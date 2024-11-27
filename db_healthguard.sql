-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 27, 2024 at 04:16 PM
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
('A10002', 'Doctor', 'Dr.', 'Luis', 'Santos', 'luis.santos@healthguard.com', 'HG#123@C', '09391234567', 'Active', '2024-11-27 20:02:54', NULL, 'Cardiology', 'Cardiologist');

--
-- Triggers `accounts`
--
DELIMITER $$
CREATE TRIGGER `trg_accounts_delete` AFTER DELETE ON `accounts` FOR EACH ROW BEGIN
    INSERT INTO audit_logs (ActionType, TableName, RecordID, UserID, Changes)
    VALUES ('DELETE', 'accounts', OLD.UserID, NULL, CONCAT('Deleted Account: ', OLD.FirstName, ' ', OLD.LastName));
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `trg_accounts_insert` AFTER INSERT ON `accounts` FOR EACH ROW BEGIN
    INSERT INTO audit_logs (ActionType, TableName, RecordID, UserID, Changes)
    VALUES ('INSERT', 'accounts', NEW.UserID, NULL, CONCAT('New Account Added: ', NEW.FirstName, ' ', NEW.LastName));
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `trg_accounts_update` AFTER UPDATE ON `accounts` FOR EACH ROW BEGIN
    INSERT INTO audit_logs (ActionType, TableName, RecordID, UserID, Changes)
    VALUES ('UPDATE', 'accounts', OLD.UserID, NULL, CONCAT('Updated Account: ', OLD.UserID));
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `audit_logs`
--

CREATE TABLE `audit_logs` (
  `LogID` int(11) NOT NULL,
  `ActionType` enum('INSERT','UPDATE','DELETE') NOT NULL,
  `TableName` varchar(100) NOT NULL,
  `RecordID` varchar(255) NOT NULL,
  `ActionTime` timestamp NOT NULL DEFAULT current_timestamp(),
  `UserID` varchar(255) DEFAULT NULL,
  `Changes` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

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
-- Table structure for table `patientallergies`
--

CREATE TABLE `patientallergies` (
  `AllergyID` int(11) NOT NULL,
  `PatientID` char(6) NOT NULL,
  `Allergy` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `patientallergies`
--

INSERT INTO `patientallergies` (`AllergyID`, `PatientID`, `Allergy`) VALUES
(1, 'P00001', 'Peanuts'),
(2, 'P00002', 'Penicillin');

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
  `ExternalPatientID` varchar(50) DEFAULT NULL,
  `BloodType` enum('A','B','AB','O') DEFAULT NULL,
  `ClinicSite` varchar(255) DEFAULT NULL,
  `ReferredBy` varchar(255) DEFAULT NULL,
  `ReferredDate` date DEFAULT NULL,
  `PlaceOfBirth` varchar(255) DEFAULT NULL,
  `Occupation` varchar(255) DEFAULT NULL,
  `Phone` varchar(15) DEFAULT NULL,
  `Religion` varchar(255) DEFAULT NULL,
  `ParentGuardian` varchar(255) DEFAULT NULL,
  `Email` varchar(255) DEFAULT NULL,
  `Address` text DEFAULT NULL,
  `Country` varchar(100) DEFAULT NULL,
  `PrimaryDiagnoses` text DEFAULT NULL,
  `OperativePlan` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `patients`
--

INSERT INTO `patients` (`PatientID`, `FirstName`, `MiddleName`, `LastName`, `Sex`, `DateOfBirth`, `ExternalPatientID`, `BloodType`, `ClinicSite`, `ReferredBy`, `ReferredDate`, `PlaceOfBirth`, `Occupation`, `Phone`, `Religion`, `ParentGuardian`, `Email`, `Address`, `Country`, `PrimaryDiagnoses`, `OperativePlan`) VALUES
('P00001', 'Juan', 'Dela', 'Cruz', 'Male', '1990-01-15', NULL, 'O', 'Quezon City General Hospital', 'Dr. Santos', '2024-11-01', 'Manila', 'Engineer', '09171234567', 'Catholic', 'Maria Dela Cruz', 'juan.cruz@gmail.com', '123 Main St, QC', 'Philippines', 'Hypertension', 'None'),
('P00002', 'Maria', 'Santos', 'Reyes', 'Female', '1985-03-22', NULL, 'A', 'Metro Health Clinic', 'Dr. Rivera', '2024-11-10', 'Pasig', 'Teacher', '09281234567', 'Christian', 'Juan Reyes', 'maria.reyes@gmail.com', '456 Elm St, Pasig', 'Philippines', 'Diabetes', 'Scheduled Surgery');

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
  `AppointmentType` enum('Admission','Clinic','Follow-Up','Lab') NOT NULL,
  `StartDate` datetime DEFAULT NULL,
  `EndDate` datetime DEFAULT NULL,
  `AllDay` tinyint(1) DEFAULT 0,
  `StartTime` time DEFAULT NULL,
  `EndTime` time DEFAULT NULL,
  `PatientID` char(6) NOT NULL,
  `DoctorID` char(6) NOT NULL,
  `Location` varchar(255) DEFAULT NULL,
  `Status` enum('Attended','Scheduled','Cancelled','Missed') DEFAULT 'Scheduled',
  `RequestStatus` enum('Accepted','Declined') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `schedules`
--

INSERT INTO `schedules` (`ScheduleID`, `AppointmentType`, `StartDate`, `EndDate`, `AllDay`, `StartTime`, `EndTime`, `PatientID`, `DoctorID`, `Location`, `Status`, `RequestStatus`) VALUES
('SCHED001', 'Clinic', '2024-11-15 09:00:00', NULL, 0, '09:00:00', '10:00:00', 'P00001', 'A10002', 'Quezon City General Hospital', 'Scheduled', 'Accepted'),
('SCHED002', 'Follow-Up', '2024-11-20 10:00:00', NULL, 1, NULL, NULL, 'P00002', 'A10002', 'Metro Health Clinic', 'Scheduled', 'Accepted');

-- --------------------------------------------------------

--
-- Table structure for table `visits`
--

CREATE TABLE `visits` (
  `VisitID` int(11) NOT NULL,
  `PatientID` char(6) NOT NULL,
  `AdmissionDate` datetime DEFAULT NULL,
  `DischargeDate` datetime DEFAULT NULL,
  `VisitType` enum('Check-Up','Follow-Up','Emergency') DEFAULT NULL,
  `Location` varchar(255) DEFAULT NULL,
  `Examiner` varchar(255) DEFAULT NULL,
  `ReasonForVisit` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `visits`
--

INSERT INTO `visits` (`VisitID`, `PatientID`, `AdmissionDate`, `DischargeDate`, `VisitType`, `Location`, `Examiner`, `ReasonForVisit`) VALUES
(1, 'P00001', '2024-11-01 09:00:00', '2024-11-05 18:00:00', 'Check-Up', 'Room 101', 'Dr. Santos', 'Routine Check-Up'),
(2, 'P00002', '2024-11-10 10:00:00', NULL, 'Follow-Up', 'Room 202', 'Dr. Rivera', 'Diabetes Monitoring');

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
-- Indexes for table `audit_logs`
--
ALTER TABLE `audit_logs`
  ADD PRIMARY KEY (`LogID`);

--
-- Indexes for table `medicines`
--
ALTER TABLE `medicines`
  ADD PRIMARY KEY (`MedicineID`),
  ADD KEY `PrescriptionID` (`PrescriptionID`);

--
-- Indexes for table `patientallergies`
--
ALTER TABLE `patientallergies`
  ADD PRIMARY KEY (`AllergyID`),
  ADD KEY `PatientID` (`PatientID`);

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
-- Indexes for table `visits`
--
ALTER TABLE `visits`
  ADD PRIMARY KEY (`VisitID`),
  ADD KEY `PatientID` (`PatientID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `audit_logs`
--
ALTER TABLE `audit_logs`
  MODIFY `LogID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `medicines`
--
ALTER TABLE `medicines`
  MODIFY `MedicineID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `patientallergies`
--
ALTER TABLE `patientallergies`
  MODIFY `AllergyID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `prescriptions`
--
ALTER TABLE `prescriptions`
  MODIFY `PrescriptionID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `visits`
--
ALTER TABLE `visits`
  MODIFY `VisitID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

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
-- Constraints for table `patientallergies`
--
ALTER TABLE `patientallergies`
  ADD CONSTRAINT `patientallergies_ibfk_1` FOREIGN KEY (`PatientID`) REFERENCES `patients` (`PatientID`) ON DELETE CASCADE;

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

--
-- Constraints for table `visits`
--
ALTER TABLE `visits`
  ADD CONSTRAINT `visits_ibfk_1` FOREIGN KEY (`PatientID`) REFERENCES `patients` (`PatientID`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
