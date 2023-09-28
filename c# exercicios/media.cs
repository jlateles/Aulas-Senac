using System;

class Program{
    static void Main(string[]args){

        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();

        int n1, n2, n3, media;
        Console.WriteLine("Insira o primeiro número: ");
        Console.WriteLine("Insira o segundo número: ");
        Console.WriteLine("Insira o terceiro número: ");

        media = (n1 + n2 + n3) / 3;

        Console.WriteLine("Olá, " + nome "!")
        Console.WriteLine("A média dos números é: " + media);

    }
}