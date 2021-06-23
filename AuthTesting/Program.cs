using System;

namespace AuthTesting
{
   public class Program
    {
        static void Main(string[] args)
        {
            
        }

       public static string Something()
        {
            return "Algo";
        }

        public static bool Login (string user, string pass) =>
            user == "karla" && pass == "12345" ? true : false;
    }
}
