using System;

namespace PrimeiroDojo
{
    public class Jogador
    {
        public string Nome { get; set; }
        public string Posicao { get; set; }
        public DateTime Nascimento { get; set; }
        public float Altura { get; set; }
        public float Peso {get; set;}
        public string Nacionalidade { get; set; }
        public string MostrarDados(){
            
            return $"Nome: {Nome}, Posição do jogador : {Posicao}, Data de nascimento : {Nascimento}, Altura : {Altura}, Peso: {Peso}, Nacionalidade: {Nacionalidade}";
        }

        public int idade { get; set; }

        public int CalcularIdade(){
            int anoNascimento = Int32.Parse(Nascimento.ToString().Split('/' ,' ')[2]);
            int anoAtual = Int32.Parse(DateTime.Now.ToString().Split('/' ,' ')[2]);

            idade = anoAtual - anoNascimento;

            return idade;
            
        }
        public string CalcularAposentadoria(){

            string aposentadoria = "";

            if(Posicao == "Atacante" && idade >= 35){

                aposentadoria = "Você pode se aposentar";

            }else if(Posicao == "Defesa" && idade >= 40){

                aposentadoria = "Você pode se aposentar";

            }else{

                aposentadoria = "Você ainda não pode se aposentar";

            }
            return aposentadoria;

        }

    }
}