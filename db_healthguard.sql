-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 28, 2024 at 03:41 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_healthguard`
--

-- --------------------------------------------------------

--
-- Table structure for table `accounts`
--

CREATE TABLE `accounts` (
  `UserID` char(6) NOT NULL,
  `Role` enum('Patient','Nurse','Doctor','Admin') NOT NULL,
  `FirstName` varchar(255) NOT NULL,
  `MiddleName` varchar(255) DEFAULT NULL,
  `LastName` varchar(255) NOT NULL,
  `EmailUsername` varchar(255) NOT NULL,
  `Password` varchar(255) DEFAULT 'HG#123@C',
  `ContactNumber` varchar(15) DEFAULT NULL,
  `Status` enum('Active','Pending','Disabled') DEFAULT 'Pending',
  `CreationDate` datetime DEFAULT current_timestamp(),
  `PatientID` char(6) DEFAULT NULL,
  `AssignedDepartment` varchar(255) DEFAULT NULL,
  `Specialization` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `accounts`
--

INSERT INTO `accounts` (`UserID`, `Role`, `FirstName`, `MiddleName`, `LastName`, `EmailUsername`, `Password`, `ContactNumber`, `Status`, `CreationDate`, `PatientID`, `AssignedDepartment`, `Specialization`) VALUES
('', 'Admin', 'FirstName', 'MiddleName', 'LastName', 'test', 'test', NULL, 'Active', '2024-11-27 20:07:36', NULL, NULL, NULL),
('A10001', 'Patient', 'Juan', 'Dela', 'Cruz', 'juan.cruz@gmail.com', 'HG#123@C', '09171234567', 'Active', '2024-11-27 20:02:54', 'P00001', NULL, NULL),
('A10002', 'Doctor', 'Manuel', 'Luis', 'Santos', 'manuel.luis.santos@healthguard.com', 'HG#123@C', '09391234567', 'Active', '2024-11-27 20:02:54', NULL, 'Cardiology', 'Cardiologist');

-- --------------------------------------------------------

--
-- Table structure for table `medicines`
--

CREATE TABLE `medicines` (
  `MedicineID` int(11) NOT NULL,
  `PrescriptionID` int(11) NOT NULL,
  `MedicineName` varchar(255) NOT NULL,
  `Dosage` varchar(255) DEFAULT NULL,
  `Frequency` varchar(255) DEFAULT NULL,
  `Duration` varchar(255) DEFAULT NULL,
  `Instructions` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `medicines`
--

INSERT INTO `medicines` (`MedicineID`, `PrescriptionID`, `MedicineName`, `Dosage`, `Frequency`, `Duration`, `Instructions`) VALUES
(1, 1, 'Paracetamol', '500mg', 'Twice a day', '5 days', 'Take after meals'),
(2, 2, 'Metformin', '850mg', 'Once a day', '30 days', 'Take with breakfast');

-- --------------------------------------------------------

--
-- Table structure for table `patients`
--

CREATE TABLE `patients` (
  `PatientID` char(6) NOT NULL,
  `FirstName` varchar(255) NOT NULL,
  `MiddleName` varchar(255) DEFAULT NULL,
  `LastName` varchar(255) NOT NULL,
  `Sex` enum('Male','Female','Other') DEFAULT NULL,
  `DateOfBirth` date NOT NULL,
  `Age` int(11) GENERATED ALWAYS AS (year(curdate()) - year(`DateOfBirth`)) VIRTUAL,
  `BloodType` enum('A','B','AB','O') DEFAULT NULL,
  `Phone` varchar(15) DEFAULT NULL,
  `ParentGuardian` varchar(255) DEFAULT NULL,
  `Email` varchar(255) DEFAULT NULL,
  `Address` text DEFAULT NULL,
  `Country` varchar(100) DEFAULT NULL,
  `PrimaryDiagnoses` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `patients`
--

INSERT INTO `patients` (`PatientID`, `FirstName`, `MiddleName`, `LastName`, `Sex`, `DateOfBirth`, `BloodType`, `Phone`, `ParentGuardian`, `Email`, `Address`, `Country`, `PrimaryDiagnoses`) VALUES
('P00001', 'Juan', 'Dela', 'Cruz', 'Male', '1990-01-15', 'O', '09171234567', 'Maria Dela Cruz', 'juan.cruz@gmail.com', '123 Main St, QC', 'Philippines', 'Hypertension'),
('P00002', 'Maria', 'Santos', 'Reyes', 'Female', '1985-03-22', 'A', '09281234567', 'Juan Reyes', 'maria.reyes@gmail.com', '456 Elm St, Pasig', 'Philippines', 'Diabetes');

-- --------------------------------------------------------

--
-- Table structure for table `prescriptions`
--

CREATE TABLE `prescriptions` (
  `PrescriptionID` int(11) NOT NULL,
  `PatientID` char(6) NOT NULL,
  `DoctorID` char(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `prescriptions`
--

INSERT INTO `prescriptions` (`PrescriptionID`, `PatientID`, `DoctorID`) VALUES
(1, 'P00001', 'A10002'),
(2, 'P00002', 'A10002');

-- --------------------------------------------------------

--
-- Table structure for table `schedules`
--

CREATE TABLE `schedules` (
  `ScheduleID` char(8) NOT NULL,
  `StartDate` date DEFAULT NULL,
  `EndDate` datetime DEFAULT NULL,
  `AllDay` tinyint(1) DEFAULT 0,
  `StartTime` time DEFAULT NULL,
  `EndTime` time DEFAULT NULL,
  `PatientID` char(6) NOT NULL,
  `DoctorID` char(6) NOT NULL,
  `Status` enum('Requested','Scheduled','Declined','Past') DEFAULT 'Scheduled',
  `RequestStatus` enum('Accepted','Declined') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `schedules`
--

INSERT INTO `schedules` (`ScheduleID`, `StartDate`, `EndDate`, `AllDay`, `StartTime`, `EndTime`, `PatientID`, `DoctorID`, `Status`, `RequestStatus`) VALUES
('SCHED001', '2024-11-15', NULL, 0, '09:00:00', '10:00:00', 'P00001', 'A10002', 'Past', 'Accepted'),
('SCHED002', '2024-11-28', NULL, 1, NULL, NULL, 'P00002', 'A10002', 'Requested', 'Accepted'),
('SCHED003', '2024-12-10', NULL, 0, NULL, NULL, 'P00002', 'A10002', 'Scheduled', 'Accepted');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `accounts`
--
ALTER TABLE `accounts`
  ADD PRIMARY KEY (`UserID`),
  ADD UNIQUE KEY `Email` (`EmailUsername`),
  ADD KEY `PatientID` (`PatientID`);

--
-- Indexes for table `medicines`
--
ALTER TABLE `medicines`
  ADD PRIMARY KEY (`MedicineID`),
  ADD KEY `PrescriptionID` (`PrescriptionID`);

--
-- Indexes for table `patients`
--
ALTER TABLE `patients`
  ADD PRIMARY KEY (`PatientID`),
  ADD UNIQUE KEY `Email` (`Email`);

--
-- Indexes for table `prescriptions`
--
ALTER TABLE `prescriptions`
  ADD PRIMARY KEY (`PrescriptionID`),
  ADD KEY `PatientID` (`PatientID`),
  ADD KEY `DoctorID` (`DoctorID`);

--
-- Indexes for table `schedules`
--
ALTER TABLE `schedules`
  ADD PRIMARY KEY (`ScheduleID`),
  ADD KEY `PatientID` (`PatientID`),
  ADD KEY `DoctorID` (`DoctorID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `medicines`
--
ALTER TABLE `medicines`
  MODIFY `MedicineID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `prescriptions`
--
ALTER TABLE `prescriptions`
  MODIFY `PrescriptionID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `accounts`
--
ALTER TABLE `accounts`
  ADD CONSTRAINT `accounts_ibfk_1` FOREIGN KEY (`PatientID`) REFERENCES `patients` (`PatientID`) ON DELETE SET NULL;

--
-- Constraints for table `medicines`
--
ALTER TABLE `medicines`
  ADD CONSTRAINT `medicines_ibfk_1` FOREIGN KEY (`PrescriptionID`) REFERENCES `prescriptions` (`PrescriptionID`) ON DELETE CASCADE;

--
-- Constraints for table `prescriptions`
--
ALTER TABLE `prescriptions`
  ADD CONSTRAINT `prescriptions_ibfk_1` FOREIGN KEY (`PatientID`) REFERENCES `patients` (`PatientID`) ON DELETE CASCADE,
  ADD CONSTRAINT `prescriptions_ibfk_2` FOREIGN KEY (`DoctorID`) REFERENCES `accounts` (`UserID`) ON DELETE CASCADE;

--
-- Constraints for table `schedules`
--
ALTER TABLE `schedules`
  ADD CONSTRAINT `schedules_ibfk_1` FOREIGN KEY (`PatientID`) REFERENCES `patients` (`PatientID`) ON DELETE CASCADE,
  ADD CONSTRAINT `schedules_ibfk_2` FOREIGN KEY (`DoctorID`) REFERENCES `accounts` (`UserID`) ON DELETE CASCADE;

DELIMITER $$
--
-- Events
--
CREATE DEFINER=`root`@`localhost` EVENT `update_schedule_status` ON SCHEDULE EVERY 1 DAY STARTS '2024-11-28 20:05:59' ON COMPLETION NOT PRESERVE ENABLE DO UPDATE Schedules
    SET Status = 'Past'
    WHERE StartDate < CURDATE() AND Status != 'Past'$$

DELIMITER ;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
