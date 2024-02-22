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
    public partial class DodajNauczycielaForm : Form
    {
        public Teachers NowyNauczyciel { get; set; }
        public DodajNauczycielaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NowyNauczyciel = new Teachers
            {
                Name = textBoxName.Text,
                LastName = textBoxLastName.Text,
                Stopien = comboBoxStopnie.Text,
                Specjalizacja = textBoxSpecjalizacja.Text,
            };
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void buttonDeleteById_Click(object sender, EventArgs e)
        {
            Teachers teachers = new Teachers();
            if (int.TryParse(textBoxDeleteById.Text, out int idTeacher))
            {
                WykladowcyDataAccess wykladowcyDataAccess = new WykladowcyDataAccess();

                if (wykladowcyDataAccess.UsunWykladowce(idTeacher))
                {
                    MessageBox.Show("Wykladowca zostal pomyslnie usuniety");
                }
                else
                {
                    MessageBox.Show("Wprowadz poprawne Id wykladowcy");
                }
            }
        }
    }
}
