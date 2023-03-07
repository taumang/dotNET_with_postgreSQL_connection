using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace dotNET_with_postgreSQL_connection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's get those numbers in check");

            //PostgreSQL connection from the user:
            Console.WriteLine("Enter PostgreSQL Connection string:");
            string connectionString = Console.ReadLine();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString)) {
                    connection.Open();

                    Console.WriteLine("Enter Business Name:");
                    string businessName = Console.ReadLine();

                    Console.WriteLine("Enter Revenue:");
                    decimal revenue = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Expenses:");
                    decimal expenses = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Profit:");
                    decimal profit = revenue - expenses;

                    string sql = "INSERT INTO bookkeeping_info (business_name,, revenue, expenses, profit) VALUES (@businessName, @revenue, @expenses, @profit);";
                    using (NpgsqlCommand command = new NpgsqlCommand(sql,connection)) {
                        command.Parameters.AddWithValue("@businessName", businessName);
                        command.Parameters.AddWithValue("@revenue", revenue);
                        command.Parameters.AddWithValue("@expenses", expenses);
                        command.Parameters.AddWithValue("@profit", profit);

                        int rowsAffected = command.ExecuteNonQuery();

                        Console.WriteLine($"{rowsAffected}rows inserted into the bookkeeping_info table.");
                    }
                }

                Console.WriteLine("Bookkeeping completed!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
