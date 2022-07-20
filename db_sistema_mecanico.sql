-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Servidor: sql303.byetcluster.com
-- Tiempo de generación: 20-07-2022 a las 01:01:04
-- Versión del servidor: 10.3.27-MariaDB
-- Versión de PHP: 7.2.22

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `epiz_32048222_sistema_mecanico`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `boleta_canje`
--

CREATE TABLE `boleta_canje` (
  `id` int(11) NOT NULL,
  `nombre_cliente` varchar(100) NOT NULL,
  `correo_cliente` varchar(100) NOT NULL,
  `rut_cliente` varchar(100) NOT NULL,
  `nombre_taller` varchar(100) NOT NULL,
  `direccion_taller` varchar(100) NOT NULL,
  `correo_mecanico` varchar(100) NOT NULL,
  `servicio_venta` varchar(300) NOT NULL,
  `fecha` int(11) NOT NULL,
  `precio` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `inventario`
--

CREATE TABLE `inventario` (
  `ID` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `imagen` varchar(200) NOT NULL,
  `descripcion` varchar(300) NOT NULL,
  `stock` int(11) NOT NULL,
  `precio` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perfil_taller`
--

CREATE TABLE `perfil_taller` (
  `ID_perfil` int(11) NOT NULL,
  `nombre_mecanico` varchar(50) NOT NULL,
  `nombre_taller` varchar(70) NOT NULL,
  `direccion_taller` varchar(100) NOT NULL,
  `venta_producto` varchar(10) NOT NULL,
  `servicio` varchar(10) NOT NULL,
  `telefono_taller` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `registro_auto`
--

CREATE TABLE `registro_auto` (
  `ID` int(11) NOT NULL,
  `ID_dueño` int(11) NOT NULL,
  `marca` varchar(50) NOT NULL,
  `modelo` varchar(100) NOT NULL,
  `año` varchar(2100) NOT NULL,
  `tipo_motor` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `servicio`
--

CREATE TABLE `servicio` (
  `id_servicio` int(11) NOT NULL,
  `nombre` varchar(25) NOT NULL,
  `descripcion` varchar(300) NOT NULL,
  `fecha` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario_cliente`
--

CREATE TABLE `usuario_cliente` (
  `ID_cliente` int(11) NOT NULL,
  `nombre` varchar(200) NOT NULL,
  `usuario` varchar(200) NOT NULL,
  `rut` varchar(25) NOT NULL,
  `telefono` longtext NOT NULL,
  `direccion` varchar(100) NOT NULL,
  `correo` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `fecha` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario_mecanico`
--

CREATE TABLE `usuario_mecanico` (
  `ID_mecanico` int(11) NOT NULL,
  `nombre` varchar(200) NOT NULL,
  `password` varchar(200) NOT NULL,
  `email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `valoracion`
--

CREATE TABLE `valoracion` (
  `ID_valo` int(11) NOT NULL,
  `tipo_servicio` varchar(100) NOT NULL,
  `comentario` varchar(100) NOT NULL,
  `nota` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `boleta_canje`
--
ALTER TABLE `boleta_canje`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `inventario`
--
ALTER TABLE `inventario`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `perfil_taller`
--
ALTER TABLE `perfil_taller`
  ADD PRIMARY KEY (`ID_perfil`);

--
-- Indices de la tabla `registro_auto`
--
ALTER TABLE `registro_auto`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `usuario_cliente`
--
ALTER TABLE `usuario_cliente`
  ADD PRIMARY KEY (`ID_cliente`);

--
-- Indices de la tabla `usuario_mecanico`
--
ALTER TABLE `usuario_mecanico`
  ADD PRIMARY KEY (`ID_mecanico`);

--
-- Indices de la tabla `valoracion`
--
ALTER TABLE `valoracion`
  ADD PRIMARY KEY (`ID_valo`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `boleta_canje`
--
ALTER TABLE `boleta_canje`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `inventario`
--
ALTER TABLE `inventario`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `perfil_taller`
--
ALTER TABLE `perfil_taller`
  MODIFY `ID_perfil` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `registro_auto`
--
ALTER TABLE `registro_auto`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `usuario_cliente`
--
ALTER TABLE `usuario_cliente`
  MODIFY `ID_cliente` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `usuario_mecanico`
--
ALTER TABLE `usuario_mecanico`
  MODIFY `ID_mecanico` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `valoracion`
--
ALTER TABLE `valoracion`
  MODIFY `ID_valo` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
