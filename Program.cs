using System;

namespace PrimeiroDojo
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador NeyMito = new Jogador();
            NeyMito.Nome = "Neymar da Silva Santos Júnior";
            NeyMito.Posicao = "Atacante";
            NeyMito.Nascimento = DateTime.Parse("05/02/1992");            

            NeyMito.MostrarDados();
            Console.WriteLine( NeyMito.CalcularIdade() );
            Console.WriteLine( NeyMito.CalcularAposentadoria() );
        }
    }
}
