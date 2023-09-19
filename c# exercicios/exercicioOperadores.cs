using System;
using System.Text;
public class Operadores{
    public static void Main(string[] args) {

        int num1;
        int num2;
        int soma;
        Console.WriteLine("Digite um número: ");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro número: ");
        num2 = int.Parse(Console.ReadLine());
        soma = num1 + num2;
        Console.WriteLine("A soma dos números é de {0}", soma);

        // multiplicação 
        int n1;
        int n2;
        int multiplica;
        Console.WriteLine("Digite um número: ");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro número: ");
        n2 = int.Parse(Console.ReadLine());
        multiplica  = n1 * n2;
        Console.WriteLine("A multiplicação dos números é de {0}", multiplica);

        // divisão 
        int nu1;
        int nu2;
        int dividir;
        Console.WriteLine("Digite um número: ");
        nu1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro número: ");
        nu2 = int.Parse(Console.ReadLine());
        dividir = nu1 / nu2;
        Console.WriteLine("A divisão dos números é de {0}", dividir);

        // subtração 
        int numero1;
        int numero2;
        int subtrair;
        Console.WriteLine("Digite um número: ");
        numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro número: ");
        numero2 = int.Parse(Console.ReadLine());
        subtrair = numero1 - numero2;
        Console.WriteLine("A subtração dos números é de {0}", subtrair);
    }
}