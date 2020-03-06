using System;

namespace Examen
{
    class Program
    {

        static void Main(string[] args)
        {
            Objetos v = new Objetos("V", "vacio", 0);
            Objetos pl = new Objetos("PL", "Platano", 40); //ocupa 2 espacios
            Objetos p = new Objetos("P", "Pan", 70);
            Objetos m = new Objetos("M", "Manzana", 250);
            Objetos pb = new Objetos("PB", "Papel de Baño", 320);
            Objetos b = new Objetos("B", "Brujula", 350);
            Objetos c = new Objetos("C", "Cuerda", 1000); //ocupa 2 espacios
            Objetos a = new Objetos("A", "Botella de Agua", 1100); //ocupa 2 espacios

            Mochila mochila = new Mochila(new Objetos[3, 4]{{ v,   b,   m,   v },
                                                           { p,    a,   c,   pl },
                                                           { pb,   a,   c,   pl }});


            mochila.VerificarPesos();

        }

    }
}
