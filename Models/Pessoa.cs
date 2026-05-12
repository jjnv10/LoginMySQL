using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.Modelos
{
    public abstract class Pessoa
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        protected Pessoa(int idPessoa, string nome, int idade)
        {
            this.IdPessoa = idPessoa;
            this.Nome = nome;
            this.Idade = idade;  
        }
        protected Pessoa(string nome, int idade)
        {
            this.IdPessoa = 0;
            this.Nome = nome;
            this.Idade = idade;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade} ";
        }
    }
}
