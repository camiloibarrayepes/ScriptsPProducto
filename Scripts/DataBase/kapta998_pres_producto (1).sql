-- phpMyAdmin SQL Dump
-- version 4.7.3
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost:3306
-- Tiempo de generación: 25-04-2018 a las 18:00:31
-- Versión del servidor: 5.6.36-82.1-log
-- Versión de PHP: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `kapta998_pres_producto`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `asesor`
--

CREATE TABLE `asesor` (
  `id` int(11) NOT NULL,
  `nombre` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `cedula` int(11) NOT NULL,
  `pass` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `id_c` varchar(10) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `asesor`
--

INSERT INTO `asesor` (`id`, `nombre`, `cedula`, `pass`, `id_c`) VALUES
(1, 'camilo', 123, '', '1'),
(11, 'camiloandres', 0, '', '1'),
(24, 'andres', 444, 'asca', 'asca'),
(25, 'ibarra', 1061754806, 'ol123', 'ol123');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categorias`
--

CREATE TABLE `categorias` (
  `id` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `urlImg` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `categorias`
--

INSERT INTO `categorias` (`id`, `nombre`, `urlImg`) VALUES
(1, 'Vacaciones', 'https://kapta.biz/bmw/image_vacations.jpg'),
(2, 'Familia', 'https://kapta.biz/bmw/image_family.jpg'),
(3, 'Deportes', 'https://www.infobae.com/new-resizer/RX5qApaUrihSIgx-m5ZYWNb_860=/600x0/filters:quality(100)/s3.amazonaws.com/arc-wordpress-client-uploads/infobae-wp/wp-content/uploads/2017/12/22195850/futbol-deporte.jpg'),
(4, 'Entretenimiento', 'https://images.hellogiggles.com/uploads/2016/11/03104150/videogame.jpg'),
(5, 'Tecnología', 'https://des.gbtcdn.com/uploads/2015/201505/heditor/201505121615011846.jpg');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `concesionario`
--

CREATE TABLE `concesionario` (
  `id` int(11) NOT NULL,
  `nombre` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `direccion` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `telefono` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `concesionario`
--

INSERT INTO `concesionario` (`id`, `nombre`, `direccion`, `telefono`) VALUES
(1, 'concesionario1', 'calle 152 # 34-4', 321232),
(2, 'concesionario2', 'cra 4 # 5-55', 435343),
(3, 'Concesionario3', 'calle 300', 32143),
(4, 'concesionario4', 'calle 4', 32123),
(5, 'concesionario5', 'calle 5', 555);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `q_categorias`
--

CREATE TABLE `q_categorias` (
  `id` int(11) NOT NULL,
  `id_categoria` int(11) NOT NULL,
  `pregunta` text CHARACTER SET utf8 COLLATE utf8_spanish2_ci NOT NULL,
  `ans_a` varchar(100) NOT NULL,
  `ans_b` varchar(100) NOT NULL,
  `ans_c` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `q_categorias`
--

INSERT INTO `q_categorias` (`id`, `id_categoria`, `pregunta`, `ans_a`, `ans_b`, `ans_c`) VALUES
(1, 1, 'Que lugar prefieres para tomar vacaciones?', 'Playa', 'Nieve', 'Selva'),
(2, 1, 'Que te gusta llevar cuando vas de viaje?', 'Gafas de sol', 'Camara de fotos', 'Celular '),
(3, 1, 'Te gusta ir de vacaciones con...', 'Mi familia', 'Mis amigos', 'Solo'),
(4, 1, 'Cuantos dias consideras unas vacaciones ideales?', 'de 1 a 3', 'de 3 a 5', 'mas de 5'),
(5, 2, 'Cada cuanto piensas en comprar regalos para tu familia', 'Cada semana', 'Cada mes', 'Cada dos meses o mas'),
(6, 2, 'Cuantos hijos tienes?', 'No tengo', 'de 1 a 3', 'mas de 3'),
(7, 2, 'Vives solo o con tu familia?', 'Solo', 'Con mi pareja', 'Con mis padres'),
(8, 2, 'En que llevas a tus hijos al colegio?', 'En transporte urbano', 'Carro propio', 'Motocicleta'),
(9, 3, 'Cual es tu deporte favorito?', 'Futbol', 'Baloncesto', 'Tenis'),
(10, 3, 'Te gusta ver deportes en TV?', 'Si', 'No', 'Indiferente'),
(11, 3, 'Te gustan los deportes extremos? cual?', 'No', 'CicloMontañismo', 'Rapel'),
(12, 3, 'Escoge tu respuesta favorita', 'Formula 1', 'MotoGp', 'BMX'),
(13, 4, 'Que tipo de musica te gusta?', 'Bailables', 'Rock', 'Electronica'),
(14, 4, 'Que tipo de peliculas te gustan mas?', 'Accion', 'Comedia', 'Drama'),
(15, 4, 'Que cantante/banda prefieres?', 'David guetta y martin garrix', 'Green day y Kiss', 'Ninguno'),
(16, 4, 'Te gustan los videojuegos? cual?', 'No', 'XBOX', 'PLAY STATION'),
(17, 5, 'Selecciona tu respuesta favorita', 'Apple', 'Microsoft', 'Android'),
(18, 5, 'Normalmente como escuchas musica?', 'Equipo de sonido', 'Audifonos', 'Stereo de Carro'),
(19, 5, 'Cuando compra un articulo tecnologico. que es lo primero que miro', 'Precio', 'Potencia', 'Color'),
(20, 5, 'En promedio cuanto invierte en un celular?', 'de 100 a 300', 'de 300 a 900 ', 'mas de 900'),
(21, 3, 'Cual de estos deportistas es mas reconocido para ti', 'Juan pablo Montoya', 'Valentino Rossi', 'Tatan Mejia');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `nombre` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `email` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `pass` varchar(100) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `user`
--

INSERT INTO `user` (`id`, `nombre`, `email`, `pass`) VALUES
(1, 'camilo', 'camilo@gmail.com', '123'),
(2, 'asad', 'camilo23@gmail.com', '123asd'),
(3, 'andres', 'a@gmail.com', '123'),
(4, 'ba', 'b@gmail.com', '202cb962ac59075b964b07152d234b70'),
(5, 'usuarioprueba', 'up@gmail.com', 'a906449d5769fa7361d7ecc6aa3f6d28'),
(6, 'ca', 'c3amilo@gmail.com', '202cb962ac59075b964b07152d234b70'),
(7, 'camilo', 'calk@gmail.com', 'a7fa5385c99fecb3642a8e1f7333b8a5');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `asesor`
--
ALTER TABLE `asesor`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `categorias`
--
ALTER TABLE `categorias`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `concesionario`
--
ALTER TABLE `concesionario`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `q_categorias`
--
ALTER TABLE `q_categorias`
  ADD PRIMARY KEY (`id`),
  ADD KEY `q_categorias_ibfk_1` (`id_categoria`);

--
-- Indices de la tabla `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `asesor`
--
ALTER TABLE `asesor`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;
--
-- AUTO_INCREMENT de la tabla `categorias`
--
ALTER TABLE `categorias`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT de la tabla `concesionario`
--
ALTER TABLE `concesionario`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT de la tabla `q_categorias`
--
ALTER TABLE `q_categorias`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;
--
-- AUTO_INCREMENT de la tabla `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `q_categorias`
--
ALTER TABLE `q_categorias`
  ADD CONSTRAINT `q_categorias_ibfk_1` FOREIGN KEY (`id_categoria`) REFERENCES `categorias` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
