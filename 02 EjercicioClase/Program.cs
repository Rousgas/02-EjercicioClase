﻿using _02_EjercicioClase;

internal class Program
{
    private static void Main(string[] args)
    {
        int resp;
      
        do
        {
            Console.WriteLine("Selecciona el número de la opción que quieres abrir");
            Console.WriteLine("1 Fechas");
            Console.WriteLine("2 Libros");
            Console.WriteLine("3 Barcos");
            Console.WriteLine("4 Salir");
            resp = Int32.Parse(Console.ReadLine());

            if (resp == 1)
            {
                Fecha f = new Fecha();
                f.ver_fecha();
                f.que_dia();
                f.incrementar_dias();
                f.restar_fechas();
                f.comparar_fechas();
            }
            
        } while (resp != 4);
    }
}