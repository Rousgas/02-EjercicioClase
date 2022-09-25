using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EjercicioClase
{
    internal class Alquiler
    {
        public String nombre;
        public String dni;
        public DateTime fechaIni, fechaFin;
        public String posicion;
        public Barco barco;

        public Alquiler(string n, string d, DateTime fI, DateTime fF, string p, Barco b)
        {
            this.nombre = n;
            this.dni = d;
            this.fechaIni = fI;
            this.fechaFin = fF;
            this.posicion = p;
            this.barco = b;
        }
    }
}
