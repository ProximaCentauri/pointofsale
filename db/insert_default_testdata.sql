-- MySQL dump 10.13  Distrib 5.5.29, for Win32 (x86)
-- Date Modified:	 March 08, 2013
-- Host: localhost    Database: db_laundry_refilling
-- ------------------------------------------------------
-- Server version	5.5.29-log

-- DEFAULT FOR TEST DATA

-- Laaundry - services table
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

-- Refill and Laundry Company Info
INSERT INTO `db_laundry_refilling`.`company` (`Name`,`Address`,`ContactNumber`,`VoidFlag`) VALUES ('Bottoms Up Purified Drinking Water','Mandaue City','239-9555','0');
INSERT INTO `db_laundry_refilling`.`company` (`Name`,`Address`,`ContactNumber`,`VoidFlag`) VALUES ('Laundry Pro Garmet Care','Mandaue City','239-9555','0');

-- Customer table (for testing only)
INSERT INTO `db_laundry_refilling`.`customer` (`Name`, `Address`, `ContactNumber`) VALUES ('John Dee', 'Cebu', '111-1111');
INSERT INTO `db_laundry_refilling`.`customer` (`Name`, `Address`, `ContactNumber`) VALUES ('Vanessa Dee', 'Cebu', '111-1111');

-- Refill inventory table (for testing only)
INSERT INTO `db_laundry_refilling`.`refillinventoryheader` (`Name`, `TotalQty`, `QtyOnHand`, `QtyReleased`) VALUES ('5 GAL BOTTLE', '400', '400', '0');
INSERT INTO `db_laundry_refilling`.`refillinventoryheader` (`Name`, `TotalQty`, `QtyOnHand`, `QtyReleased`) VALUES ('CAPS', '100', '100', '0');


-- Refill inventory table (for testing only)
INSERT INTO `db_laundry_refilling`.`refillinventorydetail` (`InvHeaderID`, `QtyAdded`, `QtyRemoved`, `TotalQty`,`QtyOnHand`,`QtyReleased`,`Date`) VALUES ('1','100','0','100','100','0','2013-02-09 00:00:00');
INSERT INTO `db_laundry_refilling`.`refillinventorydetail` (`InvHeaderID`, `QtyAdded`, `QtyRemoved`, `TotalQty`,`QtyOnHand`,`QtyReleased`,`Date`) VALUES ('1','100','0','200','200','0','2013-02-10 00:00:00');
INSERT INTO `db_laundry_refilling`.`refillinventorydetail` (`InvHeaderID`, `QtyAdded`, `QtyRemoved`, `TotalQty`,`QtyOnHand`,`QtyReleased`,`Date`) VALUES ('1','100','0','300','300','0','2013-02-11 00:00:00');
INSERT INTO `db_laundry_refilling`.`refillinventorydetail` (`InvHeaderID`, `QtyAdded`, `QtyRemoved`, `TotalQty`,`QtyOnHand`,`QtyReleased`,`Date`) VALUES ('1','100','0','400','400','0','2013-02-12 00:00:00');
INSERT INTO `db_laundry_refilling`.`refillinventorydetail` (`InvHeaderID`, `QtyAdded`, `QtyRemoved`, `TotalQty`,`QtyOnHand`,`QtyReleased`,`Date`) VALUES ('2','100','0','100','100','0','2013-02-12 00:00:00');