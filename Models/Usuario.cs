using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LoginMySQL.Models
{
    public sealed class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Activo { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Utilizador { get; set; }
        public string Password { get; set; }

        public Usuario(int id, string nome,string email, bool activo, string role, string utilizador, string password = null)
        {
            Id = id;
            Nome = nome;
            Activo = activo;
            Role = role;
            Utilizador = utilizador;
            Email = email;
            Password = password;

        }

        public Usuario()
        {
            Id = 0;
            Nome = "";
            Activo = false;
            Role = "";
            Utilizador = "";
            Email = string.Empty;
            Password = string.Empty;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Email: {Utilizador}";
        }

    }
}
