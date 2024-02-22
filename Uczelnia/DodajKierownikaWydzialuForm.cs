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
    public partial class DodajKierownikaWydzialuForm : Form
    {
        public KierownikWydzialu NowyKierownikWydzialu { get; set; }
        List<KierownikWydzialu> listaKierownikWydzial = KierownikWydzialuDataAccess.pobierzKierownikaWydzialu();
        KierownikWydzialuDataAccess dataAccess = new KierownikWydzialuDataAccess();
        public DodajKierownikaWydzialuForm()
        {
            InitializeComponent();
            dataGridViewKierownik.DataSource = listaKierownikWydzial;

        }


        private void buttonAddKierownik_Click(object sender, EventArgs e)
        {
            NowyKierownikWydzialu = new KierownikWydzialu
            {
                Name = textBoxLastName.Text,
                LastName = textBoxLastName.Text,
                WydzialID = Convert.ToInt32(textBoxWydzialID.Text),
            };
            dataGridViewKierownik.Refresh();
            //this.DialogResult = DialogResult.OK;
            // this.Close();

        }

        private void dataGridViewKierownik_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Pobierz zaznaczony wiersz
                DataGridViewRow row = dataGridViewKierownik.Rows[e.RowIndex];
                int ROW= e.RowIndex;
                // Przykład aktualizacji danych po wybraniu wiersza (możesz dostosować do swoich potrzeb)
                textBoxName.Text = Convert.ToString(dataGridViewKierownik[0, ROW].Value);
                textBoxLastName.Text = Convert.ToString(dataGridViewKierownik[1, ROW].Value);
                textBoxWydzialID.Text = Convert.ToString(dataGridViewKierownik[2, ROW].Value);

            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewKierownik.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewKierownik.SelectedRows[0];

                // Pobierz identyfikator zaznaczonego wiersza
                //int kierownikID = Convert.ToInt32(row.Cells["KierownikID"].Value);

                // Pobierz nowe dane z textboxów
                string noweImie = textBoxName.Text;
                string noweNazwisko = textBoxLastName.Text;
                int noweWydzialID = Convert.ToInt32(textBoxWydzialID.Text);

                // Aktualizuj dane w bazie danych
                dataAccess.AktualizujKierownikaWydzialu( noweImie, noweNazwisko, noweWydzialID);

                dataGridViewKierownik.Refresh();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewKierownik.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewKierownik.SelectedRows[0];

                String imie = textBoxName.Text;
                String nazwisko = textBoxLastName.Text;
                int wydzialId = Convert.ToInt32(textBoxWydzialID.Text);

                dataAccess.UsunKierownikaWydzialu(imie, nazwisko, wydzialId);

                dataGridViewKierownik.Refresh();
            }
        }
    }
}
