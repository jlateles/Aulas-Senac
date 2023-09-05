using System;
using System.Text;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101); // Gera número aleatório entre 1 e 100.
        int palpite = 0;
        
        Console.WriteLine("Bem-vindo(a) ao jogo de adivinhação!");
        Console.WriteLine("Tente adivinhar o número secreto:");

        while (palpite != numeroAleatorio)
        {
            try
            {
                palpite = Int32.Parse(Console.ReadLine());

                if (palpite < 1 || palpite > 100)
                {
                    Console.WriteLine("Por favor, insira um número entre 1 e 100.");
                    continue;
                }

                if (palpite < numeroAleatorio)
                {
                    Console.WriteLine("O número é maior! Tente novamente:");
                }
                else if (palpite > numeroAleatorio)
                {
                    Console.WriteLine("O número é menor! Tente outra vez:");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Por favor, insira um número válido.");
            }
        }

        Console.WriteLine("Parabéns! Você adivinhou o número.");
    }
}