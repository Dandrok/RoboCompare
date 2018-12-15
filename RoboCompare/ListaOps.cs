using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace RoboCompare
{
    class ListaOps
    {

        public void Populate()
        {
            Random rnd = new Random();
            string conStr = ConfigurationManager.ConnectionStrings["Test"].ToString();

            StringBuilder sb = new StringBuilder();



            sb.Append("INSERT INTO NRandomOne VALUES (@param1,@param2,@param3" +
                ",@param4,@param5,@param6,@param7,@param8,@param9,@param10)");



            string param1 = rnd.Next(1, 10).ToString();
            string param2 = rnd.Next(1, 10).ToString();
            string param3 = rnd.Next(1, 10).ToString();
            string param4 = rnd.Next(1, 10).ToString();
            string param5 = rnd.Next(1, 10).ToString();
            string param6 = rnd.Next(1, 10).ToString();
            string param7 = rnd.Next(1, 10).ToString();
            string param8 = rnd.Next(1, 10).ToString();
            string param9 = rnd.Next(1, 10).ToString();
            string param10 = rnd.Next(1, 10).ToString();


            using (SqlConnection connection =
                new SqlConnection(conStr))

            {
                SqlCommand command = new SqlCommand(sb.ToString(), connection);
                command.CommandType = CommandType.Text;

                command.Parameters.AddWithValue("@param1", DbType.String).Value = param1;
                command.Parameters.AddWithValue("@param2", DbType.String).Value = param2;
                command.Parameters.AddWithValue("@param3", DbType.String).Value = param3;
                command.Parameters.AddWithValue("@param4", DbType.String).Value = param4;
                command.Parameters.AddWithValue("@param5", DbType.String).Value = param5;
                command.Parameters.AddWithValue("@param6", DbType.String).Value = param6;
                command.Parameters.AddWithValue("@param7", DbType.String).Value = param7;
                command.Parameters.AddWithValue("@param8", DbType.String).Value = param8;
                command.Parameters.AddWithValue("@param9", DbType.String).Value = param9;
                command.Parameters.AddWithValue("@param10", DbType.String).Value = param10;


                try
                {
                    connection.Open();

                    command.ExecuteReader();

                    connection.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

        }

        public List<NRandomOne> Compare()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Test"].ToString()))
            {

                StringBuilder sb = new StringBuilder();

                sb.AppendLine("SELECT * FROM NRandomOne WHERE ID=8");

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = sb.ToString();
                command.CommandType = CommandType.Text;

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                List<NRandomOne> listaCompare1 = new List<NRandomOne>();

                NRandomOne oSimulacao = null;

                try
                {
                    while (reader.Read())
                    {
                        oSimulacao = new NRandomOne();

                        oSimulacao.Random1 = reader["Random1"].ToString();
                        oSimulacao.Random2 = reader["Random2"].ToString();
                        oSimulacao.Random3 = reader["Random3"].ToString();
                        oSimulacao.Random4 = reader["Random4"].ToString();
                        oSimulacao.Random5 = reader["Random5"].ToString();
                        oSimulacao.Random6 = reader["Random6"].ToString();
                        oSimulacao.Random7 = reader["Random7"].ToString();
                        oSimulacao.Random8 = reader["Random8"].ToString();
                        oSimulacao.Random9 = reader["Random9"].ToString();
                        oSimulacao.Random10 = reader["Random10"].ToString();
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                finally
                {
                    connection.Close();
                }


                listaCompare1.Add(oSimulacao);

                return listaCompare1;

            }

        }
    }
}
