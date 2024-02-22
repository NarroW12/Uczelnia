using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uczelnia
{
    public class WydzialyDataAccess
    {
        private const string connectionString = "Server=JAKUB;Database=Uczelnia;Trusted_Connection=True;TrustServerCertificate=Yes";

        public static List<Wydzial> pobierzWydzial()
        {
            List<Wydzial> listaWydzial = new List<Wydzial>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("PobierzWydzial", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Wydzial WydzialDane = new Wydzial
                            {
                                WydzialID = Convert.ToInt32(reader["WydzialID"]),
                                Nazwa = reader["Nazwa"].ToString(),
                                Zaklad = reader["Zaklad"].ToString(),
                            };

                            listaWydzial.Add(WydzialDane);
                        }
                    }
                }
            }

            return listaWydzial;
        }
    }
}
