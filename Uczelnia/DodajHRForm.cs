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
    public partial class DodajHRForm : Form
    {
        public HR NowyHR { get; set; }
        public DodajHRForm()
        {
            InitializeComponent();
        }

        private void buttonAddHR_Click(object sender, EventArgs e)
        {
            NowyHR = new HR
            {
                Name = textBoxImie.Text,
                LastName = textBoxNazwisko.Text,
                Stanowisko = textBoxStanowisko.Text,
            };
            this.DialogResult = DialogResult.OK;
            this.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
