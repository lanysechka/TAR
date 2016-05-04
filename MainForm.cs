using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAR
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_MODB_Click(object sender, EventArgs e)
        {
            new MODB_Start().Show();
        }

        private void button_Pharmacy_Click(object sender, EventArgs e)
        {
            new Pharmacy_Start().Show();
        }

        private void button_Cabinet_Click(object sender, EventArgs e)
        {
            new Cabinet_Start().Show();
        }

        private void button_Extra_Click(object sender, EventArgs e)
        {
            new Extra_Start().Show();
        }
    }
}
