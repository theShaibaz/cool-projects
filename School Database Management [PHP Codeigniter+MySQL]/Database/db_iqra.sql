-- phpMyAdmin SQL Dump
-- version 4.8.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 30, 2018 at 11:41 AM
-- Server version: 10.1.32-MariaDB
-- PHP Version: 7.2.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_iqra`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_fees_term_one`
--

CREATE TABLE `tbl_fees_term_one` (
  `id` int(11) NOT NULL,
  `gr_number` varchar(10) NOT NULL,
  `class` enum('First','Second','Third','Forth','Fifth','Sixth','Seventh','Eghth','Nineth','Tenth') NOT NULL,
  `division` enum('A','B','C','D','None') NOT NULL DEFAULT 'None',
  `june` int(11) NOT NULL,
  `july` int(11) NOT NULL,
  `august` int(11) NOT NULL,
  `september` int(11) NOT NULL,
  `october` int(11) NOT NULL,
  `november` int(11) NOT NULL,
  `term` int(11) NOT NULL,
  `activity` int(11) NOT NULL,
  `computer` int(11) NOT NULL,
  `elearning` int(11) NOT NULL,
  `sport` int(11) NOT NULL,
  `total` int(11) NOT NULL,
  `passed_out` enum('0','1') NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_fees_term_one`
--

INSERT INTO `tbl_fees_term_one` (`id`, `gr_number`, `class`, `division`, `june`, `july`, `august`, `september`, `october`, `november`, `term`, `activity`, `computer`, `elearning`, `sport`, `total`, `passed_out`) VALUES
(38, 'GR123', 'First', 'A', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '1'),
(39, 'GR124', 'First', 'A', 100, 100, 100, 100, 150, 350, 100, 100, 100, 100, 100, 1400, '0'),
(40, 'GR125', 'First', 'A', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '0'),
(41, 'GR126', 'First', 'A', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '0'),
(42, 'GR127', 'First', 'A', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '0'),
(43, 'GR128', 'First', 'A', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '0'),
(44, 'GR129', 'First', 'A', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '0'),
(45, 'GR123', 'First', 'B', 100, 100, 100, 0, 0, 0, 250, 0, 250, 0, 250, 1050, '1'),
(46, 'GR130', 'First', 'B', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '0'),
(51, 'GR131', 'First', 'B', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '0'),
(56, 'GR132', 'Second', 'A', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '1'),
(57, 'GR132', 'Second', 'B', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '1');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_fees_term_two`
--

CREATE TABLE `tbl_fees_term_two` (
  `id` int(11) NOT NULL,
  `gr_number` varchar(10) NOT NULL,
  `class` enum('First','Second','Third','Forth','Fifth','Sixth','Seventh','Eghth','Nineth','Tenth') NOT NULL,
  `division` enum('A','B','C','D','None') NOT NULL DEFAULT 'None',
  `december` int(11) NOT NULL,
  `january` int(11) NOT NULL,
  `february` int(11) NOT NULL,
  `march` int(11) NOT NULL,
  `april` int(11) NOT NULL,
  `may` int(11) NOT NULL,
  `term` int(11) NOT NULL,
  `activity` int(11) NOT NULL,
  `computer` int(11) NOT NULL,
  `elearning` int(11) NOT NULL,
  `sport` int(11) NOT NULL,
  `total` int(11) NOT NULL,
  `passed_out` enum('0','1') NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_fees_term_two`
--

INSERT INTO `tbl_fees_term_two` (`id`, `gr_number`, `class`, `division`, `december`, `january`, `february`, `march`, `april`, `may`, `term`, `activity`, `computer`, `elearning`, `sport`, `total`, `passed_out`) VALUES
(11, 'GR123', 'First', 'A', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '1'),
(12, 'GR124', 'First', 'A', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '0'),
(13, 'GR125', 'First', 'A', 0, 0, 0, 0, 0, 0, 100, 250, 350, 0, 0, 700, '0'),
(14, 'GR126', 'First', 'A', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '0'),
(15, 'GR127', 'First', 'A', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '0'),
(16, 'GR128', 'First', 'A', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '0'),
(17, 'GR129', 'First', 'A', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '0'),
(18, 'GR123', 'First', 'B', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '1'),
(19, 'GR130', 'First', 'B', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '0'),
(23, 'GR131', 'First', 'B', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '0'),
(28, 'GR132', 'Second', 'A', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '1'),
(29, 'GR132', 'Second', 'B', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '1');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_invoices`
--

CREATE TABLE `tbl_invoices` (
  `id` int(11) NOT NULL,
  `gr_number` varchar(10) NOT NULL,
  `class` enum('First','Second','Third','Forth','Fifth','Sixth','Seventh','Eghth','Nineth','Tenth') NOT NULL,
  `division` enum('A','B','C','D','None') NOT NULL DEFAULT 'None',
  `date` date NOT NULL,
  `particulars` varchar(1000) NOT NULL,
  `amount` varchar(1000) NOT NULL,
  `grand_total` int(11) NOT NULL,
  `fees_help` varchar(100) NOT NULL,
  `comment` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_invoices`
--

INSERT INTO `tbl_invoices` (`id`, `gr_number`, `class`, `division`, `date`, `particulars`, `amount`, `grand_total`, `fees_help`, `comment`) VALUES
(21, 'GR123', 'First', 'B', '2018-08-26', 'june july august term_one computer_one sport_one', '100 100 100 250 250 250', 1050, '', ''),
(22, 'GR124', 'First', 'A', '2018-08-28', 'july', '100', 100, '', ''),
(23, 'GR124', 'First', 'A', '2018-08-28', 'august', '100', 100, '', ''),
(24, 'GR124', 'First', 'A', '2018-08-29', 'september october november term_one activity_one computer_one elearning_one sport_one', '100 150 350 100 100 100 100 100', 1100, '', ''),
(25, 'GR125', 'First', 'A', '2018-08-30', 'term_two', '100', 100, '', ''),
(26, 'GR125', 'First', 'A', '2018-08-30', 'activity_two', '250', 250, '', ''),
(29, 'GR125', 'First', 'A', '2018-08-30', 'computer_two', '350', 350, '', '');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_login`
--

CREATE TABLE `tbl_login` (
  `id` int(11) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(256) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_login`
--

INSERT INTO `tbl_login` (`id`, `username`, `password`) VALUES
(1, 'sudo', '$2y$10$jAGPI5XqxDgC9RxYxws4teo2zHD1gYjdyFeBt7Ua0T8lIrbeD0KIO'),
(2, 'user', '$2y$10$gkR4s3y4//M6FJ4o/5.86.ZMvKj7Sw.bVBwymrT6EV1ywqPDQ7GIy'),
(3, 'admin', '$2y$10$B5ggwIyyQABDBUCLIJbXx.X9isqyoeDm7LV0bBzHaLmaDQdK1Kboe');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_students`
--

CREATE TABLE `tbl_students` (
  `gr_number` varchar(10) NOT NULL,
  `name` varchar(255) NOT NULL,
  `class` enum('First','Second','Third','Forth','Fifth','Sixth','Seventh','Eghth','Nineth','Tenth') NOT NULL,
  `division` enum('A','B','C','D') DEFAULT NULL,
  `aadhar` varchar(15) NOT NULL,
  `contact` varchar(15) NOT NULL,
  `alt_contact` varchar(15) NOT NULL,
  `email` varchar(50) NOT NULL,
  `address` varchar(500) NOT NULL,
  `landmark` varchar(100) NOT NULL,
  `comment` varchar(500) NOT NULL,
  `passed_out` enum('0','1') DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_students`
--

INSERT INTO `tbl_students` (`gr_number`, `name`, `class`, `division`, `aadhar`, `contact`, `alt_contact`, `email`, `address`, `landmark`, `comment`, `passed_out`) VALUES
('GR123', 'Shaibaz Mahamad Mulla', 'First', 'B', '', '7588130054', '', '', 'Ratnagiri', 'Airport', '', '1'),
('GR124', 'Shoheb Mahamad Mulla', 'First', 'A', '', '8793264668', '', '', 'Ratnagiri', 'Airport', '', '0'),
('GR125', 'Rida Shoheb Mulla', 'First', 'A', '', '7758856536', '', '', 'Ratnagiri', 'Airport', '', '0'),
('GR126', 'Raziya Mahamad Mulla', 'First', 'A', '', '9145916719', '', '', 'Ratnagiri', 'Airport', '', '0'),
('GR127', 'Mahamad Ibrahim Mulla', 'First', 'A', '', '8668501810', '', '', 'Ratnagiri', 'Airport', '', '0'),
('GR128', 'Zehra Shoheb Mulla', 'First', 'A', '', '8793264668', '', '', 'Ratnagiri', 'Airport', '', '0'),
('GR129', 'Nisar Husain Wagle', 'First', 'A', '', '7588160054', '', '', 'Ratnagiri', 'Airport', '', '0'),
('GR130', 'Shadab Shaukat Wasta', 'First', 'B', '', '8899654111', '', '', 'Ratnagiri', 'Kokan Nagar', '', '0'),
('GR131', 'Shahid Siraj Mukadam', 'First', 'B', '', '8899654111', '', '', 'Ratnagiri', 'Kokan Nagar', '', '0'),
('GR132', 'Mubin Ismaeel Shaikh', 'Second', 'B', '', '7744115522', '', '', 'Ratnagiri\r\n', 'Kokan Nagar', '', '1');

--
-- Triggers `tbl_students`
--
DELIMITER $$
CREATE TRIGGER `import_students` AFTER INSERT ON `tbl_students` FOR EACH ROW BEGIN
    INSERT INTO tbl_fees_term_one(gr_number,class,division)
	VALUES(NEW.gr_number,NEW.class,NEW.division);
    
    INSERT INTO tbl_fees_term_two(gr_number,class,division)
	VALUES(NEW.gr_number,NEW.class,NEW.division);
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_transactions`
--

CREATE TABLE `tbl_transactions` (
  `id` int(11) NOT NULL,
  `type` enum('Income','Expense') NOT NULL,
  `is_of` enum('Fees Payment','Miscellaneous') NOT NULL,
  `date` date NOT NULL,
  `amount` int(11) NOT NULL,
  `payment_mode` enum('Cash','Cheque') NOT NULL,
  `cheque_number` varchar(10) NOT NULL,
  `ifsc_code` varchar(10) NOT NULL,
  `comment` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_transactions`
--

INSERT INTO `tbl_transactions` (`id`, `type`, `is_of`, `date`, `amount`, `payment_mode`, `cheque_number`, `ifsc_code`, `comment`) VALUES
(1, 'Income', 'Fees Payment', '2018-08-16', 3100, 'Cash', '', '', ''),
(2, 'Income', 'Fees Payment', '2018-08-16', 700, 'Cash', '', '', ''),
(3, 'Income', 'Miscellaneous', '2018-08-16', 10000, 'Cash', '', '', ''),
(5, 'Income', 'Miscellaneous', '2018-08-17', 11500, 'Cash', '789', '555', 'hi'),
(8, 'Expense', 'Miscellaneous', '2018-08-17', 500, 'Cash', '789', '555', 'hi'),
(9, 'Income', 'Miscellaneous', '2018-08-16', 10000, 'Cash', '', '', ''),
(11, 'Income', 'Miscellaneous', '2018-08-16', 5000, 'Cheque', '', '', ''),
(21, 'Expense', 'Miscellaneous', '2018-08-16', 5511, 'Cash', '', '', ''),
(25, 'Income', 'Fees Payment', '2018-07-25', 1500, 'Cash', '', '', ''),
(28, 'Income', 'Fees Payment', '2018-07-25', 1500, 'Cash', '', '', ''),
(29, 'Income', 'Fees Payment', '2018-07-25', 1500, 'Cash', '', '', ''),
(30, 'Income', 'Fees Payment', '2018-07-25', 1500, 'Cash', '', '', ''),
(31, 'Income', 'Fees Payment', '2018-07-25', 1500, 'Cash', '', '', ''),
(32, 'Income', 'Fees Payment', '2018-07-25', 1500, 'Cash', '', '', ''),
(33, 'Income', 'Fees Payment', '2018-07-25', 1500, 'Cash', '', '', ''),
(34, 'Income', 'Fees Payment', '2018-07-25', 1500, 'Cash', '', '', ''),
(35, 'Income', 'Fees Payment', '2018-07-25', 1500, 'Cash', '', '', ''),
(36, 'Income', 'Fees Payment', '2018-07-25', 1500, 'Cash', '', '', ''),
(37, 'Income', 'Fees Payment', '2018-07-25', 1500, 'Cash', '', '', ''),
(38, 'Income', 'Fees Payment', '2018-07-25', 1500, 'Cash', '', '', ''),
(39, 'Income', 'Fees Payment', '2018-08-28', 100, 'Cash', '', '', ''),
(40, 'Income', 'Fees Payment', '2018-08-28', 100, 'Cash', '', '', ''),
(41, 'Income', 'Fees Payment', '2018-08-29', 1100, 'Cash', '', '', ''),
(42, 'Income', 'Miscellaneous', '2018-08-29', 5500, 'Cash', '', '', ''),
(43, 'Income', 'Fees Payment', '2018-08-30', 100, 'Cash', '', '', ''),
(44, 'Income', 'Fees Payment', '2018-08-30', 250, 'Cash', '', '', ''),
(45, 'Income', 'Fees Payment', '2018-08-30', 350, 'Cash', '', '', ''),
(46, 'Income', 'Fees Payment', '2018-08-30', 350, 'Cash', '', '', ''),
(47, 'Income', 'Fees Payment', '2018-08-30', 350, 'Cash', '', '', '');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_fees_term_one`
--
ALTER TABLE `tbl_fees_term_one`
  ADD PRIMARY KEY (`id`),
  ADD KEY `gr_number` (`gr_number`);

--
-- Indexes for table `tbl_fees_term_two`
--
ALTER TABLE `tbl_fees_term_two`
  ADD PRIMARY KEY (`id`),
  ADD KEY `gr_number` (`gr_number`);

--
-- Indexes for table `tbl_invoices`
--
ALTER TABLE `tbl_invoices`
  ADD PRIMARY KEY (`id`),
  ADD KEY `gr_number` (`gr_number`);

--
-- Indexes for table `tbl_login`
--
ALTER TABLE `tbl_login`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Indexes for table `tbl_students`
--
ALTER TABLE `tbl_students`
  ADD PRIMARY KEY (`gr_number`),
  ADD UNIQUE KEY `name` (`name`);

--
-- Indexes for table `tbl_transactions`
--
ALTER TABLE `tbl_transactions`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_fees_term_one`
--
ALTER TABLE `tbl_fees_term_one`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=58;

--
-- AUTO_INCREMENT for table `tbl_fees_term_two`
--
ALTER TABLE `tbl_fees_term_two`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT for table `tbl_invoices`
--
ALTER TABLE `tbl_invoices`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT for table `tbl_login`
--
ALTER TABLE `tbl_login`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tbl_transactions`
--
ALTER TABLE `tbl_transactions`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=48;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_fees_term_one`
--
ALTER TABLE `tbl_fees_term_one`
  ADD CONSTRAINT `tbl_fees_term_one_ibfk_1` FOREIGN KEY (`gr_number`) REFERENCES `tbl_students` (`gr_number`);

--
-- Constraints for table `tbl_fees_term_two`
--
ALTER TABLE `tbl_fees_term_two`
  ADD CONSTRAINT `tbl_fees_term_two_ibfk_1` FOREIGN KEY (`gr_number`) REFERENCES `tbl_students` (`gr_number`);

--
-- Constraints for table `tbl_invoices`
--
ALTER TABLE `tbl_invoices`
  ADD CONSTRAINT `tbl_invoices_ibfk_1` FOREIGN KEY (`gr_number`) REFERENCES `tbl_students` (`gr_number`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
