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

        public int calcularAlquiler(int mb)
        {
            int al=0, dias;
            double dd;
            String cad;

            var difDias = this.fechaFin.Subtract(this.fechaIni);

            dd = difDias.TotalDays;
            dias = Convert.ToInt32(dd);
            
            al = dias * mb;
            
            return al;
        }

        public override string ToString()
        {
            return ("Nombre: " + this.nombre + " DNI: " + this.dni + " Fecha entrada: " + this.fechaIni.ToString("d") + " Fecha salida: " + this.fechaFin.ToString("d") + " Posición: " + this.posicion);
        }
    }
}
