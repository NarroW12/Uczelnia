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
    public partial class DodajWydzialForm : Form
    {
        public Wydzial NowyWydzial {  get; set; }
        public DodajWydzialForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NowyWydzial = new Wydzial
            {
                Nazwa = textBoxNazwaWydzialu.Text,
                Zaklad = textBoxZaklad.Text,
            };
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
