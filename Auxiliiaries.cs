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
            new XrayRoom().ShowDialog();
        }

        private void button_Xray_Diagnostic_Study_Click(object sender, EventArgs e)
        {
            new XrayDiagnosticStudy().ShowDialog();
        }

        private void button_Psychotherapeutic_Office_Click(object sender, EventArgs e)
        {
            new PsychotherapeuticOffice().ShowDialog();
        }

        private void button_Transfusion_Aid_Office_Click(object sender, EventArgs e)
        {
            new TransfusionAidOffice().ShowDialog();
        }

        private void button_Functional_Diagnostics_Department_Click(object sender, EventArgs e)
        {
            new FunctionalDiagnosticsDepartment().ShowDialog();
        }

        private void button_Endoscopic_Department_Click(object sender, EventArgs e)
        {
            new EndoscopicDepartment().ShowDialog();
        }

        private void button_Organizational_Methodical_Department_Click(object sender, EventArgs e)
        {
            new OrganizationalMedicalDepartment().ShowDialog();
        }

        private void button_Medstatistiki_Office_Click(object sender, EventArgs e)
        {
            new MedstatistikiOffice().ShowDialog();
        }
    }
}
