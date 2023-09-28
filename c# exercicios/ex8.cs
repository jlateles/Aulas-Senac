using System;

class HelloWorld {
  
  static void Main() {
    
    Console.WriteLine("Digite o primeiro número: ");
    int num1 = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite o segundo número: ");
    int num2 = int.Parse(Console.ReadLine());
    
    int soma = num1 + num2;
    int subtracao = num1 - num2;
    int multiplicacao = num1 * num2;
    int divisao = num1 / num2;
    int restoDivisao = num1 % num2;
    
    Console.WriteLine("Soma: " + soma);
    Console.WriteLine("Subtração: " + subtracao);
    Console.WriteLine("Multiplicação: " + multiplicacao);
    Console.WriteLine("Divisão: " + divisao);
    Console.WriteLine("Resto da divisão: " + restoDivisao);
  }
}