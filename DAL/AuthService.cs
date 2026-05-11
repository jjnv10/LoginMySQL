using LoginMySQL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;

namespace LoginMySQL.DAL
{
    public sealed class AuthService
    {
        private readonly string _connectionString;

        public AuthService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public static string GerarHashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }



        public async Task<Usuario?> LoginAsync(
            string usuario,
            string password,
            CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(password))
                return null;

            const string sql = @"
            SELECT id, nome, email, usuario, password_hash, activo, role
            FROM utilizadores
            WHERE usuario = @usuario
            LIMIT 1;";

            await using var connection = ConexaoMySQL.ObterConexao();
            await connection.OpenAsync(cancellationToken);

            await using var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@usuario", usuario.Trim());

            await using var reader = await command.ExecuteReaderAsync(cancellationToken);

            if (!await reader.ReadAsync(cancellationToken))
                return null;

            bool activo = reader.GetBoolean(reader.GetOrdinal("activo"));

            if (!activo)
                return null;

            string passwordHash = reader.GetString(reader.GetOrdinal("password_hash"));

            bool passwordValida = BCrypt.Net.BCrypt.Verify(password, passwordHash);

            if (!passwordValida)
                return null;

            return new Usuario
            {
                Id = reader.GetInt32(reader.GetOrdinal("id")),
                Nome = reader.GetString(reader.GetOrdinal("nome")),
                Email = reader.GetString(reader.GetOrdinal("email")),
                Utilizador = reader.GetString(reader.GetOrdinal("usuario")),
                Role = reader.GetString(reader.GetOrdinal("role")),
                Activo = reader.GetBoolean(reader.GetOrdinal("activo"))
            };
        }
    }
}
