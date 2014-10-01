-- phpMyAdmin SQL Dump
-- version 4.0.9
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 06-08-2014 a las 02:13:45
-- Versión del servidor: 5.5.34
-- Versión de PHP: 5.4.22

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `dbms_crain`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `administrador`
--

CREATE TABLE IF NOT EXISTS `administrador` (
  `ADMINISTRADOR_ID` int(10) NOT NULL AUTO_INCREMENT,
  `ADMINISTRADOR_NOMBRE` varchar(100) NOT NULL,
  `ADMINISTRADOR_APELLIDO` varchar(100) NOT NULL,
  `ADMINISTRADOR_USUARIO` varchar(100) NOT NULL,
  `ADMINISTRADOR_PASSWORD` varchar(100) NOT NULL,
  `ADMINISTRADOR_CARGO` varchar(100) NOT NULL,
  PRIMARY KEY (`ADMINISTRADOR_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Volcado de datos para la tabla `administrador`
--

INSERT INTO `administrador` (`ADMINISTRADOR_ID`, `ADMINISTRADOR_NOMBRE`, `ADMINISTRADOR_APELLIDO`, `ADMINISTRADOR_USUARIO`, `ADMINISTRADOR_PASSWORD`, `ADMINISTRADOR_CARGO`) VALUES
(1, 'Martin', 'Carrizo', 'mcarrizo', 'carrizocrain', 'empleado'),
(2, 'Walter', 'Vale', 'wvale', 'valecrain', 'empleado');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categoria`
--

CREATE TABLE IF NOT EXISTS `categoria` (
  `CATEGORIA_ID` int(10) NOT NULL AUTO_INCREMENT,
  `CATEGORIA_NOMBRE` varchar(100) NOT NULL,
  PRIMARY KEY (`CATEGORIA_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Volcado de datos para la tabla `categoria`
--

INSERT INTO `categoria` (`CATEGORIA_ID`, `CATEGORIA_NOMBRE`) VALUES
(1, 'PLATOS'),
(2, 'BEBIDAS'),
(4, 'Minutas'),
(5, 'Minutas'),
(6, 'Minutas'),
(7, 'Frutas');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `complemento`
--

CREATE TABLE IF NOT EXISTS `complemento` (
  `COMPLEMENTO_ID` int(10) NOT NULL AUTO_INCREMENT,
  `COMPLEMENTO_NOMBRE` varchar(100) NOT NULL,
  `COMPLEMENTO_DESCRIPCION` varchar(100) NOT NULL,
  `MENU_ID` int(10) NOT NULL,
  PRIMARY KEY (`COMPLEMENTO_ID`),
  KEY `MENU_ID` (`MENU_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `diario`
--

CREATE TABLE IF NOT EXISTS `diario` (
  `DIARIO_ID` int(10) NOT NULL AUTO_INCREMENT,
  `DIARIO_NOMBRE` varchar(100) NOT NULL,
  `DIARIO_URL` varchar(600) NOT NULL,
  PRIMARY KEY (`DIARIO_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Volcado de datos para la tabla `diario`
--

INSERT INTO `diario` (`DIARIO_ID`, `DIARIO_NOMBRE`, `DIARIO_URL`) VALUES
(1, 'clarin', 'http://www.clarin.com'),
(2, 'nacion', 'http://www.lanacion.com.ar/'),
(3, 'tribuno', 'http://www.eltribuno.info/jujuy/');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `menu`
--

CREATE TABLE IF NOT EXISTS `menu` (
  `MENU_ID` int(10) NOT NULL AUTO_INCREMENT,
  `MENU_NOMBRE_PLATO` varchar(100) NOT NULL,
  `MENU_PRECIO` float(10,2) NOT NULL,
  `MENU_DESCRIPCION` varchar(100) NOT NULL,
  `CATEGORIA_ID` int(10) NOT NULL,
  PRIMARY KEY (`MENU_ID`),
  KEY `CATEGORIA_ID` (`CATEGORIA_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=11 ;

--
-- Volcado de datos para la tabla `menu`
--

INSERT INTO `menu` (`MENU_ID`, `MENU_NOMBRE_PLATO`, `MENU_PRECIO`, `MENU_DESCRIPCION`, `CATEGORIA_ID`) VALUES
(1, 'PIZZA ESPECIAL', 60.00, 'DESCRIPCION', 1),
(2, 'EMPANADAS', 60.00, 'DESCRIPCION', 1),
(3, 'PICADA', 40.00, 'DESCRIPCION', 1),
(4, 'HAMBURGUESA COMPLETA', 37.00, 'DESCRIPCION', 1),
(5, 'DESAYUNO AMERICANO', 30.00, 'DESCRIPCION', 1),
(6, 'LICUADO DE FRUTILLA', 25.00, 'DESCRIPCION', 2),
(7, 'JUGO DE NARANJA', 25.00, 'DESCRIPCION', 2),
(8, 'CAPUCHINO', 25.00, 'DESCRIPCION', 2),
(9, 'COCA COLA DE 350 CC', 20.00, 'DESCRIPCION', 2),
(10, 'VINO TINTO', 30.00, 'DESCRIPCION', 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mesa`
--

CREATE TABLE IF NOT EXISTS `mesa` (
  `MESA_ID` int(10) NOT NULL AUTO_INCREMENT,
  `MESA_DESCRIPCION` varchar(100) NOT NULL,
  PRIMARY KEY (`MESA_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Volcado de datos para la tabla `mesa`
--

INSERT INTO `mesa` (`MESA_ID`, `MESA_DESCRIPCION`) VALUES
(1, 'ADELANTE A LA DERECHA'),
(2, 'ADELANTE A LA IZQUEIRDA'),
(3, 'ATRAS A LA IZQUIERDA'),
(4, 'ATRAS A LA DERECHA');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedido`
--

CREATE TABLE IF NOT EXISTS `pedido` (
  `PEDIDO_ID` int(10) NOT NULL AUTO_INCREMENT,
  `PEDIDO_FECHA` varchar(100) NOT NULL,
  `PEDIDO_TOTAL` float(10,2) NOT NULL,
  `MESA_ID` int(10) NOT NULL,
  PRIMARY KEY (`PEDIDO_ID`),
  KEY `MESA_ID` (`MESA_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=26 ;

--
-- Volcado de datos para la tabla `pedido`
--

INSERT INTO `pedido` (`PEDIDO_ID`, `PEDIDO_FECHA`, `PEDIDO_TOTAL`, `MESA_ID`) VALUES
(1, '06/09/2014', 27.00, 1),
(2, '10/05/2012', 12.00, 1),
(3, '10/05/2012', 18.00, 1),
(4, '07/01/2014', 51.00, 1),
(5, '07/01/2014', 128.00, 1),
(6, '07/02/2014', 24.00, 1),
(7, '07/02/2014', 90.00, 1),
(8, '07/02/2014', 80.00, 1),
(9, '07/02/2014', 120.00, 1),
(10, '07/02/2014', 30.00, 1),
(11, '07/02/2014', 42.00, 1),
(12, '07/02/2014', 80.00, 1),
(13, '07/02/2014', 40.00, 1),
(14, '07/02/2014', 67.00, 1),
(15, '07/02/2014', 26.00, 1),
(16, '07/02/2014', 76.00, 1),
(17, '07/02/2014', 80.00, 1),
(18, '07/02/2014', 26.00, 1),
(19, '07/02/2014', 26.00, 1),
(20, '07/02/2014', 12.00, 1),
(21, '07/02/2014', 40.00, 1),
(22, '07/02/2014', 77.00, 1),
(23, '07/02/2014', 54.00, 1),
(24, '07/02/2014', 92.00, 1),
(25, '07/03/2014', 30.00, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tea_menu_pedido`
--

CREATE TABLE IF NOT EXISTS `tea_menu_pedido` (
  `TEA_ID` int(10) NOT NULL AUTO_INCREMENT,
  `TEA_CANTIDAD` int(10) NOT NULL,
  `TEA_ESTADO` varchar(100) NOT NULL,
  `PEDIDO_ID` int(10) NOT NULL,
  `MENU_ID` int(10) NOT NULL,
  PRIMARY KEY (`TEA_ID`),
  KEY `PEDIDO_ID` (`PEDIDO_ID`),
  KEY `MENU_ID` (`MENU_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=11 ;

--
-- Volcado de datos para la tabla `tea_menu_pedido`
--

INSERT INTO `tea_menu_pedido` (`TEA_ID`, `TEA_CANTIDAD`, `TEA_ESTADO`, `PEDIDO_ID`, `MENU_ID`) VALUES
(1, 1, 'REALIZADO', 1, 8),
(2, 1, 'REALIZADO', 1, 9),
(3, 1, 'REALIZADO', 4, 7),
(4, 1, 'REALIZADO', 4, 8),
(5, 2, 'REALIZADO', 4, 9),
(6, 3, 'REALIZADO', 5, 2),
(7, 1, 'REALIZADO', 5, 3),
(8, 2, 'REALIZADO', 6, 9),
(9, 1, 'REALIZADO', 7, 1),
(10, 1, 'REALIZADO', 7, 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `video`
--

CREATE TABLE IF NOT EXISTS `video` (
  `VIDEO_ID` int(10) NOT NULL AUTO_INCREMENT,
  `VIDEO_NOMBRE` varchar(100) NOT NULL,
  `VIDEO_URL` varchar(600) NOT NULL,
  `VIDEO_ESTADO` varchar(50) NOT NULL,
  PRIMARY KEY (`VIDEO_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=35 ;

--
-- Volcado de datos para la tabla `video`
--

INSERT INTO `video` (`VIDEO_ID`, `VIDEO_NOMBRE`, `VIDEO_URL`, `VIDEO_ESTADO`) VALUES
(32, 'tacos mexicanos', 'https://www.youtube.com/watch?v=LeyJgmCSg1E', 'ACTIVO'),
(34, 'milanesa napolitana', 'https://www.youtube.com/watch?v=vjGLlxGKYjc', 'INACTIVO');

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `complemento`
--
ALTER TABLE `complemento`
  ADD CONSTRAINT `complemento_ibfk_1` FOREIGN KEY (`MENU_ID`) REFERENCES `menu` (`MENU_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `menu`
--
ALTER TABLE `menu`
  ADD CONSTRAINT `menu_ibfk_1` FOREIGN KEY (`CATEGORIA_ID`) REFERENCES `categoria` (`CATEGORIA_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `pedido`
--
ALTER TABLE `pedido`
  ADD CONSTRAINT `pedido_ibfk_1` FOREIGN KEY (`MESA_ID`) REFERENCES `mesa` (`MESA_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `tea_menu_pedido`
--
ALTER TABLE `tea_menu_pedido`
  ADD CONSTRAINT `tea_menu_pedido_ibfk_1` FOREIGN KEY (`PEDIDO_ID`) REFERENCES `pedido` (`PEDIDO_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tea_menu_pedido_ibfk_2` FOREIGN KEY (`MENU_ID`) REFERENCES `menu` (`MENU_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
