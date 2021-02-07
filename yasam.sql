-- Adminer 4.7.8 MySQL dump

SET NAMES utf8;
SET time_zone = '+00:00';
SET foreign_key_checks = 0;
SET sql_mode = 'NO_AUTO_VALUE_ON_ZERO';

SET NAMES utf8mb4;

DROP TABLE IF EXISTS `besinler`;
CREATE TABLE `besinler` (
  `besid` int(11) NOT NULL AUTO_INCREMENT,
  `besad` text CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL,
  `beskal` float NOT NULL,
  PRIMARY KEY (`besid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

INSERT INTO `besinler` (`besid`, `besad`, `beskal`) VALUES
(1,	'peynir',	4.2),
(2,	'zeytin',	1.15),
(3,	'domates',	0.22),
(4,	'ekmek',	2.64),
(5,	'yumurta',	1.55),
(6,	'süt',	0.42),
(7,	'çay',	1),
(8,	'yoğurt',	0.9),
(9,	'yenmedi',	0),
(10,	'pilav',	3.59),
(11,	'domates çorbası',	0.5),
(12,	'yoğurt',	0.61),
(13,	'tavuk',	2.19),
(14,	'et',	2.48),
(15,	'makarna',	3.67),
(16,	'elma',	0.52),
(17,	'ceviz',	6.54),
(18,	'badem',	6);

DROP TABLE IF EXISTS `gun`;
CREATE TABLE `gun` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `kal` float DEFAULT NULL,
  `kilo` float NOT NULL,
  `gun` datetime NOT NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

INSERT INTO `gun` (`id`, `kal`, `kilo`, `gun`) VALUES
(1,	1000,	40,	'2021-02-05 03:50:34'),
(2,	593,	100,	'2021-02-05 03:59:39'),
(3,	3740,	100,	'2021-02-05 11:33:13'),
(4,	1022,	90,	'2021-02-05 11:37:36'),
(5,	641,	100,	'2021-02-05 20:12:31'),
(6,	1973,	100,	'2021-02-06 15:17:25');

-- 2021-02-07 12:43:57
