namespace Dojo
{
    using System;
    public class Jogador
    {
         public string Nome { get; set; }
        public string Posicao { get; set; }
        public DateTime Nascimento { get; set; }
        public float Altura { get; set; }
        public float Peso {get; set;}
        public string Nacionalidade { get; set; }
        public string MostrarDados(){
            
            return $"Nome: {Nome}\nPosição do jogador : {Posicao}\nData de nascimento : {Nascimento}\nAltura : {Altura} m\nPeso: {Peso} kg\nNacionalidade: {Nacionalidade}\n";
        }

        public int idade { get; set; }

        public int CalcIdade(){
            int anoNasc = Int32.Parse(Nascimento.ToString().Split('/' ,' ')[2]);
            int anoAtual = Int32.Parse(DateTime.Now.ToString().Split('/' ,' ')[2]);

            idade = anoAtual - anoNasc;

            return idade;
            
        }
        public string CalcAposentadoria(){
            //Atacante : 35
            //Meia : 38
            //Defesa : 40

            string aposentadoria = "";

            if(Posicao == "Atacante" && idade >= 35){

                aposentadoria = "Você já pode se aposentar.";

            }else if(Posicao == "Meia" && idade >= 38){

                aposentadoria = "Você já pode se aposentar.";

            }else if(Posicao == "Defesa" && idade >= 40){

                aposentadoria = "Você já pode se aposentar.";

            }else{

                aposentadoria = "Você ainda não pode se aposentar.";

            }


            return aposentadoria;


        }

    }
}