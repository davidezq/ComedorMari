-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 14-06-2021 a las 05:39:06
-- Versión del servidor: 10.4.17-MariaDB
-- Versión de PHP: 8.0.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `compras`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE `clientes` (
  `Codigo_Cliente` int(11) NOT NULL,
  `Nombre` varchar(255) NOT NULL,
  `Apellido` varchar(255) NOT NULL
  `Telefono` int(8) NULL,
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura`
--

CREATE TABLE `factura` (
  `Codigo_Factura` int(11) NOT NULL,
  `Codigo_Listado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `listado_compras`
--

CREATE TABLE `listado_compras` (
  `Codigo_Lista` int(11) NOT NULL,
  `Codigo_Cliente` int(11) NOT NULL,
  `Codigo_Producto` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE `productos` (
  `Codigo_Producto` int(11) NOT NULL,
  `Nombre` varchar(255) NOT NULL,
  `Precio` int(11) NOT NULL,
  `Stock` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`Codigo_Cliente`);

--
-- Indices de la tabla `factura`
--
ALTER TABLE `factura`
  ADD KEY `Fk_Factura` (`Codigo_Listado`);

--
-- Indices de la tabla `listado_compras`
--
ALTER TABLE `listado_compras`
  ADD PRIMARY KEY (`Codigo_Lista`),
  ADD KEY `Fk_Cliente_Factura` (`Codigo_Cliente`),
  ADD KEY `Fk_Codigo_Factura` (`Codigo_Producto`);

--
-- Indices de la tabla `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`Codigo_Producto`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `factura`
--
ALTER TABLE `factura`
  ADD CONSTRAINT `Fk_Factura` FOREIGN KEY (`Codigo_Listado`) REFERENCES `listado_compras` (`Codigo_Lista`);

--
-- Filtros para la tabla `listado_compras`
--
ALTER TABLE `listado_compras`
  ADD CONSTRAINT `Fk_Cliente_Factura` FOREIGN KEY (`Codigo_Cliente`) REFERENCES `clientes` (`Codigo_Cliente`),
  ADD CONSTRAINT `Fk_Codigo_Factura` FOREIGN KEY (`Codigo_Producto`) REFERENCES `productos` (`Codigo_Producto`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
