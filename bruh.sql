-- MariaDB dump 10.17  Distrib 10.4.11-MariaDB, for Win64 (AMD64)
--
-- Host: 127.0.0.1    Database: project
-- ------------------------------------------------------
-- Server version	10.4.11-MariaDB

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
-- Table structure for table `buy_tour`
--

DROP TABLE IF EXISTS `buy_tour`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `buy_tour` (
  `t_id` varchar(10) NOT NULL,
  `u_id` varchar(45) NOT NULL,
  PRIMARY KEY (`t_id`,`u_id`),
  KEY `fk_tour_has_user_account_user_account1_idx` (`u_id`),
  KEY `fk_tour_has_user_account_tour_idx` (`t_id`),
  CONSTRAINT `fk_tour_has_user_account_tour` FOREIGN KEY (`t_id`) REFERENCES `tour` (`t_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tour_has_user_account_user_account1` FOREIGN KEY (`u_id`) REFERENCES `user_account` (`u_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `buy_tour`
--

LOCK TABLES `buy_tour` WRITE;
/*!40000 ALTER TABLE `buy_tour` DISABLE KEYS */;
INSERT INTO `buy_tour` VALUES ('t001','qwer');
/*!40000 ALTER TABLE `buy_tour` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee`
--

DROP TABLE IF EXISTS `employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `employee` (
  `e_id` varchar(10) NOT NULL,
  `e_name` varchar(45) NOT NULL,
  `tel` varchar(45) NOT NULL,
  `t_id` varchar(10) NOT NULL,
  PRIMARY KEY (`e_id`),
  KEY `fk_employee_tour1_idx` (`t_id`),
  CONSTRAINT `fk_employee_tour1` FOREIGN KEY (`t_id`) REFERENCES `tour` (`t_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee`
--

LOCK TABLES `employee` WRITE;
/*!40000 ALTER TABLE `employee` DISABLE KEYS */;
INSERT INTO `employee` VALUES ('e001','John','044-111111','t001'),('e002','Hector','044-223344','t002'),('e003','Simon','044-333222','t003'),('e004','Sam','044-444333','t004'),('e005','Ink','044-123456','t005'),('e006','Skipper','044-444555','t006'),('e007','Gorge','044-555666','t007'),('e008','Edward','044-333111','t008'),('e009','David','044-555666','t009'),('e010','Jack','044-444444','t010');
/*!40000 ALTER TABLE `employee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tour`
--

DROP TABLE IF EXISTS `tour`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tour` (
  `t_id` varchar(10) NOT NULL,
  `location` varchar(45) NOT NULL,
  `country` varchar(45) NOT NULL,
  `price` int(11) NOT NULL,
  `vehicle` varchar(45) NOT NULL,
  `date_departure` datetime NOT NULL,
  PRIMARY KEY (`t_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tour`
--

LOCK TABLES `tour` WRITE;
/*!40000 ALTER TABLE `tour` DISABLE KEYS */;
INSERT INTO `tour` VALUES ('t001','Beijing','China',30000,'plane','2020-06-05 02:00:00'),('t002','Huairou','China',30000,'plane','2020-06-07 03:30:00'),('t003','Shaanxi','China',35000,'bus','2020-06-10 01:00:00'),('t004','Guangxi','China',25000,'bus','2020-06-15 02:30:00'),('t005','Marina Bay','Singapore',15000,'plane','2020-06-20 03:00:00'),('t006','Supertree Grove','Singapore',15000,'plane','2020-06-22 05:00:00'),('t007','Angkor wat','Cambodia',5000,'bus','2020-07-01 03:45:00'),('t008','Imperial Palace','Japan',16000,'plane','2020-07-03 02:30:00'),('t009','Mount Fuji','Japan',16000,'plane','2020-07-15 03:20:00'),('t010','Osaka','Japan',12000,'plane','2020-07-20 04:00:00');
/*!40000 ALTER TABLE `tour` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user_account`
--

DROP TABLE IF EXISTS `user_account`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user_account` (
  `u_id` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `name` varchar(45) NOT NULL,
  `personal_id` varchar(45) NOT NULL,
  `age` varchar(45) NOT NULL,
  `gender` varchar(45) NOT NULL,
  `tel` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`u_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_account`
--

LOCK TABLES `user_account` WRITE;
/*!40000 ALTER TABLE `user_account` DISABLE KEYS */;
INSERT INTO `user_account` VALUES ('qwer','12345','zxcvb','123456','22','male','22');
/*!40000 ALTER TABLE `user_account` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-05-31 16:44:42
