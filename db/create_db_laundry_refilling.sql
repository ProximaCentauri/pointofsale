-- MySQL dump 10.13  Distrib 5.5.29, for Win32 (x86)
-- Date Modified:	January 5, 2013
-- Host: localhost    Database: db_laundry_refilling
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


DROP DATABASE IF EXISTS `db_laundry_refilling`;

CREATE DATABASE `db_laundry_refilling`;
USE `db_laundry_refilling`;


-- Table structure for table `customer`
DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE  TABLE `db_laundry_refilling`.`customer` (
  `CustomerID` int(10) NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(50) NOT NULL DEFAULT 'NULL' ,
  `Address` VARCHAR(50) NOT NULL DEFAULT 'NULL' ,
  `ContactNumber` VARCHAR(25) NOT NULL DEFAULT 'NULL' ,
  PRIMARY KEY (`CustomerID`) )
ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


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
  PRIMARY KEY (`CategoryID`),
  UNIQUE KEY `IX_laundrycategory_1` (`Name`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
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
  PRIMARY KEY (`ServiceID`),
  UNIQUE KEY `IX_laundryservices` (`Name`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
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
  `Amount` decimal(10,2) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ChargeID`),
  UNIQUE KEY `IX_laundrycharges_1` (`Name`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


-- Table structure for table `laundrychecklist`
DROP TABLE IF EXISTS `laundrychecklist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE  TABLE `db_laundry_refilling`.`laundrychecklist` (
  `ChecklistID` int(10) NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(50) NOT NULL DEFAULT 'NULL' ,
  PRIMARY KEY (`ChecklistID`) ,
  UNIQUE INDEX `IX_laundrychecklist_1` (`Name` ASC) 
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
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
  `Price` decimal(10,2) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`),
  UNIQUE KEY `IX_laundrypricescheme_1` (`CategoryID`,`ServiceID`),
  KEY `FK_laundrypricescheme_1` (`CategoryID`),
  KEY `FK_laundrypricescheme_2` (`ServiceID`),
  CONSTRAINT `FK_laundrypricescheme_1` FOREIGN KEY (`CategoryID`) REFERENCES `laundrycategory` (`CategoryID`) ON UPDATE CASCADE,
  CONSTRAINT `FK_laundrypricescheme_2` FOREIGN KEY (`ServiceID`) REFERENCES `laundryservices` (`ServiceID`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
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
  `TotalSales` decimal(10,2) NOT NULL DEFAULT '0',
  `TransCount` int(10) unsigned NOT NULL DEFAULT '0',
  PRIMARY KEY (`DayID`),
  UNIQUE KEY `IX_laundrydaysummary_1` (`DayStamp`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
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
  `CustomerID` int(10) NOT NULL,
  `ReceivedDate` datetime NOT NULL,
  `DueDate` datetime NOT NULL,
  `ClaimDate` datetime NOT NULL,
  `TotalItemQty` int(10) unsigned NOT NULL DEFAULT '0',
  `AmountDue` decimal(10,2) NOT NULL DEFAULT '0',
  `TotalCharge` decimal(10,2) NOT NULL DEFAULT '0',
  `TotalDiscount` decimal(10,2) NOT NULL DEFAULT '0',   
  `TotalAmountDue` decimal(10,2) NOT NULL DEFAULT '0',
  `AmountTender` decimal(10,2) NOT NULL DEFAULT '0',
  `PaidFlag` tinyint(1) NOT NULL DEFAULT '0',
  `ClaimFlag` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`LaundryHeaderID`),
  KEY `FK_laundryheader_1` (`DayID`),
  KEY `FK_laundryheader_2` (`CustomerID`),
  CONSTRAINT `FK_laundryheader_1` FOREIGN KEY (`DayID`) REFERENCES `laundrydaysummary` (`DayID`) ON UPDATE CASCADE,
  CONSTRAINT `FK_laundryheader_2` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
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
  `Amount` decimal(10,2) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`),  
  KEY `FK_LaundryDetail_1` (`LaundryHeaderID`),
  KEY `FK_laundrydetail_2` (`CategoryID`),
  KEY `FK_laundrydetail_3` (`ServiceID`),
  CONSTRAINT `FK_laundrydetail_2` FOREIGN KEY (`CategoryID`) REFERENCES `laundrycategory` (`CategoryID`) ON UPDATE CASCADE,
  CONSTRAINT `FK_laundrydetail_3` FOREIGN KEY (`ServiceID`) REFERENCES `laundryservices` (`ServiceID`) ON UPDATE CASCADE,
  CONSTRAINT `FK_LaundryDetail_1` FOREIGN KEY (`LaundryHeaderID`) REFERENCES `laundryheader` (`LaundryHeaderID`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


--
-- Table structure for table `laundrypaymentdetail`
--

DROP TABLE IF EXISTS `laundrypaymentdetail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `laundrypaymentdetail` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `LaundryHeaderID` int(10) unsigned NOT NULL, 
  `PaymentDate` datetime NOT NULL,
  `Amount` decimal(10,2) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`),
  KEY `IX_laundrypaymentdetail_1` (`LaundryHeaderID`),  
  CONSTRAINT `FK_laundrypaymentdetail_1` FOREIGN KEY (`LaundryHeaderID`) REFERENCES `laundryheader` (`LaundryHeaderID`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
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
  UNIQUE KEY `IX_laundryJobcharges_1` (`LaundryHeaderID`,`ChargeID`),
  KEY `FK_LaundryJobCharges_1` (`LaundryHeaderID`),
  KEY `FK_LaundryJobCharges_2` (`ChargeID`),
  CONSTRAINT `FK_LaundryJobCharges_1` FOREIGN KEY (`LaundryHeaderID`) REFERENCES `laundryheader` (`LaundryHeaderID`) ON UPDATE CASCADE,
  CONSTRAINT `FK_LaundryJobCharges_2` FOREIGN KEY (`ChargeID`) REFERENCES `laundrycharges` (`ChargeID`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


-- Table structure for table `laundryjobchecklist`
DROP TABLE IF EXISTS `laundryjobchecklist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE  TABLE `db_laundry_refilling`.`laundryjobchecklist` (
  `ID` int(10) NOT NULL AUTO_INCREMENT,
  `ChecklistID` int(10) NOT NULL ,
  `LaundryHeaderID` int(10) unsigned NOT NULL,
  `Qty` int(10) NOT NULL DEFAULT 0 ,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `IX_laundryjobchecklist_1` (`LaundryHeaderID`,`ChecklistID`),
  KEY `FK_LaundryJobChecklist_1` (`LaundryHeaderID`),
  KEY `FK_LaundryJobChecklist_2` (`ChecklistID`),
  CONSTRAINT `FK_LaundryJobChecklist_1` FOREIGN KEY (`LaundryHeaderID`) REFERENCES `laundryheader` (`LaundryHeaderID`) ON UPDATE CASCADE,
  CONSTRAINT `FK_LaundryJobChecklist_2` FOREIGN KEY (`ChecklistID`) REFERENCES `laundrychecklist` (`ChecklistID`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
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
  PRIMARY KEY (`TransactionTypeID`),
  UNIQUE KEY `IX_refilltransactiontype` (`Name`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
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
  `Price` decimal(10,2) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ProductTypeID`),
  UNIQUE KEY `IX_refillproducttype` (`Name`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;



--
-- Table structure for table `refilldaysummary`
--

DROP TABLE IF EXISTS `refilldaysummary`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `refilldaysummary` (
  `DayID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `TotalSales` decimal(10,2) NOT NULL DEFAULT '0',
  `TransCount` int NOT NULL DEFAULT '0',
  `DayStamp` datetime NOT NULL,
  PRIMARY KEY (`DayID`),
  UNIQUE KEY `IX_refilldaysummary` (`DayStamp`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;



--
-- Table structure for table `refillheader`
--

DROP TABLE IF EXISTS `refillheader`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `refillheader` (
  `RefillHeaderID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `CustomerID` int(10) NOT NULL,
  `Date` datetime NOT NULL,
  `TotalQty` int(10) unsigned NOT NULL DEFAULT '0',
  `AmountDue` decimal(10,2) NOT NULL DEFAULT '0',
  `AmountTender` decimal(10,2) NOT NULL DEFAULT '0',
  `PaidFlag` tinyint(1) NOT NULL DEFAULT '0',
  `TransactionTypeID` int(10) unsigned NOT NULL,
  `DayID` int(10) unsigned NOT NULL,
  PRIMARY KEY (`RefillHeaderID`),
  KEY `FK_refillheader_1` (`CustomerID`),
  KEY `FK_refillheader_2` (`DayID`),
  KEY `FK_refillheader_3` (`TransactionTypeID`),
  CONSTRAINT `FK_refillheader_1` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`) ON UPDATE CASCADE,
  CONSTRAINT `FK_refillheader_2` FOREIGN KEY (`DayID`) REFERENCES `refilldaysummary` (`DayID`) ON UPDATE CASCADE,
  CONSTRAINT `FK_refillheader_3` FOREIGN KEY (`TransactionTypeID`) REFERENCES `refilltransactiontype` (`TransactionTypeID`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
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
  `StoreBottleQty` int(10) unsigned NOT NULL DEFAULT '0',
  `StoreCapQty` int(10) unsigned NOT NULL DEFAULT '0',
  `Amount` decimal(10,2) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`),  
  KEY `FK_refilldetail_1` (`RefillHeaderID`),
  KEY `FK_refilldetail_2` (`ProductTypeID`),
  CONSTRAINT `FK_refilldetail_1` FOREIGN KEY (`RefillHeaderID`) REFERENCES `refillheader` (`RefillHeaderID`) ON UPDATE CASCADE,
  CONSTRAINT `FK_refilldetail_2` FOREIGN KEY (`ProductTypeID`) REFERENCES `refillproducttype` (`ProductTypeID`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;



--
-- Table structure for table `refillpaymentdetail`
--

DROP TABLE IF EXISTS `refillpaymentdetail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `refillpaymentdetail` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `RefillHeaderID` int(10) unsigned NOT NULL, 
  `PaymentDate` datetime NOT NULL,
  `Amount` decimal(10,2) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`),
  KEY `IX_refillpaymentdetail_1` (`RefillHeaderID`),  
  CONSTRAINT `FK_refillpaymentdetail_1` FOREIGN KEY (`RefillHeaderID`) REFERENCES `refillheader` (`RefillHeaderID`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `refillinventoryheader`
--

DROP TABLE IF EXISTS `refillinventoryheader`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `refillinventoryheader` (
  `InvHeaderID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(25) NOT NULL DEFAULT 'NULL',
  `TotalQty` int(10) unsigned NOT NULL DEFAULT '0',
  `QtyOnHand` int(10) unsigned NOT NULL DEFAULT '0',
  `QtyReleased` int(10) unsigned NOT NULL DEFAULT '0',
  PRIMARY KEY (`InvHeaderID`),
  UNIQUE KEY `IX_refillinventoryheader_1` (`Name`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


--
-- Table structure for table `refillinventorydetail`
--

DROP TABLE IF EXISTS `refillinventorydetail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `refillinventorydetail` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `InvHeaderID` int(10) unsigned NOT NULL,  
  `QtyAdded` int(10) unsigned NOT NULL DEFAULT '0',
  `QtyRemoved` int(10) unsigned NOT NULL DEFAULT '0',
  `Date` datetime NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `IX_refillinventorydetail_1` (`InvHeaderID`),  
  CONSTRAINT `FK_refillinventorydetail_1` FOREIGN KEY (`InvHeaderID`) REFERENCES `refillinventorydetail` (`InvHeaderID`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;
--
-- Table structure for table `refillcustomerinventory`
--

DROP TABLE IF EXISTS `refillcustomerinventory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `refillcustomerinventory` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `CustomerID` int(10) NOT NULL,
  `BottlesOnHand` int(10) unsigned NOT NULL DEFAULT '0',
  `BottlesReturned` int(10) unsigned NOT NULL DEFAULT '0',
  `CapsOnHand` int(10) unsigned NOT NULL DEFAULT '0',
  `CapsReturned` int(10) unsigned NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`),
  UNIQUE KEY `IX_refillcustomerinventory_1` (`CustomerID`),
  KEY `FK_refillcustomerinventory_1` (`CustomerID`),
  CONSTRAINT `FK_refillcustomerinventory_1` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;



/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- DEFAULT DATA

-- Luandry - services table
INSERT INTO `db_laundry_refilling`.`laundryservices` (`Name`, `Description`) VALUES ('Wash - Dry - Fold', 'for wash dry fold services');
INSERT INTO `db_laundry_refilling`.`laundryservices` (`Name`, `Description`) VALUES ('Wash - Dry - Press', 'for wash dry press services');
INSERT INTO `db_laundry_refilling`.`laundryservices` (`Name`, `Description`) VALUES ('Dry Clean', 'for dry clean services');
INSERT INTO `db_laundry_refilling`.`laundryservices` (`Name`, `Description`) VALUES ('Press Only', 'for press only services');
INSERT INTO `db_laundry_refilling`.`laundryservices` (`Name`, `Description`) VALUES ('Other Services', 'for other services');

-- Laundry - category table
INSERT INTO `db_laundry_refilling`.`laundrycategory` (`Name`, `Description`) VALUES ('Colored Garments','for colored garments');
INSERT INTO `db_laundry_refilling`.`laundrycategory` (`Name`, `Description`) VALUES ('White Garments','for white garments');
INSERT INTO `db_laundry_refilling`.`laundrycategory` (`Name`, `Description`) VALUES ('Comforter','for comforters');
INSERT INTO `db_laundry_refilling`.`laundrycategory` (`Name`, `Description`) VALUES ('Bed Sheets','for bed sheets');
INSERT INTO `db_laundry_refilling`.`laundrycategory` (`Name`, `Description`) VALUES ('Towels','for towels');
INSERT INTO `db_laundry_refilling`.`laundrycategory` (`Name`, `Description`) VALUES ('Linens','for linens');
INSERT INTO `db_laundry_refilling`.`laundrycategory` (`Name`, `Description`) VALUES ('Shoes','for shoes');
INSERT INTO `db_laundry_refilling`.`laundrycategory` (`Name`, `Description`) VALUES ('Bags','for bags');
INSERT INTO `db_laundry_refilling`.`laundrycategory` (`Name`, `Description`) VALUES ('Carpet','for carpets');
INSERT INTO `db_laundry_refilling`.`laundrycategory` (`Name`, `Description`) VALUES ('Curtains','for curtains');
INSERT INTO `db_laundry_refilling`.`laundrycategory` (`Name`, `Description`) VALUES ('Stuffed Toys','for stuffed toys');
INSERT INTO `db_laundry_refilling`.`laundrycategory` (`Name`, `Description`) VALUES ('Seat Cover','for seat covers');
INSERT INTO `db_laundry_refilling`.`laundrycategory` (`Name`, `Description`) VALUES ('Others','for other items');

-- Laundry - pricescheme table
INSERT INTO `db_laundry_refilling`.`laundrypricescheme` (`CategoryID`, `ServiceID`, `Description`, `Price`) VALUES ('1', '1', 'this is a test only price scheme', '25.00');
INSERT INTO `db_laundry_refilling`.`laundrypricescheme` (`CategoryID`, `ServiceID`, `Description`, `Price`) VALUES ('2', '1', 'this is a test only price scheme', '15.00');
INSERT INTO `db_laundry_refilling`.`laundrypricescheme` (`CategoryID`, `ServiceID`, `Description`, `Price`) VALUES ('3', '1', 'this is a test only price scheme', '10.00');
INSERT INTO `db_laundry_refilling`.`laundrypricescheme` (`CategoryID`, `ServiceID`, `Description`, `Price`) VALUES ('1', '2', 'this is a test only price scheme', '25.00');
INSERT INTO `db_laundry_refilling`.`laundrypricescheme` (`CategoryID`, `ServiceID`, `Description`, `Price`) VALUES ('2', '2', 'this is a test only price scheme', '15.00');
INSERT INTO `db_laundry_refilling`.`laundrypricescheme` (`CategoryID`, `ServiceID`, `Description`, `Price`) VALUES ('3', '2', 'this is a test only price scheme', '10.00');

-- Laundry - charges table
INSERT INTO `db_laundry_refilling`.`laundrycharges` (`Name`, `Amount`) VALUES ('Pick - Up', '0.00');
INSERT INTO `db_laundry_refilling`.`laundrycharges` (`Name`, `Amount`) VALUES ('Delivery', '20.00');
INSERT INTO `db_laundry_refilling`.`laundrycharges` (`Name`, `Amount`) VALUES ('24 Hour Rush Service', '75.00');
INSERT INTO `db_laundry_refilling`.`laundrycharges` (`Name`, `Amount`) VALUES ('Same Day Rush Service','150.00');


-- Laundry - checklist table
INSERT INTO `db_laundry_refilling`.`laundrychecklist` (`Name`) VALUES ('T-shirt');
INSERT INTO `db_laundry_refilling`.`laundrychecklist` (`Name`) VALUES ('Pants');
INSERT INTO `db_laundry_refilling`.`laundrychecklist` (`Name`) VALUES ('Skirt');
INSERT INTO `db_laundry_refilling`.`laundrychecklist` (`Name`) VALUES ('Shorts');
INSERT INTO `db_laundry_refilling`.`laundrychecklist` (`Name`) VALUES ('Sando');
INSERT INTO `db_laundry_refilling`.`laundrychecklist` (`Name`) VALUES ('Boxer shorts');

-- Refill - product table
INSERT INTO `db_laundry_refilling`.`refillproducttype` (`Name`, `Description`, `Price`) VALUES ('5 Gal at 25', 'for 5-gal with price of Php 25', '25.00');
INSERT INTO `db_laundry_refilling`.`refillproducttype` (`Name`, `Description`, `Price`) VALUES ('5 Gal at 20', 'for 5-gal with price of Php 20', '20.00');
INSERT INTO `db_laundry_refilling`.`refillproducttype` (`Name`, `Description`, `Price`) VALUES ('5 Gal at 15', 'for 5-gal with price of Php 15', '15.00');
INSERT INTO `db_laundry_refilling`.`refillproducttype` (`Name`, `Description`, `Price`) VALUES ('5 Gal at 13', 'for 5-gal with price of Php 13', '13.00');
INSERT INTO `db_laundry_refilling`.`refillproducttype` (`Name`, `Description`, `Price`) VALUES ('4L at 25', 'for 4L with price of Php 25', '25.00');
INSERT INTO `db_laundry_refilling`.`refillproducttype` (`Name`, `Description`, `Price`) VALUES ('4L at 20', 'for 4L with price of Php 20', '20.00');
INSERT INTO `db_laundry_refilling`.`refillproducttype` (`Name`, `Description`, `Price`) VALUES ('4L at 10', 'for 4L with price of Php 10', '10.00');
INSERT INTO `db_laundry_refilling`.`refillproducttype` (`Name`, `Description`, `Price`) VALUES ('1L at 20', 'for 1L with price of Php 20', '20.00');
INSERT INTO `db_laundry_refilling`.`refillproducttype` (`Name`, `Description`, `Price`) VALUES ('1L at 15', 'for 1L with price of Php 15', '15.00');
INSERT INTO `db_laundry_refilling`.`refillproducttype` (`Name`, `Description`, `Price`) VALUES ('1L at 5', 'for 1L with price of Php 5', '5.00');
INSERT INTO `db_laundry_refilling`.`refillproducttype` (`Name`, `Description`, `Price`) VALUES ('500ML at 12', 'for 500 ML with price of Php 12', '12.00');
INSERT INTO `db_laundry_refilling`.`refillproducttype` (`Name`, `Description`, `Price`) VALUES ('500ML at 7', 'for 500 ML with price of Php 7', '7.00');
INSERT INTO `db_laundry_refilling`.`refillproducttype` (`Name`, `Description`, `Price`) VALUES ('330ML at 10', 'for 330 ML with price of Php 10', '10.00');
INSERT INTO `db_laundry_refilling`.`refillproducttype` (`Name`, `Description`, `Price`) VALUES ('330ML at 5', 'for 330 ML with price of Php 5', '5.00');
INSERT INTO `db_laundry_refilling`.`refillproducttype` (`Name`, `Description`) VALUES ('CAP', 'for cap');
INSERT INTO `db_laundry_refilling`.`refillproducttype` (`Name`, `Description`) VALUES ('New Bottle', 'for new bottle');

-- Refill - transactiontype table
INSERT INTO `db_laundry_refilling`.`refilltransactiontype` (`Name`) VALUES ('Delivery');
INSERT INTO `db_laundry_refilling`.`refilltransactiontype` (`Name`) VALUES ('Walk-In');

-- Customer table (for testing only)
INSERT INTO `db_laundry_refilling`.`customer` (`Name`, `Address`, `ContactNumber`) VALUES ('John Dee', 'Cebu', '111-1111');
INSERT INTO `db_laundry_refilling`.`customer` (`Name`, `Address`, `ContactNumber`) VALUES ('Vanessa Dee', 'Cebu', '111-1111');

-- Refill inventory table (for testing only)
INSERT INTO `db_laundry_refilling`.`refillinventoryheader` (`Name`, `TotalQty`, `QtyOnHand`, `QtyReleased`) VALUES ('5 Gal Bottle', '100', '100', '0');
INSERT INTO `db_laundry_refilling`.`refillinventoryheader` (`Name`, `TotalQty`, `QtyOnHand`, `QtyReleased`) VALUES ('4L Bottle', '100', '100', '0');
INSERT INTO `db_laundry_refilling`.`refillinventoryheader` (`Name`, `TotalQty`, `QtyOnHand`, `QtyReleased`) VALUES ('1L Bottle', '100', '100', '0');
INSERT INTO `db_laundry_refilling`.`refillinventoryheader` (`Name`, `TotalQty`, `QtyOnHand`, `QtyReleased`) VALUES ('500ML Bottle', '100', '100', '0');
INSERT INTO `db_laundry_refilling`.`refillinventoryheader` (`Name`, `TotalQty`, `QtyOnHand`, `QtyReleased`) VALUES ('330 Bottle', '100', '100', '0');
INSERT INTO `db_laundry_refilling`.`refillinventoryheader` (`Name`, `TotalQty`, `QtyOnHand`, `QtyReleased`) VALUES ('Cap', '100', '100', '0');

-- DUMP COMPLETE


