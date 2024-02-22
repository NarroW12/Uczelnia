using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uczelnia
{
    public class WykladowcyDataAccess
    {
        private const string connectionString = "Server=JAKUB;Database=Uczelnia;Trusted_Connection=True;TrustServerCertificate=Yes";
        
        public static List<Teachers> pobierzWykladowcow()
        {
            List<Teachers> listaNauczycieli = new List<Teachers>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("PobierzWykladowcow", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Teachers teachers = new Teachers
                            {
                                WykladowcaId = Convert.ToInt32(reader["WykladowcaID"]),
                                Name = reader["Imie"].ToString(),
                                LastName = reader["Nazwisko"].ToString(),
                                Stopien = reader["Stopien"].ToString(),
                                Specjalizacja =reader["Specjalizacja"].ToString()
                            };

                            listaNauczycieli.Add(teachers);
                        }
                    }
                }
            }

            return listaNauczycieli;
        }
        public bool UsunWykladowce(int wykladowcaID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("UsunWykladowce", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@WykladowcaID", wykladowcaID);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usunieto wykladowce pomyslnie");
                        return true; // Usunięcie powiodło się
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Błąd podczas usuwania: " + ex.Message);
                        return false; // Usunięcie nie powiodło się
                    }
                }
            }
        }

    }
}
