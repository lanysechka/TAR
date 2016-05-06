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
    public partial class MODBStart : Form
    {
        public MODBStart()
        {
            InitializeComponent();
        }

        private void MODB_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ////ToolTip1.SetToolTip(this.картотекаToolStripMenuItem, "Hello");
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

        private void справочникОтделенийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Subdivisions().ShowDialog();
        }
    }
}
