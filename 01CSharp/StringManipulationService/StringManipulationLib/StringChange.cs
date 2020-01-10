using System;

namespace StringManipulationLib
{
    public class StringChange
    {
        public string ChangeToUpper(string str)
        {
            return str.ToUpper();
        }
        public string Reverse(string str)
        {
            char[] arr=str.ToCharArray();
            Array.Reverse(arr);
            string r = new string(arr);
            return r;
        }
    }
}
