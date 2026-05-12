using LoginMySQL.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace LoginMySQL.DAL
{
    public class LoginDAL
    {
        public static Usuario FazerLogin(string usuario, string senha)
        {
            

            // 'using' garante a libertação dos recursos mesmo em caso de excepção
            /**
            using var con = ConexaoMySQL.ObterConexao();
            con.Open();

            string sql = "SELECT * FROM utilizadores WHERE usuario = @usuario;";

            using var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Estudante(
                    id: reader.GetInt32("id"),
                    nome: reader.GetString("nome"),
                    matricula: reader.GetString("matricula"),
                    curso: reader.GetString("curso"),
                    nota: reader.GetDecimal("nota")
                ));
            }*/
            return null;
        }

    }
}
