using Menu.Modelos;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LoginMySQL.DAL
{
    public class DisciplinaDAL
    {
        public static string Inserir(Disciplina disciplina)
        {
            string info = string.Empty;
            using var conexao = ConexaoMySQL.ObterConexao();
            conexao.Open();

            
            try
            {
                string sql = @"
                            INSERT INTO disciplina 
                            (nome, codigo, carga_horaria, id_professor)
                            VALUES 
                            (@nome, @codigo, @cargaHoraria, @idProfessor);";

                using var comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nome", disciplina.Nome);
                comando.Parameters.AddWithValue("@codigo", disciplina.Codigo);
                comando.Parameters.AddWithValue("@cargaHoraria", disciplina.CargaHoraria);
                comando.Parameters.AddWithValue("@idProfessor", disciplina.Professor.IdProfessor);

                comando.ExecuteNonQuery();

                info = "Disciplina Inserida!";
            }
            catch (Exception ex) 
            {
                
                info = "Ocorreu um Erro!" + "\n"+ex.Message;
                conexao.Close();
            }

            return info;
        }

        public static DataTable TodosDisciplinas()
        {
            DataTable dt = new DataTable();

            using var conexao = ConexaoMySQL.ObterConexao();
            conexao.Open();

            try
            {
                string sql = @"
        SELECT 
            d.id_disciplina,
            d.nome AS nome_disciplina,
            d.codigo,
            d.carga_horaria,

            p.nome AS Professor, 
            pr.nif AS NIF
            
        FROM disciplina d
        INNER JOIN professor pr ON d.id_professor = pr.id_professor
        INNER JOIN pessoa p ON pr.id_pessoa = p.id_pessoa;";


                MySqlDataAdapter da = new MySqlDataAdapter(sql, conexao);
                da.Fill(dt);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Deu Um erro!"+ex.Message);
            }
            finally
            {
                conexao.Close();
            }



            return dt;
        }
    }
}
