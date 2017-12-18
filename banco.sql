-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.0.85-community-nt


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema bms
--

CREATE DATABASE IF NOT EXISTS bms;
USE bms;

--
-- Definition of table `cargos`
--

DROP TABLE IF EXISTS `cargos`;
CREATE TABLE `cargos` (
  `CAR_CODIGO_ID` int(10) unsigned NOT NULL auto_increment,
  `CAR_NOME` varchar(255) NOT NULL,
  PRIMARY KEY  (`CAR_CODIGO_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `cargos`
--

/*!40000 ALTER TABLE `cargos` DISABLE KEYS */;
INSERT INTO `cargos` (`CAR_CODIGO_ID`,`CAR_NOME`) VALUES 
 (1,'ADMINISTRADOR'),
 (2,'GERENTE'),
 (3,'SUPERVISOR'),
 (4,'VENDEDOR'),
 (5,'OPERADOR DE CAIXA');
/*!40000 ALTER TABLE `cargos` ENABLE KEYS */;


--
-- Definition of table `empresa`
--

DROP TABLE IF EXISTS `empresa`;
CREATE TABLE `empresa` (
  `EMP_CODIGO_ID` int(10) unsigned NOT NULL auto_increment,
  `EMP_NOME_REDUZIDO` varchar(50) default NULL,
  `EMP_NOME_FANTASIA` varchar(255) default NULL,
  `EMP_RAZAO_SOCIAL` varchar(255) default NULL,
  `EMP_CNPJ` varchar(14) default NULL,
  `EMP_ENDERECO` varchar(100) default NULL,
  `EMP_NUMERO` varchar(5) default NULL,
  `EMP_BAIRRO` varchar(100) default NULL,
  `EMP_CODIGO_CIDADE_ID` int(10) unsigned default NULL,
  `EMP_UF` varchar(2) default NULL,
  `EMP_CEP` varchar(9) default NULL,
  `EMP_LOGO` varchar(255) default NULL,
  PRIMARY KEY  (`EMP_CODIGO_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `empresa`
--

/*!40000 ALTER TABLE `empresa` DISABLE KEYS */;
INSERT INTO `empresa` (`EMP_CODIGO_ID`,`EMP_NOME_REDUZIDO`,`EMP_NOME_FANTASIA`,`EMP_RAZAO_SOCIAL`,`EMP_CNPJ`,`EMP_ENDERECO`,`EMP_NUMERO`,`EMP_BAIRRO`,`EMP_CODIGO_CIDADE_ID`,`EMP_UF`,`EMP_CEP`,`EMP_LOGO`) VALUES 
 (1,'HCELL MANUTENÇÕES','HCELL MANUTENÇÕES','HENRIQUE SILVA GONÇALVES 1230594645789','00000000000000','RUA SANTO ANTONIO','104','ROÇA GRANDE',0,'MG','34545780',NULL);
/*!40000 ALTER TABLE `empresa` ENABLE KEYS */;


--
-- Definition of table `funcionario`
--

DROP TABLE IF EXISTS `funcionario`;
CREATE TABLE `funcionario` (
  `FUNC_CODIGO_ID` int(10) unsigned NOT NULL auto_increment,
  `FUNC_NOME_COMPLETO` varchar(300) NOT NULL,
  `FUNC_CODIGO_CARGO` int(10) unsigned NOT NULL,
  PRIMARY KEY  (`FUNC_CODIGO_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `funcionario`
--

/*!40000 ALTER TABLE `funcionario` DISABLE KEYS */;
INSERT INTO `funcionario` (`FUNC_CODIGO_ID`,`FUNC_NOME_COMPLETO`,`FUNC_CODIGO_CARGO`) VALUES 
 (1,'Administrador',1);
/*!40000 ALTER TABLE `funcionario` ENABLE KEYS */;


--
-- Definition of table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE `usuario` (
  `USU_CODIGO_ID` int(10) unsigned NOT NULL auto_increment,
  `USU_NOME` varchar(255) default NULL,
  `USU_LOGIN` varchar(50) default NULL,
  `USU_SENHA` varchar(20) default NULL,
  `USU_CODIGO_FUNC_ID` int(10) unsigned default NULL,
  PRIMARY KEY  (`USU_CODIGO_ID`),
  UNIQUE KEY `login` (`USU_LOGIN`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `usuario`
--

/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` (`USU_CODIGO_ID`,`USU_NOME`,`USU_LOGIN`,`USU_SENHA`,`USU_CODIGO_FUNC_ID`) VALUES 
 (1,'Italo Angelo','italoangelo13','galoforte2',1);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
