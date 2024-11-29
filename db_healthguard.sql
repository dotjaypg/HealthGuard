-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 29, 2024 at 04:14 PM
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

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `GeneratePatientID` (OUT `NewPatientID` VARCHAR(6))   BEGIN
    DECLARE next_id INT;
    
    -- Get the last used PatientID from ID_Tracker
    SELECT LastID INTO next_id FROM ID_Tracker WHERE Entity = 'PatientID';
    
    -- Generate the new PatientID (prefix 'P' + the next number)
    SET NewPatientID = CONCAT('P', next_id + 1);
    
    -- Update the ID_Tracker table with the new value
    UPDATE ID_Tracker SET LastID = next_id + 1 WHERE Entity = 'PatientID';
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `GenerateScheduleID` (OUT `NewScheduleID` VARCHAR(8))   BEGIN
    DECLARE next_id INT;
    
    -- Get the last used ScheduleID from ID_Tracker
    SELECT LastID INTO next_id FROM ID_Tracker WHERE Entity = 'ScheduleID';
    
    -- Generate the new ScheduleID (prefix 'S' + the next number)
    SET NewScheduleID = CONCAT('S', next_id + 1);
    
    -- Update the ID_Tracker table with the new value
    UPDATE ID_Tracker SET LastID = next_id + 1 WHERE Entity = 'ScheduleID';
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `GenerateUserID` (OUT `NewUserID` VARCHAR(6))   BEGIN
    DECLARE next_id INT;
    
    -- Get the last used UserID from ID_Tracker
    SELECT LastID INTO next_id FROM ID_Tracker WHERE Entity = 'UserID';
    
    -- Generate the new UserID (prefix 'A' + the next number)
    SET NewUserID = CONCAT('A', next_id + 1);
    
    -- Update the ID_Tracker table with the new value
    UPDATE ID_Tracker SET LastID = next_id + 1 WHERE Entity = 'UserID';
END$$

DELIMITER ;

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
('A1', 'Admin', 'Ronald', 'Policher', 'Dycoco', 'test', 'test', '09947238473', 'Active', '2024-11-29 22:03:15', NULL, NULL, NULL),
('A2', 'Patient', 'Juan', 'Dela', 'Cruz', 'juan.cruz@gmail.com', 'HG#123@C', '09171234567', 'Active', '2024-11-27 20:02:54', 'P1', NULL, NULL),
('A3', 'Doctor', 'Manuel', 'Luis', 'Santos', 'manuel.luis.santos@healthguard.com', 'HG#123@C', '09391234567', 'Active', '2024-11-27 20:02:54', NULL, 'Cardiology', 'Cardiologist'),
('A4', 'Doctor', 'Jundill Mhar', 'Pila', 'Reyes', 'jundill@gmail.com', 'jun123', '09123456789', 'Active', '2024-11-27 20:07:36', NULL, 'Surgery', 'Cardiology');

-- --------------------------------------------------------

--
-- Table structure for table `id_tracker`
--

CREATE TABLE `id_tracker` (
  `Entity` varchar(50) NOT NULL,
  `LastID` int(11) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `id_tracker`
--

INSERT INTO `id_tracker` (`Entity`, `LastID`) VALUES
('PatientID', 1),
('ScheduleID', 0),
('UserID', 4);

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
  `BloodType` enum('A+','A-','B+','B-','AB+','AB-','O+','O-') DEFAULT NULL,
  `Phone` varchar(15) DEFAULT NULL,
  `ParentGuardian` varchar(255) DEFAULT NULL,
  `Email` varchar(255) DEFAULT NULL,
  `Address` text DEFAULT NULL,
  `PrimaryDiagnoses` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `patients`
--

INSERT INTO `patients` (`PatientID`, `FirstName`, `MiddleName`, `LastName`, `Sex`, `DateOfBirth`, `BloodType`, `Phone`, `ParentGuardian`, `Email`, `Address`, `PrimaryDiagnoses`) VALUES
('P1', 'Juan', 'Dela', 'Cruz', 'Male', '2005-01-04', 'B+', '09171234567', 'Maria Dela Cruz', 'juan.cruz@gmail.com', '123 Main St, QC', 'Hypertension');

-- --------------------------------------------------------

--
-- Table structure for table `prescriptions`
--

CREATE TABLE `prescriptions` (
  `PrescriptionID` int(11) NOT NULL,
  `PatientID` char(6) NOT NULL,
  `DoctorID` char(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

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
-- Indexes for table `id_tracker`
--
ALTER TABLE `id_tracker`
  ADD PRIMARY KEY (`Entity`);

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
