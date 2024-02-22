using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
namespace Uczelnia
{
    public partial class Form1 : Form
    {
        private const string connectionString = "Server=JAKUB;Database=Uczelnia;Trusted_Connection=True;TrustServerCertificate=Yes";

        public Form1()
        {
            InitializeComponent();
            /*
            if (IsServerConnected() == true)
            {
                MessageBox.Show("Polaczono z baza danych");
            }
            else
            {
                MessageBox.Show("Jendak nie");

            }*/
        }
        public bool IsServerConnected()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }


        private void buttonADDStudents_Click(object sender, EventArgs e)
        {
            DodajUczniaForm dodajUczniaForm = new DodajUczniaForm();
            if (dodajUczniaForm.ShowDialog() == DialogResult.OK)
            {
                DodajUczniaDoBazy(dodajUczniaForm.NowyUczen);
            }
        }


        private void DodajUczniaDoBazy(Uczniowie nowyUczen)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            using (SqlCommand cmd = new SqlCommand("DodajUcznia", connection))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Imie", nowyUczen.Name);
                cmd.Parameters.AddWithValue("@Nazwisko", nowyUczen.LastName);
                cmd.Parameters.AddWithValue("@NrIndeksu", nowyUczen.IndexNumber);
                cmd.Parameters.AddWithValue("@Semestr", nowyUczen.Semester);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Uczeñ dodany pomyœlnie!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("B³¹d podczas dodawania ucznia: " + ex.Message);
                }
            }
            connection.Close();

        }

        private void buttonAddTeacher_Click(object sender, EventArgs e)
        {
            DodajNauczycielaForm dodajNauczyciela = new DodajNauczycielaForm();
            if (dodajNauczyciela.ShowDialog() == DialogResult.OK)
            {
                DodajWykladowceDoBazy(dodajNauczyciela.NowyNauczyciel);
            }
        }
        private void DodajWykladowceDoBazy(Teachers newTeachers)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            using (SqlCommand cmd = new SqlCommand("DodajWykladowce", connection))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Imie", newTeachers.Name);
                cmd.Parameters.AddWithValue("@Nazwisko", newTeachers.LastName);
                cmd.Parameters.AddWithValue("@Stopien", newTeachers.Stopien);
                cmd.Parameters.AddWithValue("@Specjalizacja", newTeachers.Specjalizacja);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Wykladowca dodany pomyœlnie!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("B³¹d podczas dodawania Wykladowcy: " + ex.Message);
                }
            }
            connection.Close();

        }

        private void buttonAddHR_Click(object sender, EventArgs e)
        {
            DodajHRForm dodajHRForm = new DodajHRForm();
            if (dodajHRForm.ShowDialog() == DialogResult.OK)
            {
                DodajHRDoBazy(dodajHRForm.NowyHR);
            }
        }
        private void DodajHRDoBazy(HR newHR)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            using (SqlCommand cmd = new SqlCommand("DodajHR", connection))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Imie", newHR.Name);
                cmd.Parameters.AddWithValue("@Nazwisko", newHR.LastName);
                cmd.Parameters.AddWithValue("@Stanowisko", newHR.Stanowisko);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("HR dodany pomyœlnie!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("B³¹d podczas dodawania HR: " + ex.Message);
                }
            }
            connection.Close();
        }

        private void buttonAddWydzial_Click(object sender, EventArgs e)
        {
            DodajWydzialForm dodajWydzialForm = new DodajWydzialForm();
            if (dodajWydzialForm.ShowDialog() == DialogResult.OK)
            {
                DodajHRDoBazy(dodajWydzialForm.NowyWydzial);
            }
        }
        private void DodajHRDoBazy(Wydzial nowyWydzial)
        {

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            using (SqlCommand cmd = new SqlCommand("DodajWydzial", connection))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nazwa", nowyWydzial.Nazwa);
                cmd.Parameters.AddWithValue("@Zaklad", nowyWydzial.Zaklad);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dodano nowy Wydzial!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("B³¹d podczas dodawania HR: " + ex.Message);
                }
            }
            connection.Close();
        }

        private void buttonAddKierownikWydzialu_Click(object sender, EventArgs e)
        {
            DodajKierownikaWydzialuForm dodajKierownikaWydzialu = new DodajKierownikaWydzialuForm();
            if (dodajKierownikaWydzialu.ShowDialog() == DialogResult.OK)
            {
                DodajKierownikaWydzialuDoBazy(dodajKierownikaWydzialu.NowyKierownikWydzialu);
            }
        }
        private void DodajKierownikaWydzialuDoBazy(KierownikWydzialu nowyKierownikWydzialu)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            using (SqlCommand cmd = new SqlCommand("DodajKierownikaWydzialu", connection))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Imie", nowyKierownikWydzialu.Name);
                cmd.Parameters.AddWithValue("@Nazwisko", nowyKierownikWydzialu.LastName);
                cmd.Parameters.AddWithValue("@WydzialID", nowyKierownikWydzialu.WydzialID);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dodano nowego kierownika Wydzialu!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("B³¹d podczas dodawania kierownika Wydzialu: " + ex.Message);
                }
            }
            connection.Close();
        }

        private void buttonShowStudents_Click(object sender, EventArgs e)
        {

        }

        private void buttonShowData_Click(object sender, EventArgs e)
        {
            ListaDanychForm listaDanychForm = new ListaDanychForm();

            listaDanychForm.ShowDialog();
        }
    }
}