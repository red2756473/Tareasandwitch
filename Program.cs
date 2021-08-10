using System;

namespace Tareasandwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voy a hacer un sandwitch de jamon");

            Console.WriteLine("agregar pan");
            Console.WriteLine("Quieres Mayonesa o crema?");
            var adherezo = Console.ReadLine();
            Console.WriteLine("¿Con lechuga?");
            var lechuga = Console.ReadLine();
            Console.WriteLine("¿Con jitomate?");
            var jitomate = Console.ReadLine();
            Console.WriteLine("¿Con queso?");
            var queso = Console.ReadLine();
            Console.WriteLine("¿Con chile?...no(ademas, no me gusta el chile...OK ESTA BIEN!)");
            var chile = Console.ReadLine();
            Console.WriteLine("Fin(Ahorita esta tu sandwitch):)");
            Console.WriteLine("\n");
            string [] sandwitch = new string [15];
            sandwitch [0] = "tapa de arriba";
            if (adherezo == "Mayonesa"){
                sandwitch [1] = "Mayonesa";
            }
            else if (adherezo == "crema"){
                sandwitch [1] = "crema";
            }
            sandwitch [2] = "jamon";
            if (lechuga == "con"){
                sandwitch [3] = "lechuga";
            }
            else if (lechuga == "sin"){
                sandwitch [3] = "lechuga";
            }
            if (jitomate == "con"){
                sandwitch [4] = "jitomate";
            }
            else if (jitomate == "sin"){
                sandwitch [4] = "jitomate";
            }
            if (queso == "con"){
                sandwitch [5] = "queso";
            }
            else if (queso == "sin"){
                sandwitch [5] = "queso";
            }
            if (chile == "con"){
                sandwitch [6] = "chile";
            }
            else if (chile == "sin"){
                sandwitch [6] = "chile";
            }
            sandwitch [7] = "tapa de abajo";
            for (int x = 0; x<15; x++){
                if(!string.IsNullOrEmpty(sandwitch[x]))
                Console.WriteLine(sandwitch[x]);
            } 

        }
    }
}
