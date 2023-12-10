-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 05, 2023 at 04:52 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.0.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `studentinfosys`
--

-- --------------------------------------------------------

--
-- Table structure for table `courses`
--

CREATE TABLE `courses` (
  `courseid` int(11) NOT NULL,
  `coursename` varchar(255) NOT NULL,
  `coursecode` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `courses`
--

INSERT INTO `courses` (`courseid`, `coursename`, `coursecode`) VALUES
(1, 'Bachelor of Science in Information Technology', 'BSIT'),
(2, 'Bachelor of Science in Computer Science', 'BSCS');

-- --------------------------------------------------------

--
-- Table structure for table `enrollmentdata`
--

CREATE TABLE `enrollmentdata` (
  `enrollmentid` int(11) NOT NULL,
  `studentid` int(11) NOT NULL,
  `courseid` int(11) NOT NULL,
  `year` int(11) NOT NULL,
  `unit` int(11) DEFAULT NULL,
  `status` varchar(20) NOT NULL,
  `completed` tinyint(1) NOT NULL,
  `date_registered` datetime NOT NULL,
  `date_enrolled` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `enrollmentdata`
--

INSERT INTO `enrollmentdata` (`enrollmentid`, `studentid`, `courseid`, `year`, `unit`, `status`, `completed`, `date_registered`, `date_enrolled`) VALUES
(1, 1, 2, 1, 20, 'Enrolled', 0, '2023-12-05 01:54:53', '2023-12-05 01:54:53'),
(2, 2, 2, 1, 21, 'Enrolled', 0, '2023-12-05 04:46:32', '2023-12-05 04:46:32');

-- --------------------------------------------------------

--
-- Table structure for table `installment`
--

CREATE TABLE `installment` (
  `installmentid` int(11) NOT NULL,
  `tuitionid` int(11) NOT NULL,
  `installmentperiod` int(11) NOT NULL,
  `originalamount` double NOT NULL,
  `duedate` date NOT NULL,
  `additionalfeepercent` double NOT NULL,
  `totalamount` double NOT NULL,
  `remainingbalance` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `installment`
--

INSERT INTO `installment` (`installmentid`, `tuitionid`, `installmentperiod`, `originalamount`, `duedate`, `additionalfeepercent`, `totalamount`, `remainingbalance`) VALUES
(1, 1, 1, 6000, '2023-12-04', 5, 6300, 6300),
(2, 1, 2, 6000, '2023-12-04', 5, 6300, 6300),
(3, 1, 3, 6000, '2024-01-19', 5, 6000, 6000),
(4, 1, 4, 6000, '2024-02-03', 5, 6000, 6000),
(5, 1, 5, 6000, '2024-02-18', 5, 6000, 6000),
(6, 2, 1, 6300, '2023-12-20', 5, 6300, 0),
(7, 2, 2, 6300, '2024-01-04', 5, 6300, 4600),
(8, 2, 3, 6300, '2024-01-19', 5, 6300, 6300),
(9, 2, 4, 6300, '2024-02-03', 5, 6300, 6300),
(10, 2, 5, 6300, '2024-02-18', 5, 6300, 6300);

-- --------------------------------------------------------

--
-- Table structure for table `paymenthistory`
--

CREATE TABLE `paymenthistory` (
  `transactionid` int(11) NOT NULL,
  `referencenumber` varchar(255) NOT NULL,
  `studentid` int(11) NOT NULL,
  `coursecode` varchar(20) NOT NULL,
  `year` int(11) NOT NULL,
  `unit` int(11) NOT NULL,
  `installmentperiod` int(11) NOT NULL,
  `paymentmethod` varchar(20) NOT NULL,
  `phonenumber` varchar(12) NOT NULL,
  `recievername` varchar(255) DEFAULT NULL,
  `amountpaid` double NOT NULL,
  `remainingbalance` double NOT NULL,
  `datesent` datetime NOT NULL,
  `daterecieved` datetime NOT NULL,
  `status` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `paymenthistory`
--

INSERT INTO `paymenthistory` (`transactionid`, `referencenumber`, `studentid`, `coursecode`, `year`, `unit`, `installmentperiod`, `paymentmethod`, `phonenumber`, `recievername`, `amountpaid`, `remainingbalance`, `datesent`, `daterecieved`, `status`) VALUES
(1, 'ST2023125204316284', 2, 'BSCS', 1, 21, 1, 'CASH ON COUNTER', '09856234523', 'College portal', 8000, 0, '2023-12-05 20:43:16', '2023-12-05 20:43:16', 'Paid'),
(2, 'ST2023125204316434', 2, 'BSCS', 1, 21, 2, 'CASH ON COUNTER', '09856234523', 'College portal', 1700, 4600, '2023-12-05 20:43:16', '2023-12-05 20:43:16', 'Paid');

-- --------------------------------------------------------

--
-- Table structure for table `personaldata`
--

CREATE TABLE `personaldata` (
  `studentid` int(11) NOT NULL,
  `userid` int(11) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `age` int(11) NOT NULL,
  `address` varchar(255) NOT NULL,
  `walletid` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `personaldata`
--

INSERT INTO `personaldata` (`studentid`, `userid`, `lastname`, `firstname`, `gender`, `age`, `address`, `walletid`) VALUES
(1, 1, 'Doe', 'John', 'Male', 18, '#123 Street', 1),
(2, 2, 'Doe', 'Jessica', 'Female', 18, 'address nnmn', 2);

-- --------------------------------------------------------

--
-- Table structure for table `tuitionfee`
--

CREATE TABLE `tuitionfee` (
  `tuitionid` int(11) NOT NULL,
  `enrollmentid` int(11) NOT NULL,
  `balance` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tuitionfee`
--

INSERT INTO `tuitionfee` (`tuitionid`, `enrollmentid`, `balance`) VALUES
(1, 1, 30000),
(2, 2, 31500);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `userid` int(11) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `email` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`userid`, `username`, `password`, `email`) VALUES
(1, 'johndoe123', 'password123', 'johndoe@email.com'),
(2, 'jessica123', 'pass123', 'jessko@email.com');

-- --------------------------------------------------------

--
-- Table structure for table `walletaccount`
--

CREATE TABLE `walletaccount` (
  `walletid` int(11) NOT NULL,
  `phonenumber` varchar(12) NOT NULL,
  `accountname` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `walletaccount`
--

INSERT INTO `walletaccount` (`walletid`, `phonenumber`, `accountname`) VALUES
(1, '09943655811', 'johndoe'),
(2, '09856234523', 'jess');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `courses`
--
ALTER TABLE `courses`
  ADD PRIMARY KEY (`courseid`);

--
-- Indexes for table `enrollmentdata`
--
ALTER TABLE `enrollmentdata`
  ADD PRIMARY KEY (`enrollmentid`),
  ADD UNIQUE KEY `studentid` (`studentid`),
  ADD KEY `courseid` (`courseid`);

--
-- Indexes for table `installment`
--
ALTER TABLE `installment`
  ADD PRIMARY KEY (`installmentid`),
  ADD KEY `tuitionid` (`tuitionid`);

--
-- Indexes for table `paymenthistory`
--
ALTER TABLE `paymenthistory`
  ADD PRIMARY KEY (`transactionid`);

--
-- Indexes for table `personaldata`
--
ALTER TABLE `personaldata`
  ADD PRIMARY KEY (`studentid`),
  ADD UNIQUE KEY `userid` (`userid`),
  ADD UNIQUE KEY `walletid` (`walletid`);

--
-- Indexes for table `tuitionfee`
--
ALTER TABLE `tuitionfee`
  ADD PRIMARY KEY (`tuitionid`),
  ADD KEY `enrollmentid` (`enrollmentid`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`userid`);

--
-- Indexes for table `walletaccount`
--
ALTER TABLE `walletaccount`
  ADD PRIMARY KEY (`walletid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `courses`
--
ALTER TABLE `courses`
  MODIFY `courseid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `enrollmentdata`
--
ALTER TABLE `enrollmentdata`
  MODIFY `enrollmentid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `installment`
--
ALTER TABLE `installment`
  MODIFY `installmentid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `paymenthistory`
--
ALTER TABLE `paymenthistory`
  MODIFY `transactionid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `personaldata`
--
ALTER TABLE `personaldata`
  MODIFY `studentid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tuitionfee`
--
ALTER TABLE `tuitionfee`
  MODIFY `tuitionid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `userid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `walletaccount`
--
ALTER TABLE `walletaccount`
  MODIFY `walletid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `enrollmentdata`
--
ALTER TABLE `enrollmentdata`
  ADD CONSTRAINT `enrollmentdata_ibfk_1` FOREIGN KEY (`courseid`) REFERENCES `courses` (`courseid`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `enrollmentdata_ibfk_2` FOREIGN KEY (`studentid`) REFERENCES `personaldata` (`studentid`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `installment`
--
ALTER TABLE `installment`
  ADD CONSTRAINT `installment_ibfk_1` FOREIGN KEY (`tuitionid`) REFERENCES `tuitionfee` (`tuitionid`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `personaldata`
--
ALTER TABLE `personaldata`
  ADD CONSTRAINT `personaldata_ibfk_1` FOREIGN KEY (`walletid`) REFERENCES `walletaccount` (`walletid`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `personaldata_ibfk_2` FOREIGN KEY (`userid`) REFERENCES `users` (`userid`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `tuitionfee`
--
ALTER TABLE `tuitionfee`
  ADD CONSTRAINT `tuitionfee_ibfk_1` FOREIGN KEY (`enrollmentid`) REFERENCES `enrollmentdata` (`enrollmentid`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
