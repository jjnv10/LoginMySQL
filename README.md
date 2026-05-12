## Tabela `usuario`

A classe `Usuario` representa os utilizadores que podem aceder ao sistema. Esta tabela é independente das tabelas `pessoa`, `estudante` e `professor`, porque está relacionada com autenticação, permissões e estado da conta.

Classe correspondente em C#:

```csharp
public sealed class Usuario
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public bool Activo { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
    public string Utilizador { get; set; }
    public string Password { get; set; }
}
```

---

## Script SQL actualizado

Acrescente esta tabela ao ficheiro `database.sql`:

```sql
CREATE TABLE IF NOT EXISTS usuario (
    id_usuario INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(150) NOT NULL,
    activo BOOLEAN NOT NULL DEFAULT TRUE,
    role ENUM('Administrador', 'Professor', 'Estudante', 'Secretaria') NOT NULL,
    utilizador VARCHAR(50) NOT NULL,
    password VARCHAR(255) NOT NULL,

    CONSTRAINT uq_usuario_email 
        UNIQUE (email),

    CONSTRAINT uq_usuario_utilizador 
        UNIQUE (utilizador)
);
```

---

## Explicação dos campos da tabela `usuario`

```text
usuario
-------
id_usuario PK
nome
email UNIQUE
activo
role
utilizador UNIQUE
password
```

### Campos principais

- `id_usuario`: identificador único do utilizador;
- `nome`: nome completo do utilizador;
- `email`: endereço electrónico do utilizador;
- `activo`: indica se a conta está activa ou inactiva;
- `role`: define o nível de acesso no sistema;
- `utilizador`: nome usado para iniciar sessão;
- `password`: palavra-passe do utilizador.

---

## Tipos de utilizador permitidos

A coluna `role` aceita apenas os seguintes valores:

```text
Administrador
Professor
Estudante
Secretaria
```

Exemplo:

```sql
INSERT INTO usuario 
    (nome, email, activo, role, utilizador, password)
VALUES 
    ('Administrador do Sistema', 
     'admin@escola.ao', 
     TRUE, 
     'Administrador', 
     'admin', 
     '12345');
```

---

## Observação importante sobre segurança

Em ambiente real, a palavra-passe nunca deve ser gravada em texto simples.

Este exemplo:

```sql
password = '12345'
```

serve apenas para testes académicos.

Numa aplicação real, a palavra-passe deve ser guardada usando um mecanismo de protecção, como `hash` com `salt`.

Exemplo conceptual:

```text
password_hash
```

em vez de:

```text
password
```

---

## Inserir utilizadores de teste

Depois de criar a tabela, pode inserir alguns utilizadores para testar o sistema:

```sql
INSERT INTO usuario 
    (nome, email, activo, role, utilizador, password)
VALUES
    ('Administrador do Sistema', 'admin@escola.ao', TRUE, 'Administrador', 'admin', '12345'),

    ('António Pedro', 'antonio.pedro@escola.ao', TRUE, 'Professor', 'antonio.pedro', '12345'),

    ('João Manuel', 'joao.manuel@escola.ao', TRUE, 'Estudante', 'joao.manuel', '12345'),

    ('Maria José', 'maria.jose@escola.ao', TRUE, 'Secretaria', 'maria.jose', '12345');
```

---

## Consultar utilizadores

Para listar todos os utilizadores:

```sql
SELECT 
    id_usuario,
    nome,
    email,
    activo,
    role,
    utilizador
FROM usuario;
```

Por motivos de segurança, recomenda-se não mostrar a coluna `password` em consultas comuns.

---

## Consultar apenas utilizadores activos

```sql
SELECT 
    id_usuario,
    nome,
    email,
    role,
    utilizador
FROM usuario
WHERE activo = TRUE;
```

---

## Validar login no banco de dados

Exemplo simples de consulta para autenticação:

```sql
SELECT 
    id_usuario,
    nome,
    email,
    activo,
    role,
    utilizador
FROM usuario
WHERE utilizador = 'admin'
  AND password = '12345'
  AND activo = TRUE;
```

Na aplicação C#, os valores devem ser enviados por parâmetros, nunca por concatenação directa de texto.

---

## Método C# para inserir utilizador

```csharp
using MySqlConnector;

public void InserirUsuario(Usuario usuario)
{
    string connectionString =
        "Server=localhost;Port=3306;Database=escola;User ID=root;Password=sua_senha;";

    using var conexao = new MySqlConnection(connectionString);
    conexao.Open();

    string sql = @"
        INSERT INTO usuario
            (nome, email, activo, role, utilizador, password)
        VALUES
            (@nome, @email, @activo, @role, @utilizador, @password);";

    using var comando = new MySqlCommand(sql, conexao);

    comando.Parameters.AddWithValue("@nome", usuario.Nome);
    comando.Parameters.AddWithValue("@email", usuario.Email);
    comando.Parameters.AddWithValue("@activo", usuario.Activo);
    comando.Parameters.AddWithValue("@role", usuario.Role);
    comando.Parameters.AddWithValue("@utilizador", usuario.Utilizador);
    comando.Parameters.AddWithValue("@password", usuario.Password);

    comando.ExecuteNonQuery();
}
```

---

## Método C# para autenticar utilizador

```csharp
using MySqlConnector;

public Usuario AutenticarUsuario(string utilizador, string password)
{
    string connectionString =
        "Server=localhost;Port=3306;Database=escola;User ID=root;Password=sua_senha;";

    using var conexao = new MySqlConnection(connectionString);
    conexao.Open();

    string sql = @"
        SELECT 
            id_usuario,
            nome,
            email,
            activo,
            role,
            utilizador
        FROM usuario
        WHERE utilizador = @utilizador
          AND password = @password
          AND activo = TRUE;";

    using var comando = new MySqlCommand(sql, conexao);

    comando.Parameters.AddWithValue("@utilizador", utilizador);
    comando.Parameters.AddWithValue("@password", password);

    using var reader = comando.ExecuteReader();

    if (reader.Read())
    {
        return new Usuario(
            reader.GetInt32("id_usuario"),
            reader.GetString("nome"),
            reader.GetString("email"),
            reader.GetBoolean("activo"),
            reader.GetString("role"),
            reader.GetString("utilizador")
        );
    }

    return null;
}
```

---

## Modelo relacional actualizado

Com a inclusão da classe `Usuario`, o modelo passa a ter a seguinte estrutura:

```text
Pessoa
------
id_pessoa PK
nome
idade

Estudante
---------
id_estudante PK
id_pessoa FK UNIQUE
mec UNIQUE
curso

Professor
---------
id_professor PK
id_pessoa FK UNIQUE
nif UNIQUE
area_especialidade

Disciplina
----------
id_disciplina PK
nome
codigo UNIQUE
carga_horaria
id_professor FK

Matricula
---------
id_matricula PK
id_estudante FK
id_disciplina FK
estado
data_matricula
UNIQUE(id_estudante, id_disciplina)

Usuario
-------
id_usuario PK
nome
email UNIQUE
activo
role
utilizador UNIQUE
password
```

---

## Script completo actualizado

```sql
CREATE DATABASE IF NOT EXISTS escola
CHARACTER SET utf8mb4
COLLATE utf8mb4_unicode_ci;

USE escola;

CREATE TABLE IF NOT EXISTS pessoa (
    id_pessoa INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    idade INT NOT NULL,

    CONSTRAINT chk_pessoa_idade 
        CHECK (idade >= 0)
);

CREATE TABLE IF NOT EXISTS estudante (
    id_estudante INT AUTO_INCREMENT PRIMARY KEY,
    id_pessoa INT NOT NULL,
    mec VARCHAR(30) NOT NULL,
    curso VARCHAR(100) NOT NULL,

    CONSTRAINT uq_estudante_pessoa 
        UNIQUE (id_pessoa),

    CONSTRAINT uq_estudante_mec 
        UNIQUE (mec),

    CONSTRAINT fk_estudante_pessoa
        FOREIGN KEY (id_pessoa)
        REFERENCES pessoa(id_pessoa)
        ON UPDATE CASCADE
        ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS professor (
    id_professor INT AUTO_INCREMENT PRIMARY KEY,
    id_pessoa INT NOT NULL,
    nif VARCHAR(30) NOT NULL,
    area_especialidade VARCHAR(100) NOT NULL,

    CONSTRAINT uq_professor_pessoa 
        UNIQUE (id_pessoa),

    CONSTRAINT uq_professor_nif 
        UNIQUE (nif),

    CONSTRAINT fk_professor_pessoa
        FOREIGN KEY (id_pessoa)
        REFERENCES pessoa(id_pessoa)
        ON UPDATE CASCADE
        ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS disciplina (
    id_disciplina INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    codigo VARCHAR(30) NOT NULL,
    carga_horaria INT NOT NULL,
    id_professor INT NOT NULL,

    CONSTRAINT uq_disciplina_codigo 
        UNIQUE (codigo),

    CONSTRAINT chk_disciplina_carga_horaria 
        CHECK (carga_horaria > 0),

    CONSTRAINT fk_disciplina_professor
        FOREIGN KEY (id_professor)
        REFERENCES professor(id_professor)
        ON UPDATE CASCADE
        ON DELETE RESTRICT
);

CREATE TABLE IF NOT EXISTS matricula (
    id_matricula INT AUTO_INCREMENT PRIMARY KEY,
    id_estudante INT NOT NULL,
    id_disciplina INT NOT NULL,
    estado ENUM('Activa', 'Cancelada', 'Concluída', 'Reprovada') NOT NULL DEFAULT 'Activa',
    data_matricula DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,

    CONSTRAINT uq_matricula_estudante_disciplina 
        UNIQUE (id_estudante, id_disciplina),

    CONSTRAINT fk_matricula_estudante
        FOREIGN KEY (id_estudante)
        REFERENCES estudante(id_estudante)
        ON UPDATE CASCADE
        ON DELETE RESTRICT,

    CONSTRAINT fk_matricula_disciplina
        FOREIGN KEY (id_disciplina)
        REFERENCES disciplina(id_disciplina)
        ON UPDATE CASCADE
        ON DELETE RESTRICT
);

CREATE TABLE IF NOT EXISTS usuario (
    id_usuario INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(150) NOT NULL,
    activo BOOLEAN NOT NULL DEFAULT TRUE,
    role ENUM('Administrador', 'Professor', 'Estudante', 'Secretaria') NOT NULL,
    utilizador VARCHAR(50) NOT NULL,
    password VARCHAR(255) NOT NULL,

    CONSTRAINT uq_usuario_email 
        UNIQUE (email),

    CONSTRAINT uq_usuario_utilizador 
        UNIQUE (utilizador)
);
```
