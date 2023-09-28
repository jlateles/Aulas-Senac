using System;
 
namespace imc {
  class Program {
    static void Main(string[] args) {
    // solicitando o peso e a altura 
    Console.Write("Informe seu peso: ");
    double peso = Double.Parse(Console.ReadLine());
    Console.Write("Informe sua altura: ");
    double altura = Double.Parse(Console.ReadLine());
 
    // calculando o IMC
    double imc = peso / (altura * altura);
    Console.WriteLine("Seu IMC é: " + imc);
 
    // mostrando a classificação
    if (imc < 16) {
        Console.WriteLine("Sua classificação é Magreza grave.");
    }
    else if ((imc >= 16) && (imc < 17)) {
        Console.WriteLine("Sua classificação é Magreza moderada.");
    }
    else if ((imc >= 17) && (imc < 18.5)) {
        Console.WriteLine("Sua classificação é Magreza leve.");
    }
    else if ((imc >= 18.5) && (imc < 25)) {
        Console.WriteLine("Sua classificação é Saudável.");
    }
    else if ((imc >= 25) && (imc < 30)) {
        Console.WriteLine("Sua classificação é Sobrepeso.");
    }
    else if ((imc >= 30) && (imc < 35)) {
        Console.WriteLine("Sua classificação é Obesidade Grau I.");
    }
    else if ((imc >= 35) && (imc < 40)) {
        Console.WriteLine("Sua classificação é Obesidade Grau II.");
    }
    else {
        Console.WriteLine("Sua classificação é Obesidade Grau III (mórbida).");
    }
 
    Console.ReadKey();
    }
  }
}