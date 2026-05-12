-- phpMyAdmin SQL Dump
-- version 5.2.3
-- https://www.phpmyadmin.net/
--
-- Host: db
-- Tempo de geração: 12-Maio-2026 às 18:36
-- Versão do servidor: 8.4.8
-- versão do PHP: 8.3.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de dados: `meubanco`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `disciplina`
--

CREATE TABLE `disciplina` (
  `id_disciplina` int NOT NULL,
  `nome` varchar(100) NOT NULL,
  `codigo` varchar(30) NOT NULL,
  `carga_horaria` int NOT NULL,
  `id_professor` int NOT NULL
) ;

--
-- Extraindo dados da tabela `disciplina`
--

INSERT INTO `disciplina` (`id_disciplina`, `nome`, `codigo`, `carga_horaria`, `id_professor`) VALUES
(2, 'Programação I', 'PROG-I', 80, 2),
(3, 'Matemática', 'mat', 35, 3),
(4, 'Fisica', 'FIS', 60, 3),
(5, 'Linguagem VIII', 'LVIII', 45, 5),
(6, 'Base da Dados III', 'BDIII', 60, 5);

-- --------------------------------------------------------

--
-- Estrutura da tabela `estudante`
--

CREATE TABLE `estudante` (
  `id_estudante` int NOT NULL,
  `id_pessoa` int NOT NULL,
  `mec` varchar(30) NOT NULL,
  `curso` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `estudante`
--

INSERT INTO `estudante` (`id_estudante`, `id_pessoa`, `mec`, `curso`) VALUES
(1, 1, '2024001', 'Engenharia Informática'),
(2, 4, '23423', 'Informática');

-- --------------------------------------------------------

--
-- Estrutura da tabela `matricula`
--

CREATE TABLE `matricula` (
  `id_matricula` int NOT NULL,
  `id_estudante` int NOT NULL,
  `id_disciplina` int NOT NULL,
  `estado` enum('Activa','Cancelada','Concluída','Reprovada') NOT NULL DEFAULT 'Activa',
  `data_matricula` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `matricula`
--

INSERT INTO `matricula` (`id_matricula`, `id_estudante`, `id_disciplina`, `estado`, `data_matricula`) VALUES
(1, 1, 2, 'Activa', '2026-05-12 10:49:43');

-- --------------------------------------------------------

--
-- Estrutura da tabela `pessoa`
--

CREATE TABLE `pessoa` (
  `id_pessoa` int NOT NULL,
  `nome` varchar(100) NOT NULL,
  `idade` int NOT NULL
) ;

--
-- Extraindo dados da tabela `pessoa`
--

INSERT INTO `pessoa` (`id_pessoa`, `nome`, `idade`) VALUES
(1, 'João Manuel', 22),
(2, 'António Manuel', 45),
(3, 'António Manuel', 45),
(4, 'Joaquim João', 45),
(5, 'Fernanda Marcos', 34),
(6, 'Amaral Peter', 34),
(7, 'Adilson Pedro', 23);

-- --------------------------------------------------------

--
-- Estrutura da tabela `professor`
--

CREATE TABLE `professor` (
  `id_professor` int NOT NULL,
  `id_pessoa` int NOT NULL,
  `nif` varchar(30) NOT NULL,
  `area_especialidade` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `professor`
--

INSERT INTO `professor` (`id_professor`, `id_pessoa`, `nif`, `area_especialidade`) VALUES
(2, 3, '123456789LA041', 'Bases de Dados'),
(3, 5, '345632', 'IA'),
(4, 6, '4355436', 'Enfermagem'),
(5, 7, '49873484', 'Software');

-- --------------------------------------------------------

--
-- Estrutura da tabela `utilizadores`
--

CREATE TABLE `utilizadores` (
  `id` int NOT NULL,
  `nome` varchar(100) NOT NULL,
  `usuario` varchar(50) NOT NULL,
  `email` varchar(150) NOT NULL,
  `password_hash` varchar(255) NOT NULL,
  `role` varchar(25) NOT NULL,
  `activo` tinyint(1) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `utilizadores`
--

INSERT INTO `utilizadores` (`id`, `nome`, `usuario`, `email`, `password_hash`, `role`, `activo`) VALUES
(1, 'João Ventura Peter', 'joao', 'joao1@gmail.com', '$2a$11$rQgx6frJTaAVNGD6zY3C5.w9wM861xLvQPKfSW5aGJpq2Lmk1O.NO', 'Administrador', 1),
(2, 'Ventura João Nsaku', 'ventura', 'ventura@gmail.com', '$2a$11$itLUgMT0Lh4WLvWvPpKVnuMWFoBhQGX5jmYgy3JCDBz.ZNSoPxqM2', 'Estudante', 1),
(3, 'Pedro Teca', 'pedro', 'pedro@gmail.com', '$2a$11$LCrN4Ek2.EQAq3lbj4grYO9Cwo.PPoOepOfus/y9gsYVrXAGCbLue', 'Estudante', 1),
(4, 'Adelina Ventura', 'anny', 'anny@gmail.com', '$2a$11$U6uzrgMy7gVMWGMJeCI1VOnuz5GNML7nvpBeZzC9kGB3oNzKAIvTK', 'Administrador', 1),
(5, 'Conceição Teca', 'sao', 'sao@gmail.com', '$2a$11$lwPiArEwQs5vj3Q7izXvfOVSs0K1IDP3n9uuXVtoK2Q94CxY3pV7O', 'Estudante', 1),
(8, 'Celestina Pedro', 'celestina', 'celestina@gmail.com', '$2a$11$5V5kctZk9IZww/8CQyVYxud3iaHdtRC90bXy/ilHxv/2TGULVv0Fi', 'Estudante', 1),
(9, 'Alcides Pedro', 'alcides', 'alcides@gmail.com', '$2a$11$QMgAfbrzzto9Y4xwhTAhpOAY2xKocQKRUHgem5SJNQoeq/KV32VJi', 'Professor', 1);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `disciplina`
--
ALTER TABLE `disciplina`
  ADD PRIMARY KEY (`id_disciplina`),
  ADD UNIQUE KEY `uq_disciplina_codigo` (`codigo`),
  ADD KEY `fk_disciplina_professor` (`id_professor`);

--
-- Índices para tabela `estudante`
--
ALTER TABLE `estudante`
  ADD PRIMARY KEY (`id_estudante`),
  ADD UNIQUE KEY `uq_estudante_pessoa` (`id_pessoa`),
  ADD UNIQUE KEY `uq_estudante_mec` (`mec`);

--
-- Índices para tabela `matricula`
--
ALTER TABLE `matricula`
  ADD PRIMARY KEY (`id_matricula`),
  ADD UNIQUE KEY `uq_matricula_estudante_disciplina` (`id_estudante`,`id_disciplina`),
  ADD KEY `fk_matricula_disciplina` (`id_disciplina`);

--
-- Índices para tabela `pessoa`
--
ALTER TABLE `pessoa`
  ADD PRIMARY KEY (`id_pessoa`);

--
-- Índices para tabela `professor`
--
ALTER TABLE `professor`
  ADD PRIMARY KEY (`id_professor`),
  ADD UNIQUE KEY `uq_professor_pessoa` (`id_pessoa`),
  ADD UNIQUE KEY `uq_professor_nif` (`nif`);

--
-- Índices para tabela `utilizadores`
--
ALTER TABLE `utilizadores`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `usuario` (`usuario`),
  ADD UNIQUE KEY `email` (`email`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `disciplina`
--
ALTER TABLE `disciplina`
  MODIFY `id_disciplina` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `estudante`
--
ALTER TABLE `estudante`
  MODIFY `id_estudante` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `matricula`
--
ALTER TABLE `matricula`
  MODIFY `id_matricula` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `pessoa`
--
ALTER TABLE `pessoa`
  MODIFY `id_pessoa` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `professor`
--
ALTER TABLE `professor`
  MODIFY `id_professor` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de tabela `utilizadores`
--
ALTER TABLE `utilizadores`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `disciplina`
--
ALTER TABLE `disciplina`
  ADD CONSTRAINT `fk_disciplina_professor` FOREIGN KEY (`id_professor`) REFERENCES `professor` (`id_professor`) ON DELETE RESTRICT ON UPDATE CASCADE;

--
-- Limitadores para a tabela `estudante`
--
ALTER TABLE `estudante`
  ADD CONSTRAINT `fk_estudante_pessoa` FOREIGN KEY (`id_pessoa`) REFERENCES `pessoa` (`id_pessoa`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limitadores para a tabela `matricula`
--
ALTER TABLE `matricula`
  ADD CONSTRAINT `fk_matricula_disciplina` FOREIGN KEY (`id_disciplina`) REFERENCES `disciplina` (`id_disciplina`) ON DELETE RESTRICT ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_matricula_estudante` FOREIGN KEY (`id_estudante`) REFERENCES `estudante` (`id_estudante`) ON DELETE RESTRICT ON UPDATE CASCADE;

--
-- Limitadores para a tabela `professor`
--
ALTER TABLE `professor`
  ADD CONSTRAINT `fk_professor_pessoa` FOREIGN KEY (`id_pessoa`) REFERENCES `pessoa` (`id_pessoa`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
