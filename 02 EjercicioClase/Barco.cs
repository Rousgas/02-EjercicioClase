using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EjercicioClase
{
    internal abstract class Barco
    {
        public String matricula;
        public int eslora;
        public int anio;

        public Barco(String m, int e, int a)
        {
            this.matricula = m;
            this.eslora = e;
            this.anio = a;
        }

        public abstract int moduloBarco();
    }
}
