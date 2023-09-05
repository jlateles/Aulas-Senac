using System;
using System.Text;

public class ExemploFor{
    public static void Main(string[] args){
        Console.OutputEncoding = Encoding.UTF8;
        
        Console.WriteLine("Números pares entre 1 e 100:");
        
        for (int i = 2; i <= 100; i= i+2){
        Console.WriteLine(i);
        }
    }
}