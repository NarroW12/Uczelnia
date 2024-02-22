using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uczelnia
{
    public partial class DodajUczniaForm : Form
    {
        public Uczniowie NowyUczen { get; private set; }

        public DodajUczniaForm()
        {
            InitializeComponent();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            NowyUczen = new Uczniowie
            {
                Name = NametextBox.Text,
                LastName = LastNametextBox.Text,
                IndexNumber = IndexNumbertextBox.Text,
                Semester = Convert.ToInt32(SemestertextBox.Text)
            };

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAktualizujDane_Click(object sender, EventArgs e)
        {
        }

        private void buttonAddId_Click(object sender, EventArgs e)
        {
            UczniowieDataAccess uczniowieDataAccess = new UczniowieDataAccess();


            if (int.TryParse(IdUczniaTextBox.Text, out int idUcznia))
            {
                // Utwórz nowy obiekt formularza DodajUczniaForm
                DodajUczniaForm dodajUczniaForm = new DodajUczniaForm();

                // Pobierz dane ucznia na podstawie ID i ustaw je w TextBoxach formularza DodajUczniaForm
                Uczniowie uczniowie = uczniowieDataAccess.PobierzDaneUcznia(idUcznia);

                dodajUczniaForm.NametextBox.Text = uczniowie.Name;
                dodajUczniaForm.LastNametextBox.Text = uczniowie.LastName;
                dodajUczniaForm.IndexNumbertextBox.Text = uczniowie.IndexNumber;
                dodajUczniaForm.SemestertextBox.Text = uczniowie.Semester.ToString();

                // Otwórz formularz DodajUczniaForm w trybie edycji
                if (dodajUczniaForm.ShowDialog() == DialogResult.OK)
                {

                    // Pobierz dane ucznia z formularza
                    Uczniowie uczniowieDoAktualizacji = new Uczniowie
                    {
                        IdUczniowie = idUcznia,
                        Name = dodajUczniaForm.NametextBox.Text,
                        LastName = dodajUczniaForm.LastNametextBox.Text,
                        IndexNumber = dodajUczniaForm.IndexNumbertextBox.Text,
                        Semester = Convert.ToInt32(dodajUczniaForm.SemestertextBox.Text)
                    };

                    // Wywołaj metodę aktualizacji w bazie danych
                    if (uczniowieDataAccess.AktualizujDaneUcznia(uczniowieDoAktualizacji))
                    {
                        MessageBox.Show("Dane ucznia zostały zaktualizowane pomyślnie.");
                        // Tutaj możesz dodać dodatkowe operacje po aktualizacji, np. odświeżenie widoku, aktualizacja listy itp.
                    }
                    else
                    {
                        MessageBox.Show("Błąd podczas aktualizacji danych ucznia.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Wprowadź poprawne ID ucznia.");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
