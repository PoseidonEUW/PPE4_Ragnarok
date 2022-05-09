-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Hôte : localhost
-- Généré le : mer. 05 mai 2021 à 22:53
-- Version du serveur :  10.3.27-MariaDB-0+deb10u1
-- Version de PHP : 7.3.19-1~deb10u1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `PPE4_Ragnarok`
--

DELIMITER $$
--
-- Procédures
--
CREATE DEFINER=`Titouan_Annaix`@`%` PROCEDURE `emailPersToIdPers` (IN `libelle` VARCHAR(32))  BEGIN
	select id from users where email = libelle;
END$$

CREATE DEFINER=`Elliot_Guittet`@`%` PROCEDURE `IdForAdmin` (IN `log` VARCHAR(30), `mdp` VARCHAR(100))  BEGIN 
	SELECT IDPERSONNE FROM admin WHERE LOGADMIN = log AND MDPADMIN = SHA1(mdp);
END$$

CREATE DEFINER=`Titouan_Annaix`@`%` PROCEDURE `nomLieuToIdLieu` (IN `nom` VARCHAR(500))  BEGIN
 select IDLIEU from lieu where LIBELLELIEU = nom;
END$$

CREATE DEFINER=`Titouan_Annaix`@`%` PROCEDURE `nomManifToIdManif` (IN `libelle` VARCHAR(100))  BEGIN
 select IDMANIF from manifestation where LIBELLEMANIF = libelle;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `nomsPersToIdPers` (IN `libelle` VARCHAR(50))  BEGIN
	select IDPERSONNE from personne where NOMPERSONNE = libelle;
END$$

CREATE DEFINER=`Titouan_Annaix`@`%` PROCEDURE `nomsPublicToIdPublic` (IN `libelle` VARCHAR(32))  BEGIN
	select IDPUBLIC from nomspublic where LIBELLEPUBLIC = libelle;
END$$

CREATE DEFINER=`Titouan_Annaix`@`%` PROCEDURE `nomThemeToIdTheme` (IN `libelle` VARCHAR(32))  BEGIN
 select IDTHEMATIQUE from thematique where LIBELLETHEMATIQUE = libelle;
END$$

CREATE DEFINER=`Titouan_Annaix`@`%` PROCEDURE `persToResp` (IN `nom` VARCHAR(32))  BEGIN
 select IDPERSONNE from personne where NOMPERSONNE = nom;
END$$

CREATE DEFINER=`Titouan_Annaix`@`%` PROCEDURE `totalCapaciteRestanteLieu` (IN `libelleLieu` VARCHAR(500))  IF ((SELECT L.CAPACITELIEU - SUM(M.JAUGEPERSMANIF) FROM lieu L LEFT JOIN manifestation M ON L.IDLIEU = M.IDLIEU WHERE L.LIBELLELIEU = libelleLieu) <> "NULL")
THEN
SELECT L.CAPACITELIEU - SUM(M.JAUGEPERSMANIF) AS 'PLACESRESTANTES' FROM lieu L LEFT JOIN manifestation M ON L.IDLIEU = M.IDLIEU WHERE L.LIBELLELIEU = libelleLieu ;
ELSE
SELECT L.CAPACITELIEU FROM lieu L WHERE L.LIBELLELIEU = libelleLieu ;
END IF$$

--
-- Fonctions
--
CREATE DEFINER=`root`@`localhost` FUNCTION `verifTypeManif` (`idManif` INT) RETURNS VARCHAR(50) CHARSET latin1 BEGIN
    DECLARE libType VARCHAR(50);
    IF EXISTS(SELECT * FROM atelier A WHERE A.IDMANIF = idManif) THEN
        SET libType = "atelier";
    END IF;
	IF EXISTS(SELECT * FROM concert C WHERE C.IDMANIF = idManif) THEN
            SET libType = "concert";
    END IF;
	IF EXISTS(SELECT * FROM conference C WHERE C.IDMANIF = idManif) THEN
            SET libType = "conference";
    END IF;
	IF EXISTS(SELECT * FROM debat D WHERE D.IDMANIF = idManif) THEN
            SET libType = "debat";
    END IF;
    RETURN libType;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `admin`
--

CREATE TABLE `admin` (
  `IDPERSONNE` bigint(4) NOT NULL,
  `LOGADMIN` varchar(30) NOT NULL,
  `MDPADMIN` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `admin`
--

INSERT INTO `admin` (`IDPERSONNE`, `LOGADMIN`, `MDPADMIN`) VALUES
(2, 'Titouan_Annaix', '8ea5d6ae79f0455c7580fc0fd925a579989e75bd'),
(3, 'Yoann_Bournique', '97e57b852f1ed9074bb6140b4f4aa0be7a9554c9'),
(4, 'Jessy_Provenzal', '2bcadd3b32b079a73a313eec584ceafd83761a9a');

--
-- Déclencheurs `admin`
--
DELIMITER $$
CREATE TRIGGER `before_add_admin` BEFORE INSERT ON `admin` FOR EACH ROW BEGIN 
	DECLARE mdp VARCHAR(100);
    SET mdp = SHA1(NEW.MDPADMIN);
	SET NEW.MDPADMIN = mdp;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `animateur`
--

CREATE TABLE `animateur` (
  `IDPERSONNE` bigint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `animateur`
--

INSERT INTO `animateur` (`IDPERSONNE`) VALUES
(51);

-- --------------------------------------------------------

--
-- Doublure de structure pour la vue `animateurpersonne`
-- (Voir ci-dessous la vue réelle)
--
CREATE TABLE `animateurpersonne` (
`IDPERSONNE` bigint(4)
,`NOMPERSONNE` varchar(32)
,`PRENOMPERSONNE` varchar(32)
);

-- --------------------------------------------------------

--
-- Structure de la table `animer_atelier`
--

CREATE TABLE `animer_atelier` (
  `IDMANIF` int(11) NOT NULL,
  `IDPERSONNE` bigint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Doublure de structure pour la vue `artistepersonne`
-- (Voir ci-dessous la vue réelle)
--
CREATE TABLE `artistepersonne` (
`IDPERSONNE` bigint(4)
,`NOMPERSONNE` varchar(32)
,`PRENOMPERSONNE` varchar(32)
);

-- --------------------------------------------------------

--
-- Structure de la table `artistes`
--

CREATE TABLE `artistes` (
  `IDPERSONNE` bigint(4) NOT NULL,
  `ROLEARTISTE` varchar(32) NOT NULL,
  `LIENFBSITEARTISTE` varchar(128) DEFAULT NULL,
  `LIBELLEARTISTE` varchar(500) DEFAULT NULL,
  `IMGARTISTE` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `artistes`
--

INSERT INTO `artistes` (`IDPERSONNE`, `ROLEARTISTE`, `LIENFBSITEARTISTE`, `LIBELLEARTISTE`, `IMGARTISTE`) VALUES
(9, 'Le Docteur', 'https://www.facebook.com/davidtennantcom', 'David Tennant est un acteur britannique né le 18 avril 1971 à Bathgate en Ecosse. Il est principalement connu pour les rôles de Barty Croupton Jr dans Harry Potter et du dixième Docteur dans Doctor Who.', 'https://www.programme-tv.net/imgre/fit/https.3A.2F.2Fprd2-tel-epg-img.2Es3-eu-west-1.2Eamazonaws.2Ecom.2FproviderPerson.2Fe0dc9d1115252b93.2Ejpeg/300x300/quality/80/david-tennant.jpeg'),
(12, 'Compositeur', '', 'John Williams est un compositeur, chef d\'orchestre et pianiste américain né le 8 février 1932 à New York. Il est principalement connu pour les bandes originales de Star Wars de Georges Lucas, Jurassic Park et Les Dents de la Mer de Steven Spielberg ou bien encore Harry Potter parmi tant d\'autres.', 'https://images.sk-static.com/images/media/profile_images/artists/204961/huge_avatar'),
(47, 'Harry Potter', 'https://www.facebook.com/groups/369716640193526', 'Daniel Radcliffe, né le 23 juillet 1989 dans le quartier londonien de Fulham, est un acteur et producteur britannique. Il est connu pour son premier et plus grand rôle en tant que Harry Potter dans la saga éponyme.', 'https://gal.img.pmdstatic.net/fit/http.3A.2F.2Fprd2-bone-image.2Es3-website-eu-west-1.2Eamazonaws.2Ecom.2Fgal.2Fvar.2Fgal.2Fstorage.2Fimages.2Fmedia.2Fmultiupload_du_28_juin_2016.2Fdaniel-radcliffe.2F3598053-1-fre-FR.2Fdaniel-radcliffe.2Ejpg/480x480/quality/80/daniel-radcliffe-retrouvera-t-il-bientot-harry-potter.jpg');

-- --------------------------------------------------------

--
-- Structure de la table `atelier`
--

CREATE TABLE `atelier` (
  `IDMANIF` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `atelier`
--

INSERT INTO `atelier` (`IDMANIF`) VALUES
(1),
(49),
(51);

-- --------------------------------------------------------

--
-- Structure de la table `avis`
--

CREATE TABLE `avis` (
  `IDAVIS` int(11) NOT NULL,
  `IDMANIF` int(11) NOT NULL,
  `IDPERSONNE` bigint(4) NOT NULL,
  `LIBELLEAVIS` varchar(500) NOT NULL,
  `NOTEAVIS` tinyint(4) NOT NULL,
  `VALIDEAVIS` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `avis`
--

INSERT INTO `avis` (`IDAVIS`, `IDMANIF`, `IDPERSONNE`, `LIBELLEAVIS`, `NOTEAVIS`, `VALIDEAVIS`) VALUES
(21, 51, 3, 'Super !', 3, 1),
(22, 1, 54, 'C\'était COOL !', 5, 1);

--
-- Déclencheurs `avis`
--
DELIMITER $$
CREATE TRIGGER `before_add_avis` BEFORE INSERT ON `avis` FOR EACH ROW BEGIN
    IF EXISTS (SELECT * FROM avis WHERE IDMANIF = NEW.IDMANIF AND IDPERSONNE = NEW.IDPERSONNE) THEN
        SIGNAL SQLSTATE '16440' SET MESSAGE_TEXT = 'Vous avez déjà donné votre avis sur cette manifestation !';
    END IF;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `chanter`
--

CREATE TABLE `chanter` (
  `IDPERSONNE` bigint(4) NOT NULL,
  `IDMANIF` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `chanter`
--

INSERT INTO `chanter` (`IDPERSONNE`, `IDMANIF`) VALUES
(12, 2);

-- --------------------------------------------------------

--
-- Structure de la table `concert`
--

CREATE TABLE `concert` (
  `IDMANIF` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `concert`
--

INSERT INTO `concert` (`IDMANIF`) VALUES
(2);

-- --------------------------------------------------------

--
-- Structure de la table `conference`
--

CREATE TABLE `conference` (
  `IDMANIF` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `debat`
--

CREATE TABLE `debat` (
  `IDMANIF` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `facture`
--

CREATE TABLE `facture` (
  `REFFACTURE` int(11) NOT NULL,
  `REFRESERVATION` int(11) NOT NULL,
  `RECAPFACTURE` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `failed_jobs`
--

CREATE TABLE `failed_jobs` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `uuid` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `connection` text COLLATE utf8_unicode_ci NOT NULL,
  `queue` text COLLATE utf8_unicode_ci NOT NULL,
  `payload` longtext COLLATE utf8_unicode_ci NOT NULL,
  `exception` longtext COLLATE utf8_unicode_ci NOT NULL,
  `failed_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `festival`
--

CREATE TABLE `festival` (
  `ANNEEFESTIVAL` year(4) NOT NULL,
  `IDTHEMATIQUE` int(11) NOT NULL,
  `IDPERSONNE` bigint(4) NOT NULL,
  `NOMFESTIVAL` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `festival`
--

INSERT INTO `festival` (`ANNEEFESTIVAL`, `IDTHEMATIQUE`, `IDPERSONNE`, `NOMFESTIVAL`) VALUES
(2021, 1, 1, 'CARANTEC'),
(2022, 4, 3, 'Festival de Gaulle'),
(2023, 2, 1, 'Festival du Manga'),
(2025, 2, 2, 'All Hail Britannia'),
(2026, 1, 1, 'Exposition 25 ans Harry Potter'),
(2032, 1, 1, 'HP');

-- --------------------------------------------------------

--
-- Doublure de structure pour la vue `infosAvis`
-- (Voir ci-dessous la vue réelle)
--
CREATE TABLE `infosAvis` (
`IDAVIS` int(11)
,`LIBELLEMANIF` varchar(100)
,`NOMPRENOM` varchar(65)
,`LIBELLEAVIS` varchar(500)
,`NOTEAVIS` tinyint(4)
,`VALIDEAVIS` tinyint(1)
);

-- --------------------------------------------------------

--
-- Doublure de structure pour la vue `infosfestival`
-- (Voir ci-dessous la vue réelle)
--
CREATE TABLE `infosfestival` (
`ANNEEFESTIVAL` year(4)
,`NOMFESTIVAL` varchar(32)
,`LIBELLETHEMATIQUE` varchar(50)
,`NOMPRENOMPERSONNE` varchar(65)
);

-- --------------------------------------------------------

--
-- Doublure de structure pour la vue `infosManif`
-- (Voir ci-dessous la vue réelle)
--
CREATE TABLE `infosManif` (
`IDMANIF` int(11)
,`ANNEEFESTIVAL` year(4)
,`LIBELLELIEU` varchar(500)
,`DATEMANIF` date
,`LIBELLEMANIF` varchar(100)
,`HORAIREDEBUTMANIF` time
,`HORAIREFINMANIF` time
,`JAUGEDISPOPERSMANIF` bigint(4)
,`JAUGEPERSMANIF` bigint(4)
,`DESCRIPTIONMANIF` varchar(255)
,`PRIXMANIF` int(11)
,`IMGMANIF` varchar(255)
,`PUBLICVISE` varchar(32)
);

-- --------------------------------------------------------

--
-- Doublure de structure pour la vue `infosParticiper`
-- (Voir ci-dessous la vue réelle)
--
CREATE TABLE `infosParticiper` (
`LIBELLEMANIF` varchar(100)
,`NOMPRENOM` varchar(65)
);

-- --------------------------------------------------------

--
-- Doublure de structure pour la vue `infosReservation`
-- (Voir ci-dessous la vue réelle)
--
CREATE TABLE `infosReservation` (
`REFRESERVATION` int(11)
,`LIBELLEMANIF` varchar(100)
,`NOMPRENOM` varchar(65)
,`QUANTITERESERVATION` int(11)
);

-- --------------------------------------------------------

--
-- Structure de la table `intervenantspecialise`
--

CREATE TABLE `intervenantspecialise` (
  `IDPERSONNE` bigint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `intervenantspecialise`
--

INSERT INTO `intervenantspecialise` (`IDPERSONNE`) VALUES
(49),
(50);

-- --------------------------------------------------------

--
-- Doublure de structure pour la vue `intervenantspecialisepersonne`
-- (Voir ci-dessous la vue réelle)
--
CREATE TABLE `intervenantspecialisepersonne` (
`IDPERSONNE` bigint(4)
,`NOMPERSONNE` varchar(32)
,`PRENOMPERSONNE` varchar(32)
);

-- --------------------------------------------------------

--
-- Structure de la table `lieu`
--

CREATE TABLE `lieu` (
  `IDLIEU` int(11) NOT NULL,
  `LIBELLELIEU` varchar(500) NOT NULL,
  `CAPACITELIEU` bigint(5) NOT NULL,
  `INTERIEURLIEU` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `lieu`
--

INSERT INTO `lieu` (`IDLIEU`, `LIBELLELIEU`, `CAPACITELIEU`, `INTERIEURLIEU`) VALUES
(1, 'QG AVENGERS', 2500, 0),
(2, 'Temple de la Série Fantastique', 1500, 1),
(3, 'Poudlard', 5000, 0),
(16, 'AnimeZone2', 199, 0),
(20, 'Le Mordor', 900, 0),
(22, 'Salle d\'orchestre', 500, 1);

-- --------------------------------------------------------

--
-- Doublure de structure pour la vue `manifAtelier`
-- (Voir ci-dessous la vue réelle)
--
CREATE TABLE `manifAtelier` (
`IDMANIF` int(11)
,`ANNEEFESTIVAL` year(4)
,`IDLIEU` int(11)
,`LIBELLEMANIF` varchar(100)
,`DATEMANIF` date
,`HORAIREDEBUTMANIF` time
,`HORAIREFINMANIF` time
,`JAUGEDISPOPERSMANIF` bigint(4)
,`JAUGEPERSMANIF` bigint(4)
,`DESCRIPTIONMANIF` varchar(255)
,`PRIXMANIF` int(11)
,`IMGMANIF` varchar(255)
);

-- --------------------------------------------------------

--
-- Doublure de structure pour la vue `manifConcert`
-- (Voir ci-dessous la vue réelle)
--
CREATE TABLE `manifConcert` (
`IDMANIF` int(11)
,`ANNEEFESTIVAL` year(4)
,`IDLIEU` int(11)
,`LIBELLEMANIF` varchar(100)
,`DATEMANIF` date
,`HORAIREDEBUTMANIF` time
,`HORAIREFINMANIF` time
,`JAUGEDISPOPERSMANIF` bigint(4)
,`JAUGEPERSMANIF` bigint(4)
,`DESCRIPTIONMANIF` varchar(255)
,`PRIXMANIF` int(11)
,`IMGMANIF` varchar(255)
);

-- --------------------------------------------------------

--
-- Doublure de structure pour la vue `manifConference`
-- (Voir ci-dessous la vue réelle)
--
CREATE TABLE `manifConference` (
`IDMANIF` int(11)
,`ANNEEFESTIVAL` year(4)
,`IDLIEU` int(11)
,`LIBELLEMANIF` varchar(100)
,`DATEMANIF` date
,`HORAIREDEBUTMANIF` time
,`HORAIREFINMANIF` time
,`JAUGEDISPOPERSMANIF` bigint(4)
,`JAUGEPERSMANIF` bigint(4)
,`DESCRIPTIONMANIF` varchar(255)
,`PRIXMANIF` int(11)
,`IMGMANIF` varchar(255)
);

-- --------------------------------------------------------

--
-- Doublure de structure pour la vue `manifDebat`
-- (Voir ci-dessous la vue réelle)
--
CREATE TABLE `manifDebat` (
`IDMANIF` int(11)
,`ANNEEFESTIVAL` year(4)
,`IDLIEU` int(11)
,`LIBELLEMANIF` varchar(100)
,`DATEMANIF` date
,`HORAIREDEBUTMANIF` time
,`HORAIREFINMANIF` time
,`JAUGEDISPOPERSMANIF` bigint(4)
,`JAUGEPERSMANIF` bigint(4)
,`DESCRIPTIONMANIF` varchar(255)
,`PRIXMANIF` int(11)
,`IMGMANIF` varchar(255)
);

-- --------------------------------------------------------

--
-- Structure de la table `manifestation`
--

CREATE TABLE `manifestation` (
  `IDMANIF` int(11) NOT NULL,
  `ANNEEFESTIVAL` year(4) NOT NULL,
  `IDLIEU` int(11) NOT NULL,
  `LIBELLEMANIF` varchar(100) NOT NULL,
  `DATEMANIF` date NOT NULL,
  `HORAIREDEBUTMANIF` time NOT NULL,
  `HORAIREFINMANIF` time NOT NULL,
  `JAUGEDISPOPERSMANIF` bigint(4) NOT NULL,
  `JAUGEPERSMANIF` bigint(4) NOT NULL,
  `DESCRIPTIONMANIF` varchar(255) NOT NULL,
  `PRIXMANIF` int(11) DEFAULT NULL,
  `IMGMANIF` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `manifestation`
--

INSERT INTO `manifestation` (`IDMANIF`, `ANNEEFESTIVAL`, `IDLIEU`, `LIBELLEMANIF`, `DATEMANIF`, `HORAIREDEBUTMANIF`, `HORAIREFINMANIF`, `JAUGEDISPOPERSMANIF`, `JAUGEPERSMANIF`, `DESCRIPTIONMANIF`, `PRIXMANIF`, `IMGMANIF`) VALUES
(1, 2021, 2, 'Voyage avec le Docteur', '2021-04-29', '09:30:00', '10:30:00', 188, 600, 'Venez rencontrer Matt Smith, David Tennant et Jenna-Louise Coleman et voyagez avec eux dans le Tardis pour résoudre des énigmes, enquêtes et découvrir de nouvelles planètes dont vous ne soupçonniez même pas l\'existence ! ', 10, 'https://static.hitek.fr/img/actualite/2013/11/22/i_doctor-who-logo-black-background11.jpg'),
(2, 2021, 2, 'Harry Potter et le Monde des Sorciers', '2021-04-09', '10:00:00', '11:00:00', 89, 200, 'Venez combattre le Seigneur des Ténèbres aux cotés de Harry Potter !', 1, 'https://static.actu.fr/uploads/2020/09/billetterie-zapata-la-soiree-de-l-academie-des-sorciers-internet-explorer.jpg'),
(49, 2021, 1, 'Avengers Rassemblement', '2021-05-05', '13:30:00', '15:00:00', 140, 150, 'Venez affronter Thanos et défendre l\'univers au côté des plus grand héros de l\'univers Marvel !', NULL, 'https://www.msemporium.de/disney-portal/fileadmin/bilder/teaser/studios-filme-serien/marvel-studios.jpg'),
(51, 2021, 3, 'Création de baguettes', '2021-05-16', '14:00:00', '16:30:00', 20, 30, 'Venez créer votre propre baguette magique !', 5, 'https://noblecollection.fr/img/N/NN7905_600.jpg');

-- --------------------------------------------------------

--
-- Doublure de structure pour la vue `manifGeneral`
-- (Voir ci-dessous la vue réelle)
--
CREATE TABLE `manifGeneral` (
`IMGMANIF` varchar(255)
,`LIBELLEMANIF` varchar(100)
,`DESCRIPTIONMANIF` varchar(255)
,`LIBELLELIEU` varchar(500)
,`HORAIREDEBUTMANIF` time
,`DATEMANIF` date
);

-- --------------------------------------------------------

--
-- Structure de la table `migrations`
--

CREATE TABLE `migrations` (
  `id` int(10) UNSIGNED NOT NULL,
  `migration` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `batch` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `migrations`
--

INSERT INTO `migrations` (`id`, `migration`, `batch`) VALUES
(1, '2014_10_12_000000_create_users_table', 1),
(2, '2014_10_12_100000_create_password_resets_table', 1),
(3, '2019_08_19_000000_create_failed_jobs_table', 1);

-- --------------------------------------------------------

--
-- Doublure de structure pour la vue `nomslieuxfrommanifs`
-- (Voir ci-dessous la vue réelle)
--
CREATE TABLE `nomslieuxfrommanifs` (
`IDMANIF` int(11)
,`LIBELLEMANIF` varchar(100)
,`LIBELLELIEU` varchar(500)
);

-- --------------------------------------------------------

--
-- Doublure de structure pour la vue `nomsmanifsfromreserv`
-- (Voir ci-dessous la vue réelle)
--
CREATE TABLE `nomsmanifsfromreserv` (
`REFRESERVATION` int(11)
,`LIBELLEMANIF` varchar(100)
);

-- --------------------------------------------------------

--
-- Doublure de structure pour la vue `nomspublic`
-- (Voir ci-dessous la vue réelle)
--
CREATE TABLE `nomspublic` (
`IDPUBLIC` int(11)
,`LIBELLEPUBLIC` varchar(32)
);

-- --------------------------------------------------------

--
-- Doublure de structure pour la vue `nomsuserfromreserv`
-- (Voir ci-dessous la vue réelle)
--
CREATE TABLE `nomsuserfromreserv` (
`REFRESERVATION` int(11)
,`EMAILUTILISATEUR` varchar(255)
);

-- --------------------------------------------------------

--
-- Structure de la table `participer`
--

CREATE TABLE `participer` (
  `IDMANIF` int(11) NOT NULL,
  `IDPERSONNE` bigint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `participer`
--

INSERT INTO `participer` (`IDMANIF`, `IDPERSONNE`) VALUES
(2, 9),
(2, 12),
(2, 47),
(49, 51);

-- --------------------------------------------------------

--
-- Structure de la table `password_resets`
--

CREATE TABLE `password_resets` (
  `email` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `token` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `personne`
--

CREATE TABLE `personne` (
  `IDPERSONNE` bigint(4) NOT NULL,
  `NOMPERSONNE` varchar(32) NOT NULL,
  `PRENOMPERSONNE` varchar(32) NOT NULL,
  `EMAILPERSONNE` varchar(100) DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `personne`
--

INSERT INTO `personne` (`IDPERSONNE`, `NOMPERSONNE`, `PRENOMPERSONNE`, `EMAILPERSONNE`, `created_at`, `updated_at`) VALUES
(1, 'Guittet', 'Elliot', 'elliotguittet@gmail.com', NULL, NULL),
(2, 'Annaix', 'Titouan', 'titouan.annaix@gmail.com', NULL, NULL),
(3, 'Bournique', 'Yoann', 'yoann.brnq@gmail.com', NULL, NULL),
(4, 'Provenzal', 'Jessy', 'jessyprovenzal@yahoo.com', NULL, NULL),
(9, 'Tennant', 'David', '', NULL, NULL),
(12, 'Williams', 'John', '', NULL, NULL),
(27, 'Mousset', 'Bastien', 'bastien.mousset@mail.com', '2021-04-12 15:43:45', '2021-04-12 15:43:45'),
(47, 'Radcliffe', 'Daniel', 'DanyR@gmail.com', NULL, NULL),
(49, 'Wood', 'Elijah', 'elijah.wood@yahoo.uk', NULL, NULL),
(50, 'Astin', 'Sean', 'sean.astin@yahoo.uk', NULL, NULL),
(51, 'Downey Jr', 'Robert', 'robertdowney@orange.fr', NULL, NULL),
(53, 'Watson', 'Emma', 'watson@gmail.com', NULL, NULL),
(54, 'Guittet', 'Elliot', 'elliot@gmail.com', '2021-04-30 12:39:38', '2021-04-30 12:39:38');

-- --------------------------------------------------------

--
-- Doublure de structure pour la vue `personnesimplifie`
-- (Voir ci-dessous la vue réelle)
--
CREATE TABLE `personnesimplifie` (
`ID Utilisateur` bigint(4)
,`Nom` varchar(32)
,`Prenom` varchar(32)
,`Email` varchar(100)
);

-- --------------------------------------------------------

--
-- Structure de la table `public`
--

CREATE TABLE `public` (
  `IDPUBLIC` int(11) NOT NULL,
  `LIBELLEPUBLIC` varchar(32) NOT NULL,
  `DESCRIPTIONPUBLIC` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `public`
--

INSERT INTO `public` (`IDPUBLIC`, `LIBELLEPUBLIC`, `DESCRIPTIONPUBLIC`) VALUES
(1, 'Tout public', 'Pour les spectateurs de tout âge'),
(2, 'Enfants', 'Jeunes jusqu\'à 10 ans'),
(5, 'Adolescents', 'Entre 10 et 17 ans'),
(6, 'Jeunes adultes', 'De 18 à 25 ans'),
(7, 'Adultes', 'De 26 à 60 ans'),
(8, 'Seniors', 'Pour les 61 et +'),
(9, 'Mineurs', 'Enfants + Adolescents'),
(10, 'Majeurs', 'Jeunes adultes + Adultes + Seniors'),
(11, 'Etudiants', 'Etudiants2');

-- --------------------------------------------------------

--
-- Structure de la table `reservation`
--

CREATE TABLE `reservation` (
  `REFRESERVATION` int(11) NOT NULL,
  `IDMANIF` int(11) NOT NULL,
  `IDPERSONNE` bigint(4) NOT NULL,
  `QUANTITERESERVATION` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `reservation`
--

INSERT INTO `reservation` (`REFRESERVATION`, `IDMANIF`, `IDPERSONNE`, `QUANTITERESERVATION`) VALUES
(63, 51, 3, 2),
(64, 1, 54, 3),
(65, 1, 54, 1),
(66, 51, 27, 4);

--
-- Déclencheurs `reservation`
--
DELIMITER $$
CREATE TRIGGER `after_delete_reservation` AFTER DELETE ON `reservation` FOR EACH ROW BEGIN    
    UPDATE manifestation
    SET JAUGEDISPOPERSMANIF = JAUGEDISPOPERSMANIF + OLD.QUANTITERESERVATION
    WHERE IDMANIF = OLD.IDMANIF;
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `before_add_reservation` BEFORE INSERT ON `reservation` FOR EACH ROW BEGIN 
	IF(((SELECT SUM(QUANTITERESERVATION) FROM reservation WHERE IDPERSONNE = NEW.IDPERSONNE AND IDMANIF = NEW.IDMANIF) + NEW.QUANTITERESERVATION) > 4) THEN
    	SIGNAL SQLSTATE '16440' SET MESSAGE_TEXT = 'Vous ne pouvez réserver que pour 4 personnes !';
    ELSEIF(((SELECT manifestation.JAUGEDISPOPERSMANIF FROM manifestation WHERE manifestation.IDMANIF = NEW.IDMANIF) - NEW.QUANTITERESERVATION) < 0) THEN
    	SIGNAL SQLSTATE '16440' SET MESSAGE_TEXT = 'Il n''y a plus de place à réserver pour cette manifestation';
    ELSE
    	UPDATE manifestation SET JAUGEDISPOPERSMANIF = JAUGEDISPOPERSMANIF - NEW.QUANTITERESERVATION;
    END IF;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

CREATE TABLE `responsable` (
  `IDPERSONNE` bigint(4) NOT NULL,
  `LOGINRESPONSABLE` varchar(32) NOT NULL,
  `MDPRESPONSABLE` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`IDPERSONNE`, `LOGINRESPONSABLE`, `MDPRESPONSABLE`) VALUES
(1, 'Elliot_Guittet', '4c2d7189a770666f2905305e91d3fd335bc9e754'),
(2, 'Annaix_Titouan', '795d9aaebdae52b45af9e994c96ab235ffdbadf9'),
(3, 'Yoann_Bournique', 'c0329d122fdab5655026c21604fec1e21ba73cd9');

--
-- Déclencheurs `responsable`
--
DELIMITER $$
CREATE TRIGGER `before_add_responsable` BEFORE INSERT ON `responsable` FOR EACH ROW BEGIN 
	DECLARE mdp VARCHAR(100);
    SET mdp = SHA1(NEW.MDPRESPONSABLE);
	SET NEW.MDPRESPONSABLE = mdp;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Doublure de structure pour la vue `resptopers`
-- (Voir ci-dessous la vue réelle)
--
CREATE TABLE `resptopers` (
`NOMPRENOMRESPONSABLE` varchar(65)
);

-- --------------------------------------------------------

--
-- Structure de la table `thematique`
--

CREATE TABLE `thematique` (
  `IDTHEMATIQUE` int(11) NOT NULL,
  `LIBELLETHEMATIQUE` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `thematique`
--

INSERT INTO `thematique` (`IDTHEMATIQUE`, `LIBELLETHEMATIQUE`) VALUES
(1, 'Films et Séries'),
(2, 'Japon'),
(3, 'Jeux Vidéos'),
(4, 'France'),
(5, 'Musique'),
(6, 'Histoire');

-- --------------------------------------------------------

--
-- Structure de la table `users`
--

CREATE TABLE `users` (
  `id` bigint(4) NOT NULL,
  `email` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `password` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `remember_token` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `users`
--

INSERT INTO `users` (`id`, `email`, `password`, `remember_token`, `created_at`, `updated_at`) VALUES
(3, 'yoann.brnq@gmail.com', '$2y$10$bDthzGuc5HmCsqKHPNQSpeLVscHM.Y81M5or5MgqfNjdU6djxcQ8e', NULL, '2021-04-30 08:56:55', '2021-04-30 08:56:55'),
(27, 'bastien@mail.com', '$2y$10$6tJP5iWintRTNO1np8uCw.iVW6b/IM6zEW0YO.0.AELkKOU1xnVVy', 'VyLZT0y0VDn4DsITzekObImbi7rTpf4flwkHJbCtFslko7AqB6PxgqpGTpPj', '2021-04-12 15:43:46', '2021-04-12 15:43:46'),
(54, 'elliot@gmail.com', '$2y$10$HCVzcBMsLx4C6h6LW8QFeOqBgrLV5ogWI5w6C.I.jTLuQMhm.A1Py', NULL, '2021-04-30 12:39:40', '2021-04-30 12:39:40');

-- --------------------------------------------------------

--
-- Doublure de structure pour la vue `userspersonne`
-- (Voir ci-dessous la vue réelle)
--
CREATE TABLE `userspersonne` (
`IDPERSONNE` bigint(4)
,`NOMPERSONNE` varchar(32)
,`PRENOMPERSONNE` varchar(32)
);

-- --------------------------------------------------------

--
-- Structure de la table `viser`
--

CREATE TABLE `viser` (
  `IDPUBLIC` int(11) NOT NULL,
  `IDMANIF` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `viser`
--

INSERT INTO `viser` (`IDPUBLIC`, `IDMANIF`) VALUES
(1, 49),
(2, 2),
(5, 1),
(9, 51);

-- --------------------------------------------------------

--
-- Structure de la vue `animateurpersonne`
--
DROP TABLE IF EXISTS `animateurpersonne`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `animateurpersonne`  AS SELECT `p`.`IDPERSONNE` AS `IDPERSONNE`, `p`.`NOMPERSONNE` AS `NOMPERSONNE`, `p`.`PRENOMPERSONNE` AS `PRENOMPERSONNE` FROM (`personne` `p` join `animateur` `a` on(`p`.`IDPERSONNE` = `a`.`IDPERSONNE`)) ORDER BY `a`.`IDPERSONNE` ASC ;

-- --------------------------------------------------------

--
-- Structure de la vue `artistepersonne`
--
DROP TABLE IF EXISTS `artistepersonne`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `artistepersonne`  AS SELECT `p`.`IDPERSONNE` AS `IDPERSONNE`, `p`.`NOMPERSONNE` AS `NOMPERSONNE`, `p`.`PRENOMPERSONNE` AS `PRENOMPERSONNE` FROM (`personne` `p` join `artistes` `a` on(`p`.`IDPERSONNE` = `a`.`IDPERSONNE`)) ORDER BY `a`.`IDPERSONNE` ASC ;

-- --------------------------------------------------------

--
-- Structure de la vue `infosAvis`
--
DROP TABLE IF EXISTS `infosAvis`;

CREATE ALGORITHM=UNDEFINED DEFINER=`Titouan_Annaix`@`%` SQL SECURITY DEFINER VIEW `infosAvis`  AS SELECT `A`.`IDAVIS` AS `IDAVIS`, `M`.`LIBELLEMANIF` AS `LIBELLEMANIF`, concat(`E`.`NOMPERSONNE`,' ',`E`.`PRENOMPERSONNE`) AS `NOMPRENOM`, `A`.`LIBELLEAVIS` AS `LIBELLEAVIS`, `A`.`NOTEAVIS` AS `NOTEAVIS`, `A`.`VALIDEAVIS` AS `VALIDEAVIS` FROM ((`avis` `A` join `personne` `E` on(`A`.`IDPERSONNE` = `E`.`IDPERSONNE`)) join `manifestation` `M` on(`A`.`IDMANIF` = `M`.`IDMANIF`)) ;

-- --------------------------------------------------------

--
-- Structure de la vue `infosfestival`
--
DROP TABLE IF EXISTS `infosfestival`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `infosfestival`  AS SELECT `f`.`ANNEEFESTIVAL` AS `ANNEEFESTIVAL`, `f`.`NOMFESTIVAL` AS `NOMFESTIVAL`, `t`.`LIBELLETHEMATIQUE` AS `LIBELLETHEMATIQUE`, concat(`p`.`NOMPERSONNE`,' ',`p`.`PRENOMPERSONNE`) AS `NOMPRENOMPERSONNE` FROM ((`festival` `f` left join `thematique` `t` on(`f`.`IDTHEMATIQUE` = `t`.`IDTHEMATIQUE`)) left join `personne` `p` on(`f`.`IDPERSONNE` = `p`.`IDPERSONNE`)) ;

-- --------------------------------------------------------

--
-- Structure de la vue `infosManif`
--
DROP TABLE IF EXISTS `infosManif`;

CREATE ALGORITHM=UNDEFINED DEFINER=`Titouan_Annaix`@`%` SQL SECURITY DEFINER VIEW `infosManif`  AS SELECT `M`.`IDMANIF` AS `IDMANIF`, `M`.`ANNEEFESTIVAL` AS `ANNEEFESTIVAL`, `L`.`LIBELLELIEU` AS `LIBELLELIEU`, `M`.`DATEMANIF` AS `DATEMANIF`, `M`.`LIBELLEMANIF` AS `LIBELLEMANIF`, `M`.`HORAIREDEBUTMANIF` AS `HORAIREDEBUTMANIF`, `M`.`HORAIREFINMANIF` AS `HORAIREFINMANIF`, `M`.`JAUGEDISPOPERSMANIF` AS `JAUGEDISPOPERSMANIF`, `M`.`JAUGEPERSMANIF` AS `JAUGEPERSMANIF`, `M`.`DESCRIPTIONMANIF` AS `DESCRIPTIONMANIF`, `M`.`PRIXMANIF` AS `PRIXMANIF`, `M`.`IMGMANIF` AS `IMGMANIF`, `P`.`LIBELLEPUBLIC` AS `PUBLICVISE` FROM (((`manifestation` `M` join `viser` `V` on(`M`.`IDMANIF` = `V`.`IDMANIF`)) join `public` `P` on(`V`.`IDPUBLIC` = `P`.`IDPUBLIC`)) join `lieu` `L` on(`M`.`IDLIEU` = `L`.`IDLIEU`)) ORDER BY `M`.`IDMANIF` ASC ;

-- --------------------------------------------------------

--
-- Structure de la vue `infosParticiper`
--
DROP TABLE IF EXISTS `infosParticiper`;

CREATE ALGORITHM=UNDEFINED DEFINER=`Titouan_Annaix`@`%` SQL SECURITY DEFINER VIEW `infosParticiper`  AS SELECT `M`.`LIBELLEMANIF` AS `LIBELLEMANIF`, concat(`E`.`NOMPERSONNE`,' ',`E`.`PRENOMPERSONNE`) AS `NOMPRENOM` FROM ((`participer` `P` join `personne` `E` on(`P`.`IDPERSONNE` = `E`.`IDPERSONNE`)) join `manifestation` `M` on(`P`.`IDMANIF` = `M`.`IDMANIF`)) ;

-- --------------------------------------------------------

--
-- Structure de la vue `infosReservation`
--
DROP TABLE IF EXISTS `infosReservation`;

CREATE ALGORITHM=UNDEFINED DEFINER=`Titouan_Annaix`@`%` SQL SECURITY DEFINER VIEW `infosReservation`  AS SELECT `R`.`REFRESERVATION` AS `REFRESERVATION`, `M`.`LIBELLEMANIF` AS `LIBELLEMANIF`, concat(`E`.`NOMPERSONNE`,' ',`E`.`PRENOMPERSONNE`) AS `NOMPRENOM`, `R`.`QUANTITERESERVATION` AS `QUANTITERESERVATION` FROM ((`reservation` `R` join `personne` `E` on(`R`.`IDPERSONNE` = `E`.`IDPERSONNE`)) join `manifestation` `M` on(`R`.`IDMANIF` = `M`.`IDMANIF`)) ;

-- --------------------------------------------------------

--
-- Structure de la vue `intervenantspecialisepersonne`
--
DROP TABLE IF EXISTS `intervenantspecialisepersonne`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `intervenantspecialisepersonne`  AS SELECT `p`.`IDPERSONNE` AS `IDPERSONNE`, `p`.`NOMPERSONNE` AS `NOMPERSONNE`, `p`.`PRENOMPERSONNE` AS `PRENOMPERSONNE` FROM (`personne` `p` join `intervenantspecialise` `i` on(`p`.`IDPERSONNE` = `i`.`IDPERSONNE`)) ORDER BY `i`.`IDPERSONNE` ASC ;

-- --------------------------------------------------------

--
-- Structure de la vue `manifAtelier`
--
DROP TABLE IF EXISTS `manifAtelier`;

CREATE ALGORITHM=UNDEFINED DEFINER=`Titouan_Annaix`@`%` SQL SECURITY DEFINER VIEW `manifAtelier`  AS SELECT `A`.`IDMANIF` AS `IDMANIF`, `M`.`ANNEEFESTIVAL` AS `ANNEEFESTIVAL`, `M`.`IDLIEU` AS `IDLIEU`, `M`.`LIBELLEMANIF` AS `LIBELLEMANIF`, `M`.`DATEMANIF` AS `DATEMANIF`, `M`.`HORAIREDEBUTMANIF` AS `HORAIREDEBUTMANIF`, `M`.`HORAIREFINMANIF` AS `HORAIREFINMANIF`, `M`.`JAUGEDISPOPERSMANIF` AS `JAUGEDISPOPERSMANIF`, `M`.`JAUGEPERSMANIF` AS `JAUGEPERSMANIF`, `M`.`DESCRIPTIONMANIF` AS `DESCRIPTIONMANIF`, `M`.`PRIXMANIF` AS `PRIXMANIF`, `M`.`IMGMANIF` AS `IMGMANIF` FROM (`manifestation` `M` join `atelier` `A` on(`M`.`IDMANIF` = `A`.`IDMANIF`)) ;

-- --------------------------------------------------------

--
-- Structure de la vue `manifConcert`
--
DROP TABLE IF EXISTS `manifConcert`;

CREATE ALGORITHM=UNDEFINED DEFINER=`Titouan_Annaix`@`%` SQL SECURITY DEFINER VIEW `manifConcert`  AS SELECT `C`.`IDMANIF` AS `IDMANIF`, `M`.`ANNEEFESTIVAL` AS `ANNEEFESTIVAL`, `M`.`IDLIEU` AS `IDLIEU`, `M`.`LIBELLEMANIF` AS `LIBELLEMANIF`, `M`.`DATEMANIF` AS `DATEMANIF`, `M`.`HORAIREDEBUTMANIF` AS `HORAIREDEBUTMANIF`, `M`.`HORAIREFINMANIF` AS `HORAIREFINMANIF`, `M`.`JAUGEDISPOPERSMANIF` AS `JAUGEDISPOPERSMANIF`, `M`.`JAUGEPERSMANIF` AS `JAUGEPERSMANIF`, `M`.`DESCRIPTIONMANIF` AS `DESCRIPTIONMANIF`, `M`.`PRIXMANIF` AS `PRIXMANIF`, `M`.`IMGMANIF` AS `IMGMANIF` FROM (`manifestation` `M` join `concert` `C` on(`M`.`IDMANIF` = `C`.`IDMANIF`)) ;

-- --------------------------------------------------------

--
-- Structure de la vue `manifConference`
--
DROP TABLE IF EXISTS `manifConference`;

CREATE ALGORITHM=UNDEFINED DEFINER=`Titouan_Annaix`@`%` SQL SECURITY DEFINER VIEW `manifConference`  AS SELECT `K`.`IDMANIF` AS `IDMANIF`, `M`.`ANNEEFESTIVAL` AS `ANNEEFESTIVAL`, `M`.`IDLIEU` AS `IDLIEU`, `M`.`LIBELLEMANIF` AS `LIBELLEMANIF`, `M`.`DATEMANIF` AS `DATEMANIF`, `M`.`HORAIREDEBUTMANIF` AS `HORAIREDEBUTMANIF`, `M`.`HORAIREFINMANIF` AS `HORAIREFINMANIF`, `M`.`JAUGEDISPOPERSMANIF` AS `JAUGEDISPOPERSMANIF`, `M`.`JAUGEPERSMANIF` AS `JAUGEPERSMANIF`, `M`.`DESCRIPTIONMANIF` AS `DESCRIPTIONMANIF`, `M`.`PRIXMANIF` AS `PRIXMANIF`, `M`.`IMGMANIF` AS `IMGMANIF` FROM (`manifestation` `M` join `conference` `K` on(`M`.`IDMANIF` = `K`.`IDMANIF`)) ;

-- --------------------------------------------------------

--
-- Structure de la vue `manifDebat`
--
DROP TABLE IF EXISTS `manifDebat`;

CREATE ALGORITHM=UNDEFINED DEFINER=`Titouan_Annaix`@`%` SQL SECURITY DEFINER VIEW `manifDebat`  AS SELECT `D`.`IDMANIF` AS `IDMANIF`, `M`.`ANNEEFESTIVAL` AS `ANNEEFESTIVAL`, `M`.`IDLIEU` AS `IDLIEU`, `M`.`LIBELLEMANIF` AS `LIBELLEMANIF`, `M`.`DATEMANIF` AS `DATEMANIF`, `M`.`HORAIREDEBUTMANIF` AS `HORAIREDEBUTMANIF`, `M`.`HORAIREFINMANIF` AS `HORAIREFINMANIF`, `M`.`JAUGEDISPOPERSMANIF` AS `JAUGEDISPOPERSMANIF`, `M`.`JAUGEPERSMANIF` AS `JAUGEPERSMANIF`, `M`.`DESCRIPTIONMANIF` AS `DESCRIPTIONMANIF`, `M`.`PRIXMANIF` AS `PRIXMANIF`, `M`.`IMGMANIF` AS `IMGMANIF` FROM (`manifestation` `M` join `debat` `D` on(`M`.`IDMANIF` = `D`.`IDMANIF`)) ;

-- --------------------------------------------------------

--
-- Structure de la vue `manifGeneral`
--
DROP TABLE IF EXISTS `manifGeneral`;

CREATE ALGORITHM=UNDEFINED DEFINER=`Elliot_Guittet`@`%` SQL SECURITY DEFINER VIEW `manifGeneral`  AS SELECT `m`.`IMGMANIF` AS `IMGMANIF`, `m`.`LIBELLEMANIF` AS `LIBELLEMANIF`, `m`.`DESCRIPTIONMANIF` AS `DESCRIPTIONMANIF`, `l`.`LIBELLELIEU` AS `LIBELLELIEU`, `m`.`HORAIREDEBUTMANIF` AS `HORAIREDEBUTMANIF`, `m`.`DATEMANIF` AS `DATEMANIF` FROM (`manifestation` `m` join `lieu` `l` on(`m`.`IDLIEU` = `l`.`IDLIEU`)) ;

-- --------------------------------------------------------

--
-- Structure de la vue `nomslieuxfrommanifs`
--
DROP TABLE IF EXISTS `nomslieuxfrommanifs`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `nomslieuxfrommanifs`  AS SELECT `m`.`IDMANIF` AS `IDMANIF`, `m`.`LIBELLEMANIF` AS `LIBELLEMANIF`, `l`.`LIBELLELIEU` AS `LIBELLELIEU` FROM (`manifestation` `m` join `lieu` `l` on(`m`.`IDLIEU` = `l`.`IDLIEU`)) ;

-- --------------------------------------------------------

--
-- Structure de la vue `nomsmanifsfromreserv`
--
DROP TABLE IF EXISTS `nomsmanifsfromreserv`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `nomsmanifsfromreserv`  AS SELECT `r`.`REFRESERVATION` AS `REFRESERVATION`, `m`.`LIBELLEMANIF` AS `LIBELLEMANIF` FROM (`reservation` `r` join `manifestation` `m` on(`r`.`IDMANIF` = `m`.`IDMANIF`)) ;

-- --------------------------------------------------------

--
-- Structure de la vue `nomspublic`
--
DROP TABLE IF EXISTS `nomspublic`;

CREATE ALGORITHM=UNDEFINED DEFINER=`Titouan_Annaix`@`%` SQL SECURITY DEFINER VIEW `nomspublic`  AS SELECT `public`.`IDPUBLIC` AS `IDPUBLIC`, `public`.`LIBELLEPUBLIC` AS `LIBELLEPUBLIC` FROM `public` ;

-- --------------------------------------------------------

--
-- Structure de la vue `nomsuserfromreserv`
--
DROP TABLE IF EXISTS `nomsuserfromreserv`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `nomsuserfromreserv`  AS SELECT `r`.`REFRESERVATION` AS `REFRESERVATION`, `u`.`email` AS `EMAILUTILISATEUR` FROM (`reservation` `r` join `users` `u` on(`r`.`IDPERSONNE` = `u`.`id`)) ;

-- --------------------------------------------------------

--
-- Structure de la vue `personnesimplifie`
--
DROP TABLE IF EXISTS `personnesimplifie`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `personnesimplifie`  AS SELECT `p`.`IDPERSONNE` AS `ID Utilisateur`, `p`.`NOMPERSONNE` AS `Nom`, `p`.`PRENOMPERSONNE` AS `Prenom`, `p`.`EMAILPERSONNE` AS `Email` FROM `personne` AS `p` ;

-- --------------------------------------------------------

--
-- Structure de la vue `resptopers`
--
DROP TABLE IF EXISTS `resptopers`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `resptopers`  AS SELECT concat(`p`.`NOMPERSONNE`,' ',`p`.`PRENOMPERSONNE`) AS `NOMPRENOMRESPONSABLE` FROM (`responsable` `r` join `personne` `p` on(`r`.`IDPERSONNE` = `p`.`IDPERSONNE`)) ;

-- --------------------------------------------------------

--
-- Structure de la vue `userspersonne`
--
DROP TABLE IF EXISTS `userspersonne`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `userspersonne`  AS SELECT `p`.`IDPERSONNE` AS `IDPERSONNE`, `p`.`NOMPERSONNE` AS `NOMPERSONNE`, `p`.`PRENOMPERSONNE` AS `PRENOMPERSONNE` FROM (`personne` `p` join `users` `u` on(`p`.`IDPERSONNE` = `u`.`id`)) ORDER BY `u`.`id` ASC ;

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`IDPERSONNE`);

--
-- Index pour la table `animateur`
--
ALTER TABLE `animateur`
  ADD PRIMARY KEY (`IDPERSONNE`);

--
-- Index pour la table `animer_atelier`
--
ALTER TABLE `animer_atelier`
  ADD PRIMARY KEY (`IDMANIF`,`IDPERSONNE`),
  ADD KEY `I_FK_ANIMER_ATELIER_ATELIER` (`IDMANIF`),
  ADD KEY `I_FK_ANIMER_ATELIER_ANIMATEUR` (`IDPERSONNE`);

--
-- Index pour la table `artistes`
--
ALTER TABLE `artistes`
  ADD PRIMARY KEY (`IDPERSONNE`);

--
-- Index pour la table `atelier`
--
ALTER TABLE `atelier`
  ADD PRIMARY KEY (`IDMANIF`);

--
-- Index pour la table `avis`
--
ALTER TABLE `avis`
  ADD PRIMARY KEY (`IDAVIS`),
  ADD KEY `I_FK_AVIS_ADHERENT` (`IDPERSONNE`),
  ADD KEY `I_FK_AVIS_MANIFESTATION` (`IDMANIF`);

--
-- Index pour la table `chanter`
--
ALTER TABLE `chanter`
  ADD PRIMARY KEY (`IDPERSONNE`,`IDMANIF`),
  ADD KEY `I_FK_CHANTER_ARTISTES` (`IDPERSONNE`),
  ADD KEY `I_FK_CHANTER_CONCERT` (`IDMANIF`);

--
-- Index pour la table `concert`
--
ALTER TABLE `concert`
  ADD PRIMARY KEY (`IDMANIF`);

--
-- Index pour la table `conference`
--
ALTER TABLE `conference`
  ADD PRIMARY KEY (`IDMANIF`);

--
-- Index pour la table `debat`
--
ALTER TABLE `debat`
  ADD PRIMARY KEY (`IDMANIF`),
  ADD KEY `I_FK_DEBAT_CONFÉRENCE` (`IDMANIF`);

--
-- Index pour la table `facture`
--
ALTER TABLE `facture`
  ADD PRIMARY KEY (`REFFACTURE`),
  ADD KEY `I_FK_FACTURE_RESERVATION` (`REFRESERVATION`);

--
-- Index pour la table `failed_jobs`
--
ALTER TABLE `failed_jobs`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `failed_jobs_uuid_unique` (`uuid`);

--
-- Index pour la table `festival`
--
ALTER TABLE `festival`
  ADD PRIMARY KEY (`ANNEEFESTIVAL`),
  ADD KEY `I_FK_FESTIVAL_RESPONSABLE` (`IDPERSONNE`),
  ADD KEY `I_FK_FESTIVAL_THEMATIQUE` (`IDTHEMATIQUE`);

--
-- Index pour la table `intervenantspecialise`
--
ALTER TABLE `intervenantspecialise`
  ADD PRIMARY KEY (`IDPERSONNE`);

--
-- Index pour la table `lieu`
--
ALTER TABLE `lieu`
  ADD PRIMARY KEY (`IDLIEU`);

--
-- Index pour la table `manifestation`
--
ALTER TABLE `manifestation`
  ADD PRIMARY KEY (`IDMANIF`),
  ADD KEY `I_FK_MANIFESTATION_FESTIVAL` (`ANNEEFESTIVAL`),
  ADD KEY `I_FK_MANIFESTATION_LIEU` (`IDLIEU`);

--
-- Index pour la table `migrations`
--
ALTER TABLE `migrations`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `participer`
--
ALTER TABLE `participer`
  ADD PRIMARY KEY (`IDMANIF`,`IDPERSONNE`),
  ADD KEY `I_FK_PARTCIPER_CONFÉRENCE` (`IDMANIF`),
  ADD KEY `I_FK_PARTCIPER_INTERVENANTSPECIALISE` (`IDPERSONNE`);

--
-- Index pour la table `password_resets`
--
ALTER TABLE `password_resets`
  ADD KEY `password_resets_email_index` (`email`);

--
-- Index pour la table `personne`
--
ALTER TABLE `personne`
  ADD PRIMARY KEY (`IDPERSONNE`);

--
-- Index pour la table `public`
--
ALTER TABLE `public`
  ADD PRIMARY KEY (`IDPUBLIC`);

--
-- Index pour la table `reservation`
--
ALTER TABLE `reservation`
  ADD PRIMARY KEY (`REFRESERVATION`),
  ADD KEY `I_FK_RESERVATION_ADHERENT` (`IDPERSONNE`),
  ADD KEY `I_FK_RESERVATION_MANIFESTATION` (`IDMANIF`);

--
-- Index pour la table `responsable`
--
ALTER TABLE `responsable`
  ADD PRIMARY KEY (`IDPERSONNE`);

--
-- Index pour la table `thematique`
--
ALTER TABLE `thematique`
  ADD PRIMARY KEY (`IDTHEMATIQUE`);

--
-- Index pour la table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `users_email_unique` (`email`);

--
-- Index pour la table `viser`
--
ALTER TABLE `viser`
  ADD PRIMARY KEY (`IDPUBLIC`,`IDMANIF`),
  ADD KEY `I_FK_VISER_PUBLIC` (`IDPUBLIC`),
  ADD KEY `I_FK_VISER_MANIFESTATION` (`IDMANIF`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `avis`
--
ALTER TABLE `avis`
  MODIFY `IDAVIS` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT pour la table `facture`
--
ALTER TABLE `facture`
  MODIFY `REFFACTURE` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `failed_jobs`
--
ALTER TABLE `failed_jobs`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `lieu`
--
ALTER TABLE `lieu`
  MODIFY `IDLIEU` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT pour la table `manifestation`
--
ALTER TABLE `manifestation`
  MODIFY `IDMANIF` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=54;

--
-- AUTO_INCREMENT pour la table `migrations`
--
ALTER TABLE `migrations`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT pour la table `personne`
--
ALTER TABLE `personne`
  MODIFY `IDPERSONNE` bigint(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=55;

--
-- AUTO_INCREMENT pour la table `public`
--
ALTER TABLE `public`
  MODIFY `IDPUBLIC` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT pour la table `reservation`
--
ALTER TABLE `reservation`
  MODIFY `REFRESERVATION` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=67;

--
-- AUTO_INCREMENT pour la table `thematique`
--
ALTER TABLE `thematique`
  MODIFY `IDTHEMATIQUE` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `admin`
--
ALTER TABLE `admin`
  ADD CONSTRAINT `FK_ADMIN_PERSONNE` FOREIGN KEY (`IDPERSONNE`) REFERENCES `personne` (`IDPERSONNE`);

--
-- Contraintes pour la table `animateur`
--
ALTER TABLE `animateur`
  ADD CONSTRAINT `FK_ANIMATEUR_PERSONNE` FOREIGN KEY (`IDPERSONNE`) REFERENCES `personne` (`IDPERSONNE`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `animer_atelier`
--
ALTER TABLE `animer_atelier`
  ADD CONSTRAINT `FK_ANIMER_ATELIER_ANIMATEUR` FOREIGN KEY (`IDPERSONNE`) REFERENCES `animateur` (`IDPERSONNE`),
  ADD CONSTRAINT `FK_ANIMER_ATELIER_ATELIER` FOREIGN KEY (`IDMANIF`) REFERENCES `atelier` (`IDMANIF`);

--
-- Contraintes pour la table `artistes`
--
ALTER TABLE `artistes`
  ADD CONSTRAINT `FK_ARTISTES_PERSONNE` FOREIGN KEY (`IDPERSONNE`) REFERENCES `personne` (`IDPERSONNE`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `atelier`
--
ALTER TABLE `atelier`
  ADD CONSTRAINT `FK_ATELIER_MANIFESTATION` FOREIGN KEY (`IDMANIF`) REFERENCES `manifestation` (`IDMANIF`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `avis`
--
ALTER TABLE `avis`
  ADD CONSTRAINT `AVIS_ibfk_1` FOREIGN KEY (`IDPERSONNE`) REFERENCES `users` (`id`),
  ADD CONSTRAINT `FK_AVIS_MANIFESTATION` FOREIGN KEY (`IDMANIF`) REFERENCES `manifestation` (`IDMANIF`);

--
-- Contraintes pour la table `chanter`
--
ALTER TABLE `chanter`
  ADD CONSTRAINT `FK_CHANTER_ARTISTES` FOREIGN KEY (`IDPERSONNE`) REFERENCES `artistes` (`IDPERSONNE`),
  ADD CONSTRAINT `FK_CHANTER_CONCERT` FOREIGN KEY (`IDMANIF`) REFERENCES `concert` (`IDMANIF`);

--
-- Contraintes pour la table `concert`
--
ALTER TABLE `concert`
  ADD CONSTRAINT `FK_CONCERT_MANIFESTATION` FOREIGN KEY (`IDMANIF`) REFERENCES `manifestation` (`IDMANIF`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `conference`
--
ALTER TABLE `conference`
  ADD CONSTRAINT `FK_CONFERENCE_MANIFESTATION` FOREIGN KEY (`IDMANIF`) REFERENCES `manifestation` (`IDMANIF`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `debat`
--
ALTER TABLE `debat`
  ADD CONSTRAINT `FK_DEBAT_MANIFESTATION` FOREIGN KEY (`IDMANIF`) REFERENCES `manifestation` (`IDMANIF`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `facture`
--
ALTER TABLE `facture`
  ADD CONSTRAINT `FK_FACTURE_RESERVATION` FOREIGN KEY (`REFRESERVATION`) REFERENCES `reservation` (`REFRESERVATION`);

--
-- Contraintes pour la table `festival`
--
ALTER TABLE `festival`
  ADD CONSTRAINT `FK_FESTIVAL_RESPONSABLE` FOREIGN KEY (`IDPERSONNE`) REFERENCES `responsable` (`IDPERSONNE`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `FK_FESTIVAL_THEMATIQUE` FOREIGN KEY (`IDTHEMATIQUE`) REFERENCES `thematique` (`IDTHEMATIQUE`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `intervenantspecialise`
--
ALTER TABLE `intervenantspecialise`
  ADD CONSTRAINT `FK_INTERVENANTSPECIALISE_PERSONNE` FOREIGN KEY (`IDPERSONNE`) REFERENCES `personne` (`IDPERSONNE`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `manifestation`
--
ALTER TABLE `manifestation`
  ADD CONSTRAINT `FK_MANIFESTATION_FESTIVAL` FOREIGN KEY (`ANNEEFESTIVAL`) REFERENCES `festival` (`ANNEEFESTIVAL`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_MANIFESTATION_LIEU` FOREIGN KEY (`IDLIEU`) REFERENCES `lieu` (`IDLIEU`);

--
-- Contraintes pour la table `participer`
--
ALTER TABLE `participer`
  ADD CONSTRAINT `FK_PARTCIPER_MANIFESTATION` FOREIGN KEY (`IDMANIF`) REFERENCES `manifestation` (`IDMANIF`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_PARTCIPER_PERSONNE` FOREIGN KEY (`IDPERSONNE`) REFERENCES `personne` (`IDPERSONNE`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `reservation`
--
ALTER TABLE `reservation`
  ADD CONSTRAINT `FK_RESERVATION_MANIFESTATION` FOREIGN KEY (`IDMANIF`) REFERENCES `manifestation` (`IDMANIF`),
  ADD CONSTRAINT `RESERVATION_ibfk_1` FOREIGN KEY (`IDPERSONNE`) REFERENCES `users` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `responsable`
--
ALTER TABLE `responsable`
  ADD CONSTRAINT `FK_RESPONSABLE_PERSONNE` FOREIGN KEY (`IDPERSONNE`) REFERENCES `personne` (`IDPERSONNE`);

--
-- Contraintes pour la table `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `users_ibfk_1` FOREIGN KEY (`id`) REFERENCES `personne` (`IDPERSONNE`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `viser`
--
ALTER TABLE `viser`
  ADD CONSTRAINT `FK_VISER_MANIFESTATION` FOREIGN KEY (`IDMANIF`) REFERENCES `manifestation` (`IDMANIF`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_VISER_PUBLIC` FOREIGN KEY (`IDPUBLIC`) REFERENCES `public` (`IDPUBLIC`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
