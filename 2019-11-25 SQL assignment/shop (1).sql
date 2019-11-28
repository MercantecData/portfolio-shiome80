-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 28, 2019 at 10:08 AM
-- Server version: 10.4.8-MariaDB
-- PHP Version: 7.1.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `shop`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `deleteOrder` ()  BEGIN
DELETE FROM orders
WHERE orders.user_id = 1;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `addresses`
--

CREATE TABLE `addresses` (
  `addr_id` int(11) NOT NULL,
  `user_id` int(11) DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  `city` varchar(255) DEFAULT NULL,
  `zip_code` int(20) DEFAULT NULL,
  `country` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `addresses`
--

INSERT INTO `addresses` (`addr_id`, `user_id`, `address`, `city`, `zip_code`, `country`) VALUES
(1, 1, 'vejvej 1', 'South Park', 202020, 'Colorado'),
(2, 2, 'vejvej 2', 'South Park', 202020, 'Colorado'),
(3, 3, 'vejvej 3', 'South Park', 202020, 'Colorado'),
(4, 4, 'vejvej 4', 'South Park', 202020, 'Colorado'),
(5, 5, 'Street 1', 'South Park', 202020, 'Colorado'),
(6, 6, 'Street 2', 'South Park', 202020, 'Colorado'),
(7, 7, 'Street 3', 'South Park', 202020, 'Colorado'),
(8, 8, 'Street 4', 'South Park', 202020, 'Colorado'),
(9, 9, 'Street 5', 'South Park', 202020, 'Colorado'),
(10, 10, 'Street 6', 'South Park', 202020, 'Colorado');

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `order_id` int(11) NOT NULL,
  `user_id` int(11) DEFAULT NULL,
  `addr_id` int(11) DEFAULT NULL,
  `prod_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`order_id`, `user_id`, `addr_id`, `prod_id`) VALUES
(61556, 8, 8, 5),
(61557, 5, 5, 6),
(61558, 2, 2, 2);

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `prod_id` int(11) NOT NULL,
  `prod_name` varchar(255) DEFAULT NULL,
  `prod_description` varchar(255) DEFAULT NULL,
  `prod_stock` int(11) DEFAULT NULL,
  `prod_price` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`prod_id`, `prod_name`, `prod_description`, `prod_stock`, `prod_price`) VALUES
(1, 'Dragonball', 'Magical when combined', 7, 1000000),
(2, 'Cure for cancer', 'Not responsable for side effects', 1, 99),
(3, 'Grapling Hook', 'Batmans own', 3, 500),
(4, 'Dyne & Sengesæt fra Jysk', 'Rest parti', 5, 200),
(5, 'Mystery box', 'Who knows, could be rice, could be a Cyper car', 2, 60000),
(6, 'Realdoll', 'Slightly used', 1, 200),
(7, 'Deal with the devil', 'No delivery to Jylland', 999999, 1),
(8, 'Food plate', 'Enough to end world hunger', 9, 500),
(9, 'Bucket', 'Steel', 50, 20),
(10, 'Rope', 'Knots not included', 5, 10);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(255) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `first_name` varchar(255) DEFAULT NULL,
  `last_name` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `username`, `email`, `first_name`, `last_name`) VALUES
(1, 'skinkebørge1234', 'lk@hotmail.com', 'Lars', 'Karlsen'),
(2, 'manbearpig69', 'mbp@sølvpapirshat.dk', 'man', 'bearpig'),
(3, 'princessKenny', 'princessKen@something.com', 'Kenny', 'mhpghph'),
(4, 'Mysterion', 'mysterion@hero.com', 'Secret', 'Secret'),
(5, 'MintberryCrunch', 'mbc@hero.com', 'Mintberry', 'Crunch'),
(6, 'JediYoda', 'notthegremlin@gmail.com', 'Yo', 'da'),
(7, '1WishPlz', 'sirdiesalot@underworld.com', 'Krillin', 'Baldguy'),
(8, 'Staninator', 'care@nothing.com', 'Stan', 'Marsh'),
(9, 'Kylesan', 'jewfro@hebrew.com', 'Kyle', 'Brawfloski'),
(10, 'NewReich', 'suckmyballs@school.com', 'Eric', 'Cartman');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `addresses`
--
ALTER TABLE `addresses`
  ADD PRIMARY KEY (`addr_id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`order_id`),
  ADD KEY `user_id` (`user_id`),
  ADD KEY `addr_id` (`addr_id`),
  ADD KEY `prod_id` (`prod_id`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`prod_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `addresses`
--
ALTER TABLE `addresses`
  MODIFY `addr_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `order_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=61560;

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `prod_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `addresses`
--
ALTER TABLE `addresses`
  ADD CONSTRAINT `addresses_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`);

--
-- Constraints for table `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `orders_ibfk_2` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`),
  ADD CONSTRAINT `orders_ibfk_3` FOREIGN KEY (`addr_id`) REFERENCES `addresses` (`addr_id`),
  ADD CONSTRAINT `orders_ibfk_4` FOREIGN KEY (`prod_id`) REFERENCES `products` (`prod_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
