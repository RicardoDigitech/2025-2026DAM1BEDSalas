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
        private SalaModel[] salaArray;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(SalaModel[] salaArray)
        {
            InitializeComponent();
            this.salaArray = salaArray;

            for (int i = 0; i < salaArray.Length; i++)
            {
                cbSala.Items.Add("Sala " + (i + 1));
            }
        }

        private void btnTerminado_Click(object sender, EventArgs e)
        {
            string pelicula;
            int aforo;
            int ocupadas;
            float entrada;
            SalaModel miSala;
            int posicion;

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

            posicion = cbSala.SelectedIndex;
            if (posicion != -1)
            {
                salaArray[posicion] = miSala;
                limpiar();
            }
            else
            {
                MessageBox.Show("ERES TONTO");
            }
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
