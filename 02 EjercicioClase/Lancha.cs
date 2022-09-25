using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EjercicioClase
{
    internal class Lancha : Barco
    {
        public int potencia;
        public Lancha(string m, int e, int a, int p) : base(m, e, a)
        {
            this.potencia = p;
        }

        public override int moduloBarco()
        {
            int total;
            total = (((10*this.eslora) * 12) + this.potencia);
            return total;
        }

        public override string ToString()
        {
            return ("Matricula: " + this.matricula + " Eslora: " + this.eslora + " Año: " + this.anio + " Potencia: " + this.potencia);
        }
    }
}
