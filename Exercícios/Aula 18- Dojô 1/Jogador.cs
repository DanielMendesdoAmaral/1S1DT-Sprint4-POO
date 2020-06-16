using System;

namespace Aula_18__Dojô_1
{
    public class Jogador
    {
        // ATRIBUTOS/GETTERS E SETTERS
        
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        
        private string _posicao;
        public string Posicao
        {
            get { return _posicao; }
            set { _posicao = value; }
        }

        private DateTime _dataNascimento;
        public DateTime DataNascimento
        {
            get { return _dataNascimento; }
            set { _dataNascimento = value; }
        }

        private string _nacionalidade;
        public string Nacionalidade
        {
            get { return _nacionalidade; }
            set { _nacionalidade = value; }
        }

        private double _altura;
        public double Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }

        private double _peso;
        public double Peso
        {
            get { return _peso; }
            set { _peso = value; }
        }
        



        
        //MÉTODO CONSTRUTOR
        
        public Jogador(string nome, string posicao, DateTime dataNascimento, double altura, double peso) {

            this.Nome = nome;
            this.Posicao = posicao;
            this.DataNascimento = dataNascimento;
            this.Altura = altura;
            this.Peso = peso;
            
        }





        //OUTROS MÉTODOS:

        /// <summary>
        ///     Exibir os dados do jogador.
        /// </summary>
        /// <returns> Retorna o nome, posição, data de nascimento, altura e peso do jogador. </returns>
        public string ExibirDados() {
            return $"NOME: {Nome}\nPOSIÇÃO: {Posicao}\n Data de nascimento: {DataNascimento}\n Altura : {Altura}\n Peso: {Peso}";
        }

        /// <summary>
        ///     Calcula a idade do jogador.
        /// </summary>
        /// <returns> Retorna quantos anos de idade o jogador tem. </returns>
        public int CalcularIdade() {
            int anoNascimento = this.DataNascimento.Year; //Guarda o ano em que o jogador nasceu.
            int anoAtual = DateTime.Now.Year; //Guarda o ano atual com base na data do sistema.
            if (this.DataNascimento.Month > DateTime.Now.Month) 
                return anoAtual-anoNascimento-1;
            else if ((this.DataNascimento.Month == DateTime.Now.Month) && (this.DataNascimento.Day > DateTime.Now.Day))
                return anoAtual-anoNascimento-1;
            else 
                return anoAtual-anoNascimento;
        }

        /// <summary>
        ///     Verifica se o jogador já se aposentou. Se ele ainda não se aposentou, mostra quantos anos faltam para ele se aposentar.
        /// </summary>
        /// <returns> Retorna as mensagens das situações descritas acima. </returns>
        public string VerificarAposentadoria() {
            int idade = CalcularIdade(); //Guarda a idade do jogador.

            switch(Posicao) {
                
                case "Defesa": 
                    if (40 - idade <= 0)
                        return $"O jogador {Nome} já se aposentou.";
                    else if (40 - idade == 1)
                        return $"Falta 1 ano para o jogador {Nome} se aposentar.";
                    else 
                        return $"Faltam {40 - idade} anos para o jogador {Nome} se aposentar.";

                case "Meio-Campo":
                    if(38 - idade <= 0)
                        return $"O jogador {Nome} já se aposentou.";
                    else if (38 - idade == 1)
                        return $"Falta 1 ano para o jogador {Nome} se aposentar.";
                    else
                        return $"Faltam {38 - idade} anos para o jogador {Nome} se aposentar.";

                
                case "Ataque":
                    if(35 - idade <0)
                       return $"O jogador {Nome} já se aposentou.";
                    else if (35 - idade == 1)
                       return $"Falta 1 ano para o jogador {Nome} se aposentar.";
                    else
                        return $"Falta {35 - idade} anos para o jogador {Nome} se aposentar.";
                    
            }

            return $"ERRO! Insira uma posição válida.";

        }
    }
} 