using LoginMySQL.DAL;
using LoginMySQL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;
using System.Runtime.CompilerServices;

namespace LoginMySQL.Controller
{
    public static class Controlador
    {
        public static string GerarHashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
    

    public static string InserirUtilizadores(Usuario usuario)
        {
            string Info;
            string password_hashed = GerarHashPassword(usuario.Password);
            string sql = @"INSERT INTO utilizadores (nome, usuario, email, password_hash, role, activo) 
                            VALUES (@nome, @usuario, @email, @password_hash, 
                            @role, @activo);";
            using var connection = ConexaoMySQL.ObterConexao();
            connection.Open();
            using var command = new MySqlCommand(sql, connection);
            
            command.Parameters.AddWithValue("@nome", usuario.Nome);
            command.Parameters.AddWithValue("@usuario", usuario.Utilizador);
            command.Parameters.AddWithValue("@email", usuario.Email);
            command.Parameters.AddWithValue("@role", usuario.Role);
            command.Parameters.AddWithValue("@password_hash", password_hashed);
            command.Parameters.AddWithValue("@activo", usuario.Activo);

            int inserir = command.ExecuteNonQuery();
            if (inserir > 0)
            {
               Info="Utilizador inserido!";
            }
            else
            {
                Info = "Utilizador não inserido!";
            }

            connection.Close();

            return Info;
                               
        }

    public static void Inserir()
        {
            InserirUtilizadores(new Usuario(0, "João Ventura", "joao@gmail.com", true, "Professor", "joao", "123456"));
            InserirUtilizadores(new Usuario(0, "Ventura João", "ventura@gmail.com", true, "Estudante", "ventura", "123456"));
            InserirUtilizadores(new Usuario(0, "Pedro Teca", "pedro@gmail.com", true, "Estudante", "pedro", "123456"));
            InserirUtilizadores(new Usuario(0, "Anny Ventura", "anny@gmail.com", true, "Funcionaria", "anny", "123456"));
            InserirUtilizadores(new Usuario(0, "Conceição Teca", "sao@gmail.com", true, "Estudante", "sao", "123456"));
        }
}
    
}
// fmLogin fmLog = new ();
//var result = fmLog.ShowDialog();
// if (result == DialogResult.OK)
// {
//   Application.Run(new Form1());
// }
// else
// {
//   Application.Exit();
// }