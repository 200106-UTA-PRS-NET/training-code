using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace JsonSerialization
{
   public class JsonHelper<T>
    {
        public static string Serialize<T>(T t) {
            // This Object is used to serialize and deserialize the data
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
            // This stream is required to serialize the string to Json 
            MemoryStream stream = new MemoryStream();
            string jsonString;
            // data is serialized here
            try { 
            serializer.WriteObject(stream, t);

             jsonString = Encoding.UTF8.GetString(stream.ToArray());
            }
            catch
            {
                throw;
            }
            finally
            {
                stream.Close();
            }
            return jsonString;
        }

        public static T Deserialize<T>(string jsonString)
        {
            DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(T));

            MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));

            T data=(T)deserializer.ReadObject(stream);

            return data;
        }
    }
}
