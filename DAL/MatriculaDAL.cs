using Menu.Modelos;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LoginMySQL.DAL
{
    public static class MatriculaDAL
    {

        public static void InserirMatricula(Matricula matricula)
        {
            using var conexao = ConexaoMySQL.ObterConexao();
            
            conexao.Open();

            string sql = @"
        INSERT INTO matricula 
            (id_estudante, id_disciplina, estado, data_matricula)
        VALUES 
            (@idEstudante, @idDisciplina, @estado, @dataMatricula);";

            using var comando = new MySqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@idEstudante", matricula.Estudante.IdEstudante);
            comando.Parameters.AddWithValue("@idDisciplina", matricula.Disciplina.IdDisciplina);
            comando.Parameters.AddWithValue("@estado", matricula.Estado);
            comando.Parameters.AddWithValue("@dataMatricula", matricula.DataMatricula);

            comando.ExecuteNonQuery();
     
        }

        public static DataTable TodasMatriculas()
        {
            DataTable dt = new DataTable();

            using var conexao = ConexaoMySQL.ObterConexao();
            conexao.Open();

            try
            {
                string sql = @"
        SELECT
            m.id_matricula,
            m.estado,
            m.data_matricula,


            pe.nome AS Estudante,
            e.mec,
            e.curso,

            d.nome AS nome_disciplina,
            d.codigo,
            d.carga_horaria,

            pp.nome AS Professor,
            pr.nif

        FROM matricula m
        INNER JOIN estudante e ON m.id_estudante = e.id_estudante
        INNER JOIN pessoa pe ON e.id_pessoa = pe.id_pessoa
        INNER JOIN disciplina d ON m.id_disciplina = d.id_disciplina
        INNER JOIN professor pr ON d.id_professor = pr.id_professor
        INNER JOIN pessoa pp ON pr.id_pessoa = pp.id_pessoa;";


                MySqlDataAdapter da = new MySqlDataAdapter(sql, conexao);
                da.Fill(dt);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Deu Um erro!" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }



            return dt;
        }
    }
}
