-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 17-10-2019 a las 20:10:30
-- Versión del servidor: 5.7.26
-- Versión de PHP: 7.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `vikingssoft`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categoria`
--

DROP TABLE IF EXISTS `categoria`;
CREATE TABLE IF NOT EXISTS `categoria` (
  `idcat` int(11) NOT NULL AUTO_INCREMENT,
  `codcat` varchar(30) NOT NULL,
  `nombcat` varchar(30) NOT NULL,
  `desccat` varchar(30) NOT NULL,
  PRIMARY KEY (`idcat`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

DROP TABLE IF EXISTS `clientes`;
CREATE TABLE IF NOT EXISTS `clientes` (
  `idcliente` int(11) NOT NULL AUTO_INCREMENT,
  `nombcliente` varchar(30) NOT NULL,
  `dircliente` varchar(30) NOT NULL,
  `telcliente` int(11) DEFAULT NULL,
  `cuentacliente` int(10) DEFAULT NULL,
  PRIMARY KEY (`idcliente`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`idcliente`, `nombcliente`, `dircliente`, `telcliente`, `cuentacliente`) VALUES
(9, 'don silva', 'julio delgado 403', 47322912, -230),
(11, 'el comisario rex', 'ni idea', 47324245, -4302),
(12, 'jose', 'asdasd', 4242, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura`
--

DROP TABLE IF EXISTS `factura`;
CREATE TABLE IF NOT EXISTS `factura` (
  `idventafact` int(11) NOT NULL AUTO_INCREMENT,
  `factfecha` date NOT NULL,
  `montofinalfact` int(30) NOT NULL,
  PRIMARY KEY (`idventafact`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `facturaclientes`
--

DROP TABLE IF EXISTS `facturaclientes`;
CREATE TABLE IF NOT EXISTS `facturaclientes` (
  `idventafact` int(11) NOT NULL,
  `idcliente` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `notas`
--

DROP TABLE IF EXISTS `notas`;
CREATE TABLE IF NOT EXISTS `notas` (
  `idnotas` int(11) NOT NULL AUTO_INCREMENT,
  `nombnotas` varchar(30) NOT NULL,
  `fechanota` date NOT NULL,
  `contenidonota` varchar(50) NOT NULL,
  PRIMARY KEY (`idnotas`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

DROP TABLE IF EXISTS `productos`;
CREATE TABLE IF NOT EXISTS `productos` (
  `idprod` int(11) NOT NULL AUTO_INCREMENT,
  `Codprod` varchar(15) NOT NULL,
  `nombprod` varchar(30) NOT NULL,
  `precioprod` int(10) NOT NULL,
  `stockprod` int(10) NOT NULL,
  `descprod` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Codprod`),
  KEY `idprod` (`idprod`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`idprod`, `Codprod`, `nombprod`, `precioprod`, `stockprod`, `descprod`) VALUES
(13, 'ph2849', '(A)Renault Traffic', 1211, 5, ''),
(17, 'ph4703', 'Citroen', 532, 1, ''),
(18, 'ph5548', 'vw gol', 1000, 1, ''),
(16, 'ph9973', 'peugeot 206 1Y', 2521, 1, '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productoscategoria`
--

DROP TABLE IF EXISTS `productoscategoria`;
CREATE TABLE IF NOT EXISTS `productoscategoria` (
  `codprod` varchar(15) NOT NULL,
  `idcat` int(11) NOT NULL,
  PRIMARY KEY (`codprod`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productosfactura`
--

DROP TABLE IF EXISTS `productosfactura`;
CREATE TABLE IF NOT EXISTS `productosfactura` (
  `codprod` varchar(15) NOT NULL,
  `idventafact` int(11) NOT NULL,
  `numlineas` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `montolinea` int(15) NOT NULL,
  PRIMARY KEY (`codprod`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `productosfactura`
--

INSERT INTO `productosfactura` (`codprod`, `idventafact`, `numlineas`, `cantidad`, `montolinea`) VALUES
('ph9973', 3, 3, 2, 3);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productosproveedor`
--

DROP TABLE IF EXISTS `productosproveedor`;
CREATE TABLE IF NOT EXISTS `productosproveedor` (
  `codprod` varchar(15) NOT NULL,
  `idprov` int(11) NOT NULL,
  PRIMARY KEY (`codprod`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedor`
--

DROP TABLE IF EXISTS `proveedor`;
CREATE TABLE IF NOT EXISTS `proveedor` (
  `id_prov` int(11) NOT NULL AUTO_INCREMENT,
  `nombprov` varchar(20) NOT NULL,
  `rutprov` int(11) NOT NULL,
  `direccprov` varchar(30) NOT NULL,
  `telprov` int(10) NOT NULL,
  `emailprov` varchar(35) NOT NULL,
  `cuentaprov` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_prov`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `proveedor`
--

INSERT INTO `proveedor` (`id_prov`, `nombprov`, `rutprov`, `direccprov`, `telprov`, `emailprov`, `cuentaprov`) VALUES
(6, 'hfthth', 2125124, 'asdasdas', 35225, 'asdasd', 242),
(7, 'asdasd', 24124124, 'asdasd', 241241, 'asdasdas', 4214),
(8, 'asdasd', 241241, 'asdasd', 24124, 'asdasd', 24124);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE IF NOT EXISTS `usuario` (
  `iduser` int(11) NOT NULL AUTO_INCREMENT,
  `nombuser` varchar(25) NOT NULL,
  `passwduser` varchar(25) NOT NULL,
  PRIMARY KEY (`iduser`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`iduser`, `nombuser`, `passwduser`) VALUES
(10, 'seba', '1234');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuariofactura`
--

DROP TABLE IF EXISTS `usuariofactura`;
CREATE TABLE IF NOT EXISTS `usuariofactura` (
  `iduser` int(11) NOT NULL,
  `idventafact` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarionotas`
--

DROP TABLE IF EXISTS `usuarionotas`;
CREATE TABLE IF NOT EXISTS `usuarionotas` (
  `iduser` int(11) NOT NULL,
  `idnotas` int(11) NOT NULL,
  PRIMARY KEY (`idnotas`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarioproducto`
--

DROP TABLE IF EXISTS `usuarioproducto`;
CREATE TABLE IF NOT EXISTS `usuarioproducto` (
  `iduser` int(11) NOT NULL,
  `codprod` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
