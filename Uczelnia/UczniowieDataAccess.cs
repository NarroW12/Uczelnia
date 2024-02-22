using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Uczelnia
{
    public class UczniowieDataAccess
    {
        private const string connectionString = "Server=JAKUB;Database=Uczelnia;Trusted_Connection=True;TrustServerCertificate=Yes";

        public List<Uczniowie> PobierzUczniow()
        {
            List<Uczniowie> listaUczniow = new List<Uczniowie>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("PobierzUczniow", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Uczniowie uczniowie = new Uczniowie
                            {
                                IdUczniowie = Convert.ToInt32(reader["UczenID"]),
                                Name = reader["Imie"].ToString(),
                                LastName = reader["Nazwisko"].ToString(),
                                IndexNumber = reader["NrIndeksu"].ToString(),
                                Semester = Convert.ToInt32(reader["Semestr"])
                            };

                            listaUczniow.Add(uczniowie);
                        }
                    }
                }
            }

            return listaUczniow;
        }
        public Uczniowie PobierzDaneUcznia(int idUcznia)
        {
            Uczniowie uczniowie = new Uczniowie();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Uczniowie WHERE UczenID = @IdUczniowie", connection))
                {
                    cmd.Parameters.AddWithValue("@IdUczniowie", idUcznia);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            uczniowie.IdUczniowie = Convert.ToInt32(reader["UczenID"]);
                            uczniowie.Name = reader["Imie"].ToString();
                            uczniowie.LastName = reader["Nazwisko"].ToString();
                            uczniowie.IndexNumber = reader["NrIndeksu"].ToString();
                            uczniowie.Semester = Convert.ToInt32(reader["Semestr"]);
                        }
                        else
                        {
                            MessageBox.Show("Uczeń o podanym ID nie istnieje.");
                        }
                    }
                }
            }

            return uczniowie;
        }
        public bool AktualizujDaneUcznia(Uczniowie uczniowie)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("AktualizujUcznia", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdUczniowie", uczniowie.IdUczniowie);
                    cmd.Parameters.AddWithValue("@Imie", uczniowie.Name);
                    cmd.Parameters.AddWithValue("@Nazwisko", uczniowie.LastName);
                    cmd.Parameters.AddWithValue("@NrIndeksu", uczniowie.IndexNumber);
                    cmd.Parameters.AddWithValue("@Semestr", uczniowie.Semester);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true; 
                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show("Błąd podczas aktualizacji: " + ex.Message);
                        return false; // Aktualizacja nie powiodła się
                    }
                }
            }
        }

    }
}
