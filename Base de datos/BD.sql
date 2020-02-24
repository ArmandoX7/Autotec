-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: localhost    Database: autotec
-- ------------------------------------------------------
-- Server version	8.0.19

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `automovil`
--

DROP TABLE IF EXISTS `automovil`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `automovil` (
  `NumSerie` varchar(15) NOT NULL,
  `Marca` varchar(45) NOT NULL,
  `Modelo` varchar(45) NOT NULL,
  `Año` year NOT NULL,
  `Color` varchar(45) NOT NULL,
  `idCliente` int NOT NULL,
  PRIMARY KEY (`NumSerie`),
  KEY `idCliente_idx` (`idCliente`),
  CONSTRAINT `idCliente` FOREIGN KEY (`idCliente`) REFERENCES `cliente` (`idCliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `automovil`
--

LOCK TABLES `automovil` WRITE;
/*!40000 ALTER TABLE `automovil` DISABLE KEYS */;
INSERT INTO `automovil` VALUES ('ABF59JLR3ZY','General Motors','Ruby Glenn',1999,'azul',17),('AYT74FBS7TV','Isuzu','Francesca Mccormick',2004,'verde',9),('CEF69HMD2XE','Kenworth','Bianca Pickett',2017,'verde',18),('CQJ84ASQ7RW','GMC','Elaine Pierce',2014,'verde',13),('FIT64YLZ2PY','Dacia','Kathleen Gonzales',2010,'amarillo',6),('HDT06HFS1LL','Kia Motors','Adele Stokes',1998,'rojo',20),('JTE15WZL3TO','Smart','Mariko Olson',1998,'verde',7),('MSS45YEQ0DP','Skoda','Claudia Morrison',2002,'índigo',6),('NAG09ACP3CE','Kenworth','Briar Murray',2019,'rojo',10),('OEW61HIS4ZA','Volvo','Raya Randall',2010,'rojo',8),('OMZ51STE4AY','Suzuki','Maggie Pearson',2018,'rojo',10),('QFZ22XMQ6QE','Cadillac','Shelly Forbes',2010,'rojo',5),('RIJ45XYD1BL','Infiniti','Lael Tucker',2004,'violeta',11),('SGC56ZBG7HI','Mitsubishi Motors','Mara Casey',2010,'amarillo',11),('TGZ34BET4DB','Dacia','Kylan Delgado',2004,'amarillo',3),('TLP64PQI7AG','Volkswagen','Marcia Bean',2012,'índigo',13),('TYG00XNH4FA','Suzuki','Pandora Lloyd',1995,'rojo',14),('UJP47BDC8FT','Maruti Suzuki','Jenette Mcmahon',2017,'naranja',8),('WNX02OGL5AG','RAM Trucks','Robin Hopper',1999,'violeta',8),('XIX13KJW7PV','Fiat','Claudia Bridges',2017,'violeta',16);
/*!40000 ALTER TABLE `automovil` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cliente` (
  `idCliente` int NOT NULL AUTO_INCREMENT,
  `Nombres` varchar(45) NOT NULL,
  `Apellidos` varchar(45) NOT NULL,
  `Telefono` bigint NOT NULL,
  `Promosión` int DEFAULT NULL,
  PRIMARY KEY (`idCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (1,'Maxine','Steele',1646122095,NULL),(2,'Gavin','Huber',1627031239,NULL),(3,'Colt','Meyers',1686091298,NULL),(4,'Keefe','Sharp',1690082627,NULL),(5,'Risa','Fitzgerald',1609102415,NULL),(6,'Riley','Gates',1643080315,NULL),(7,'Sophia','Malone',1634012307,NULL),(8,'Camille','Moses',1635040579,NULL),(9,'Hannah','Brock',164603205677,NULL),(10,'Deacon','Kramer',166506125647,NULL),(11,'Lev','Bray',169710232019,NULL),(12,'Zenia','Pacheco',163006163699,NULL),(13,'Samson','Harrell',167911224736,NULL),(14,'Deacon','Schultz',166908201764,NULL),(15,'Brady','Rodriquez',163403037082,NULL),(16,'Zia','Bentley',169102270700,NULL),(17,'Sophia','Carney',168908011631,NULL),(18,'Thor','Peck',164312245006,NULL),(19,'Jose','Alvarez',1646188195,NULL),(20,'Jorge','Rodriguez',1640122995,NULL);
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `departamento`
--

DROP TABLE IF EXISTS `departamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `departamento` (
  `idDepartamento` int NOT NULL AUTO_INCREMENT,
  `Nombre Departamento` varchar(85) NOT NULL,
  `idEmpleado` int NOT NULL,
  PRIMARY KEY (`idDepartamento`),
  KEY `idEmpleado_idx` (`idEmpleado`),
  CONSTRAINT `idEmpleado` FOREIGN KEY (`idEmpleado`) REFERENCES `empleado` (`idEmpleado`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departamento`
--

LOCK TABLES `departamento` WRITE;
/*!40000 ALTER TABLE `departamento` DISABLE KEYS */;
INSERT INTO `departamento` VALUES (1,'Carroceria y pintura',1),(2,'Eléctrico',2),(3,'Alineacion, Balanceo, Suspension',3),(4,'Mecanico',13);
/*!40000 ALTER TABLE `departamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `descripción`
--

DROP TABLE IF EXISTS `descripción`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `descripción` (
  `idDescripción` int NOT NULL AUTO_INCREMENT,
  `Descripción` varchar(45) NOT NULL,
  `idDepartamento` int NOT NULL,
  `Precio` int NOT NULL,
  `Garantia` varchar(45) NOT NULL,
  `idRefaccionaria` int DEFAULT NULL,
  PRIMARY KEY (`idDescripción`),
  KEY `idDepartamento_idx` (`idDepartamento`),
  KEY `idRefaccionaria_idx` (`idRefaccionaria`),
  CONSTRAINT `idDepartamento` FOREIGN KEY (`idDepartamento`) REFERENCES `departamento` (`idDepartamento`),
  CONSTRAINT `idRefaccionaria` FOREIGN KEY (`idRefaccionaria`) REFERENCES `refaccionaria` (`idRefaccionaria`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `descripción`
--

LOCK TABLES `descripción` WRITE;
/*!40000 ALTER TABLE `descripción` DISABLE KEYS */;
INSERT INTO `descripción` VALUES (1,'Luces de advertencia',2,150,'7 dias',NULL),(2,'Chisporroteo o no de encendido del motor',4,350,'14 dias',NULL),(3,'Consumo excesivo de combustible',4,850,'14 dias',NULL),(4,'Bateria muerta',2,350,'7 dias',NULL),(5,'Neumaticos Lisos',4,150,'7 dias',NULL),(6,'Frenos Ruidosos',4,600,'14 dias',NULL),(7,'Falla en el alternador',3,800,'14 dias',NULL),(8,'Motor de arranque roto',4,700,'8 dias',NULL),(9,'Volante movedizo',4,500,'14 dias',NULL),(10,'Sobrecalentamiento',4,650,'14 dias',NULL),(11,'Deslizamiento',3,750,'12 dias',NULL),(12,'Falla en el sensor de oxigeno',2,260,'18 dias',NULL),(13,'Falla en los cilindros',4,650,'14 dias',NULL),(14,'Mala eficiencia en el catalizador',3,450,'14 dias',NULL),(15,'Falla del termostato',3,650,'14 dias',NULL);
/*!40000 ALTER TABLE `descripción` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `diagdesc`
--

DROP TABLE IF EXISTS `diagdesc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `diagdesc` (
  `idDiagnostico` int NOT NULL,
  `idDescripción` int NOT NULL,
  KEY `idDiagnostico_idx` (`idDiagnostico`),
  KEY `idDescripción_idx` (`idDescripción`),
  CONSTRAINT `idDescripción` FOREIGN KEY (`idDescripción`) REFERENCES `descripción` (`idDescripción`),
  CONSTRAINT `idDiagnostico` FOREIGN KEY (`idDiagnostico`) REFERENCES `diagnostico` (`idDiagnostico`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `diagdesc`
--

LOCK TABLES `diagdesc` WRITE;
/*!40000 ALTER TABLE `diagdesc` DISABLE KEYS */;
INSERT INTO `diagdesc` VALUES (8,13),(2,3),(10,14),(3,10),(8,12),(3,8),(5,11),(17,5),(14,9),(10,7),(6,10),(8,3),(5,15),(11,12),(8,5),(5,1),(13,6),(17,11),(5,2),(16,2);
/*!40000 ALTER TABLE `diagdesc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `diagnostico`
--

DROP TABLE IF EXISTS `diagnostico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `diagnostico` (
  `idDiagnostico` int NOT NULL AUTO_INCREMENT,
  `idEmpleado` int NOT NULL,
  `idCliente` int NOT NULL,
  PRIMARY KEY (`idDiagnostico`),
  KEY `idEmpleado` (`idEmpleado`),
  KEY `idCliente` (`idCliente`),
  CONSTRAINT `diagnostico_ibfk_1` FOREIGN KEY (`idEmpleado`) REFERENCES `empleado` (`idEmpleado`),
  CONSTRAINT `diagnostico_ibfk_2` FOREIGN KEY (`idCliente`) REFERENCES `cliente` (`idCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `diagnostico`
--

LOCK TABLES `diagnostico` WRITE;
/*!40000 ALTER TABLE `diagnostico` DISABLE KEYS */;
INSERT INTO `diagnostico` VALUES (1,7,19),(2,7,5),(3,1,8),(4,2,6),(5,2,11),(6,16,16),(7,14,2),(8,16,18),(9,2,14),(10,9,1),(11,17,2),(12,5,4),(13,20,8),(14,6,1),(15,7,12),(16,10,20),(17,2,10),(18,15,12),(19,15,13),(20,3,1);
/*!40000 ALTER TABLE `diagnostico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleado`
--

DROP TABLE IF EXISTS `empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empleado` (
  `idEmpleado` int NOT NULL AUTO_INCREMENT,
  `Nombres` varchar(45) NOT NULL,
  `Apellidos` varchar(45) NOT NULL,
  `Telefono` bigint NOT NULL,
  `Rango` varchar(45) NOT NULL,
  PRIMARY KEY (`idEmpleado`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleado`
--

LOCK TABLES `empleado` WRITE;
/*!40000 ALTER TABLE `empleado` DISABLE KEYS */;
INSERT INTO `empleado` VALUES (1,'Josiah','Castillo',45204926508,'supervisor'),(2,'Heidi','Rogers',45788881187,'supervisor'),(3,'Jamalia','Hancock',45497842993,'supervisor'),(4,'Cameron','Workman',45725006126,'mecanico general'),(5,'Jorden','Velasquez',45714138230,'mecanico general'),(6,'Jael','Stark',45705715838,'mecanico general'),(7,'Cheryl','Fletcher',45497485728,'mecanico general'),(8,'Otto','Carpenter',45799366077,'mecanico general'),(9,'Xyla','Stark',45302379511,'mecanico general'),(10,'Prescott','Humphrey',45975825288,'mecanico general'),(11,'Evangeline','Gallagher',45752632337,'mecanico general'),(12,'Melodie','Todd',45253738031,'mecanico general'),(13,'Shana','Herring',45774044963,'supervisor'),(14,'Sigourney','Waller',45154559797,'mecanico general'),(15,'Ariana','Gould',45123623726,'mecanico general'),(16,'Lois','Nelson',45477160527,'mecanico general'),(17,'Mark','Bolton',45579903353,'mecanico general'),(18,'Amena','Hayes',45583736753,'mecanico general'),(19,'Dillon','Mcbride',45652810418,'mecanico general'),(20,'Tarik','Prince',45473024618,'mecanico general');
/*!40000 ALTER TABLE `empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `refaccionaria`
--

DROP TABLE IF EXISTS `refaccionaria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `refaccionaria` (
  `idRefaccionaria` int NOT NULL AUTO_INCREMENT,
  `Nombre pieza` varchar(45) NOT NULL,
  `Precio` int NOT NULL,
  `Cantidad` int NOT NULL,
  PRIMARY KEY (`idRefaccionaria`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `refaccionaria`
--

LOCK TABLES `refaccionaria` WRITE;
/*!40000 ALTER TABLE `refaccionaria` DISABLE KEYS */;
INSERT INTO `refaccionaria` VALUES (1,'cofre',800,1),(2,'facia delantera',1000,1),(3,'facia trasera',450,1),(4,'calavera izquierda',300,1),(5,'Espejo lateral izquierdo',950,1),(6,'parabrisas',200,1),(7,'bisagra izquierda',400,1),(8,'brazo suspencion delantero izquierdo',2500,1),(9,'amortiguador delantero izquierdo',2500,1),(10,'amortiguador delantero derecho',2500,1),(11,'amortiguador trasero izquierdo',2800,1),(12,'amortiguador trasero derecho',2800,1),(13,'rin delantero derecho',200,1),(14,'rin delantero izquierdo',200,1),(15,'rin trasero derecho',200,1),(16,'rin trasero izquierdo',200,1),(17,'Puerta delantera izquierda',800,1),(18,'Puerta delantera derecha',800,1),(19,'Puerta trasera derecha',800,1),(20,'Puerta trasera izquierda',800,1);
/*!40000 ALTER TABLE `refaccionaria` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-02-19 14:39:57
-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: localhost    Database: cuentas
-- ------------------------------------------------------
-- Server version	8.0.19

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(30) DEFAULT NULL,
  `password` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'Admin','12345');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-02-19 14:39:57
