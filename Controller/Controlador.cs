using LoginMySQL.DAL;
using LoginMySQL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;
using System.Runtime.CompilerServices;
using System.Data;

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

   

    public static DataTable TodosUtilizadores() 
        {
            using var connection = ConexaoMySQL.ObterConexao();
            DataTable dt = new DataTable(); ;
            try
            {
                
                string sql = "SELECT id, nome, email, usuario, role, activo  FROM utilizadores ORDER BY nome";
                connection.Open();
                MySqlDataAdapter da= new MySqlDataAdapter(sql, connection);

                
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;
           

        }

        public static string ActualizarUtilizador(Usuario usuario)
        {
            using var connection = ConexaoMySQL.ObterConexao();
            string info = string.Empty;
            try
            {
               
                string sql = @"UPDATE utilizadores SET 
                            nome = @nome, email = @email, usuario = @usuario,
                            role = @role, activo = @activo, password_hash = @password_hash
                            WHERE id = @id;";
                connection.Open();
                using var command = new MySqlCommand(sql, connection);

                command.Parameters.AddWithValue("@id", usuario.Id);
                command.Parameters.AddWithValue("@nome", usuario.Nome);
                command.Parameters.AddWithValue("@usuario", usuario.Utilizador);
                command.Parameters.AddWithValue("@email", usuario.Email);
                command.Parameters.AddWithValue("@role", usuario.Role);
                command.Parameters.AddWithValue("@password_hash", GerarHashPassword(usuario.Password));
                command.Parameters.AddWithValue("@activo", usuario.Activo);

                command.ExecuteNonQuery();
                info = "Informação Actualizada!";
            }
            catch (Exception ex)
            {

                info = ex.Message;
            }
            finally { connection.Close(); }

            return info;
            
        }
        public static string EliminarUtilizador(int Id)
        {
            using var connection = ConexaoMySQL.ObterConexao();
            string info = string.Empty;
            try
            {

                string sql = @"DELETE FROM utilizadores WHERE id = @id;";
                connection.Open();
                using var command = new MySqlCommand(sql, connection);

                command.Parameters.AddWithValue("@id", Id);
               
                command.ExecuteNonQuery();
                info = "Eliminado com Sucesso!";
            }
            catch (Exception ex)
            {
                info = ex.Message;
            }
            finally { connection.Close(); }

            return info;

        }
    }
}
