using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uczelnia
{
    public class KierownikWydzialuDataAccess
    {
        private const string connectionString = "Server=JAKUB;Database=Uczelnia;Trusted_Connection=True;TrustServerCertificate=Yes";

        public static List<KierownikWydzialu> pobierzKierownikaWydzialu()
        {
            List<KierownikWydzialu> listaKierownikWydzial = new List<KierownikWydzialu>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("PobierzKierownikWydzial", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            KierownikWydzialu KierownikWydzialDane = new KierownikWydzialu
                            {
                                //KierownikID = Convert.ToInt32(reader["KierownikID"]),
                                Name = reader["Imie"].ToString(),
                                LastName = reader["Nazwisko"].ToString(),
                                WydzialID= Convert.ToInt32(reader["WydzialID"])
                            };

                            listaKierownikWydzial.Add(KierownikWydzialDane);
                        }
                    }
                }
            }

            return listaKierownikWydzial;
        }
        public void AktualizujKierownikaWydzialu( string noweImie, string noweNazwisko, int noweWydzialID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("AktualizujKierownikaWydzialu", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NoweImie", noweImie);
                    cmd.Parameters.AddWithValue("@NoweNazwisko", noweNazwisko);
                    cmd.Parameters.AddWithValue("@NoweWydzialID", noweWydzialID);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void UsunKierownikaWydzialu(String Imie, String Nazwisko, int WydzialID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("UsunKierownikaWydzialu", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Imie", Imie);
                    cmd.Parameters.AddWithValue("@Nazwisko", Nazwisko);
                    cmd.Parameters.AddWithValue("@WydzialID", WydzialID);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
