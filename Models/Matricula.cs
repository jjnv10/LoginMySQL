using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.Modelos
{
    public class Matricula
    {
        public int IdMatricula { get; set; }
        public string Estado { get; set; }

        public DateTime DataMatricula { get; set; }

        public Estudante Estudante { get; set; }

        public Disciplina Disciplina { get; set; }

        public Matricula(int id, string estado, Estudante est, Disciplina disc)
        {
            IdMatricula = id;
            Disciplina = disc;
            Estado = estado;
            Estudante = est;
            DataMatricula = DateTime.Now;   
            
        }

        public override string ToString()
        {
            return Estado;
        }
    }
}
