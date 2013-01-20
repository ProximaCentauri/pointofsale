-- MySQL dump 10.13  Distrib 5.5.29, for Win32 (x86)
--
-- Host: localhost    Database: db_pos
-- ------------------------------------------------------
-- Server version	5.5.29-log

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

DROP DATABASE IF EXISTS `db_pos`;
CREATE DATABASE `db_pos`;
USE `db_pos`;
--
-- Table structure for table `accesssite`
--

DROP TABLE IF EXISTS `accesssite`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `accesssite` (
  `AccessSiteID` int(11) NOT NULL AUTO_INCREMENT,
  `SiteName` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`AccessSiteID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `categoryinfo`
--

DROP TABLE IF EXISTS `categoryinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categoryinfo` (
  `CategoryID` int(11) NOT NULL AUTO_INCREMENT,
  `CategoryName` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`CategoryID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `genericinfo`
--

DROP TABLE IF EXISTS `genericinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `genericinfo` (
  `genericID` bigint(20) NOT NULL AUTO_INCREMENT,
  `genericName` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`genericID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


----
-- Table structure for table `daysummary`
--

DROP TABLE IF EXISTS `daysummary`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `daysummary` (
  `DayID` bigint(20) NOT NULL AUTO_INCREMENT,
  `DayStamp` datetime DEFAULT NULL,
  `TotalItemSold` int(11) NOT NULL DEFAULT '0',
  `TotalSales` double NOT NULL DEFAULT '0',
  `TotalTax` double NOT NULL DEFAULT '0',
  PRIMARY KEY (`DayID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


--
-- Table structure for table `iteminfo`
--

DROP TABLE IF EXISTS `iteminfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `iteminfo` (
  `ItemID` bigint(20) NOT NULL AUTO_INCREMENT,
  `ItemName` varchar(300) DEFAULT NULL,
  `Description` varchar(750) DEFAULT NULL,
  `GenericID` bigint(20) NOT NULL,
  `CategoryID` int(11) NOT NULL,
  `Manufacturer` varchar(250) DEFAULT NULL,
  `BuyPrice` double NOT NULL DEFAULT '0',
  `Markup` smallint(6) NOT NULL DEFAULT '0',
  `OriginalStock` int(11) NOT NULL DEFAULT '0',
  `QtyStock` int(11) NOT NULL DEFAULT '0',
  `QtySold` int(11) NOT NULL DEFAULT '0',
  `ThresholdValue` int(11) NOT NULL DEFAULT '0',
  `Barcode` varchar(45) DEFAULT NULL,
  `Rack` varchar(45) DEFAULT NULL,
  `SellPrice` double NOT NULL DEFAULT '0',
  `Unit` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ItemID`),
  KEY `FK_iteminfo_1` (`CategoryID`),
  KEY `FK_iteminfo_2` (`GenericID`),
  CONSTRAINT `FK_iteminfo_1` FOREIGN KEY (`CategoryID`) REFERENCES `categoryinfo` (`CategoryID`) ON UPDATE CASCADE,
  CONSTRAINT `FK_iteminfo_2` FOREIGN KEY (`GenericID`) REFERENCES `genericinfo` (`genericID`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `iteminventory`
--

DROP TABLE IF EXISTS `iteminventory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `iteminventory` (
  `InventoryID` bigint(20) NOT NULL AUTO_INCREMENT,
  `DayStamp` datetime DEFAULT NULL,
  `StockAdded` int(11) NOT NULL DEFAULT '0',
  `StockRemoved` int(11) NOT NULL DEFAULT '0',
  `ItemID` bigint(20) NOT NULL,
  PRIMARY KEY (`InventoryID`),
  KEY `FK_iteminventory_1` (`ItemID`),
  CONSTRAINT `FK_iteminventory_1` FOREIGN KEY (`ItemID`) REFERENCES `iteminfo` (`ItemID`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


--
-- Table structure for table `rolesheader`
--

DROP TABLE IF EXISTS `rolesheader`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rolesheader` (
  `RoleID` int(11) NOT NULL AUTO_INCREMENT,
  `RoleName` varchar(50) DEFAULT NULL,
  `Description` varchar(300) DEFAULT NULL,
  PRIMARY KEY (`RoleID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `rolesdetail`
--

DROP TABLE IF EXISTS `rolesdetail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rolesdetail` (
  `DetailID` int(11) NOT NULL AUTO_INCREMENT,
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
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user` (
  `UserID` int(11) NOT NULL AUTO_INCREMENT,
  `UserName` varchar(250) DEFAULT NULL,
  `Password` varchar(50) DEFAULT NULL,
  `RoleID` int(11) NOT NULL,
  PRIMARY KEY (`UserID`),
  KEY `FK_user_1` (`RoleID`),
  CONSTRAINT `FK_user_1` FOREIGN KEY (`RoleID`) REFERENCES `rolesheader` (`RoleID`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `salesorderheader`
--

DROP TABLE IF EXISTS `salesorderheader`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `salesorderheader` (
  `SalesOrderID` bigint(20) NOT NULL AUTO_INCREMENT,
  `TotalAmount` double NOT NULL DEFAULT '0',
  `Tax` double NOT NULL DEFAULT '0',
  `AmountDue` double NOT NULL DEFAULT '0',
  `TotalQty` int(11) NOT NULL DEFAULT '0',
  `DayStamp` datetime DEFAULT NULL,
  `DayID` bigint(20) NOT NULL,
  PRIMARY KEY (`SalesOrderID`),
  KEY `FK_salesorderheader_1` (`DayID`),
  CONSTRAINT `FK_salesorderheader_1` FOREIGN KEY (`DayID`) REFERENCES `daysummary` (`DayID`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


--
-- Table structure for table `salesorderdetail`
--

DROP TABLE IF EXISTS `salesorderdetail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `salesorderdetail` (
  `DetailID` bigint(20) NOT NULL,
  `SalesOrderID` bigint(20) NOT NULL,
  `ItemID` bigint(20) NOT NULL,
  `Qty` int(11) NOT NULL DEFAULT '0',
  `Amount` double NOT NULL DEFAULT '0',
  PRIMARY KEY (`DetailID`),
  KEY `FK_salesorderdetail_1` (`SalesOrderID`),
  KEY `FK_salesorderdetail_2` (`ItemID`),
  CONSTRAINT `FK_salesorderdetail_1` FOREIGN KEY (`SalesOrderID`) REFERENCES `salesorderheader` (`SalesOrderID`) ON UPDATE CASCADE,
  CONSTRAINT `FK_salesorderdetail_2` FOREIGN KEY (`ItemID`) REFERENCES `iteminfo` (`ItemID`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


--
-- Table structure for table `payment`
--

DROP TABLE IF EXISTS `payment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `payment` (
  `ORID` bigint(20) NOT NULL AUTO_INCREMENT,
  `SalesOrderID` bigint(20) NOT NULL,
  `TotalAmount` double NOT NULL DEFAULT '0',
  `Tax` double NOT NULL DEFAULT '0',
  `AmountDue` double NOT NULL DEFAULT '0',
  `Change` double NOT NULL DEFAULT '0',
  `UserID` int(11) NOT NULL,
  `DayStamp` datetime DEFAULT NULL,
  PRIMARY KEY (`ORID`),
  KEY `FK_payment_1` (`SalesOrderID`),
  KEY `FK_payment_2` (`UserID`),
  CONSTRAINT `FK_payment_1` FOREIGN KEY (`SalesOrderID`) REFERENCES `salesorderheader` (`SalesOrderID`) ON UPDATE CASCADE,
  CONSTRAINT `FK_payment_2` FOREIGN KEY (`UserID`) REFERENCES `user` (`UserID`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2013-01-21  0:01:36
