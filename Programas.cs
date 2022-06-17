using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroOndas
{
    public class Programas
    {
        public int tempo = 1;
        public int potencia = 10;
        public string nome = "";
        public string instrucoes = "";
        public string caractere = ".";
        

        public void Construtor(int tempo, int potencia, string nome, string instrucoes, string caractere)
        {
            this.tempo = tempo;
            this.nome = nome;
            this.instrucoes = instrucoes;
            this.potencia = potencia;
            this.caractere = caractere;
            
        }

    }

    
}
