-- phpMyAdmin SQL Dump
-- version 4.1.4
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Ven 05 Février 2016 à 10:48
-- Version du serveur :  5.6.15-log
-- Version de PHP :  5.5.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";

CREATE DATABASE  IF NOT EXISTS `prwb_groupe25` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `prwb_groupe25`;
/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données :  `prwb_groupe25`
--

-- --------------------------------------------------------

--
-- Structure de la table `categories`
--

CREATE TABLE IF NOT EXISTS `categories` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(255) NOT NULL,
  `deleted` boolean NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

INSERT INTO categories (`title`,`deleted`) VALUES ('Sport',false);
INSERT INTO categories (`title`,`deleted`) VALUES ('Multimedia',false);
INSERT INTO categories (`title`,`deleted`) VALUES ('Fitness',false);
INSERT INTO categories (`title`,`deleted`) VALUES ('Natation',false);
INSERT INTO categories (`title`,`deleted`) VALUES ('Football',false);/*5*/
INSERT INTO categories (`title`,`deleted`) VALUES ('Tennis',false);
INSERT INTO categories (`title`,`deleted`) VALUES ('Course',false);
INSERT INTO categories (`title`,`deleted`) VALUES ('Gsm',false);
INSERT INTO categories (`title`,`deleted`) VALUES ('Jeux Vidéos',false);
INSERT INTO categories (`title`,`deleted`) VALUES ('Pc-Tablette',false);

-- --------------------------------------------------------

--
-- Structure de la table `products`
--

CREATE TABLE IF NOT EXISTS `products` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `description` varchar(255) NOT NULL,
  `price` float NOT NULL,
  `quantity` int(11) NOT NULL,
  `deleted` boolean NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;



INSERT INTO products (`name`,`description`,`price`,`quantity`,`deleted`) VALUES ('Banc d abdominaux', 'Banc d abdominaux pour des abdos tonic', 25, 50, false);
INSERT INTO products (`name`,`description`,`price`,`quantity`,`deleted`) VALUES ('Barre de traction', 'Une porte suffit pour son utilisation', 15, 50, false);
INSERT INTO products (`name`,`description`,`price`,`quantity`,`deleted`) VALUES ('Bonnet de bain', 'Idéal pour les petites têtes', 16, 50, false);
INSERT INTO products (`name`,`description`,`price`,`quantity`,`deleted`) VALUES ('Haltère', '2 haltère de 10kg', 32, 50, false);
INSERT INTO products (`name`,`description`,`price`,`quantity`,`deleted`) VALUES ('Maillot de bain', 'Très chic pour la plage', 15, 50, false);
INSERT INTO products (`name`,`description`,`price`,`quantity`,`deleted`) VALUES ('Tapis de course', 'Tapis avec multiples options', 395, 50, false);
INSERT INTO products (`name`,`description`,`price`,`quantity`,`deleted`) VALUES ('Vélo elliptique', 'Vélo super fun à pratiquer chez soi', 195, 50, false);

INSERT INTO products (`name`,`description`,`price`,`quantity`,`deleted`) VALUES ('Ballon', 'Ballon de la coupe du monde 2014', 20, 100, false);
INSERT INTO products (`name`,`description`,`price`,`quantity`,`deleted`) VALUES ('Baskets de foot Nike', 'Modèle dernier cri', 120, 60, false);
INSERT INTO products (`name`,`description`,`price`,`quantity`,`deleted`) VALUES ('Baskets de foot Adidas', 'Modèle dernier cri', 120, 60, false); /*10*/
INSERT INTO products (`name`,`description`,`price`,`quantity`,`deleted`) VALUES ('Maillot de l OM', 'Superbe maillot de vainqueur', 80, 20, false);
INSERT INTO products (`name`,`description`,`price`,`quantity`,`deleted`) VALUES ('Raquette de tennis Wilson', 'Superbe raquette Wilson', 150, 30, false);
INSERT INTO products (`name`,`description`,`price`,`quantity`,`deleted`) VALUES ('Baskets de course bleues', 'Idéal pour les marathons', 100, 20, false);
INSERT INTO products (`name`,`description`,`price`,`quantity`,`deleted`) VALUES ('Baskets de course grises', 'Idéal pour les marathons', 100, 20, false);
INSERT INTO products (`name`,`description`,`price`,`quantity`,`deleted`) VALUES ('Short de sport pour homme', 'Idéal pour le sport', 20, 20, false);
INSERT INTO products (`name`,`description`,`price`,`quantity`,`deleted`) VALUES ('Short de sport pour femmes', 'Idéal pour le sport', 20, 20, false);
INSERT INTO products (`name`,`description`,`price`,`quantity`,`deleted`) VALUES ('T-shirt thermique pour le sport', 'Idéal pour le sport', 30, 20, false);

INSERT INTO products (`name`,`description`,`price`,`quantity`,`deleted`) VALUES ('IPhone 6', 'GSM dernier cri', 700, 50, false);
INSERT INTO products (`name`,`description`,`price`,`quantity`,`deleted`) VALUES ('GSM HTC', 'GSM dernier cri', 500, 30, false);
INSERT INTO products (`name`,`description`,`price`,`quantity`,`deleted`) VALUES ('Samsung Galaxy S5', 'GSM dernier cri', 400, 30, false); /*20*/
INSERT INTO products (`name`,`description`,`price`,`quantity`,`deleted`) VALUES ('Huawei', 'GSM dernier cri', 300, 60, false);
INSERT INTO products (`name`,`description`,`price`,`quantity`,`deleted`) VALUES ('Nokia 3310', 'GSM old school', 50, 30, false);

INSERT INTO products (`name`,`description`,`price`,`quantity`,`deleted`) VALUES ('XBox One', 'Console dernier cri', 300, 100, false);
INSERT INTO products (`name`,`description`,`price`,`quantity`,`deleted`) VALUES ('PS4', 'Console dernier cri', 300, 100, false);
INSERT INTO products (`name`,`description`,`price`,`quantity`,`deleted`) VALUES ('WII', 'Console premier cri', 150, 50, false);

INSERT INTO products (`name`,`description`,`price`,`quantity`,`deleted`) VALUES ('FIFA 16 PS4', 'Jeu de foot sur ps4', 50, 30, false);
INSERT INTO products (`name`,`description`,`price`,`quantity`,`deleted`) VALUES ('NBA 2k16 PS4', 'Jeu de basket sur ps4', 50, 30, false);
INSERT INTO products (`name`,`description`,`price`,`quantity`,`deleted`) VALUES ('COD BO:III PS4', 'Jeu de tir sur ps4', 50, 30, false);

INSERT INTO products (`name`,`description`,`price`,`quantity`,`deleted`) VALUES ('PC Dell', 'Ordinateur dernier cri', 800, 50, false);
INSERT INTO products (`name`,`description`,`price`,`quantity`,`deleted`) VALUES ('Portable Dell', 'Ordinateur dernier cri', 600, 50, false); /*30*/
INSERT INTO products (`name`,`description`,`price`,`quantity`,`deleted`) VALUES ('Portable Asus', 'JOrdinateur dernier cri', 600, 50, false);
INSERT INTO products (`name`,`description`,`price`,`quantity`,`deleted`) VALUES ('Macbook', 'Ordinateur dernier cri', 1000, 50, false);
INSERT INTO products (`name`,`description`,`price`,`quantity`,`deleted`) VALUES ('Portable Sony', 'Ordinateur dernier cri', 800, 50, false);
INSERT INTO products (`name`,`description`,`price`,`quantity`,`deleted`) VALUES ('IMac', 'Ordinateur dernier cri', 1200, 50, false);
INSERT INTO products (`name`,`description`,`price`,`quantity`,`deleted`) VALUES ('IPad', 'Tablette dernier cri', 400, 50, false);
INSERT INTO products (`name`,`description`,`price`,`quantity`,`deleted`) VALUES ('Tablette Samsung', 'Tablette dernier cri', 300, 50, false);

-- --------------------------------------------------------
-- Structure de la table `pictures`
--

CREATE TABLE IF NOT EXISTS `pictures` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `product_id` int(11) NOT NULL,
  `path` varchar(255) NOT NULL,
  `deleted` boolean NOT NULL,
  PRIMARY KEY (`id`),
  FOREIGN KEY(`product_id`) REFERENCES products(`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;


INSERT INTO pictures (`product_id`, `path`,`deleted`) VALUES (1, 'pictures/banc.jpg', false);
INSERT INTO pictures (`product_id`, `path`,`deleted`) VALUES (2, 'pictures/barre.jpg', false);
INSERT INTO pictures (`product_id`, `path`,`deleted`) VALUES (3, 'pictures/bonnet.jpg', false);
INSERT INTO pictures (`product_id`, `path`,`deleted`) VALUES (4, 'pictures/halteres.jpg', false);
INSERT INTO pictures (`product_id`, `path`,`deleted`) VALUES (5, 'pictures/maillot.jpg', false);
INSERT INTO pictures (`product_id`, `path`,`deleted`) VALUES (6, 'pictures/tapis.jpg', false);
INSERT INTO pictures (`product_id`, `path`,`deleted`) VALUES (7, 'pictures/velo.jpg', false);
INSERT INTO pictures (`product_id`, `path`,`deleted`) VALUES (8, 'pictures/ballon.jpg', false);
INSERT INTO pictures (`product_id`, `path`,`deleted`) VALUES (9, 'pictures/Cnike.jpg', false);
INSERT INTO pictures (`product_id`, `path`,`deleted`) VALUES (10, 'pictures/Cadidas.jpg', false);
INSERT INTO pictures (`product_id`, `path`,`deleted`) VALUES (11, 'pictures/OM.jpg', false);
INSERT INTO pictures (`product_id`, `path`,`deleted`) VALUES (12, 'pictures/raquette.jpg', false);
INSERT INTO pictures (`product_id`, `path`,`deleted`) VALUES (13, 'pictures/Bbleu.jpg', false);
INSERT INTO pictures (`product_id`, `path`,`deleted`) VALUES (14, 'pictures/Bgris.jpg', false);
INSERT INTO pictures (`product_id`, `path`,`deleted`) VALUES (15, 'pictures/Sbleu.jpg', false);
INSERT INTO pictures (`product_id`, `path`,`deleted`) VALUES (16, 'pictures/Sgris.jpg', false);
INSERT INTO pictures (`product_id`, `path`,`deleted`) VALUES (17, 'pictures/tshirt.jpg', false);
INSERT INTO pictures (`product_id`, `path`,`deleted`) VALUES (18, 'pictures/iphone6.jpg', false);
INSERT INTO pictures (`product_id`, `path`,`deleted`) VALUES (19, 'pictures/htc.jpg', false);
INSERT INTO pictures (`product_id`, `path`,`deleted`) VALUES (20, 'pictures/samsung.jpg', false);
INSERT INTO pictures (`product_id`, `path`,`deleted`) VALUES (21, 'pictures/huawei.jpg', false);
INSERT INTO pictures (`product_id`, `path`,`deleted`) VALUES (22, 'pictures/nokia.png', false);
INSERT INTO pictures (`product_id`, `path`,`deleted`) VALUES (23, 'pictures/xbox.jpg', false);
INSERT INTO pictures (`product_id`, `path`,`deleted`) VALUES (24, 'pictures/ps4.png', false);
INSERT INTO pictures (`product_id`, `path`,`deleted`) VALUES (25, 'pictures/wii.jpg', false);
INSERT INTO pictures (`product_id`, `path`,`deleted`) VALUES (26, 'pictures/fifa.png', false);
INSERT INTO pictures (`product_id`, `path`,`deleted`) VALUES (27, 'pictures/nba.jpg', false);
INSERT INTO pictures (`product_id`, `path`,`deleted`) VALUES (28, 'pictures/cod.jpg', false);
INSERT INTO pictures (`product_id`, `path`,`deleted`) VALUES (29, 'pictures/pcdell.jpg', false);
INSERT INTO pictures (`product_id`, `path`,`deleted`) VALUES (30, 'pictures/portabledell.jpg', false);
INSERT INTO pictures (`product_id`, `path`,`deleted`) VALUES (31, 'pictures/portableasus.jpg', false);
INSERT INTO pictures (`product_id`, `path`,`deleted`) VALUES (32, 'pictures/macbook.jpg', false);
INSERT INTO pictures (`product_id`, `path`,`deleted`) VALUES (33, 'pictures/portablesony.jpg', false);
INSERT INTO pictures (`product_id`, `path`,`deleted`) VALUES (34, 'pictures/pcapple.jpg', false);
INSERT INTO pictures (`product_id`, `path`,`deleted`) VALUES (35, 'pictures/ipad.jpg', false);
INSERT INTO pictures (`product_id`, `path`,`deleted`) VALUES (36, 'pictures/tabsamsung.jpg', false);


-- --------------------------------------------------------

--
-- Structure de la table `members`
--

CREATE TABLE IF NOT EXISTS `members` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `lastname` varchar(255) NOT NULL,
  `firstname` varchar(255) NOT NULL,
  `birthday` date NOT NULL,
  `pseudo` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `phone` int(20) NOT NULL,
  `NN` varchar(11) NOT NULL,
  `flag` boolean NOT NULL, 
  `deleted` boolean NOT NULL,
  PRIMARY KEY (`id`,`NN`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

INSERT INTO members (`lastname`, `firstname`, `birthday`, `pseudo`, `password`, `email`, `phone`, `NN`,`flag`, `deleted`) VALUES ('ZERO', 'User', '1990-01-01', 'User','c6aa01bd261e501b1fea93c41fe46dc7', 'a@a.com', 04845684, '19900101001', false, false);
INSERT INTO members (`lastname`, `firstname`, `birthday`, `pseudo`, `password`, `email`, `phone`, `NN`,`flag`, `deleted`) VALUES ('UN', 'User', '1990-01-01', 'User1','c6aa01bd261e501b1fea93c41fe46dc7', 'a@a.com', 04845684, '19900101002', false, false);
INSERT INTO members (`lastname`, `firstname`, `birthday`, `pseudo`, `password`, `email`, `phone`, `NN`, `flag`, `deleted`) VALUES ('DEUX', 'User', '1990-01-01', 'User2','c6aa01bd261e501b1fea93c41fe46dc7', 'a@a.com', 04845684, '19900101003', false, false);
INSERT INTO members (`lastname`, `firstname`, `birthday`, `pseudo`, `password`, `email`, `phone`, `NN`,`flag`, `deleted`) VALUES ('TROIS', 'User', '1990-01-01', 'User3','c6aa01bd261e501b1fea93c41fe46dc7', 'a@a.com', 04845684, '19900101004', false, false);
INSERT INTO members (`lastname`, `firstname`, `birthday`, `pseudo`, `password`, `email`, `phone`, `NN`,`flag`, `deleted`) VALUES ('QUATRE', 'User', '1990-01-01', 'User4','c6aa01bd261e501b1fea93c41fe46dc7', 'a@a.com', 04845684, '19900101005', false, false);
INSERT INTO members (`lastname`, `firstname`, `birthday`, `pseudo`, `password`, `email`, `phone`, `NN`,`flag`, `deleted`) VALUES ('CINQ', 'User', '1990-01-01', 'User5','c6aa01bd261e501b1fea93c41fe46dc7', 'a@a.com', 04845684, '19900101006', false, false);
INSERT INTO members (`lastname`, `firstname`, `birthday`, `pseudo`, `password`, `email`, `phone`, `NN`,`flag`, `deleted`) VALUES ('Admin', 'Admin', '1990-01-01', 'Admin','c6aa01bd261e501b1fea93c41fe46dc7', 'a@a.com', 04845648, '19900101007', true, false);

/* Structure de la table 'productCategory' */


CREATE TABLE IF NOT EXISTS `productCategory` (
  `product_id` int(11) NOT NULL,
  `category_id` int(11) NOT NULL,
  `deleted` boolean NOT NULL,
  PRIMARY KEY(`product_id`, `category_id`),
  FOREIGN KEY(`product_id`) REFERENCES products(`id`),
  FOREIGN KEY(`category_id`) REFERENCES categories(`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (1,1,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (1,3,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (2,1,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (2,3,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (3,1,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (3,4,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (4,1,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (4,3,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (5,1,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (5,4,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (6,1,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (6,3,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (7,1,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (7,3,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (8,1,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (8,5,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (9,1,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (9,5,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (10,1,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (10,5,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (11,1,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (11,5,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (12,1,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (12,6,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (13,1,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (13,7,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (14,1,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (14,7,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (15,1,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (16,1,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (17,1,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (17,7,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (18,2,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (18,8,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (19,2,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (19,8,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (20,2,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (20,8,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (21,2,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (21,8,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (22,2,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (22,8,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (23,2,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (23,9,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (24,2,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (24,9,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (25,2,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (25,9,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (26,2,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (26,9,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (27,2,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (27,9,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (28,2,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (28,9,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (29,2,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (29,10,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (30,2,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (30,10,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (31,2,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (31,10,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (32,2,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (32,10,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (33,2,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (33,10,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (34,2,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (34,10,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (35,2,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (35,10,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (36,2,false);
INSERT INTO productCategory (`product_id`, `category_id`, `deleted`) VALUES (36,10,false);




/* Structure de la table 'productPicture' */

-- CREATE TABLE IF NOT EXISTS `productPicture` (
--   `product_id` int(11) NOT NULL,
--   `picture_id` int(11) NOT NULL,
--   PRIMARY KEY(`product_id`, `picture_id`),
--   FOREIGN KEY(`product_id`) REFERENCES products(`id`),
--   FOREIGN KEY(`picture_id`) REFERENCES pictures(`id`)
-- ) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;
-- 
-- INSERT INTO productPicture (`product_id`, `picture_id`) VALUES (1,7);
-- INSERT INTO productPicture (`product_id`, `picture_id`) VALUES (2,6);
-- INSERT INTO productPicture (`product_id`, `picture_id`) VALUES (3,4);
-- INSERT INTO productPicture (`product_id`, `picture_id`) VALUES (4,1);
-- INSERT INTO productPicture (`product_id`, `picture_id`) VALUES (5,2);
-- INSERT INTO productPicture (`product_id`, `picture_id`) VALUES (6,5);
-- INSERT INTO productPicture (`product_id`, `picture_id`) VALUES (7,3);


/* Structure de la table 'goods' */

CREATE TABLE IF NOT EXISTS `goods` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `member_id` int(11) NOT NULL,
  `product_id` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,  
  PRIMARY KEY(`id`),
  FOREIGN KEY(`member_id`) REFERENCES members(`id`),
  FOREIGN KEY(`product_id`) REFERENCES products(`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;