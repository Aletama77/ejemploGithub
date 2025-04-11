using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AnimalDomestico a1 = new AnimalDomestico();
            //a1.Nombre = "Enrique";

            Gato g1 = new Gato();
            Perro p1 = new Perro();

            p1.Nombre = "Juancho";
            g1.Nombre = "Pepe";

            //Console.WriteLine(a1.comunicarse());
            //Console.WriteLine(g1.comunicarse());
            //Console.WriteLine(p1.comunicarse());

            List<Animal> animales = new List<Animal>();
            animales.Add(p1);
            animales.Add(g1);
            animales.Add(new Pez());
            animales.Add(new Canario());
            animales.Add(new Aguila());
            animales.Add(new Gato());

            List<Flyable> listaVoladores = new List<Flyable>();
            listaVoladores.Add(new Canario());
            listaVoladores.Add(new Aguila());

            //foreach (Animal animal in animales)
            //{
            //    Console.WriteLine(animal.comunicarse());
            //}

            //Animal a1 = g1;
            //Gato g8 = (Gato)a1;

            //Console.WriteLine(g8.Nombre);
            //g8.Nombre = "Blanquito";

            //Console.WriteLine(g8.Nombre);
            //Console.WriteLine(g1.Nombre);

            //Console.WriteLine(animales.Count());

            Console.ReadKey();
        }
    }
}
