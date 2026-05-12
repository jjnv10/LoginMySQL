using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Menu.Modelos
{
    public class Estudante: Pessoa
    {
        public int IdEstudante { get; set; }
        public string Mec { get; set; }
        public string Curso { get; set; }
        public Estudante(int idEsudante, int idPessoa, string nome, int idade, string mec, string curso) :base(idPessoa, nome, idade)
        {
            IdEstudante = idEsudante;
            Mec = mec;
            Curso = curso;
        }
        public Estudante( string nome, int idade, string mec, string curso) : base(nome, idade)
        {
            IdEstudante = 0;
            Mec = mec;
            Curso = curso;
        }

        public Estudante(int id, string nome, int idade, string mec, string curso) : base(nome, idade)
        {
            IdEstudante = id;
            Mec = mec;
            Curso = curso;
        }


        public override string ToString()
        {
            return base.ToString() + $" Mec: {Mec}, Curso: {Curso}";
        }

    }
}
