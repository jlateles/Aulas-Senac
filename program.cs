using System;

namespace AulaUdemy{

    class Program{

        static void Main(string[] args){

            Ducha objetoDucha = new Ducha {};
            objetoDucha.Material = "plástico";
            objetoDucha.Cor = "branca";
            objetoDucha.Tamanho = "15";
            objetoDucha.Potencia = "220";

            objetoDucha.Jorrar();
        }
    }
}