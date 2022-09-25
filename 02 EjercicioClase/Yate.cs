using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EjercicioClase
{
    internal class Yate : Barco
    {
        public int potencia;
        public int camarotes;
        public Yate(string m, int e, int a, int p, int c) : base(m, e, a)
        {
            this.potencia = p;
            this.camarotes = c;
        }

        public override int moduloBarco()
        {
            int total;
            total = (((10*this.eslora) * 12) + (this.potencia + this.camarotes));
            return total;
        }

        public override string ToString()
        {
            return ("Matricula: " + this.matricula + " Eslora: " + this.eslora + " Año: " + this.anio + " Potencia: " + this.potencia + " Camarotes:" + this.camarotes);
        }
    }
}
