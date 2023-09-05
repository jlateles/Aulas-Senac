using System;

public class While
{
    public static void Main(string[] args)
    {
        int soma = 0, i = 1;
       while (i <= 10)
       {
           soma += i;
           i++;
       }
        Console.WriteLine(soma);
    }
}