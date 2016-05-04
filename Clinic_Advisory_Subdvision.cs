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
    public partial class Clinic_Advisory_Subdvision : Form
    {
        public Clinic_Advisory_Subdvision()
        {
            InitializeComponent();
        }

        private void button_Surdologichesky_Office_Click(object sender, EventArgs e)
        {
            new Surdologichesky_Office().ShowDialog();
        }

        private void button_Clinic_Advisory_Click(object sender, EventArgs e)
        {
            new Clinic_Advisory().ShowDialog();
        }

        private void button_Dental_Office_Click(object sender, EventArgs e)
        {
            new Dental_Office().ShowDialog();
        }

        private void button_Dental_Surgery_Office_Click(object sender, EventArgs e)
        {
            new Dental_Surgery_Office().ShowDialog();
        }

        private void button_Diagnostic_Study_Click(object sender, EventArgs e)
        {
            new Diagnostic_Study().ShowDialog();
        }
    }
}
