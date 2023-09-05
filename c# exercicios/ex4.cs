using System;

public class While
{
    public static void Main(string[] args)
    {
        int soma = 0;
        for (int i = 1; i <= 10; i++)
            soma +=i;
        Console.WriteLine(soma);
    }
}