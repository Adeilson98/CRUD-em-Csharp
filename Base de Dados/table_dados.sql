-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 21-Jun-2021 às 03:24
-- Versão do servidor: 10.4.14-MariaDB
-- versão do PHP: 7.2.34

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `table_dados`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `cadastro`
--

CREATE TABLE `cadastro` (
  `ID` int(10) NOT NULL COMMENT 'auto_increment',
  `Nome` varchar(50) NOT NULL,
  `Nascimento` date NOT NULL,
  `Sexo` varchar(15) NOT NULL,
  `RG` varchar(15) NOT NULL,
  `CPF` varchar(15) NOT NULL,
  `Endereco` varchar(100) NOT NULL,
  `Numero` int(10) NOT NULL,
  `Bairro` varchar(20) NOT NULL,
  `CEP` int(10) NOT NULL,
  `Cidade` varchar(20) NOT NULL,
  `Celular` int(15) NOT NULL,
  `Telefone` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `logins`
--

CREATE TABLE `logins` (
  `login` varchar(30) NOT NULL,
  `senha` int(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `logins`
--

INSERT INTO `logins` (`login`, `senha`) VALUES
('zenaide', 12345);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `cadastro`
--
ALTER TABLE `cadastro`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cadastro`
--
ALTER TABLE `cadastro`
  MODIFY `ID` int(10) NOT NULL AUTO_INCREMENT COMMENT 'auto_increment', AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
