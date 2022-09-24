using _02_EjercicioClase;

internal class Program
{
    private static void Main(string[] args)
    {
        int resp, respLib;
        String cadena = "";
        List<Libro> libreria = new List<Libro>();
        Libro l = new Libro("El señor de los anillos", "Tolkien", "Fantasá/Aventura", "Minotauro");
        Libro l1 = new Libro("Reina Roja", "Gomez-Jurado", "Suspense", "B");

        libreria.Add(l);
        libreria.Add(l1);

        

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
                f.formato_largo();
            }
            if (resp == 2)
            {
                do
                {
                    Console.WriteLine("Selecciona el número de la opción que quieres abrir");
                    Console.WriteLine("1 Insertar nuevo libro");
                    Console.WriteLine("2 Ver listado de tus libros");
                    Console.WriteLine("3 Modificar libros existente");
                    Console.WriteLine("4 Eliminar libro");
                    Console.WriteLine("5 Salir");
                    respLib = Int32.Parse(Console.ReadLine());

                    if(respLib == 1)
                    {

                    }

                    if(respLib == 2)
                    {
                        foreach(Libro lib in libreria)
                        {
                            Console.WriteLine(cadena = lib.ToString());
                            Console.WriteLine();
                        }
                    }

                } while (respLib != 5);
            }
            
        } while (resp != 4);
    }
}