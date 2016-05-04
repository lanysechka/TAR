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
    public partial class Extra : Form
    {
        public Extra()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void врачебныйПерсоналToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Subdivisions().ShowDialog();
        }

        private void среднийПерсоналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Subdivisions().ShowDialog();
        }

        private void младшийПерсоналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Subdivisions().ShowDialog();
        }

        private void педагогическийПерсоналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Subdivisions().ShowDialog();
        }

        private void прочийПерсоналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Subdivisions().ShowDialog();
        }

        private void картотекаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
