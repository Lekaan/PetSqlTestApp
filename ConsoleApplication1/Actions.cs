using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Actions
    {
        public void InsertPet(string connectionString)
        {
            bool running = true;

            while (running)
            {
                string petName = "";
                string petType = "";
                string petBreed = "";
                string petDOB = "";
                string petWeight = "";
                string petOwnerID = "";

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\n");
                Console.Write("Enter Pets name: ");
                petName = Console.ReadLine();

                Console.WriteLine("");
                Console.Write("Enter " + petName + "'s Type: ");
                petType = Console.ReadLine();

                Console.WriteLine("");
                Console.Write("Enter " + petName + "'s Breed: ");
                petBreed = Console.ReadLine();

                Console.WriteLine("");
                Console.Write("Enter " + petName + "'s Date of Birth: ");
                petDOB = Console.ReadLine();

                Console.WriteLine("");
                Console.Write("Enter " + petName + "'s Weight: ");
                petWeight = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("Confirm informations:");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("===================================================");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Pet's Name: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(petName);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Pet's Type: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(petType);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Pet's Breed: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(petBreed);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Pet's Date of Birth: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(petDOB);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Pet's Weight: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(petWeight);

                Console.WriteLine("===================================================");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Can you confirm? (y/n): ");

                switch (Console.ReadLine())
                {
                    case "y":
                        running = false;
                        break;
                    case "n":
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

        public void ErrorHandler()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: Invalid input. Please type in a number!");
            Console.ReadLine();
        }
    }
}
