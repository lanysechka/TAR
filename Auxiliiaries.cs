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
    public partial class Auxiliiaries : Form
    {
        public Auxiliiaries()
        {
            InitializeComponent();
        }

        private void button_Xray_Room_Click(object sender, EventArgs e)
        {
            new Xray_Room().ShowDialog();
        }

        private void button_Xray_Diagnostic_Study_Click(object sender, EventArgs e)
        {
            new Xray_Diagnostic_Study().ShowDialog();
        }

        private void button_Psychotherapeutic_Office_Click(object sender, EventArgs e)
        {
            new Psychotherapeutic_Office().ShowDialog();
        }

        private void button_Transfusion_Aid_Office_Click(object sender, EventArgs e)
        {
            new Transfusion_Aid_Office().ShowDialog();
        }

        private void button_Functional_Diagnostics_Department_Click(object sender, EventArgs e)
        {
            new Functional_Diagnostics_Department().ShowDialog();
        }

        private void button_Endoscopic_Department_Click(object sender, EventArgs e)
        {
            new Endoscopic_Department().ShowDialog();
        }

        private void button_Organizational_Methodical_Department_Click(object sender, EventArgs e)
        {
            new Organizational_Medical_Department().ShowDialog();
        }

        private void button_Medstatistiki_Office_Click(object sender, EventArgs e)
        {
            new Medstatistiki_Office().ShowDialog();
        }
    }
}
