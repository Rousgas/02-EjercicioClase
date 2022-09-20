using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EjercicioClase
{
    public class Fecha
    {
        public DateTime fecha_usu;

        public Fecha()
        {
            Boolean correcto;



            do
            {
                Console.WriteLine("Ingrese una fecha con formato 'DD/MM/YYYY'");

                try
                {
                    fecha_usu = DateTime.Parse(Console.ReadLine());
                    correcto = true;
                }
                catch
                {
                    Console.WriteLine("El formato tiene que ser 'DD/MM/YYY'");
                    correcto = false;
                }
            } while (!correcto);
            
        }

        public void ver_fecha()
        {
            Console.WriteLine("La fecha introducida es " + fecha_usu.ToShortDateString());

        }

        public void que_dia()
        {
            String dia;

            dia = fecha_usu.ToString("dddd", CultureInfo.CreateSpecificCulture("es-ES"));
            Console.WriteLine("El día de la semana correspondiente a esa fecha es " + dia);
        }

        public void incrementar_dias()
        {
            Console.WriteLine("Dime cuántos días incrementamos tu fecha");
            int rd = Int32.Parse(Console.ReadLine());

            DateTime fecha_suma = fecha_usu.AddDays(rd);
            Console.WriteLine("La fecha resultado después de " + rd + " días es " + fecha_suma.ToShortDateString() + ", " + 
                fecha_suma.ToString("dddd", CultureInfo.CreateSpecificCulture("es-ES")));
        }

        
        public void restar_fechas()
        {
            DateTime f1,f2;
            TimeSpan f_resultado;
            Boolean correcto, esPosterior;

            Console.WriteLine("Te voy a pedir dos fechas en formato 'DD/MM/YYYY' y vamos a ver cuánta diferencia de tiempo hay entre ellas");

            do
            {
                try
                {
                    Console.WriteLine("Ingrese la primera fecha con formato 'DD/MM/YYYY'");
                    f1 = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la segunda fecha con formato 'DD/MM/YYYY'");
                    f2 = DateTime.Parse(Console.ReadLine());
                    

                    f_resultado = f1.Subtract(f2);

                    Console.WriteLine("Lo que sale de la resta f1 - f2 " + f_resultado.ToString("dddd"));
                    //no es lo que pide el ejercicio
                    correcto = true;
                }
                catch
                {
                    Console.WriteLine("El formato tiene que ser 'DD/MM/YYY'");
                    correcto = false;
                }
            } while (!correcto);
        }
        
    }

    
}
