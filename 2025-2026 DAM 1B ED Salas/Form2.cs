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
    public partial class Form2 : Form
    {
        private SalaModel[] salaArray;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(SalaModel[] salaArray)
        {
            InitializeComponent();
            this.salaArray = salaArray;

            for (int i = 0; i < salaArray.Length; i++)
            {
                cbSala.Items.Add("Sala " + (i + 1));
            }
        }

        private void cbSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarLabels();
        }

        private void actualizarLabels()
        {
            float total = 0f;

            lblLibres.Text = "Libres: " + salaArray[cbSala.SelectedIndex].butacasLibres();
            lblOcupacion.Text = "Ocupación: " + salaArray[cbSala.SelectedIndex].porcentajeOcupacion();
            lblIngresos.Text = "Ingresos: " + salaArray[cbSala.SelectedIndex].ingresos();

            foreach (SalaModel s in salaArray)
            {
                if (s != null)
                {
                    total += s.ingresos();
                }
            }
            lblTotales.Text = "Total: " + total;
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (salaArray[cbSala.SelectedIndex].entraUno())
            {
                actualizarLabels();
            }
            else
            {
                MessageBox.Show("LA SALA ESTÁ LLENA");
            }
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            salaArray[cbSala.SelectedIndex].vaciar();
        }
    }
}
