using _02_EjercicioClase;

internal class Program
{
    private static void Main(string[] args)
    {
        int resp, respLib;
        String cadena = "", tit, aut, est, edi;
        List<Libro> libreria = new List<Libro>();
        Libro l = new Libro("El señor de los anillos", "Tolkien", "Fantasá/Aventura", "Minotauro");
        Libro l1 = new Libro("Reina Roja", "Gomez-Jurado", "Suspense", "B");
        Libro libroUsu;

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
                Console.WriteLine();
                f.que_dia();
                Console.WriteLine();
                f.incrementar_dias();
                Console.WriteLine();
                f.restar_fechas();
                Console.WriteLine();
                f.comparar_fechas();
                Console.WriteLine();
                f.formato_largo();
                Console.WriteLine();
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
                        Console.WriteLine("Para insertar un libro necesito que me digas sus datos");
                        Console.WriteLine("Título:");
                        tit = Console.ReadLine();
                        Console.WriteLine("Autor::");
                        aut = Console.ReadLine();
                        Console.WriteLine("Estilo:");
                        est = Console.ReadLine();
                        Console.WriteLine("Editorial:");
                        edi = Console.ReadLine();

                        libroUsu = new Libro(tit, aut, est, edi);
                        libreria.Add(libroUsu);
                        
                    }

                    if(respLib == 2)
                    {
                        foreach(Libro lib in libreria)
                        {
                            Console.WriteLine(cadena = lib.ToString());
                            Console.WriteLine();
                        }
                    }
                    Console.WriteLine();
                } while (respLib != 5);
            }
            Console.WriteLine();
        } while (resp != 4);
    }
}