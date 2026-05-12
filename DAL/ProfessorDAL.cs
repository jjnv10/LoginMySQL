using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using LoginMySQL.DAL;
using Menu.Modelos;
using MySqlConnector;

namespace Menu.DAL
{
    public class ProfessorDAL
    {
        public static string Inserir(Professor professor)
        {
            string info = string.Empty;
            using var conexao = ConexaoMySQL.ObterConexao();
            conexao.Open();

            using var transacao = conexao.BeginTransaction();

            try
            {
                string sqlPessoa = @"
            INSERT INTO pessoa (nome, idade)
            VALUES (@nome, @idade);
            SELECT LAST_INSERT_ID();";

                using var comandoPessoa = new MySqlCommand(sqlPessoa, conexao, transacao);
                comandoPessoa.Parameters.AddWithValue("@nome", professor.Nome);
                comandoPessoa.Parameters.AddWithValue("@idade", professor.Idade);

                int idPessoa = Convert.ToInt32(comandoPessoa.ExecuteScalar());

                string sqlProfessor = @"
            INSERT INTO professor (id_pessoa, nif, area_especialidade)
            VALUES (@idPessoa, @nif, @areaEspecialidade);";

                using var comandoProfessor = new MySqlCommand(sqlProfessor, conexao, transacao);
                comandoProfessor.Parameters.AddWithValue("@idPessoa", idPessoa);
                comandoProfessor.Parameters.AddWithValue("@nif", professor.NIF);
                comandoProfessor.Parameters.AddWithValue("@areaEspecialidade", professor.AreaEspecialidade);

                comandoProfessor.ExecuteNonQuery();

                transacao.Commit();

                info = "Professor Inserido!";
            }
            catch
            {
                transacao.Rollback();
                info = "Ocorreu um Erro!";
            }

            return info;
        }

        public static DataTable TodosProfessores() {  
            DataTable dt = new DataTable();

            using var conexao = ConexaoMySQL.ObterConexao();
            conexao.Open();

            try
            {
                string sql = @"
                 SELECT 
            pr.id_professor,
            p.id_pessoa,
            p.nome,
            p.idade,
            pr.nif,
            pr.area_especialidade
        FROM professor pr
        INNER JOIN pessoa p ON pr.id_pessoa = p.id_pessoa;";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conexao);
                da.Fill(dt);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Deu Um erro!");
            }
            finally
            {
                conexao.Close() ;
            }



            return dt; 
        }
    }
}
