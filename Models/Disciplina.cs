using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.Modelos
{
    public class Disciplina
    {
        public int IdDisciplina { get; set; }
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public int CargaHoraria { get; set; }

        public Professor Professor { get; set; }

        public Disciplina(string nome, string codigo, int cargaHoraria, Professor prof)
        {
            IdDisciplina = 0;
            Nome = nome;
            Codigo = codigo;
            CargaHoraria = cargaHoraria;
            Professor = prof;
        }
        public Disciplina(int id, string nome, string codigo, int cargaHoraria, Professor prof)
        {
            IdDisciplina = id;
            Nome = nome;
            Codigo = codigo;
            CargaHoraria = cargaHoraria;
            Professor = prof;
        }

    }
}
