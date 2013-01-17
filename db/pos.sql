-- MySQL dump 10.13  Distrib 5.1.47, for Win32 (ia32)
--
-- Host: localhost    Database: pos
-- ------------------------------------------------------
-- Server version	5.1.47-community-log

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
-- Table structure for table `accesssite`
--

DROP TABLE IF EXISTS `accesssite`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `accesssite` (
  `AccessSiteID` int(11) NOT NULL,
  `SiteName` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`AccessSiteID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `accesssite`
--

LOCK TABLES `accesssite` WRITE;
/*!40000 ALTER TABLE `accesssite` DISABLE KEYS */;
/*!40000 ALTER TABLE `accesssite` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `catergoryinfo`
--

DROP TABLE IF EXISTS `catergoryinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `catergoryinfo` (
  `CategoryID` int(11) NOT NULL,
  `CategoryName` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`CategoryID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `catergoryinfo`
--

LOCK TABLES `catergoryinfo` WRITE;
/*!40000 ALTER TABLE `catergoryinfo` DISABLE KEYS */;
/*!40000 ALTER TABLE `catergoryinfo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `daysummary`
--

DROP TABLE IF EXISTS `daysummary`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `daysummary` (
  `DayID` bigint(20) NOT NULL,
  `DayStamp` datetime DEFAULT NULL,
  `TotalItemSold` int(11) DEFAULT NULL,
  `TotalSales` double DEFAULT NULL,
  `TotalTax` double DEFAULT NULL,
  PRIMARY KEY (`DayID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `daysummary`
--

LOCK TABLES `daysummary` WRITE;
/*!40000 ALTER TABLE `daysummary` DISABLE KEYS */;
/*!40000 ALTER TABLE `daysummary` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `genericinfo`
--

DROP TABLE IF EXISTS `genericinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `genericinfo` (
  `genericID` bigint(20) NOT NULL,
  `genericName` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`genericID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `genericinfo`
--

LOCK TABLES `genericinfo` WRITE;
/*!40000 ALTER TABLE `genericinfo` DISABLE KEYS */;
/*!40000 ALTER TABLE `genericinfo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `iteminfo`
--

DROP TABLE IF EXISTS `iteminfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `iteminfo` (
  `ItemID` bigint(20) NOT NULL,
  `ItemName` varchar(300) DEFAULT NULL,
  `Description` varchar(750) DEFAULT NULL,
  `GenericID` bigint(20) DEFAULT NULL,
  `CategoryID` int(11) DEFAULT NULL,
  `Manufacturer` varchar(250) DEFAULT NULL,
  `Price` double DEFAULT NULL,
  `Markup` smallint(6) DEFAULT NULL,
  `OriginalStock` int(11) DEFAULT NULL,
  `QtyStock` int(11) DEFAULT NULL,
  `QtySold` int(11) DEFAULT NULL,
  `ThresholdValue` int(11) DEFAULT NULL,
  PRIMARY KEY (`ItemID`),
  KEY `FK_iteminfo_1` (`CategoryID`),
  KEY `FK_iteminfo_2` (`GenericID`),
  CONSTRAINT `FK_iteminfo_1` FOREIGN KEY (`CategoryID`) REFERENCES `catergoryinfo` (`CategoryID`) ON UPDATE CASCADE,
  CONSTRAINT `FK_iteminfo_2` FOREIGN KEY (`GenericID`) REFERENCES `genericinfo` (`genericID`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `iteminfo`
--

LOCK TABLES `iteminfo` WRITE;
/*!40000 ALTER TABLE `iteminfo` DISABLE KEYS */;
/*!40000 ALTER TABLE `iteminfo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `iteminventory`
--

DROP TABLE IF EXISTS `iteminventory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `iteminventory` (
  `InventoryID` bigint(20) NOT NULL,
  `DayStamp` datetime DEFAULT NULL,
  `StockAdded` int(11) DEFAULT NULL,
  `StockRemoved` int(11) DEFAULT NULL,
  `ItemID` bigint(20) NOT NULL,
  PRIMARY KEY (`InventoryID`),
  KEY `FK_iteminventory_1` (`ItemID`),
  CONSTRAINT `FK_iteminventory_1` FOREIGN KEY (`ItemID`) REFERENCES `iteminfo` (`ItemID`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `iteminventory`
--

LOCK TABLES `iteminventory` WRITE;
/*!40000 ALTER TABLE `iteminventory` DISABLE KEYS */;
/*!40000 ALTER TABLE `iteminventory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payment`
--

create database db_pos;

DROP TABLE IF EXISTS `payment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `payment` (
  `ORID` bigint(20) NOT NULL,
  `SalesOrderID` bigint(20) DEFAULT NULL,
  `TotalAmount` double DEFAULT NULL,
  `Tax` double DEFAULT NULL,
  `AmountDue` double DEFAULT NULL,
  `Change` double DEFAULT NULL,
  `UserID` int(11) DEFAULT NULL,
  `DayStamp` datetime DEFAULT NULL,
  PRIMARY KEY (`ORID`),
  KEY `FK_payment_1` (`SalesOrderID`),
  KEY `FK_payment_2` (`UserID`),
  CONSTRAINT `FK_payment_1` FOREIGN KEY (`SalesOrderID`) REFERENCES `salesorderheader` (`SalesOrderID`) ON UPDATE CASCADE,
  CONSTRAINT `FK_payment_2` FOREIGN KEY (`UserID`) REFERENCES `user` (`UserID`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payment`
--

LOCK TABLES `payment` WRITE;
/*!40000 ALTER TABLE `payment` DISABLE KEYS */;
/*!40000 ALTER TABLE `payment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rolesdetail`
--

DROP TABLE IF EXISTS `rolesdetail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rolesdetail` (
  `DetailID` int(11) NOT NULL,
  `AccessSiteID` int(11) NOT NULL,
  `RoleID` int(10) NOT NULL,
  PRIMARY KEY (`DetailID`),
  KEY `FK_rolesdetail_1` (`RoleID`),
  KEY `FK_rolesdetail_2` (`AccessSiteID`),
  CONSTRAINT `FK_rolesdetail_1` FOREIGN KEY (`RoleID`) REFERENCES `rolesheader` (`RoleID`) ON UPDATE CASCADE,
  CONSTRAINT `FK_rolesdetail_2` FOREIGN KEY (`AccessSiteID`) REFERENCES `accesssite` (`AccessSiteID`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rolesdetail`
--

LOCK TABLES `rolesdetail` WRITE;
/*!40000 ALTER TABLE `rolesdetail` DISABLE KEYS */;
/*!40000 ALTER TABLE `rolesdetail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rolesheader`
--

DROP TABLE IF EXISTS `rolesheader`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rolesheader` (
  `RoleID` int(11) NOT NULL,
  `RoleName` varchar(50) DEFAULT NULL,
  `Description` varchar(300) DEFAULT NULL,
  PRIMARY KEY (`RoleID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rolesheader`
--

LOCK TABLES `rolesheader` WRITE;
/*!40000 ALTER TABLE `rolesheader` DISABLE KEYS */;
/*!40000 ALTER TABLE `rolesheader` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `salesorderdetail`
--

DROP TABLE IF EXISTS `salesorderdetail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `salesorderdetail` (
  `DetailID` bigint(20) NOT NULL,
  `SalesOrderID` bigint(20) NOT NULL,
  `ItemID` bigint(20) DEFAULT NULL,
  `Qty` int(11) DEFAULT NULL,
  `Amount` double DEFAULT NULL,
  PRIMARY KEY (`DetailID`),
  KEY `FK_salesorderdetail_1` (`SalesOrderID`),
  CONSTRAINT `FK_salesorderdetail_1` FOREIGN KEY (`SalesOrderID`) REFERENCES `salesorderheader` (`SalesOrderID`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `salesorderdetail`
--

LOCK TABLES `salesorderdetail` WRITE;
/*!40000 ALTER TABLE `salesorderdetail` DISABLE KEYS */;
/*!40000 ALTER TABLE `salesorderdetail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `salesorderheader`
--

DROP TABLE IF EXISTS `salesorderheader`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `salesorderheader` (
  `SalesOrderID` bigint(20) NOT NULL,
  `TotalAmount` double DEFAULT NULL,
  `Tax` double DEFAULT NULL,
  `AmountDue` double DEFAULT NULL,
  `TotalQty` int(11) DEFAULT NULL,
  `DayStamp` datetime DEFAULT NULL,
  `DayID` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`SalesOrderID`),
  KEY `FK_salesorderheader_1` (`DayID`),
  CONSTRAINT `FK_salesorderheader_1` FOREIGN KEY (`DayID`) REFERENCES `daysummary` (`DayID`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `salesorderheader`
--

LOCK TABLES `salesorderheader` WRITE;
/*!40000 ALTER TABLE `salesorderheader` DISABLE KEYS */;
/*!40000 ALTER TABLE `salesorderheader` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user` (
  `UserID` int(11) NOT NULL,
  `UserName` varchar(250) DEFAULT NULL,
  `Password` varchar(50) DEFAULT NULL,
  `RoleID` int(11) DEFAULT NULL,
  PRIMARY KEY (`UserID`),
  KEY `FK_user_1` (`RoleID`),
  CONSTRAINT `FK_user_1` FOREIGN KEY (`RoleID`) REFERENCES `rolesheader` (`RoleID`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2013-01-17 21:25:52
