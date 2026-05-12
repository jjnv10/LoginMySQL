using Menu.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;
using LoginMySQL.DAL;
using System.Data;

namespace Menu.DAL
{
    public class EstudanteDAL
    {
        /// <summary>
        /// Recupera todos os estudantes registados na base de dados.
        /// Devolve uma lista de objectos Estudante.
        /// </summary>
        public static DataTable ListarTodos()
        {
            DataTable dt = new DataTable();

            // 'using' garante a libertação dos recursos mesmo em caso de excepção
            using var con = ConexaoMySQL.ObterConexao();
            con.Open();

            string sql = @"
        SELECT 
            e.id_estudante,
            p.id_pessoa,
            p.nome,
            p.idade,
            e.mec,
            e.curso
        FROM estudante e
        INNER JOIN pessoa p ON e.id_pessoa = p.id_pessoa;";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
            da.Fill(dt);


            return dt;

        }

        /// <summary>
        /// Insere um novo estudante na base de dados.
        /// Utiliza parametros (@param) para prevenir SQL Injection.
        /// Devolve true em caso de sucesso, false em caso de falha.
        /// </summary>
        public static string Inserir(Estudante estudante)
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
                comandoPessoa.Parameters.AddWithValue("@nome", estudante.Nome);
                comandoPessoa.Parameters.AddWithValue("@idade", estudante.Idade);

                int idPessoa = Convert.ToInt32(comandoPessoa.ExecuteScalar());

                string sqlEstudante = @"
            INSERT INTO estudante (id_pessoa, mec, curso)
            VALUES (@idPessoa, @mec, @curso);";

                using var comandoEstudante = new MySqlCommand(sqlEstudante, conexao, transacao);
                comandoEstudante.Parameters.AddWithValue("@idPessoa", idPessoa);
                comandoEstudante.Parameters.AddWithValue("@mec", estudante.Mec);
                comandoEstudante.Parameters.AddWithValue("@curso", estudante.Curso);

                comandoEstudante.ExecuteNonQuery();

                transacao.Commit();
                info = "Estudante Inserido!";
            }
            catch(Exception ex) 
            {
                transacao.Rollback();
                info = ex.Message;
            }

            return info;
        }

        /// <summary>
        /// Actualiza os dados de um estudante existente na base de dados.
        /// O estudante e identificado pelo seu Id (chave primaria).
        /// </summary>
        public bool Actualizar(Estudante e)
        {
            using var con = ConexaoMySQL.ObterConexao();
            con.Open();

            const string sql = "UPDATE estudante " +
                               "SET nome=@nome, mec=@mec, " +
                               "curso=@curso, idade=@idade " +
                               "WHERE id=@id;";

            using var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", e.IdEstudante);
            cmd.Parameters.AddWithValue("@nome", e.Nome);
            cmd.Parameters.AddWithValue("@mec", e.Mec);
            cmd.Parameters.AddWithValue("@curso", e.Curso);
            cmd.Parameters.AddWithValue("@idade", e.Idade);

            int linhasAfectadas = cmd.ExecuteNonQuery();
            return linhasAfectadas > 0;
        }
        /// <summary>
        /// Elimina um estudante da base de dados com base no seu Id.
        /// </summary>
        public bool Eliminar(int id)
        {
            using var con = ConexaoMySQL.ObterConexao();
            con.Open();

            const string sql = "DELETE FROM estudante WHERE id = @id;";

            using var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);

            int linhasAfectadas = cmd.ExecuteNonQuery();
            return linhasAfectadas > 0;

        }

        /// <summary>
        /// Pesquisa estudantes cujo nome ou matrícula contenha o termo fornecido.
        /// Utiliza o operador LIKE do MySQL para pesquisa parcial.
        /// </summary>
        public List<Estudante> Pesquisar(string termo)
        {
            var lista = new List<Estudante>();
            using var con = ConexaoMySQL.ObterConexao();
            con.Open();

            const string sql = "SELECT id, nome, idade, mec, curso " +
                               "FROM estudante " +
                               "WHERE nome LIKE @termo OR mec LIKE @termo " +
                               "ORDER BY nome;";

            using var cmd = new MySqlCommand(sql, con);
            // '%' e o caracter curinga do LIKE: %termo% = contém o termo
            cmd.Parameters.AddWithValue("@termo", $"%{termo}%");

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new Estudante(
                    reader.GetInt32("id"),
                    reader.GetString("nome"),
                    reader.GetInt32("idade"),
                    reader.GetString("mec"),
                    reader.GetString("curso")
                ));
            }
            return lista;

        }
    }
}
