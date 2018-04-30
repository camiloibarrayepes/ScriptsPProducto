-- phpMyAdmin SQL Dump
-- version 4.7.3
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost:3306
-- Tiempo de generación: 30-04-2018 a las 18:29:13
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
  `email` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `pass` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `id_c` varchar(10) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `asesor`
--

INSERT INTO `asesor` (`id`, `nombre`, `email`, `pass`, `id_c`) VALUES
(1, 'camilo', '123', '', '1'),
(11, 'camiloandres', '0', '', '1'),
(24, 'andres', '444', 'asca', '2'),
(25, 'ibarra', '1061754806', 'ol123', '4'),
(26, 'asesorcamilo', '123123123', '123', '123'),
(27, 'cacac', '343434', '343434', '343434'),
(28, 'cacas', '31213', '123123', '123123'),
(29, 'kapta user', '123000', '123', '000'),
(30, 'kevin', '666', '666', '666'),
(31, 'kevin2', '767', '123', '123'),
(39, 'asesor2', '121212', '1212', '1212'),
(40, 'asesor3', '1212121', '1212', '1212'),
(41, 'goku', '123212', '23412', '12341'),
(42, 'kevin', '43551343', '123123', '123123'),
(43, '', '', 'd41d8cd98f00b204e9800998ecf8427e', ''),
(44, '', '', 'd41d8cd98f00b204e9800998ecf8427e', ''),
(45, 'casca', '', 'd41d8cd98f00b204e9800998ecf8427e', ''),
(46, 'ca', '', 'd41d8cd98f00b204e9800998ecf8427e', ''),
(47, 'asesorcamilo', '', '202cb962ac59075b964b07152d234b70', '123'),
(48, 'asesor3', '', '202cb962ac59075b964b07152d234b70', '123'),
(49, 'asesor3', 'asesor3@gmail.com', '202cb962ac59075b964b07152d234b70', '123'),
(50, 'asesor3', 'asesor3@gmail.com', '202cb962ac59075b964b07152d234b70', '123'),
(51, 'kapta user', 'asesor3@gmail.com', '202cb962ac59075b964b07152d234b70', '000'),
(52, '', '', '', ''),
(53, 'camilo', 'asesor33@gmail.com', '202cb962ac59075b964b07152d234b70', '123'),
(54, 'ca', 'ca@gmail.com', '202cb962ac59075b964b07152d234b70', '123'),
(55, 'ca', 'car@gmail.com', '202cb962ac59075b964b07152d234b70', '123'),
(56, 'ca', 'cara@gmail.com', '202cb962ac59075b964b07152d234b70', '123'),
(57, 'ca', 'cae@gmail.com', '202cb962ac59075b964b07152d234b70', '123'),
(58, 'ca', 'cat@gmail.com', '202cb962ac59075b964b07152d234b70', '123');

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
  `ans_c` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `q_categorias`
--

INSERT INTO `q_categorias` (`id`, `id_categoria`, `pregunta`, `ans_a`, `ans_b`, `ans_c`) VALUES
(1, 1, 'Que lugar prefieres para tomar vacaciones?', 'Playa', 'Nieve', 'Selva'),
(2, 1, 'Te gusta cartagena?', 'Si', 'No', ''),
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
  `pass` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `poll` double NOT NULL,
  `concesionario` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `user`
--

INSERT INTO `user` (`id`, `nombre`, `email`, `pass`, `poll`, `concesionario`) VALUES
(1, 'camilo', 'camilo@gmail.com', '123', 1, 0),
(2, 'asad', 'camilo2@gmail.com', '123', 1, 0),
(3, 'andres', 'camilo3@gmail.com', '123', 1, 0),
(4, 'ba', 'camilo4@gmail.com', '123', 0, 0),
(5, 'usuarioprueba', 'camilo5@gmail.com', '123', 0, 0),
(6, 'ca', 'camilo6@gmail.com', '123', 1, 0),
(7, 'camilo', 'camilo7@gmail.com', '123', 0, 0),
(8, 'user', 'user1@gmail.com', '123123', 1, 0),
(9, 'camilo', 'camilo8@gmail.com', '123', 0, 0),
(10, 'camilo', 'camilo9@gmail.com', '123', 0, 0),
(11, 'camilo', 'camilo10@gmail.com', '123', 1, 0),
(12, 'camilo', 'camilo11@gmail.com', '123', 0, 0),
(14, 'camilo', 'camilo99@gmail.com', '9ea5e6f10d48803ae38499c0d5e6d93f', 0, 0),
(15, 'camilo', 'camilo98@gmail.com', '4297f44b13955235245b2497399d7a93', 0, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `user_responde_pregunta`
--

CREATE TABLE `user_responde_pregunta` (
  `id` int(11) NOT NULL,
  `id_user` int(11) NOT NULL,
  `id_pregunta` int(11) NOT NULL,
  `respuesta` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `user_responde_pregunta`
--

INSERT INTO `user_responde_pregunta` (`id`, `id_user`, `id_pregunta`, `respuesta`) VALUES
(15, 1, 1, 'Playa'),
(16, 1, 2, 'Si'),
(17, 1, 3, 'Mi familia'),
(18, 1, 4, 'de 3 a 5'),
(19, 1, 5, 'Cada mes'),
(20, 1, 6, 'mas de 3'),
(48, 8, 1, 'Nieve'),
(49, 8, 2, 'No'),
(50, 8, 3, 'Mis amigos'),
(51, 8, 4, 'de 3 a 5'),
(52, 8, 5, 'Cada dos meses o mas'),
(53, 8, 6, 'de 1 a 3'),
(54, 8, 7, 'Con mis padres'),
(55, 8, 8, 'Motocicleta'),
(56, 8, 9, 'Baloncesto'),
(57, 8, 10, 'Indiferente'),
(58, 8, 11, 'No'),
(59, 8, 12, 'MotoGp'),
(60, 8, 21, 'Juan pablo Montoya'),
(61, 8, 13, 'Rock'),
(62, 8, 14, 'Accion'),
(63, 8, 15, 'David guetta y martin garrix'),
(64, 8, 16, 'XBOX'),
(65, 8, 17, 'Apple'),
(66, 8, 18, 'Stereo de Carro'),
(67, 8, 19, 'Potencia'),
(68, 8, 20, 'de 100 a 300'),
(71, 11, 1, 'Playa'),
(72, 11, 2, 'No'),
(73, 11, 3, 'Mis amigos'),
(74, 11, 4, 'de 3 a 5'),
(75, 11, 5, 'Cada mes'),
(76, 11, 6, 'No tengo'),
(77, 11, 7, 'Con mis padres'),
(78, 11, 8, 'Motocicleta'),
(79, 11, 9, 'Baloncesto'),
(80, 11, 10, 'Si'),
(81, 11, 11, 'CicloMontaï¿½ismo'),
(82, 11, 12, 'MotoGp'),
(83, 11, 21, 'Juan pablo Montoya'),
(84, 11, 13, 'Electronica'),
(85, 11, 14, 'Comedia'),
(86, 11, 15, 'Ninguno'),
(87, 11, 16, 'XBOX'),
(88, 11, 17, 'Android'),
(89, 11, 18, 'Stereo de Carro'),
(90, 11, 19, 'Precio'),
(91, 11, 20, 'de 300 a 900 '),
(92, 1, 1, 'Playa'),
(93, 1, 2, 'Si'),
(94, 1, 3, 'Mi familia'),
(95, 1, 4, 'de 3 a 5'),
(96, 1, 5, 'Cada dos meses o mas'),
(97, 1, 1, 'Playa'),
(98, 1, 2, 'No'),
(99, 1, 3, 'Mis amigos'),
(100, 1, 4, 'de 3 a 5'),
(101, 1, 5, 'Cada mes'),
(102, 1, 6, 'No tengo'),
(103, 1, 7, 'Solo'),
(104, 1, 8, 'Carro propio'),
(105, 1, 9, 'Futbol'),
(106, 1, 10, 'Si'),
(107, 1, 11, 'CicloMontaï¿½ismo'),
(108, 1, 12, 'BMX'),
(109, 1, 21, 'Juan pablo Montoya'),
(110, 1, 13, 'Rock'),
(111, 1, 14, 'Drama'),
(112, 1, 15, 'David guetta y martin garrix'),
(113, 1, 16, 'XBOX'),
(114, 1, 17, 'Microsoft'),
(115, 1, 18, 'Stereo de Carro'),
(116, 1, 19, 'Potencia'),
(117, 1, 20, 'mas de 900'),
(118, 1, 1, 'Selva'),
(119, 6, 1, 'Playa'),
(120, 6, 2, 'Si'),
(121, 6, 3, 'Mi familia'),
(122, 6, 4, 'de 3 a 5'),
(123, 6, 5, 'Cada semana'),
(124, 6, 6, 'mas de 3'),
(125, 6, 7, 'Con mi pareja'),
(126, 6, 8, 'Motocicleta'),
(127, 6, 9, 'Baloncesto'),
(128, 6, 10, 'Indiferente'),
(129, 6, 11, 'No'),
(130, 6, 12, 'Formula 1'),
(131, 6, 21, 'Valentino Rossi'),
(132, 6, 13, 'Bailables'),
(133, 6, 14, 'Accion'),
(134, 6, 15, 'Green day y Kiss'),
(135, 6, 16, 'PLAY STATION'),
(136, 6, 17, 'Apple'),
(137, 6, 18, 'Audifonos'),
(138, 6, 19, 'Precio'),
(139, 6, 20, 'de 100 a 300');

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
-- Indices de la tabla `user_responde_pregunta`
--
ALTER TABLE `user_responde_pregunta`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_pregunta` (`id_pregunta`),
  ADD KEY `id_user` (`id_user`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `asesor`
--
ALTER TABLE `asesor`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=59;
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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
--
-- AUTO_INCREMENT de la tabla `user_responde_pregunta`
--
ALTER TABLE `user_responde_pregunta`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=140;
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
