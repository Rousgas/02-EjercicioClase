﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EjercicioClase
{
    internal class Libro
    {
        public String titulo;
        public String autor;
        public String estilo;
        public String editorial;
        

        public Libro(String t, String a, String e, String ed)
        {
            this.titulo = t;
            this.autor = a;
            this.estilo = e;
            this.editorial = ed;
        }

        public override string ToString()
        {
            return ("Título: " + this.titulo + " Autor: " + this.autor + " Estilo: " + this.estilo + " Editorial: " + this.editorial);
        }
    }
}
