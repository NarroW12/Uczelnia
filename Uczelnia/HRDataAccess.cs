using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uczelnia
{
    public class HRDataAccess
    {
        private const string connectionString = "Server=JAKUB;Database=Uczelnia;Trusted_Connection=True;TrustServerCertificate=Yes";

        public static List<HR> pobierzHR()
        {
            List<HR> listaHR = new List<HR>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("PobierzHR", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            HR HRdane = new HR
                            {
                                HRID = Convert.ToInt32(reader["HRID"]),
                                Name = reader["Imie"].ToString(),
                                LastName = reader["Nazwisko"].ToString(),
                                Stanowisko = reader["Stanowisko"].ToString(),
                            };

                            listaHR.Add(HRdane);
                        }
                    }
                }
            }

            return listaHR;
        }
    }
}
