using System;
namespace AulaUdemy{

    class Ducha{

        public string Material { get; set; }
        public string Cor { get; set; }
        public string Tamanho { get; set; }
        public string Potencia { get; set; }
        public bool Estado { get; set; }
        public int Litros { get; set; }


        // métodos 

        public void Jorrar(){
            
            Estado = true;

        }

        public void Pingar( bool estado, int litros, int hora){

            string avaliacao = "";
                if((estado == flase && litros == 15) && hora >= 1){
                    avaliacao = "Existe vazamento.";
                }
                else {
                    avaliacao = "Não há vazamento.";
                }
            return avaliacao;
        }

    }
}
