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
    public partial class PodajIDForm : Form
    {
        public PodajIDClass NoweID { get; private set; }
        public PodajIDForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NoweID = new PodajIDClass
            {
                ID = Convert.ToInt32(textBoxPodajID.Text)
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
