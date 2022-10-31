-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 31, 2022 at 04:50 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bdcontrole_de_estoque`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbestoque`
--

CREATE TABLE `tbestoque` (
  `id` int(11) NOT NULL,
  `description` varchar(255) DEFAULT NULL,
  `manu_date` date DEFAULT NULL,
  `expi_date` date DEFAULT NULL,
  `lot` int(11) DEFAULT NULL,
  `minimum` int(11) DEFAULT NULL,
  `maximum` int(11) DEFAULT NULL,
  `total` int(11) DEFAULT NULL,
  `obs` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbestoque`
--

INSERT INTO `tbestoque` (`id`, `description`, `manu_date`, `expi_date`, `lot`, `minimum`, `maximum`, `total`, `obs`) VALUES
(1, 'Notebook Ideapad S145', '2022-05-05', '2025-09-18', 10, 1000, 2000, 1769, 'Processador: Intel core i5, Ram: 12 GB, Armazenamento: 1 TB e Placa de Vídeo: Intel Graphics'),
(3, 'Mouse gamer Lenovo g305', '2022-10-26', '2025-05-29', 20, 200, 600, 350, 'this mouse is so fast'),
(7, 'Celular Xiaomi Redmi Note 9s', '2022-05-05', '2025-09-18', 10, 500, 1000, 723, 'Processador: 2x 2.3 GHz Kryo 465 Gold + 6x 1.8 GHz Kryo 465 Silver, Ram: 4 GB e Armazenamento: 64 GB');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbestoque`
--
ALTER TABLE `tbestoque`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbestoque`
--
ALTER TABLE `tbestoque`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
