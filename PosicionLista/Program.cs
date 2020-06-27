using System;
using System.Linq;

namespace PosicionLista
{
    class Program
    {
        static void Main(string[] args)
        {
            var oracion = "Yo estoy probando un programa a las 23 hs";
            var listaDePalabras = oracion.Split(" ").ToList();

            var palabraAbuscar = "programa";

            var clase1 = new Clase1();
            int posicion = clase1.EncontrarPosicionEnLista(listaDePalabras, palabraAbuscar);

            Console.WriteLine($"Posicion de la palabra \"{palabraAbuscar}\" = {posicion} \n");

            int posicion2 = clase1.EncontrarPosicionEnListaSobreescrito(listaDePalabras, palabraAbuscar);

            Console.WriteLine($"Resta de la posicion {posicion} y el largo de la lista {listaDePalabras.Count} = {posicion2} \n");

            Console.WriteLine("A continuación vamos a utilizar un extension method");

            Console.WriteLine($"Resta de la posicion {posicion} y el largo de la lista {listaDePalabras.Count} = " +
                                    $"{listaDePalabras.EncontrarPosicionEnLista(palabraAbuscar)} \n");
        }
    }
}
