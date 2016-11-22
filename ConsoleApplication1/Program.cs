using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private static string connectionString =
            "Server=ealdb1.eal.local; Database=EJL05_DB; User=ejl05_usr; Password=Baz1nga5;";

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }

        private void Run()
        {
            bool running = true;
            string input = "";
            
            Menu m = new Menu();
            Actions a = new Actions();

            while (running)
            {
                Console.Clear();
                m.PrintMenu();
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        a.InsertPet(connectionString);
                        break;
                    default:
                        a.ErrorHandler();
                        break;
                }
            }


            //using (SqlConnection con = new SqlConnection(connectionString))
            //{
            //    try
            //    {
            //        con.Open();
            //    }
            //    catch (SqlException ex)
            //    {
            //        Console.WriteLine("SQL Exception Code: (" + ex.ErrorCode + ")");
            //        Console.WriteLine("===========================================");
            //        Console.WriteLine(ex.Message);
            //        Console.WriteLine(ex.InnerException);
            //    }

            //}
        }
        
    }
}
