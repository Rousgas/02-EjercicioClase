using _02_EjercicioClase;

internal class Program
{
    private static void Main(string[] args)
    {
        int resp;
        Libro l = new Libro("El señor de los anillos", "Tolkien", "Fantasá/Aventura", "Minotauro");
        Libro l1 = new Libro("Reina Roja", "Gomez-Jurado", "Suspense", "B");

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
                
            }
            
        } while (resp != 4);
    }
}