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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTerminado_Click(object sender, EventArgs e)
        {
            string pelicula;
            int aforo;
            int ocupadas;
            float entrada;
            SalaModel miSala;

            pelicula = txtPelicula.Text;
            aforo = (int)nudAforo.Value;
            ocupadas = (int)nudOcupadas.Value;
            if (rb5.Checked)
            {
                entrada = 5f;
            }
            else if (rb65.Checked)
            {
                entrada = 6.5f;
            }
            else if (rb8.Checked)
            {
                entrada = 8f;
            }
            else
            {
                entrada = 0f;
            }

            miSala = new SalaModel(
                pelicula, aforo, ocupadas, entrada
                );
            limpiar();
        }

        private void limpiar()
        {
            cbSala.SelectedIndex = -1;
            txtPelicula.Clear();
            nudAforo.Value = 0;
            nudOcupadas.Value = 0;
            rb5.Checked = false;
            rb65.Checked = false;
            rb8.Checked = false;
        }
    }
}
