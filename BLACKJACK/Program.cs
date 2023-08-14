using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;
namespace BLACKJACK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Casino - What is Your Name? ");
            string playerName = Console.ReadLine();
            if (playerName.ToLower()=="admin")
            {
                List<EXCEPTIONENTITY> Exceptions = ReadExceptions();
                foreach(var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }




            bool vaiidanswer = false;
            int bank = 0;
            while (!vaiidanswer)
            {
                Console.WriteLine("How Much Mondey Do You Have?");
                vaiidanswer = int.TryParse(Console.ReadLine(), out bank);
                if (!vaiidanswer) Console.WriteLine("Please enter digits only no decimals.");
              


            }
           
            

            Console.WriteLine("Hello,{0},Would you like to join a game of 21 right now? ", playerName);
            string answer = Console.ReadLine().ToLower();
            
            
            if (answer == "yes" || answer == "yeah" || answer == "y" )
            {
                PLAYER player = new PLAYER(playerName, bank);
                GAME game = new TWENTYONEGAME();
                game += player;
                player.isActivlyPlaying = true;
                while (player.isActivlyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                        
                    }
                    catch(FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("An error has occured. Contact the Sys Admin");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;


                    }



                }
                game -= player;
                Console.WriteLine("thank you for playing");
            }
            Console.WriteLine("Feel free to look aroung the casino. bye for now. ");
            Console.Read();



        }
        private static void UpdateDbWithException(Exception ex)
        {
            string connectionString = @"Data Source = (localdb)\ProjectsV13; Initial Catalog = TwnetyOneGame; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

            string querystring = @"INSERT INTO Exceptions (ExceptionType,ExceptionMessage,TimeStamp) VALUES
            (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            using (SqlConnection connection = new SqlConnection(connectionString)) 
            {
                SqlCommand command = new SqlCommand(querystring, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);// 7:09
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString(); command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();


            }


        }
        private static List<EXCEPTIONENTITY> ReadExceptions()
        {
            string connectionString = @"Data Source = (localdb)\ProjectsV13; Initial Catalog = TwnetyOneGame; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

            string queryString = @"Select Id,ExceptionType,ExceptionMessage,TimeStamp From Exceptions";

            List<EXCEPTIONENTITY> Exceptions = new List<EXCEPTIONENTITY>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    EXCEPTIONENTITY exception = new EXCEPTIONENTITY();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }

                connection.Close();


            }
            return Exceptions;
        }
        
    }
}
