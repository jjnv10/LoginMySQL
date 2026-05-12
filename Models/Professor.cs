using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.Modelos
{
    public class Professor: Pessoa
    {
        public int IdProfessor { get; set; }
        public string NIF { get; set; }
        public string AreaEspecialidade { get; set; }

        public Professor(int idProfessor, int idPessoa, string nome, int idade, string nIF, string areaEspecialidade): base(idPessoa, nome, idade)
        {
            IdProfessor = idProfessor;
            NIF = nIF;
            AreaEspecialidade = areaEspecialidade;
        }
        public Professor():base(0,"",0)
        {
            IdProfessor = 0;
            NIF = "";
            AreaEspecialidade = "";
        }
        public Professor(string nome, int idade, string nIF, string areaEspecialidade) : base( nome, idade)
        {
            IdProfessor = 0;
            NIF = nIF;
            AreaEspecialidade = areaEspecialidade;
        }

        public override string ToString()
        {
            return base.ToString() + $"Número do Funcionário: {NIF}, Áre: {AreaEspecialidade}";
        }
    }
}
