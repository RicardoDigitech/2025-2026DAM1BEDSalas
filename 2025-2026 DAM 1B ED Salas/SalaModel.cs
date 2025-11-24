using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_2026_DAM_1B_ED_Salas
{
    public class SalaModel
    {
        // ATRIBUTOS
        private string pelicula;
        private int aforo;
        private int ocupadas;
        private float entrada;

        // CONSTRUCTORES
        public SalaModel()
        {
        }

        public SalaModel(string pelicula, int aforo)
        {
            this.pelicula = pelicula;
            this.aforo = aforo;
        }

        public SalaModel(string pelicula, int aforo, int ocupadas, float entrada)
        {
            this.pelicula = pelicula;
            this.aforo = aforo;
            this.ocupadas = ocupadas;
            this.entrada = entrada;
        }

        // GETTERS Y SETTERS
        public string Pelicula { get => pelicula; set => pelicula = value; }
        public int Aforo { get => aforo; set => aforo = value; }
        public int Ocupadas { get => ocupadas; set => ocupadas = value; }
        public float Entrada { get => entrada; set => entrada = value; }

        // MÉTODOS PROPIOS DE LA CLASE
        public int butacasLibres()
        {
            return aforo - ocupadas;
        }

        public float porcentajeOcupacion()
        {
            return ocupadas * 100 / aforo;
        }

        public float ingresos()
        {
            return ocupadas * entrada;
        }

        public void vaciar()
        {
            ocupadas = 0;
        }

        public bool entraUno()
        {
            if (ocupadas < aforo)
            {
                ocupadas++;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
