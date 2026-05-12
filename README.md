
# Sistema Académico em C# com MySQL

Este projecto implementa um sistema académico simples em **C# Windows Forms** com persistência de dados em **MySQL**.

O modelo contém as seguintes classes principais:

- `Pessoa`
- `Estudante`
- `Professor`
- `Disciplina`
- `Matricula`
- `Usuario`

A estrutura da base de dados foi construída com base nas relações existentes entre essas classes.

---

## 1. Requisitos

Antes de executar o projecto, é necessário ter instalado:

- MySQL Server
- MySQL Workbench ou outro cliente MySQL
- Visual Studio
- .NET SDK
- Pacote NuGet `MySqlConnector`

---

## 2. Instalar o MySqlConnector no projecto C#

No terminal, dentro da pasta do projecto, execute:

```bash
dotnet add package MySqlConnector
```

Ou pelo Visual Studio:

```text
Projecto > Manage NuGet Packages > Browse > MySqlConnector > Install
```

---

## 3. Criar a base de dados

Crie um ficheiro chamado:

```text
database.sql
```

Dentro desse ficheiro, coloque o seguinte script SQL:

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
```

---

## 4. Executar o script no MySQL Workbench

Para criar a base de dados pelo MySQL Workbench:

1. Abra o **MySQL Workbench**.
2. Ligue-se ao servidor MySQL.
3. Abra uma nova janela SQL.
4. Copie o conteúdo do ficheiro `database.sql`.
5. Execute o script.
6. Confirme se a base de dados `escola` foi criada.

Para verificar:

```sql
SHOW DATABASES;
```

Depois:

```sql
USE escola;
SHOW TABLES;
```

O resultado esperado deve mostrar as seguintes tabelas:

```text
pessoa
estudante
professor
disciplina
matricula
```

---

## 5. Executar o script pelo terminal

Também é possível criar a base de dados directamente pelo terminal.

No Windows:

```bash
mysql -u root -p < database.sql
```

Depois será solicitada a palavra-passe do utilizador `root`.

Se o MySQL não estiver configurado no `PATH`, execute o comando dentro da pasta onde está instalado o MySQL, por exemplo:

```bash
cd "C:\Program Files\MySQL\MySQL Server 8.0\bin"
mysql -u root -p < "C:\caminho\do\projecto\database.sql"
```

---

## 6. Inserir dados de teste

Depois de criar as tabelas, pode inserir alguns dados para testar o sistema.

```sql
USE escola;

INSERT INTO pessoa (nome, idade)
VALUES ('João Manuel', 22);

INSERT INTO estudante (id_pessoa, mec, curso)
VALUES (LAST_INSERT_ID(), '2024001', 'Engenharia Informática');

INSERT INTO pessoa (nome, idade)
VALUES ('António Pedro', 45);

INSERT INTO professor (id_pessoa, nif, area_especialidade)
VALUES (LAST_INSERT_ID(), '123456789LA041', 'Bases de Dados');

INSERT INTO disciplina (nome, codigo, carga_horaria, id_professor)
VALUES ('Programação I', 'PROG-I', 80, 1);

INSERT INTO matricula (id_estudante, id_disciplina, estado)
VALUES (1, 1, 'Activa');
```

---

## 7. Consultar os dados inseridos

Para listar estudantes:

```sql
SELECT 
    e.id_estudante,
    p.id_pessoa,
    p.nome,
    p.idade,
    e.mec,
    e.curso
FROM estudante e
INNER JOIN pessoa p ON e.id_pessoa = p.id_pessoa;
```

Para listar professores:

```sql
SELECT 
    pr.id_professor,
    p.id_pessoa,
    p.nome,
    p.idade,
    pr.nif,
    pr.area_especialidade
FROM professor pr
INNER JOIN pessoa p ON pr.id_pessoa = p.id_pessoa;
```

Para listar disciplinas com professores:

```sql
SELECT 
    d.id_disciplina,
    d.nome AS disciplina,
    d.codigo,
    d.carga_horaria,
    p.nome AS professor,
    pr.area_especialidade
FROM disciplina d
INNER JOIN professor pr ON d.id_professor = pr.id_professor
INNER JOIN pessoa p ON pr.id_pessoa = p.id_pessoa;
```

Para listar matrículas:

```sql
SELECT
    m.id_matricula,
    m.estado,
    m.data_matricula,
    pe.nome AS estudante,
    e.mec,
    d.nome AS disciplina,
    d.codigo
FROM matricula m
INNER JOIN estudante e ON m.id_estudante = e.id_estudante
INNER JOIN pessoa pe ON e.id_pessoa = pe.id_pessoa
INNER JOIN disciplina d ON m.id_disciplina = d.id_disciplina;
```

---

## 8. Configurar a ligação no C#

No projecto C#, configure a string de ligação com os dados do seu servidor MySQL:

```csharp
string connectionString =
    "Server=localhost;Port=3306;Database=escola;User ID=root;Password=sua_senha;";
```

Substitua:

```text
sua_senha
```

pela palavra-passe real do seu MySQL.

---

## 9. Testar a ligação ao banco de dados

Exemplo simples para testar se a aplicação consegue ligar-se ao MySQL:

```csharp
using MySqlConnector;
using System;
using System.Windows.Forms;

public void TestarConexao()
{
    string connectionString =
        "Server=localhost;Port=3306;Database=escola;User ID=root;Password=sua_senha;";

    try
    {
        using var conexao = new MySqlConnection(connectionString);
        conexao.Open();

        MessageBox.Show(
            "Ligação ao banco de dados realizada com sucesso.",
            "Sucesso",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
    }
    catch (Exception ex)
    {
        MessageBox.Show(
            "Erro ao ligar ao banco de dados: " + ex.Message,
            "Erro",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        );
    }
}
```

---

## 10. Modelo relacional

A base de dados segue a seguinte estrutura:

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
```

---

## 11. Relações entre as tabelas

### Pessoa e Estudante

```text
Pessoa 1 ─────── 0..1 Estudante
```

Cada estudante é uma pessoa.

### Pessoa e Professor

```text
Pessoa 1 ─────── 0..1 Professor
```

Cada professor é uma pessoa.

### Professor e Disciplina

```text
Professor 1 ─────── N Disciplina
```

Um professor pode leccionar várias disciplinas.

### Estudante e Disciplina

```text
Estudante N ─────── N Disciplina
```

Essa relação é representada pela tabela `matricula`.

---

## 12. Ordem correcta para inserir dados

Devido às chaves estrangeiras, a ordem correcta de inserção é:

1. Inserir em `pessoa`;
2. Inserir em `estudante` ou `professor`;
3. Inserir em `disciplina`;
4. Inserir em `matricula`.

Exemplo:

```text
pessoa -> estudante
pessoa -> professor
professor -> disciplina
estudante + disciplina -> matricula
```

---

## 13. Ordem correcta para eliminar dados

Devido às dependências entre tabelas, a ordem mais segura para eliminar dados é:

1. `matricula`
2. `disciplina`
3. `estudante`
4. `professor`
5. `pessoa`

Exemplo para limpar os dados:

```sql
DELETE FROM matricula;
DELETE FROM disciplina;
DELETE FROM estudante;
DELETE FROM professor;
DELETE FROM pessoa;
```

Se quiser reiniciar os identificadores automáticos:

```sql
ALTER TABLE matricula AUTO_INCREMENT = 1;
ALTER TABLE disciplina AUTO_INCREMENT = 1;
ALTER TABLE estudante AUTO_INCREMENT = 1;
ALTER TABLE professor AUTO_INCREMENT = 1;
ALTER TABLE pessoa AUTO_INCREMENT = 1;
```

---

## 14. Possíveis erros e soluções

### Erro: Access denied for user 'root'@'localhost'

Verifique se a palavra-passe do MySQL está correcta na string de ligação:

```csharp
Password=sua_senha;
```

### Erro: Unknown database 'escola'

A base de dados ainda não foi criada. Execute primeiro o ficheiro:

```text
database.sql
```

### Erro: Cannot add or update a child row

Este erro acontece quando tenta inserir um registo que depende de outro ainda inexistente.

Exemplo: tentar inserir uma `disciplina` com um `id_professor` que não existe.

### Erro: Duplicate entry

Este erro acontece quando tenta repetir valores únicos, como:

- `mec`
- `nif`
- `codigo`
- mesma combinação de `id_estudante` e `id_disciplina`

---

## 15. Executar a aplicação

Depois de criar a base de dados e configurar a string de ligação:

1. Abra o projecto no Visual Studio.
2. Verifique se o pacote `MySqlConnector` está instalado.
3. Confirme a palavra-passe do MySQL na string de ligação.
4. Compile o projecto.
5. Execute a aplicação.
6. Teste as operações de cadastro, consulta, matrícula e listagem.

---

## 16. Observação importante

A base de dados usa uma estratégia relacional para representar a herança entre classes.

No C#:

```csharp
public class Estudante : Pessoa
```

No MySQL:

```text
pessoa
estudante
```

No C#:

```csharp
public class Professor : Pessoa
```

No MySQL:

```text
pessoa
professor
```

Assim, os dados comuns ficam em `pessoa`, enquanto os dados específicos ficam em `estudante` ou `professor`.

---

## 17. Resumo

Este projecto utiliza:

- C# Windows Forms para a interface gráfica;
- MySQL para persistência dos dados;
- MySqlConnector para comunicação entre C# e MySQL;
- modelo relacional com chaves primárias e chaves estrangeiras;
- tabela `matricula` para representar a relação muitos-para-muitos entre estudantes e disciplinas.

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
