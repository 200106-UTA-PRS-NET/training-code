using System;
// 1. Use the provider for the middleware
    // 1.1 Namespace for ADO.Net
using System.Data;
    // 1.2 Namespace for provider (MSSql, Oracle, MS Access Db, Excel)
using System.Data.SqlClient;

namespace ADO.Net_Demo
{
    class Program
    {
        // 2. Connection Class - this class is used to make a connection using connection string 
        static SqlConnection connection;

        static string  conString = "Server=.\\SqlExpress; Initial Catalog=EmployeeDb; Trusted_Connection=true";
        static string query = "select * from Revature.Employee";
        // 3.1  Command Class - that holds the command
        static SqlCommand command;
        // 3.2 for connected Architecture use DataReader
        static SqlDataReader reader;
        // 3.1 for Disconnected objects
        static SqlDataAdapter adapter;
        static void Main(string[] args)
        {
            // Connected();
            DisConnected();
        }

        static void Connected()
        {
            try
            {
                using (connection = new SqlConnection(connectionString: conString))
                {
                    // Make the connection Active
                    connection.Open();
                    // Fire the Query
                    command = new SqlCommand(query, connection);
                    // Exceute the Query
                    reader = command.ExecuteReader();// Used with Select Query
                                                     //command.ExecuteNonQuery() // used with data manipulation query like insert, delete, update-> this method returns the integer values (no of rows affected)
                                                     // Read the Data 
                    if (reader.HasRows)
                    {
                        while (reader.Read())// will read each record in forward only direction
                        {
                            Console.WriteLine($"{reader["fname"]} {reader["lname"]}");
                        }
                    }
                    connection.Close();// this method is not required if you are using the using block
                }
            }
            catch(Exception ex)
            {
                //log
                Console.WriteLine(ex.Message);
            }
        }
        static void DisConnected()
        {
            using (connection=new SqlConnection(conString))
            {
                //this will open the connection, fire the query and execute it. Also this will close the connection when not in use
                adapter = new SqlDataAdapter(query,connection);
                // this will be the temporary Db in the client machine
                DataSet dataSet = new DataSet();
                // filling the dbo coming from the DB Server
               int rows= adapter.Fill(dataSet);

                if (rows!=0)
                {
                    foreach (DataRow dr in dataSet.Tables[0].Rows)
                    {
                        Console.WriteLine($"{dr["fname"]} {dr["lname"]}");
                    }
                }
            }
        }


    }
}
