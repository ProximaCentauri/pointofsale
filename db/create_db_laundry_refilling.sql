-- MySQL dump 10.13  Distrib 5.1.47, for Win32 (ia32)
--
-- Host: localhost    Database: db_laundry_refilling
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


DROP DATABASE IF EXISTS `db_laundry_refilling`;

CREATE DATABASE `db_laundry_refilling`;
USE `db_laundry_refilling`;


--
-- Table structure for table `laundrycategory`
--

DROP TABLE IF EXISTS `laundrycategory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `laundrycategory` (
  `CategoryID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL DEFAULT 'NULL',
  `Description` varchar(150) NOT NULL DEFAULT 'NULL',
  PRIMARY KEY (`CategoryID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


--
-- Table structure for table `laundryservices`
--

DROP TABLE IF EXISTS `laundryservices`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `laundryservices` (
  `ServiceID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL DEFAULT 'NULL',
  `Description` varchar(150) NOT NULL DEFAULT 'NULL',
  PRIMARY KEY (`ServiceID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


--
-- Table structure for table `laundrycharges`
--

DROP TABLE IF EXISTS `laundrycharges`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `laundrycharges` (
  `ChargeID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL DEFAULT '"NULL"',
  `Amount` double NOT NULL DEFAULT '0',
  PRIMARY KEY (`ChargeID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


--
-- Table structure for table `laundrypricescheme`
--

DROP TABLE IF EXISTS `laundrypricescheme`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `laundrypricescheme` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `CategoryID` int(10) unsigned NOT NULL,
  `ServiceID` int(10) unsigned NOT NULL,
  `Description` varchar(150) NOT NULL DEFAULT 'NULL',
  `Price` double NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`),
  KEY `FK_laundrypricescheme_1` (`CategoryID`),
  KEY `FK_laundrypricescheme_2` (`ServiceID`),
  CONSTRAINT `FK_laundrypricescheme_1` FOREIGN KEY (`CategoryID`) REFERENCES `laundrycategory` (`CategoryID`) ON UPDATE CASCADE,
  CONSTRAINT `FK_laundrypricescheme_2` FOREIGN KEY (`ServiceID`) REFERENCES `laundryservices` (`ServiceID`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `laundrydaysummary`
--

DROP TABLE IF EXISTS `laundrydaysummary`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `laundrydaysummary` (
  `DayID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `DayStamp` datetime NOT NULL,
  `TotalSales` double NOT NULL DEFAULT '0',
  `TransCount` int(10) unsigned NOT NULL DEFAULT '0',
  PRIMARY KEY (`DayID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


--
-- Table structure for table `laundryheader`
--

DROP TABLE IF EXISTS `laundryheader`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `laundryheader` (
  `LaundryHeaderID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `DayID` int(10) unsigned NOT NULL,
  `CustomerName` varchar(50) NOT NULL DEFAULT 'NULL',
  `ReceivedDate` datetime NOT NULL,
  `DueDate` datetime NOT NULL,
  `ClaimDate` datetime NOT NULL,
  `PaidFlag` tinyint(1) NOT NULL DEFAULT '0',
  `ClaimFlag` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`LaundryHeaderID`),
  KEY `FK_laundryheader_1` (`DayID`),
  CONSTRAINT `FK_laundryheader_1` FOREIGN KEY (`DayID`) REFERENCES `laundrydaysummary` (`DayID`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


--
-- Table structure for table `laundrydetail`
--

DROP TABLE IF EXISTS `laundrydetail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `laundrydetail` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `LaundryHeaderID` int(10) unsigned NOT NULL,
  `ServiceID` int(10) unsigned NOT NULL,
  `CategoryID` int(10) unsigned NOT NULL,
  `ItemQty` int(10) unsigned NOT NULL DEFAULT '0',
  `Kilo` double NOT NULL DEFAULT '0',
  `Amount` double NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`),
  KEY `FK_LaundryDetail_1` (`LaundryHeaderID`),
  KEY `FK_laundrydetail_2` (`CategoryID`),
  KEY `FK_laundrydetail_3` (`ServiceID`),
  CONSTRAINT `FK_laundrydetail_2` FOREIGN KEY (`CategoryID`) REFERENCES `laundrycategory` (`CategoryID`) ON UPDATE CASCADE,
  CONSTRAINT `FK_laundrydetail_3` FOREIGN KEY (`ServiceID`) REFERENCES `laundryservices` (`ServiceID`) ON UPDATE CASCADE,
  CONSTRAINT `FK_LaundryDetail_1` FOREIGN KEY (`LaundryHeaderID`) REFERENCES `laundryheader` (`LaundryHeaderID`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


--
-- Table structure for table `laundryjobcharges`
--

DROP TABLE IF EXISTS `laundryjobcharges`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `laundryjobcharges` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `LaundryHeaderID` int(10) unsigned NOT NULL,
  `ChargeID` int(10) unsigned NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_LaundryJobCharges_1` (`LaundryHeaderID`),
  KEY `FK_LaundryJobCharges_2` (`ChargeID`),
  CONSTRAINT `FK_LaundryJobCharges_1` FOREIGN KEY (`LaundryHeaderID`) REFERENCES `laundryheader` (`LaundryHeaderID`) ON UPDATE CASCADE,
  CONSTRAINT `FK_LaundryJobCharges_2` FOREIGN KEY (`ChargeID`) REFERENCES `laundrycharges` (`ChargeID`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


--
-- Table structure for table `refilltransactiontype`
--

DROP TABLE IF EXISTS `refilltransactiontype`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `refilltransactiontype` (
  `TransactionTypeID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL DEFAULT 'NULL',
  PRIMARY KEY (`TransactionTypeID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


--
-- Table structure for table `refillproducttype`
--

DROP TABLE IF EXISTS `refillproducttype`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `refillproducttype` (
  `ProductTypeID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL DEFAULT 'NULL',
  `Description` varchar(150) NOT NULL DEFAULT 'NULL',
  `Price` double NOT NULL DEFAULT '0',
  PRIMARY KEY (`ProductTypeID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


--
-- Table structure for table `refilldaysummary`
--

DROP TABLE IF EXISTS `refilldaysummary`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `refilldaysummary` (
  `DayID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `TotalSales` double NOT NULL DEFAULT '0',
  `TransCount` double NOT NULL DEFAULT '0',
  `DayStamp` datetime NOT NULL,
  PRIMARY KEY (`DayID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


--
-- Table structure for table `refillheader`
--

DROP TABLE IF EXISTS `refillheader`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `refillheader` (
  `RefillHeaderID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `CustomerName` varchar(50) NOT NULL DEFAULT 'NULL',
  `Date` datetime NOT NULL,
  `AmountDue` double NOT NULL DEFAULT '0',
  `TransactionTypeID` int(10) unsigned NOT NULL,
  `DayID` int(10) unsigned NOT NULL,
  PRIMARY KEY (`RefillHeaderID`),
  KEY `FK_refillheader_2` (`DayID`),
  KEY `FK_refillheader_1` (`TransactionTypeID`),
  CONSTRAINT `FK_refillheader_2` FOREIGN KEY (`DayID`) REFERENCES `refilldaysummary` (`DayID`) ON UPDATE CASCADE,
  CONSTRAINT `FK_refillheader_1` FOREIGN KEY (`TransactionTypeID`) REFERENCES `refilltransactiontype` (`TransactionTypeID`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


--
-- Table structure for table `refilldetail`
--

DROP TABLE IF EXISTS `refilldetail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `refilldetail` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `RefillHeaderID` int(10) unsigned NOT NULL,
  `ProductTypeID` int(10) unsigned NOT NULL,
  `Qty` int(10) unsigned NOT NULL DEFAULT '0',
  `Amount` double NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`),
  KEY `FK_refilldetail_1` (`RefillHeaderID`),
  KEY `FK_refilldetail_2` (`ProductTypeID`),
  CONSTRAINT `FK_refilldetail_1` FOREIGN KEY (`RefillHeaderID`) REFERENCES `refillheader` (`RefillHeaderID`) ON UPDATE CASCADE,
  CONSTRAINT `FK_refilldetail_2` FOREIGN KEY (`ProductTypeID`) REFERENCES `refillproducttype` (`ProductTypeID`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;



/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2013-01-31 19:19:55
