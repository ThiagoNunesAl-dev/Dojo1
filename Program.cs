using System;

namespace Dojo
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador debruyne = new Jogador();
            debruyne.Nome = "Kevin De Bruyne";
            debruyne.Posicao = "Meia";
            debruyne.Nascimento = DateTime.Parse("28/06/1975");
            debruyne.Nacionalidade = "Belga";
            debruyne.Altura = 1.81f;
            debruyne.Peso = 68f;

            Console.WriteLine("Idade: "+debruyne.CalcIdade());

            Console.WriteLine(debruyne.MostrarDados());

            Console.WriteLine(debruyne.CalcAposentadoria());


        }
    }
}
