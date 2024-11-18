-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 18-Nov-2024 às 13:13
-- Versão do servidor: 10.4.22-MariaDB
-- versão do PHP: 8.1.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `blossommakeup`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `administra`
--

CREATE TABLE `administra` (
  `FK_funcionario_codigo` int(11) DEFAULT NULL,
  `FK_funcionario_codigo_` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
--

CREATE TABLE `cliente` (
  `nome` varchar(255) DEFAULT NULL,
  `cpf` varchar(255) DEFAULT NULL,
  `telefone` varchar(255) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `codigo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cliente`
--

INSERT INTO `cliente` (`nome`, `cpf`, `telefone`, `email`, `codigo`) VALUES
('isabela leme cruz', '63309449033', '19998030777', 'kkkkkk@gmail.com', 1),
('[value-1]', '[value-2]', '[value-3]', '[value-4]', 2);

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionario`
--

CREATE TABLE `funcionario` (
  `cpf` varchar(255) DEFAULT NULL,
  `salario` varchar(255) DEFAULT NULL,
  `cep` varchar(255) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `codigo` int(11) NOT NULL,
  `nome` varchar(255) DEFAULT NULL,
  `numeroCasa` varchar(255) DEFAULT NULL,
  `FK_venda_codigo` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `funcionario`
--

INSERT INTO `funcionario` (`cpf`, `salario`, `cep`, `email`, `codigo`, `nome`, `numeroCasa`, `FK_venda_codigo`) VALUES
('39590033075', '2000', '13002909', 'kkkkkk@gmail.com', 1, 'luisa silveira da silva', '42', NULL);

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionariocliente`
--

CREATE TABLE `funcionariocliente` (
  `FK_funcionario_codigo` int(11) DEFAULT NULL,
  `FK_cliente_codigo` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionarioproduto`
--

CREATE TABLE `funcionarioproduto` (
  `FK_funcionario_codigo` int(11) DEFAULT NULL,
  `FK_produto_codigo` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `marca`
--

CREATE TABLE `marca` (
  `codigo` int(11) NOT NULL,
  `nome` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `marca`
--

INSERT INTO `marca` (`codigo`, `nome`) VALUES
(1, 'mari maria makeup');

-- --------------------------------------------------------

--
-- Estrutura da tabela `produto`
--

CREATE TABLE `produto` (
  `codigo` int(11) NOT NULL,
  `preco` int(11) DEFAULT NULL,
  `quantidade` int(11) DEFAULT NULL,
  `FK_tipo_codigo` int(11) DEFAULT NULL,
  `FK_marca_codigo` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `produto`
--

INSERT INTO `produto` (`codigo`, `preco`, `quantidade`, `FK_tipo_codigo`, `FK_marca_codigo`) VALUES
(1, 23, 6, 1, 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tipo`
--

CREATE TABLE `tipo` (
  `codigo` int(11) NOT NULL,
  `nome` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tipo`
--

INSERT INTO `tipo` (`codigo`, `nome`) VALUES
(1, 'máscara de cílios'),
(2, '[value-2]');

-- --------------------------------------------------------

--
-- Estrutura da tabela `venda`
--

CREATE TABLE `venda` (
  `codigo` int(11) NOT NULL,
  `funcionario` varchar(255) DEFAULT NULL,
  `produtos` varchar(255) DEFAULT NULL,
  `cliente` varchar(255) DEFAULT NULL,
  `valor` int(11) DEFAULT NULL,
  `FK_cliente_codigo` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `vendaproduto`
--

CREATE TABLE `vendaproduto` (
  `FK_produto_codigo` int(11) DEFAULT NULL,
  `FK_venda_codigo` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `administra`
--
ALTER TABLE `administra`
  ADD KEY `FK_administra_0` (`FK_funcionario_codigo`),
  ADD KEY `FK_administra_1` (`FK_funcionario_codigo_`);

--
-- Índices para tabela `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`codigo`);

--
-- Índices para tabela `funcionario`
--
ALTER TABLE `funcionario`
  ADD PRIMARY KEY (`codigo`),
  ADD KEY `FK_funcionario_1` (`FK_venda_codigo`);

--
-- Índices para tabela `funcionariocliente`
--
ALTER TABLE `funcionariocliente`
  ADD KEY `FK_funcionarioCliente_0` (`FK_funcionario_codigo`),
  ADD KEY `FK_funcionarioCliente_1` (`FK_cliente_codigo`);

--
-- Índices para tabela `funcionarioproduto`
--
ALTER TABLE `funcionarioproduto`
  ADD KEY `FK_funcionarioProduto_0` (`FK_funcionario_codigo`),
  ADD KEY `FK_funcionarioProduto_1` (`FK_produto_codigo`);

--
-- Índices para tabela `marca`
--
ALTER TABLE `marca`
  ADD PRIMARY KEY (`codigo`);

--
-- Índices para tabela `produto`
--
ALTER TABLE `produto`
  ADD PRIMARY KEY (`codigo`),
  ADD KEY `FK_produto_1` (`FK_tipo_codigo`),
  ADD KEY `FK_produto_2` (`FK_marca_codigo`);

--
-- Índices para tabela `tipo`
--
ALTER TABLE `tipo`
  ADD PRIMARY KEY (`codigo`);

--
-- Índices para tabela `venda`
--
ALTER TABLE `venda`
  ADD PRIMARY KEY (`codigo`),
  ADD KEY `FK_venda_1` (`FK_cliente_codigo`);

--
-- Índices para tabela `vendaproduto`
--
ALTER TABLE `vendaproduto`
  ADD KEY `FK_vendaProduto_0` (`FK_produto_codigo`),
  ADD KEY `FK_vendaProduto_1` (`FK_venda_codigo`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cliente`
--
ALTER TABLE `cliente`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `funcionario`
--
ALTER TABLE `funcionario`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `marca`
--
ALTER TABLE `marca`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `produto`
--
ALTER TABLE `produto`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `tipo`
--
ALTER TABLE `tipo`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `venda`
--
ALTER TABLE `venda`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `administra`
--
ALTER TABLE `administra`
  ADD CONSTRAINT `FK_administra_0` FOREIGN KEY (`FK_funcionario_codigo`) REFERENCES `funcionario` (`codigo`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_administra_1` FOREIGN KEY (`FK_funcionario_codigo_`) REFERENCES `funcionario` (`codigo`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limitadores para a tabela `funcionario`
--
ALTER TABLE `funcionario`
  ADD CONSTRAINT `FK_funcionario_1` FOREIGN KEY (`FK_venda_codigo`) REFERENCES `venda` (`codigo`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limitadores para a tabela `funcionariocliente`
--
ALTER TABLE `funcionariocliente`
  ADD CONSTRAINT `FK_funcionarioCliente_0` FOREIGN KEY (`FK_funcionario_codigo`) REFERENCES `funcionario` (`codigo`),
  ADD CONSTRAINT `FK_funcionarioCliente_1` FOREIGN KEY (`FK_cliente_codigo`) REFERENCES `cliente` (`codigo`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Limitadores para a tabela `funcionarioproduto`
--
ALTER TABLE `funcionarioproduto`
  ADD CONSTRAINT `FK_funcionarioProduto_0` FOREIGN KEY (`FK_funcionario_codigo`) REFERENCES `funcionario` (`codigo`),
  ADD CONSTRAINT `FK_funcionarioProduto_1` FOREIGN KEY (`FK_produto_codigo`) REFERENCES `produto` (`codigo`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Limitadores para a tabela `produto`
--
ALTER TABLE `produto`
  ADD CONSTRAINT `FK_produto_1` FOREIGN KEY (`FK_tipo_codigo`) REFERENCES `tipo` (`codigo`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_produto_2` FOREIGN KEY (`FK_marca_codigo`) REFERENCES `marca` (`codigo`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limitadores para a tabela `venda`
--
ALTER TABLE `venda`
  ADD CONSTRAINT `FK_venda_1` FOREIGN KEY (`FK_cliente_codigo`) REFERENCES `cliente` (`codigo`);

--
-- Limitadores para a tabela `vendaproduto`
--
ALTER TABLE `vendaproduto`
  ADD CONSTRAINT `FK_vendaProduto_0` FOREIGN KEY (`FK_produto_codigo`) REFERENCES `produto` (`codigo`),
  ADD CONSTRAINT `FK_vendaProduto_1` FOREIGN KEY (`FK_venda_codigo`) REFERENCES `venda` (`codigo`) ON DELETE SET NULL ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
