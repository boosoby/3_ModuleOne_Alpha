-- MySQL dump 10.13  Distrib 8.0.41, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: firstmodule2
-- ------------------------------------------------------
-- Server version	8.0.41

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
-- Table structure for table `client_comment`
--

DROP TABLE IF EXISTS `client_comment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `client_comment` (
  `idclient_comment` int NOT NULL AUTO_INCREMENT,
  `text` varchar(45) DEFAULT NULL,
  `idclients` int DEFAULT NULL,
  PRIMARY KEY (`idclient_comment`),
  CONSTRAINT `idclients7` FOREIGN KEY (`idclient_comment`) REFERENCES `clients` (`idclients`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `client_comment`
--

LOCK TABLES `client_comment` WRITE;
/*!40000 ALTER TABLE `client_comment` DISABLE KEYS */;
INSERT INTO `client_comment` VALUES (1,'Классный человек. Пригласил покушать',1),(2,'Мы с ним лего собирали',4);
/*!40000 ALTER TABLE `client_comment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `client_managers`
--

DROP TABLE IF EXISTS `client_managers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `client_managers` (
  `idclient_managers` int NOT NULL AUTO_INCREMENT,
  `idclients` int DEFAULT NULL,
  `idmanagers` int DEFAULT NULL,
  PRIMARY KEY (`idclient_managers`),
  KEY `idclients_idx` (`idclients`),
  KEY `idmanagers_idx` (`idmanagers`),
  CONSTRAINT `idclients` FOREIGN KEY (`idclients`) REFERENCES `clients` (`idclients`),
  CONSTRAINT `idmanagers` FOREIGN KEY (`idmanagers`) REFERENCES `managers` (`idmanagers`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `client_managers`
--

LOCK TABLES `client_managers` WRITE;
/*!40000 ALTER TABLE `client_managers` DISABLE KEYS */;
INSERT INTO `client_managers` VALUES (1,1,2),(2,2,1),(3,3,1),(6,16,2),(7,15,1);
/*!40000 ALTER TABLE `client_managers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clients`
--

DROP TABLE IF EXISTS `clients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clients` (
  `idclients` int NOT NULL AUTO_INCREMENT,
  `full_name` varchar(45) DEFAULT NULL,
  `idcontact_face` int DEFAULT NULL,
  PRIMARY KEY (`idclients`),
  KEY `fkcontact_face_idx` (`idcontact_face`),
  CONSTRAINT `fkcontact_face` FOREIGN KEY (`idcontact_face`) REFERENCES `contact_face` (`idcontact_face`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clients`
--

LOCK TABLES `clients` WRITE;
/*!40000 ALTER TABLE `clients` DISABLE KEYS */;
INSERT INTO `clients` VALUES (1,'Колесников Богдан Евгеньевич',1),(2,'Крашениников Михаил Фёдорович',2),(3,'Зубенко Михаил Петрович',3),(15,'Красноярский Краскон Антонович',5),(16,'Филармонов Филармон Филыч',5);
/*!40000 ALTER TABLE `clients` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `communication_type`
--

DROP TABLE IF EXISTS `communication_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `communication_type` (
  `idcommunication_type` int NOT NULL AUTO_INCREMENT,
  `type_name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idcommunication_type`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `communication_type`
--

LOCK TABLES `communication_type` WRITE;
/*!40000 ALTER TABLE `communication_type` DISABLE KEYS */;
INSERT INTO `communication_type` VALUES (1,'Звонок'),(2,'Встреча');
/*!40000 ALTER TABLE `communication_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `communications`
--

DROP TABLE IF EXISTS `communications`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `communications` (
  `idcommunications` int NOT NULL AUTO_INCREMENT,
  `idclients` int DEFAULT NULL,
  `idcommunication_type` int DEFAULT NULL,
  `idtext` varchar(200) DEFAULT NULL,
  `date` datetime DEFAULT NULL,
  PRIMARY KEY (`idcommunications`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `communications`
--

LOCK TABLES `communications` WRITE;
/*!40000 ALTER TABLE `communications` DISABLE KEYS */;
INSERT INTO `communications` VALUES (1,1,1,'познакомились и обменялись контактами','2024-06-17 11:37:23'),(2,2,1,'Пригласили друг друга в ресторан','2024-06-17 12:40:23'),(3,1,1,'text','2025-02-17 16:26:13'),(4,1,1,'Сходили во вкусно и точка. Купили ам нямов. Довольны','2025-02-05 16:49:48'),(5,1,2,'Сегодня почиллили','2025-02-17 16:50:44');
/*!40000 ALTER TABLE `communications` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `contact_face`
--

DROP TABLE IF EXISTS `contact_face`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `contact_face` (
  `idcontact_face` int NOT NULL AUTO_INCREMENT,
  `full_name` varchar(45) DEFAULT NULL,
  `contact_data` varchar(45) DEFAULT NULL,
  `job` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idcontact_face`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contact_face`
--

LOCK TABLES `contact_face` WRITE;
/*!40000 ALTER TABLE `contact_face` DISABLE KEYS */;
INSERT INTO `contact_face` VALUES (1,'Особый Борис Витальевич','+79960520304','СММ-менеджер'),(2,'Креативный Иван Антонович','+79233570262','Креативный директор'),(3,'Крутой Антон Тарасович','+79990001323','Креативный директор'),(4,'Андреев Андрей Андреевич','+79029187402','Вице-президент'),(5,'Семаков Антон Андреевич','+79905675909','Маркетолог');
/*!40000 ALTER TABLE `contact_face` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `deal_status`
--

DROP TABLE IF EXISTS `deal_status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `deal_status` (
  `iddeal_status` int NOT NULL AUTO_INCREMENT,
  `status_name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`iddeal_status`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `deal_status`
--

LOCK TABLES `deal_status` WRITE;
/*!40000 ALTER TABLE `deal_status` DISABLE KEYS */;
INSERT INTO `deal_status` VALUES (1,'В процессе'),(2,'Завершено'),(3,'Просрочено'),(4,'Отменено');
/*!40000 ALTER TABLE `deal_status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `deals`
--

DROP TABLE IF EXISTS `deals`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `deals` (
  `iddeals` int NOT NULL AUTO_INCREMENT,
  `date` datetime DEFAULT NULL,
  `amount` int DEFAULT NULL,
  `iddeal_status` int DEFAULT NULL,
  `idclient_managers` int DEFAULT NULL,
  `deals_name` varchar(100) DEFAULT NULL,
  `deals_percent` int DEFAULT NULL,
  `idpay_status` int DEFAULT NULL,
  `pay_date` datetime DEFAULT NULL,
  PRIMARY KEY (`iddeals`),
  KEY `iddeal_status_idx` (`iddeal_status`),
  KEY `idclient_managers_idx` (`idclient_managers`),
  KEY `idpay_status_idx` (`idpay_status`),
  CONSTRAINT `idclient_managers` FOREIGN KEY (`idclient_managers`) REFERENCES `client_managers` (`idclient_managers`),
  CONSTRAINT `iddeal_status` FOREIGN KEY (`iddeal_status`) REFERENCES `deal_status` (`iddeal_status`),
  CONSTRAINT `idpay_status2` FOREIGN KEY (`idpay_status`) REFERENCES `pay_status` (`idpay_status`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `deals`
--

LOCK TABLES `deals` WRITE;
/*!40000 ALTER TABLE `deals` DISABLE KEYS */;
INSERT INTO `deals` VALUES (1,'2025-02-10 10:00:00',500000,2,1,NULL,NULL,2,NULL),(2,'2025-02-10 12:00:00',150000,1,2,NULL,10,2,NULL),(3,'2025-02-10 12:00:00',500000,2,1,NULL,NULL,2,NULL),(4,'2025-02-11 17:27:45',123000,1,1,NULL,NULL,2,NULL),(5,'2025-02-11 17:27:45',12300,1,2,NULL,NULL,2,NULL),(6,'2025-02-15 17:35:27',123123,2,1,'Покупка айфонов',NULL,2,NULL),(7,'2025-02-12 18:22:44',800000,2,1,'Покупка айфонов',40,2,NULL),(8,'2025-02-18 21:48:51',50,1,3,'Чокопайка',50,2,NULL),(9,'2025-02-06 21:51:44',100000,1,2,'Да',NULL,2,NULL),(10,'2025-02-07 21:54:08',70000,2,2,'Бу',NULL,2,NULL),(11,'2025-02-12 22:23:12',700000,2,2,'Ещё один айфон',100,1,NULL),(12,'2025-02-11 22:54:56',50000,1,1,'Айфон Се',50,2,'2025-02-10 16:00:00'),(14,'2025-02-19 00:34:56',100000,1,1,'Биг мани',100,1,NULL),(15,'2025-02-20 22:03:34',50000,1,3,'Еще одна продажа',100,1,NULL),(16,'2025-02-20 22:39:21',50000,1,1,'Всем привет',100,1,'2025-02-10 16:00:00'),(17,'2025-02-06 01:03:41',50000,1,6,'Покупка айфона',NULL,2,'2025-02-10 16:00:00'),(18,'2025-02-01 01:05:01',550000,1,2,'По приколу',NULL,2,'2025-02-10 16:00:00'),(19,'2025-02-22 01:05:40',100,1,6,'По приколу еще раз',NULL,2,'2025-02-10 16:00:00'),(20,'2025-02-22 01:11:17',1000,2,1,'Покупка торта',NULL,2,'2025-02-10 01:11:17'),(21,'2025-02-22 01:21:10',109,1,3,'Виноград',NULL,2,'2025-02-07 11:21:09'),(22,'2025-02-22 01:37:46',1000,1,1,'Так',NULL,2,'2025-02-22 01:37:46'),(23,'2025-02-01 01:38:09',2999,1,1,'Урара',NULL,2,'2025-02-07 01:38:09'),(24,'2025-02-19 02:05:36',34324,1,7,'Буба',100,1,'2025-02-20 02:05:36');
/*!40000 ALTER TABLE `deals` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `files`
--

DROP TABLE IF EXISTS `files`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `files` (
  `idfiles` int NOT NULL AUTO_INCREMENT,
  `logo_path` varchar(45) DEFAULT NULL,
  `sign_path` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idfiles`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `files`
--

LOCK TABLES `files` WRITE;
/*!40000 ALTER TABLE `files` DISABLE KEYS */;
/*!40000 ALTER TABLE `files` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `goods`
--

DROP TABLE IF EXISTS `goods`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `goods` (
  `idgoods` int NOT NULL AUTO_INCREMENT,
  `good_name` varchar(45) DEFAULT NULL,
  `price` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idgoods`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `goods`
--

LOCK TABLES `goods` WRITE;
/*!40000 ALTER TABLE `goods` DISABLE KEYS */;
INSERT INTO `goods` VALUES (1,'Iphone 15','70000'),(2,'Iphone 14','60000'),(3,'Iphone 16','80000'),(4,'Iphone Se 2022','50000');
/*!40000 ALTER TABLE `goods` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `goods_in_deals`
--

DROP TABLE IF EXISTS `goods_in_deals`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `goods_in_deals` (
  `idgoods_in_deals` int NOT NULL AUTO_INCREMENT,
  `quantity` int DEFAULT NULL,
  `idgoods` int DEFAULT NULL,
  `iddeals` int DEFAULT NULL,
  PRIMARY KEY (`idgoods_in_deals`),
  KEY `idgoods_idx` (`idgoods`),
  KEY `iddeals_idx` (`iddeals`),
  CONSTRAINT `iddeals` FOREIGN KEY (`iddeals`) REFERENCES `deals` (`iddeals`),
  CONSTRAINT `idgoods` FOREIGN KEY (`idgoods`) REFERENCES `goods` (`idgoods`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `goods_in_deals`
--

LOCK TABLES `goods_in_deals` WRITE;
/*!40000 ALTER TABLE `goods_in_deals` DISABLE KEYS */;
INSERT INTO `goods_in_deals` VALUES (1,10,4,1),(2,15,1,2),(3,10,3,7),(4,1,1,8),(5,1,1,9),(6,1,1,10),(7,1,1,11),(8,1,4,12),(9,2,4,14),(10,1,4,15),(11,1,4,16),(12,1,4,17),(13,12,4,18),(14,2,1,19),(15,1,1,20),(16,8,1,21),(17,1,2,22),(18,8,1,23),(19,8,1,24);
/*!40000 ALTER TABLE `goods_in_deals` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `managers`
--

DROP TABLE IF EXISTS `managers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `managers` (
  `idmanagers` int NOT NULL AUTO_INCREMENT,
  `full_name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idmanagers`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `managers`
--

LOCK TABLES `managers` WRITE;
/*!40000 ALTER TABLE `managers` DISABLE KEYS */;
INSERT INTO `managers` VALUES (1,'Витас Антон Витальевич'),(2,'Зимбабве Омумба Банджо');
/*!40000 ALTER TABLE `managers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pay_status`
--

DROP TABLE IF EXISTS `pay_status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pay_status` (
  `idpay_status` int NOT NULL AUTO_INCREMENT,
  `status_name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idpay_status`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pay_status`
--

LOCK TABLES `pay_status` WRITE;
/*!40000 ALTER TABLE `pay_status` DISABLE KEYS */;
INSERT INTO `pay_status` VALUES (1,'Оплачено полностью'),(2,'Оплачено не полностью');
/*!40000 ALTER TABLE `pay_status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payment`
--

DROP TABLE IF EXISTS `payment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `payment` (
  `idpayment` int NOT NULL AUTO_INCREMENT,
  `pay_date` datetime DEFAULT NULL,
  `pay_amount` int DEFAULT NULL,
  `pay_percent` int DEFAULT NULL,
  `pay_status` int DEFAULT NULL,
  `iddeals` int DEFAULT NULL,
  `payment_name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idpayment`),
  KEY `pay_status_idx` (`pay_status`),
  KEY `iddeals_idx` (`iddeals`),
  CONSTRAINT `iddeals3` FOREIGN KEY (`iddeals`) REFERENCES `deals` (`iddeals`),
  CONSTRAINT `idpay_status` FOREIGN KEY (`pay_status`) REFERENCES `pay_status` (`idpay_status`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payment`
--

LOCK TABLES `payment` WRITE;
/*!40000 ALTER TABLE `payment` DISABLE KEYS */;
INSERT INTO `payment` VALUES (3,'2025-02-10 10:00:00',500000,100,1,1,NULL),(4,'2025-02-10 13:00:00',15000,100,1,2,NULL),(5,'2025-02-10 14:00:00',1000,77,2,7,NULL),(7,'2025-02-10 16:00:00',NULL,77,2,6,NULL),(8,'2025-02-18 21:48:51',NULL,100,1,8,NULL),(10,'2025-02-18 21:54:08',NULL,100,1,10,NULL),(11,'2025-02-17 22:23:12',NULL,77,2,11,NULL),(12,'2025-02-12 22:54:56',NULL,82,2,12,NULL),(13,'2025-02-20 00:34:56',NULL,77,2,14,NULL),(14,'2025-02-22 22:03:34',NULL,77,2,15,NULL),(15,'2025-02-19 22:39:21',NULL,77,2,16,NULL),(18,'2025-02-22 00:50:20',15000,10,2,2,'Ура'),(19,'2025-02-22 01:01:41',80000,10,2,7,'По приколу'),(20,'2025-02-22 01:02:01',80000,10,2,7,'По приколу'),(21,'2025-02-22 01:02:19',160000,20,2,7,'По приколу 3'),(22,'2025-02-13 01:03:41',NULL,NULL,2,17,NULL),(23,'2025-02-05 01:05:01',NULL,NULL,2,18,NULL),(24,'2025-02-22 01:05:40',NULL,NULL,2,19,NULL),(25,'2025-02-22 02:06:27',45000,100,1,24,'Ьуьа');
/*!40000 ALTER TABLE `payment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `project_status`
--

DROP TABLE IF EXISTS `project_status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `project_status` (
  `idproject_status` int NOT NULL AUTO_INCREMENT,
  `status_name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idproject_status`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `project_status`
--

LOCK TABLES `project_status` WRITE;
/*!40000 ALTER TABLE `project_status` DISABLE KEYS */;
INSERT INTO `project_status` VALUES (1,'В процессе'),(2,'Завершено'),(3,'Отложено'),(4,'Отменено');
/*!40000 ALTER TABLE `project_status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `projects`
--

DROP TABLE IF EXISTS `projects`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `projects` (
  `idprojects` int NOT NULL AUTO_INCREMENT,
  `start_date` datetime DEFAULT NULL,
  `end_date` datetime DEFAULT NULL,
  `idproject_status` int DEFAULT NULL,
  `idclient_managers` int DEFAULT NULL,
  `project_name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idprojects`),
  KEY `idproject_status` (`idproject_status`),
  KEY `idclient_managers_idx` (`idclient_managers`),
  CONSTRAINT `idclient_managers2` FOREIGN KEY (`idclient_managers`) REFERENCES `client_managers` (`idclient_managers`),
  CONSTRAINT `idclient_managers3` FOREIGN KEY (`idclient_managers`) REFERENCES `client_managers` (`idclient_managers`),
  CONSTRAINT `idproject_status` FOREIGN KEY (`idproject_status`) REFERENCES `project_status` (`idproject_status`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `projects`
--

LOCK TABLES `projects` WRITE;
/*!40000 ALTER TABLE `projects` DISABLE KEYS */;
INSERT INTO `projects` VALUES (1,'2025-02-10 10:00:00','2025-03-10 10:00:00',1,1,'Анимация логотипа'),(2,'2025-01-10 10:00:00','2025-02-10 10:00:00',2,2,'Разработка логотипа и айдентики');
/*!40000 ALTER TABLE `projects` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roles` (
  `idroles` int NOT NULL AUTO_INCREMENT,
  `role_name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idroles`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (1,'Админ'),(2,'Руководитель отдела продаж'),(3,'Работник');
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sales_plan`
--

DROP TABLE IF EXISTS `sales_plan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sales_plan` (
  `idsales_plan` int NOT NULL AUTO_INCREMENT,
  `start_date` datetime DEFAULT NULL,
  `end_date` datetime DEFAULT NULL,
  `amount` int DEFAULT NULL,
  `idmanagers` int DEFAULT NULL,
  PRIMARY KEY (`idsales_plan`),
  KEY `idmanagers6_idx` (`idmanagers`),
  CONSTRAINT `idmanagers6` FOREIGN KEY (`idmanagers`) REFERENCES `managers` (`idmanagers`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sales_plan`
--

LOCK TABLES `sales_plan` WRITE;
/*!40000 ALTER TABLE `sales_plan` DISABLE KEYS */;
INSERT INTO `sales_plan` VALUES (1,'2025-01-10 10:00:00','2025-02-10 10:00:00',50000,1);
/*!40000 ALTER TABLE `sales_plan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `task_priorities`
--

DROP TABLE IF EXISTS `task_priorities`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `task_priorities` (
  `idtask_priorities` int NOT NULL AUTO_INCREMENT,
  `priorities_name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idtask_priorities`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `task_priorities`
--

LOCK TABLES `task_priorities` WRITE;
/*!40000 ALTER TABLE `task_priorities` DISABLE KEYS */;
INSERT INTO `task_priorities` VALUES (1,'Обычный'),(2,'Срочный'),(3,'Наиболее срочный');
/*!40000 ALTER TABLE `task_priorities` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `task_status`
--

DROP TABLE IF EXISTS `task_status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `task_status` (
  `idtask_status` int NOT NULL AUTO_INCREMENT,
  `status_name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idtask_status`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `task_status`
--

LOCK TABLES `task_status` WRITE;
/*!40000 ALTER TABLE `task_status` DISABLE KEYS */;
INSERT INTO `task_status` VALUES (1,'В процессе'),(2,'Завершено'),(3,'Просрочено'),(4,'Отменено');
/*!40000 ALTER TABLE `task_status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tasks`
--

DROP TABLE IF EXISTS `tasks`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tasks` (
  `idtasks` int NOT NULL AUTO_INCREMENT,
  `text` varchar(45) DEFAULT NULL,
  `idprojects` int DEFAULT NULL,
  `idtask_priorities` int DEFAULT NULL,
  `idtask_status` int DEFAULT NULL,
  `start_date` datetime DEFAULT NULL,
  `end_date` datetime DEFAULT NULL,
  `plan_end` datetime DEFAULT NULL,
  `idclient_managers` int DEFAULT NULL,
  PRIMARY KEY (`idtasks`),
  KEY `idprojects_idx` (`idprojects`),
  KEY `idtask_priorities_idx` (`idtask_priorities`),
  KEY `idtask_status_idx` (`idtask_status`),
  KEY `idclient_managers_idx` (`idclient_managers`),
  CONSTRAINT `idprojects` FOREIGN KEY (`idprojects`) REFERENCES `projects` (`idprojects`),
  CONSTRAINT `idtask_priorities` FOREIGN KEY (`idtask_priorities`) REFERENCES `task_priorities` (`idtask_priorities`),
  CONSTRAINT `idtask_status` FOREIGN KEY (`idtask_status`) REFERENCES `task_status` (`idtask_status`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tasks`
--

LOCK TABLES `tasks` WRITE;
/*!40000 ALTER TABLE `tasks` DISABLE KEYS */;
INSERT INTO `tasks` VALUES (1,'Сделать раскадровку анимации',1,1,2,'2025-02-10 10:00:00','2025-02-10 15:00:00','2025-02-10 17:00:00',1),(2,'Сделать набросок логотипа',2,2,1,'2025-01-10 10:00:00',NULL,'2025-01-10 18:00:00',2);
/*!40000 ALTER TABLE `tasks` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `work_time`
--

DROP TABLE IF EXISTS `work_time`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `work_time` (
  `idwork_time` int NOT NULL AUTO_INCREMENT,
  `start_date` datetime DEFAULT NULL,
  `end_date` datetime DEFAULT NULL,
  `idtasks` int DEFAULT NULL,
  `idmanagers` int DEFAULT NULL,
  `quantity` int DEFAULT NULL,
  PRIMARY KEY (`idwork_time`),
  KEY `idtasks_idx` (`idtasks`),
  KEY `idmanagers5_idx` (`idmanagers`),
  CONSTRAINT `idmanagers5` FOREIGN KEY (`idmanagers`) REFERENCES `managers` (`idmanagers`),
  CONSTRAINT `idtasks` FOREIGN KEY (`idtasks`) REFERENCES `tasks` (`idtasks`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `work_time`
--

LOCK TABLES `work_time` WRITE;
/*!40000 ALTER TABLE `work_time` DISABLE KEYS */;
INSERT INTO `work_time` VALUES (2,'2025-02-10 10:00:00','2025-02-10 15:00:00',1,2,300);
/*!40000 ALTER TABLE `work_time` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-02-25  8:45:33
