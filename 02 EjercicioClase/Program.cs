﻿using _02_EjercicioClase;

internal class Program
{
    private static void Main(string[] args)
    {
        int resp, respLib, cont, n = 0;
        String cadena = "", tit, aut, est, edi;
        Boolean esCorrecto;
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
                        
                        Console.WriteLine();
                    }

                    if(respLib == 2)
                    {
                        foreach(Libro lib in libreria)
                        {
                            Console.WriteLine(cadena = lib.ToString());
                            Console.WriteLine();
                        }

                        Console.WriteLine();
                    }

                    if(respLib == 3)
                    {
                        esCorrecto = false;
                        Console.WriteLine("Dame el título del libro que quieres modificar");
                        tit = Console.ReadLine();
                        
                        foreach(Libro lib in libreria)
                        {
                            if (lib.titulo.Equals(tit))
                            {
                                Console.WriteLine("Libro encontrado, vamos a modificar");
                                esCorrecto = true;

                                lib.modificarLibro();
                                Console.WriteLine("Libro modificado con exito");
                                Console.WriteLine();
                            }
                        }
                        if (!esCorrecto)
                        {
                            Console.WriteLine("Libro no encontrado");
                        }
                    }

                    if(respLib == 4)
                    {
                        esCorrecto = false;
                        cont = 0;
                        Console.WriteLine("Dame el título del libro que quieres borrar");
                        tit = Console.ReadLine();

                        

                        foreach(Libro lib in libreria)
                        {
                            if (lib.titulo.Equals(tit))
                            {
                                Console.WriteLine("Libro encontrado, vamos a borrar");

                                n = cont;

                                esCorrecto = true;
                            }
                            cont++;
                        }

                        if (!esCorrecto)
                        {
                            Console.WriteLine("Libro no encontrado");
                        }
                        else
                        {
                            cadena = borrarLibro(libreria, n);
                            Console.WriteLine(cadena);
                        }

                    }

                    Console.WriteLine();
                } while (respLib != 5);
            }
            Console.WriteLine();
        } while (resp != 4);
    }

    public static String borrarLibro(List<Libro> lib, int c)
    {
        lib.Remove(lib[c]);

        return "Libro borrado con exito";
    }

    
}