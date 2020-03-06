using System;

namespace Examen
{
    class Objetos
    {

        public string inicial { get; set; } 

        public string nombre { get; set; }

        public int peso { get; set; }

        public Objetos(string inicial, string nombre, int peso)
        {

            this.inicial = inicial;
            this.nombre = nombre;
            this.peso = peso;


        }

        public string GetNombre()
        {
            return nombre;
        }

        public int GetPeso()
        {
            return peso;
        }

        public string GetInicial(){

            return inicial;
        }


    }

}