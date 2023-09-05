using System;
using System.Text;
namespace SwitchExemplo{

    class Program
{
    public static void Main(string[] args)
    {   
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Digite um dia da semana: ");
        string dia =Console.ReadLine();
        
        switch (dia.ToLower())
        {
            case "segunda-feira":
            case "terça-feira":
            case "quarta-feira":
            case "quinta-feira":
            case "sexta-feira":
                Console.WriteLine("Este dia é útil");
                break;
                
            case "sábado":
            case "domingo":
                Console.WriteLine("O dia que você digitou é final de semana!");
                break;

            default:
                Console.WriteLine("Este dia nao foi encontrado");
                break; }
        
   //Console.Readkey();
        }
    }
}