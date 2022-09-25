using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _02_EjercicioClase
{
    internal class Velero:Barco
    {
        public int mastiles;

        public Velero(string m, int e, int a, int nm) : base(m, e, a)
        {
            this.mastiles = nm;
        }

        public override int moduloBarco()
        {
            int total;
            total = (((10*this.eslora) * 12) + 1);
            return total;
        }

        
    }
}
