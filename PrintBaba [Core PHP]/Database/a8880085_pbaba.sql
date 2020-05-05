-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jul 19, 2016 at 01:51 AM
-- Server version: 5.6.17
-- PHP Version: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `a8880085_pbaba`
--

-- --------------------------------------------------------

--
-- Table structure for table `experiments`
--

CREATE TABLE IF NOT EXISTS `experiments` (
  `Subject_Name` varchar(5) NOT NULL,
  `Experiment_Name` varchar(10) NOT NULL,
  `Rate` float NOT NULL,
  `Fees` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=hp8;

--
-- Dumping data for table `experiments`
--

INSERT INTO `experiments` (`Subject_Name`, `Experiment_Name`, `Rate`, `Fees`) VALUES
('WT', 'EXP_1', 5, 2),
('WT', 'EXP_2', 5, 2);

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE IF NOT EXISTS `orders` (
  `PSN` varchar(6) NOT NULL,
  `Date` varchar(10) NOT NULL,
  `Name` varchar(20) NOT NULL,
  `Mobile` varchar(10) NOT NULL,
  `Particulars` varchar(100) NOT NULL,
  `Cost` float NOT NULL,
  `Fees` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=hp8;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`PSN`, `Date`, `Name`, `Mobile`, `Particulars`, `Cost`, `Fees`) VALUES
('PB_001', '19/07/16', 'Shaibaz', '9766908355', ' # (WT) (EXP_1, 1 Set, Rs. 5/Set)', 5, 2),
('PB_002', '19/07/16', 'Shaibaz', '9766908355', ' # (WT) (EXP_1, 1 Set, Rs. 5/Set)', 5, 2),
('PB_003', '19/07/16', 'Shaibaz', '9766908355', ' # (WT) (EXP_1, 1 Set, Rs. 5/Set)', 5, 2),
('PB_004', '19/07/16', 'Shaibaz', '9766908355', ' # (WT) (EXP_1, 1 Set, Rs. 5/Set)', 5, 2);

-- --------------------------------------------------------

--
-- Table structure for table `psn`
--

CREATE TABLE IF NOT EXISTS `psn` (
  `PSN` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=hp8;

--
-- Dumping data for table `psn`
--

INSERT INTO `psn` (`PSN`) VALUES
('PB_004');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
