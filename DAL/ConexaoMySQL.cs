using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;

namespace LoginMySQL.DAL
{
    public static class ConexaoMySQL
    {
        private const string StringLigacao =
    "Server=localhost;" +
    "Port=3306;" +
    "Database=meubanco;" +
    "Uid=root;" +
    "Pwd=senha123;";

        public static MySqlConnection ObterConexao() => new MySqlConnection(StringLigacao);
        
    }


    /**
     CREATE TABLE utilizadores (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    utilizador VARCHAR(20) NOT NULL,
    email VARCHAR(150) NOT NULL UNIQUE,
    password_hash VARCHAR(255) NOT NULL,
    activo BOOL NOT NULL DEFAULT TRUE
);
     
     */
}
