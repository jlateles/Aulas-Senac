using System;

namespace AulaUdemy{

    class Program{

        static void Main(string[] args){

            Console.WriteLine("Digite o material: ")
            string material = Console.ReadLine();
            Console.WriteLine("Digite a cor: ");
            string Cor = Console.ReadLine();
            Console.WriteLine("Digite o tamanho: ");
            string Tamanho = Console.ReadLine();
            Console.WriteLine("Digite a potência: ");
            string Potencia = Console.ReadLine();
            Console.WriteLine("Digite o estado: ");
            bool Estadp = Console.ReadLine();
            Console.WriteLine("Digite os litros: ");
            int Litros = Console.ReadLine();

            //Ducha objetoDucha = new Ducha {};
            // objetoDucha.Material = "plástico";
            //objetoDucha.Cor = "branca";
            // objetoDucha.Tamanho = "15";
            //objetoDucha.Potencia = "220";
            objetoDucha.Jorrar();
                
        }
    }
}