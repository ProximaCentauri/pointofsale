-- MySQL dump 10.13  Distrib 5.5.29, for Win32 (x86)
-- Date Modified:	 March 08, 2013
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
  `VoidFlag` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`CustomerID`) )
ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

-- Table structure for table `company`
DROP TABLE IF EXISTS `company`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE  TABLE `db_laundry_refilling`.`company` (
  `CompanyID` int(10) NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(75) NOT NULL DEFAULT 'NULL' ,
  `Address` VARCHAR(75) NOT NULL DEFAULT 'NULL' ,
  `ContactNumber` VARCHAR(50) NOT NULL DEFAULT 'NULL' ,  
  `VoidFlag` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`CompanyID`) )
ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

-- Table structure for table `printer`
DROP TABLE IF EXISTS `printer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE  TABLE `db_laundry_refilling`.`printer` (
  `PrinterID` int(10) NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(50) NOT NULL DEFAULT 'NULL' ,
  `Model` VARCHAR(50) NOT NULL DEFAULT 'NULL' ,  
  `Active` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`PrinterID`) )
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
  `TotalPayment` decimal(10,2) NOT NULL DEFAULT '0',
  `PaidFlag` tinyint(1) NOT NULL DEFAULT '0',
  `ClaimFlag` tinyint(1) NOT NULL DEFAULT '0',
  `VoidFlag` tinyint(1) NOT NULL DEFAULT '0',
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
  `VoidFlag` tinyint(1) NOT NULL DEFAULT '0',
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
  `TotalAdded` int(10) unsigned NOT NULL DEFAULT '0',
  `TotalRemoved` int (10) unsigned NOT NULL DEFAULT '0',
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
  `TotalQty` int(10) unsigned NOT NULL DEFAULT '0',
  `QtyOnHand` int(10) unsigned NOT NULL DEFAULT '0',
  `QtyReleased` int(10) unsigned NOT NULL DEFAULT '0',
  `Date` datetime NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `IX_refillinventorydetail_1` (`InvHeaderID`),  
  CONSTRAINT `FK_refillinventorydetail_1` FOREIGN KEY (`InvHeaderID`) REFERENCES `refillinventoryheader` (`InvHeaderID`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;



--
-- Table structure for table `refillcustomerinventoryheader`
--

DROP TABLE IF EXISTS `refillcustomerinventoryheader`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `refillcustomerinventoryheader` (
  `CustInvID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `CustomerID` int(10) NOT NULL,
  `BottlesOnHand` int(10) unsigned NOT NULL DEFAULT '0',
  `BottlesReturned` int(10) unsigned NOT NULL DEFAULT '0',
  `CapsOnHand` int(10) unsigned NOT NULL DEFAULT '0',
  `CapsReturned` int(10) unsigned NOT NULL DEFAULT '0',
  PRIMARY KEY (`CustInvID`),
  UNIQUE KEY `IX_refillcustinvheader_1` (`CustomerID`), 
  CONSTRAINT `FK_refillcustinvheader_1` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


--
-- Table structure for table `refillcustomerinventorydetail`
--

DROP TABLE IF EXISTS `refillcustomerinventorydetail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `refillcustomerinventorydetail` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `CustInvID` int(10) unsigned NOT NULL,  
  `BottlesReturned` int(10) unsigned NOT NULL DEFAULT '0',  
  `CapsReturned` int(10) unsigned NOT NULL DEFAULT '0',
  `Date` datetime NOT NULL,
  PRIMARY KEY (`ID`),  
  CONSTRAINT `FK_refillcustinvdetail_1` FOREIGN KEY (`CustInvID`) REFERENCES `refillcustomerinventoryheader` (`CustInvID`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- DUMP COMPLETE


