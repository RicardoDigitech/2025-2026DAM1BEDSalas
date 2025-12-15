using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025_2026_DAM_1B_ED_Salas
{
    public partial class Padre : Form
    {
        public SalaModel[] salaArray;

        public Padre()
        {
            InitializeComponent();
            salaArray = new SalaModel[4];
        }

        private void configurarSalasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(salaArray);
            f1.MdiParent = this;
            f1.Show();
        }

        private void venderEntradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(salaArray);
            f2.MdiParent = this;
            f2.Show();
        }
    }
}
