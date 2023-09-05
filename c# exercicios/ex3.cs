using System;

public class While
{
    public static void Main(string[] args)
    {
        int soma = 0, i = 1;
        do {
            soma += i;
            i++;
        } while (i <= 10);
        Console.WriteLine(soma);
    }
}