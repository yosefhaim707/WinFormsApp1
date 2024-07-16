using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal static class Connection
    {
        private static readonly string _connectionString = "Data Source=malamuddevice24;Initial Catalog=Sample;User id=sa;Password=1234;";
        public static DataTable MakeQuery(string qurey)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(qurey, connection))
                {
                    try
                    {
                        connection.Open();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine("Error occured:" + e.Message);
                    }
                }
            }
            return dataTable;
        }
    }
}
