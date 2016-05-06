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
    public partial class Hospital : Form
    {
        public Hospital()
        {
            InitializeComponent();
        }

        private void button_Hematology_Unit_Click(object sender, EventArgs e)
        {
            new HematologyUnit().ShowDialog();
        }

        private void button_Otorhinolaryngological_Department_Click(object sender, EventArgs e)
        {
            new OtorhinolaryngologicalDepartment().ShowDialog();
        }

        private void button_Pediatric_Ward_With_The_Disease_Click(object sender, EventArgs e)
        {
            new Pediatric_Ward_With_The_Disease().ShowDialog();
        }

        private void button_Pediatric_Ward_Click(object sender, EventArgs e)
        {
            new Pediatric_Ward().ShowDialog();
        }

        private void button_Intensive_Care_Unit_Of_A_Hospital_Click(object sender, EventArgs e)
        {
            new IntensiveCareUnitOfAHospital().ShowDialog();
        }

        private void button_Pediatric_Ward_For_Newborns_Click(object sender, EventArgs e)
        {
            new Pediatric_Ward_For_Newborns().ShowDialog();
        }

        private void button_Department_Of_Medical_Rehabilitation_Click(object sender, EventArgs e)
        {
            new DepartmentOfMedicalRehabilitation().ShowDialog();
        }

        private void button_Pediatric_Endocrinology_Department_Click(object sender, EventArgs e)
        {
            new PediatricEndocrinologyDepartment().ShowDialog();
        }

        private void button_Operating_Unit_Click(object sender, EventArgs e)
        {
            new OperatingUnit().ShowDialog();
        }
    }
}
