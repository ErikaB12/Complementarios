-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: simpson
-- ------------------------------------------------------
-- Server version	5.7.18-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `episodio`
--

DROP TABLE IF EXISTS `episodio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `episodio` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Titulo` text NOT NULL,
  `Descripcion` text NOT NULL,
  `IdTemporada` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `FK_IdTemporada_idx` (`IdTemporada`),
  CONSTRAINT `FK_IdTemporada` FOREIGN KEY (`IdTemporada`) REFERENCES `temporada` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `episodio`
--

LOCK TABLES `episodio` WRITE;
/*!40000 ALTER TABLE `episodio` DISABLE KEYS */;
INSERT INTO `episodio` VALUES (15,'Simpsons Roasting on an Open Fire','Llamado Especial de Navidad de Los Simpson en Hispanoamérica y Sin blanca Navidad en España, es el primer episodio de la primera temporada y el inicio de la serie de televisión de dibujos animados Los Simpson; emitido originalmente el 17 de diciembre de 1989. Fue escrito por Mimi Pond y dirigido por David Silverman.',1),(16,'Bart the Genius','Bart Simpson experimenta una vida como genio luego de hacer trampa en un test de inteligencia. Al haber sido el segundo episodio en producirse, luego de la mala calidad de la animación de Some Enchanted Evening, el futuro de la serie dependió de este episodio.​ La animación fue más aceptable, por lo que el programa continuó emitiéndose.',1),(17,'Homer\'s Oddysey','Es el tercer episodio de la primera temporada de la serie animada de televisión Los Simpson, emitido originalmente el 21 de enero de 1990. El episodio fue escrito por Jay Kogen y Wallace Wolodarsky, y dirigido por Wes Archer. ',1),(18,'There\'s No Disgrace Like Home','Es el cuarto episodio de la primera temporada de la serie animada de televisión Los Simpson, emitido originalmente el 28 de enero de 1990. El episodio fue escrito por Al Jean y Mike Reiss, y dirigido por Gregg Vanzo y Kent Buttersworth.',1),(19,'Bart the General','Emitido originalmente el 4 de febrero de 1990. El episodio fue escrito por John Swartzwelder y dirigido por David Silverman.',1),(20,'Every man\'s dream','Episodio 1 de la vigésima séptima temporada. Estrenado el 27 de septiembre de 2015 en la versión original.',27),(21,'Cue Detective','Episodio 2 de la vigésima séptima temporada. Estrenado el 4 de octubre de 2015 en la versión original.',27),(22,'Puffles','Episodio 3 de la vigésima séptima temporada. Estrenado el 11 de octubre de 2015 en la versión original.',27),(23,'Halloween of Horror','Episodio 4 de la vigésima séptima temporada. Estrenado el 18 de octubre de 2015 en la versión original.',27),(24,'Treehouse of Horror XXVI','Episodio 5 de la vigésima séptima temporada. Estrenado el 25 de octubre de 2015 en la versión original.',27),(25,'Treehouse of Horror XIII','Episodio 1 de la decimocuarta temporada. Estrenado el 3 de noviembre de 2002 en la versión original.',14),(26,'How I spent my Strummer Vacation','Episodio 2 de la decimocuarta temporada. Estrenado el 10 de noviembre de 2002 en la versión original.',14),(27,'Bart vs. Lisa vs. the Third Grade','Episodio 3 de la decimocuarta temporada. Estrenado el 17 de noviembre de 2002 en la versión original.',14),(28,'Large Marge','Episodio 4 de la decimocuarta temporada. Estrenado el 24 de noviembre de 2002 en la versión original.',14),(29,'Helter Shelter','Episodio 5 de la decimocuarta temporada. Estrenado el 1 de diciembre de 2002 en la versión original.',14),(30,'The Winter of Our Monetized Content','Episodio 1 de la trigésima primera temporada. Estrenado el 29 de septiembre de 2019 en la versión original.',31),(31,'Go Big or Go Hommer','Episodio 2 de la trigésima primera temporada. Estrenado el 6 de octubre de 2019 en la versión original',31),(32,'The Flat Blue Line','Episodio 3 de la trigésima primera temporada. Estrenado el 13 de octubre de 2019 en la versión original.',31),(33,'Treehouse of Horror XXX','Episodio 4 de la trigésima primera temporada. Estrenado el 20 de octubre de 2019 en la versión original.',31),(34,'Gorrillas on the Mast','Episodio 5 de la trigésima primera temporada. Estrenado el 3 de noviembre de 2019 en la versión original.',31);
/*!40000 ALTER TABLE `episodio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `temporada`
--

DROP TABLE IF EXISTS `temporada`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `temporada` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Temporada` varchar(25) NOT NULL,
  `FechaEstreno` text NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `temporada`
--

LOCK TABLES `temporada` WRITE;
/*!40000 ALTER TABLE `temporada` DISABLE KEYS */;
INSERT INTO `temporada` VALUES (1,'Temporada 1','1989-1990'),(2,'Temporada 2','1990-1991'),(3,'Temporada 3','1991-1992'),(4,'Temporada 4','1992-1993'),(5,'Temporada 5','1994-1995'),(6,'Temporada 6','1995-1996'),(7,'Temporada 7','1996-1997'),(8,'Temporada 8','1997-1998'),(9,'Temporada 9','1998-1999'),(10,'Temporada 10','1999-2000'),(11,'Temporada 11','2000-2001'),(12,'Temporada 12','2002-2003'),(13,'Temporada 13','2003-2004'),(14,'Temporada 14','2004-2005'),(15,'Temporada 15','2005-2006'),(16,'Temporada 16','2006-2007'),(17,'Temporada 17','2007-2008'),(18,'Temporada 18','2009-2010'),(19,'Temporada 19','2011-2012'),(20,'Temporada 20','2012-2013'),(21,'Temporada 21','2013-2014'),(22,'Temporada 22','2014-2015'),(23,'Temporada 23','2015-2016'),(24,'Temporada 24','2016-2017'),(25,'Temporada 25','2018-2019'),(26,'Temporada 26','2019-2020'),(27,'Temporada 27','2015-2016'),(28,'Temporada 28','2016-2017'),(29,'Temporada 29','2017-2018'),(30,'Temporada 30','2018-2019'),(31,'Temporada 31','2019-2020'),(32,'Temporada 32','2020-2021');
/*!40000 ALTER TABLE `temporada` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-12-28 20:43:42
