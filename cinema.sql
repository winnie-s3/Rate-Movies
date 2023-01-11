-- MySQL dump 10.13  Distrib 8.0.31, for Win64 (x86_64)
--
-- Host: localhost    Database: cinema
-- ------------------------------------------------------
-- Server version	8.0.31

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `diretor`
--

DROP TABLE IF EXISTS `diretor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `diretor` (
  `diretor_id` int NOT NULL AUTO_INCREMENT,
  `diretor_nome` varchar(200) NOT NULL,
  PRIMARY KEY (`diretor_id`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `diretor`
--

LOCK TABLES `diretor` WRITE;
/*!40000 ALTER TABLE `diretor` DISABLE KEYS */;
INSERT INTO `diretor` VALUES (1,'Damien Leone'),(2,'Parker Finn'),(3,'Jordan Peele'),(4,'William Brent Bell'),(5,'Olivia Wilde'),(6,'Kevin Ko'),(7,'Gina Prince-Bythewood'),(8,'David Leitch'),(9,'Mike Burns'),(10,'Taika Waititi'),(11,'Ryan Coogler'),(12,'Jaume Collet-Serra'),(13,'Michael Grandage'),(14,'Castille Landon'),(15,'D. J. Caruso'),(16,'Carrie Cracknell'),(17,'Brandon Camp'),(18,'Elizabeth Allen Rosenbaum'),(19,'Iris Shim'),(20,'Andrew Semans'),(21,'Kim Farrant'),(22,'Tate Taylor'),(23,'Aneesh Chaganty'),(24,'Jason Reitman'),(25,'John Hamburg'),(26,'Jeff Tomsic'),(27,'Rawson Marshall Thurber'),(28,'Tim Story');
/*!40000 ALTER TABLE `diretor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `filme`
--

DROP TABLE IF EXISTS `filme`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `filme` (
  `filme_id` int NOT NULL AUTO_INCREMENT,
  `filme_nome` varchar(200) NOT NULL,
  `filme_ano` int NOT NULL,
  `filme_genero` varchar(100) NOT NULL,
  `diretor_id` int DEFAULT NULL,
  PRIMARY KEY (`filme_id`),
  KEY `diretor_id_idx` (`diretor_id`),
  CONSTRAINT `diretor_id` FOREIGN KEY (`diretor_id`) REFERENCES `diretor` (`diretor_id`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `filme`
--

LOCK TABLES `filme` WRITE;
/*!40000 ALTER TABLE `filme` DISABLE KEYS */;
INSERT INTO `filme` VALUES (1,'Terrifier 2',2022,'terror',1),(2,'Sorria',2022,'terror',2),(3,'Não! Não Olhe!',2022,'terror',3),(4,'Órfã 2: A Origem',2022,'terror',4),(5,'Não Se Preocupe, Querida',2022,'terror',5),(6,'Marcas da Maldição',2022,'terror',6),(7,'A Mulher Rei',2022,'ação',7),(8,'Trem-Bala',2022,'ação',8),(9,'No lugar errado',2022,'ação',9),(10,'Thor Amor e Trovão',2022,'ação',10),(11,'Pantera Negra: Wakanda Para Sempre',2022,'ação',11),(12,'Adão Negro',2022,'ação',12),(13,'My Policeman',2022,'drama',13),(14,'After - Depois da Promessa',2022,'drama',14),(15,'Amor de Redenção',2022,'drama',15),(16,'Persuasão',2022,'drama',16),(17,'Amor & Gelato',2022,'drama',17),(18,'Continência ao Amor',2022,'drama',18),(19,'Umma',2022,'suspense',19),(20,'Resurrection',2022,'suspense',20),(21,'Naquele Fim de Semana',2022,'suspense',21),(22,'Ma',2019,'suspense',22),(23,'Fuja',2020,'suspense',23),(24,'Buscando...',2018,'suspense',23),(25,'Ghostbusters - Mais Além',2021,'comédia',24),(26,'De Férias da Família',2022,'comédia',25),(27,'Te Peguei!',2018,'comédia',26),(28,'Central de Inteligência',2016,'comédia',27),(29,'Alerta Vermelho',2021,'comédia',27),(30,'Policial em Apuros 2',2016,'comédia',28);
/*!40000 ALTER TABLE `filme` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `usuario_id` int NOT NULL AUTO_INCREMENT,
  `usuario_nome` varchar(200) NOT NULL,
  `usuario_email` varchar(200) NOT NULL,
  `usuario_senha` varchar(200) NOT NULL,
  PRIMARY KEY (`usuario_id`),
  UNIQUE KEY `usuario_email_UNIQUE` (`usuario_email`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'winnie','winnie@gmail.com','winnie3003'),(2,'s','s','s');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-11-29 22:11:00
