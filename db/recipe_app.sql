CREATE DATABASE  IF NOT EXISTS `recipe_app` /*!40100 DEFAULT CHARACTER SET utf8 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `recipe_app`;
-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: localhost    Database: recipe_app
-- ------------------------------------------------------
-- Server version	8.0.28

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
-- Table structure for table `allergen`
--

DROP TABLE IF EXISTS `allergen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `allergen` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Allergen` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `allergen`
--

LOCK TABLES `allergen` WRITE;
/*!40000 ALTER TABLE `allergen` DISABLE KEYS */;
INSERT INTO `allergen` VALUES (1,'Buckwheat'),(2,'Celery'),(3,'Egg'),(4,'Fish'),(5,'Mango'),(6,'Strawberry'),(7,'Banana'),(8,'Avocado'),(9,'Kiwi'),(10,'Stone Fruit'),(11,'Rose Fruit'),(12,'Hot Peppers'),(13,'Fruit'),(14,'Garlic'),(15,'Oats'),(16,'Maize'),(17,'Milk'),(18,'Mustard'),(19,'Peanut'),(20,'Poultry'),(21,'Red Meat'),(22,'Rice'),(23,'Sesame'),(24,'Shellfish'),(25,'Soy'),(26,'Tree Nut'),(27,'Wheat'),(28,'Sulfites'),(29,'Tartrazine');
/*!40000 ALTER TABLE `allergen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ethnic_origin`
--

DROP TABLE IF EXISTS `ethnic_origin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ethnic_origin` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Ethnicity` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `Ethnicity_UNIQUE` (`Ethnicity`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ethnic_origin`
--

LOCK TABLES `ethnic_origin` WRITE;
/*!40000 ALTER TABLE `ethnic_origin` DISABLE KEYS */;
INSERT INTO `ethnic_origin` VALUES (4,'African'),(2,'European'),(6,'Indian'),(9,'Latin American'),(3,'Mediterranean'),(5,'Middle Eastern'),(1,'North American'),(7,'Northeast Asian'),(10,'Pacifia'),(8,'Southeast Asian');
/*!40000 ALTER TABLE `ethnic_origin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `image`
--

DROP TABLE IF EXISTS `image`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `image` (
  `recipeID` int NOT NULL,
  `image` blob,
  PRIMARY KEY (`recipeID`),
  CONSTRAINT `image_recipeid_references_recipe_id` FOREIGN KEY (`recipeID`) REFERENCES `recipe` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `image`
--

LOCK TABLES `image` WRITE;
/*!40000 ALTER TABLE `image` DISABLE KEYS */;
/*!40000 ALTER TABLE `image` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ingredient`
--

DROP TABLE IF EXISTS `ingredient`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ingredient` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Ingredient` varchar(45) NOT NULL,
  `typeOfFoodID` int NOT NULL,
  `nutritionID` int NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `Ingredient_UNIQUE` (`Ingredient`),
  KEY `fk_Ingredient_Type_of_Food1_idx` (`typeOfFoodID`),
  KEY `fk_Ingredient_Nutrition1_idx` (`nutritionID`),
  CONSTRAINT `fk_Ingredient_Nutrition1` FOREIGN KEY (`nutritionID`) REFERENCES `nutrition` (`id`),
  CONSTRAINT `fk_Ingredient_Type_of_Food1` FOREIGN KEY (`typeOfFoodID`) REFERENCES `type_of_food` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=97 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ingredient`
--

LOCK TABLES `ingredient` WRITE;
/*!40000 ALTER TABLE `ingredient` DISABLE KEYS */;
INSERT INTO `ingredient` VALUES (1,'Salt',9,1),(2,'Black pepper',9,1),(3,'Celery',1,1),(4,'Tomato',1,1),(5,'Garlic',9,1),(6,'Lentils',4,1),(7,'Black-eye peas',4,1),(8,'Black beans',4,1),(9,'Garbanzo beans',4,1),(10,'Chickpeas',4,1),(11,'Soybeans',4,1),(12,'Northern white beans',4,1),(13,'Wheat',3,1),(14,'Oats',3,1),(15,'Maize or Corn',3,1),(16,'Barley',3,1),(17,'Rye',3,1),(18,'Rice',3,1),(19,'Buckwheat',3,1),(20,'Bread',10,1),(21,'Brocolli',1,1),(22,'Cauliflower',1,1),(23,'Kale',1,1),(24,'Lettuce',1,1),(25,'Cabbage',1,1),(26,'Peas',1,1),(27,'Green beans',1,1),(28,'Potato',3,1),(29,'Sweet potato',3,1),(30,'Collard greens',1,1),(31,'Apple',2,1),(32,'Carrots',1,1),(33,'Banana',2,1),(34,'Peach',2,1),(35,'Pear',2,1),(36,'Grapes',2,1),(37,'Raisins',2,1),(38,'Cranberries',2,1),(39,'Blueberries',2,1),(40,'Strawberries',2,1),(41,'Mango',2,1),(42,'Pineapple',2,1),(43,'Coconut',5,1),(44,'Lemon',2,1),(45,'Lime',2,1),(46,'Peanut',5,1),(47,'Cashew',5,1),(48,'Almond',5,1),(49,'Macadamia',5,1),(50,'Walnut',5,1),(51,'Pecan',5,1),(52,'Milk',6,1),(53,'Cheese',6,1),(54,'Yogurt',6,1),(55,'Egg',6,1),(56,'Chicken',7,1),(57,'Duck',7,1),(58,'Beef',7,1),(59,'Pork',7,1),(60,'Salmon',8,1),(61,'Tuna',8,1),(62,'Tilapia',8,1),(63,'Catfish',8,1),(64,'Shrimp',8,1),(65,'Oyster',8,1),(66,'Scallop',8,1),(67,'Crab',8,1),(68,'Lobster',8,1),(69,'Mussel',8,1),(70,'Rosemary',9,1),(71,'Ginger',9,1),(72,'Basil',9,1),(73,'Cinnamon',9,1),(74,'Allspice',9,1),(75,'Nutmeg',9,1),(76,'Thyme',9,1),(77,'Bell pepper',1,1),(78,'Cilantro',9,1),(79,'Marjoram',9,1),(80,'Oregano',9,1),(81,'Fennel seed',9,1),(82,'Tumeric',9,1),(83,'Cracker',10,1),(84,'Pie shell',10,1),(85,'Olive oil',11,1),(86,'Peanut oil',11,1),(87,'Butter',11,1),(88,'Ketchup',12,1),(89,'BBQ sauce',12,1),(90,'Teriyaki sauce',12,1),(91,'Rum',14,1),(92,'Port',14,1),(93,'Vermouth',14,1),(94,'Onion',1,1),(95,'Teff',3,1),(96,'Tej',14,1);
/*!40000 ALTER TABLE `ingredient` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ingredient_has_allergen`
--

DROP TABLE IF EXISTS `ingredient_has_allergen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ingredient_has_allergen` (
  `ingredientID` int NOT NULL,
  `allergenID` int NOT NULL,
  PRIMARY KEY (`ingredientID`,`allergenID`),
  KEY `fk_Ingredient_has_Allergy_Allergy1_idx` (`allergenID`),
  KEY `fk_Ingredient_has_Allergy_Ingredient1_idx` (`ingredientID`),
  CONSTRAINT `fk_Ingredient_has_Allergy_Allergy1` FOREIGN KEY (`allergenID`) REFERENCES `allergen` (`id`),
  CONSTRAINT `fk_Ingredient_has_Allergy_Ingredient1` FOREIGN KEY (`ingredientID`) REFERENCES `ingredient` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ingredient_has_allergen`
--

LOCK TABLES `ingredient_has_allergen` WRITE;
/*!40000 ALTER TABLE `ingredient_has_allergen` DISABLE KEYS */;
INSERT INTO `ingredient_has_allergen` VALUES (19,1),(3,2),(55,3),(60,4),(61,4),(62,4),(63,4),(41,5),(40,6),(33,7),(34,10),(35,10),(31,11),(35,11),(40,11),(48,11),(31,13),(32,13),(33,13),(34,13),(35,13),(36,13),(37,13),(38,13),(39,13),(40,13),(41,13),(42,13),(43,13),(44,13),(45,13),(5,14),(14,15),(15,16),(52,17),(53,17),(54,17),(46,19),(86,19),(56,20),(57,20),(58,21),(59,21),(18,22),(64,24),(65,24),(66,24),(67,24),(68,24),(69,24),(11,25),(46,26),(47,26),(48,26),(49,26),(50,26),(51,26),(13,27),(20,27),(83,27);
/*!40000 ALTER TABLE `ingredient_has_allergen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kitchenware`
--

DROP TABLE IF EXISTS `kitchenware`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `kitchenware` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Kitchenware` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `Kitchenware_UNIQUE` (`Kitchenware`)
) ENGINE=InnoDB AUTO_INCREMENT=59 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kitchenware`
--

LOCK TABLES `kitchenware` WRITE;
/*!40000 ALTER TABLE `kitchenware` DISABLE KEYS */;
INSERT INTO `kitchenware` VALUES (1,'Baking Dish'),(2,'Baking Tray'),(58,'Boiler'),(50,'Bread machine'),(3,'Cake pan'),(4,'Can opener'),(5,'Chopping board'),(53,'Coffee machine'),(6,'Coffee press'),(7,'Colander'),(8,'Cooling rack'),(9,'Corkscrew'),(51,'Deep fryer'),(12,'Egg slicer'),(11,'Eggbeater'),(52,'Electric cooker'),(13,'Electric mixer'),(14,'Frying pan'),(15,'Garlic press'),(16,'Grater'),(46,'Grill'),(17,'Grillpan'),(10,'Kitche knives'),(18,'Kitchen scissors'),(19,'Mandolin'),(20,'Measuring cups and spoons'),(21,'Meat slicer'),(48,'Microwave'),(22,'Mixing bowl'),(23,'Muffin tin'),(47,'Oven'),(25,'Peeler'),(26,'Pepper mill'),(27,'Pizza stone'),(28,'Potato masher'),(29,'Potato ricer'),(24,'Pressure cooker'),(54,'Rice cooker'),(30,'Rolling pin'),(31,'Saucepan'),(32,'Sheet pan'),(33,'Skillet'),(34,'Slotted spoon'),(56,'Slow cooker'),(35,'Spatula'),(36,'Spiral vegetable slicer'),(38,'Steamer'),(37,'Stock pot'),(49,'Stove top'),(39,'Strainer'),(40,'Timer'),(57,'Toaster'),(41,'Tomato slicer'),(42,'Tongs'),(55,'Waffle iron'),(43,'Whisk'),(44,'Wok'),(45,'Wooden spoon');
/*!40000 ALTER TABLE `kitchenware` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nutrition`
--

DROP TABLE IF EXISTS `nutrition`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `nutrition` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Stub` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nutrition`
--

LOCK TABLES `nutrition` WRITE;
/*!40000 ALTER TABLE `nutrition` DISABLE KEYS */;
INSERT INTO `nutrition` VALUES (1,'Stuff goes here ...');
/*!40000 ALTER TABLE `nutrition` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `recipe`
--

DROP TABLE IF EXISTS `recipe`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `recipe` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  `Instructions` text NOT NULL,
  `cooktime` int NOT NULL,
  `nutritionID` int NOT NULL,
  `ethnicOriginID` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_Recipe_Nutrition1_idx` (`nutritionID`),
  KEY `fk_Recipe_Ethnic_Origin1_idx` (`ethnicOriginID`),
  CONSTRAINT `fk_Recipe_Ethnic_Origin1` FOREIGN KEY (`ethnicOriginID`) REFERENCES `ethnic_origin` (`id`),
  CONSTRAINT `fk_Recipe_Nutrition1` FOREIGN KEY (`nutritionID`) REFERENCES `nutrition` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `recipe`
--

LOCK TABLES `recipe` WRITE;
/*!40000 ALTER TABLE `recipe` DISABLE KEYS */;
INSERT INTO `recipe` VALUES (1,'Chocolate Strawberry Nutella Cake','Stuff goes here ...',120,1,1),(2,'Tomato Pie','Stuff goes here ...',90,1,1),(3,'Rum Balls','Stuff goes here ...',20,1,1),(4,'Sangria','Stuff goes here ...',10,1,1),(5,'Pumpkin Muffins','Stuff goes here ...',60,1,1),(6,'African Peanut Soup','Stuff goes here ...',90,1,4),(7,'Doro Wat','Stuff goes here ...',60,1,4),(8,'Injera','Stuff goes here ...',240,1,4),(9,'BBQ Pulled Pokr','Stuff goes here ...',720,1,1),(10,'Okonomiyaki','Stuff goes here ...',60,1,7),(11,'Red Velvet Cake','Stuff goes here ...',120,1,1),(12,'Turkey BLT','Stuff goes here ...',10,1,1),(13,'Lentil Soul','Stuff goes here ...',60,1,5),(14,'Pepperoni Pizza','Stuff goes here ...',120,1,2),(15,'Shepherd\'s Pie','Stuff goes here ...',240,1,2),(16,'Cheese Quesadilla','Stuff goes here ...',30,1,9),(17,'Lime Sorbet Margarita','Stuff goes here ...',5,1,1),(18,'Garlic Rosemary Cheddar Bread','Stuff goes here ...',120,1,2),(19,'Hummus','Stuff goes here ...',60,1,3),(20,'Chocolate Peanut Butter Drops','Stuff goes here ...',90,1,1),(21,'Ploughman\'s Lunch','Stuff goes here ...',30,1,2),(22,'Quinoa and Black Beans','Stuff goes here ...',60,1,4),(23,'Banana Bread','Stuff goes here ...',90,1,1),(24,'Keema Aloo','Stuff goes here ...',120,1,6),(25,'Masoor Dal','Stuff goes here ...',90,1,6),(26,'Yam Taeng','Stuff goes here ...',90,1,7),(27,'Pad Kee Mow','Stuff goes here ...',90,1,7),(28,'Pad See Ew','Stuff goes here ...',60,1,7);
/*!40000 ALTER TABLE `recipe` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `recipe_has_ingredient`
--

DROP TABLE IF EXISTS `recipe_has_ingredient`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `recipe_has_ingredient` (
  `recipeID` int NOT NULL,
  `ingredientID` int NOT NULL,
  PRIMARY KEY (`recipeID`,`ingredientID`),
  KEY `fk_Recipe_has_Ingredient_Ingredient1_idx` (`ingredientID`),
  KEY `fk_Recipe_has_Ingredient_Recipe1_idx` (`recipeID`),
  CONSTRAINT `fk_Recipe_has_Ingredient_Ingredient1` FOREIGN KEY (`ingredientID`) REFERENCES `ingredient` (`id`),
  CONSTRAINT `fk_Recipe_has_Ingredient_Recipe1` FOREIGN KEY (`recipeID`) REFERENCES `recipe` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `recipe_has_ingredient`
--

LOCK TABLES `recipe_has_ingredient` WRITE;
/*!40000 ALTER TABLE `recipe_has_ingredient` DISABLE KEYS */;
INSERT INTO `recipe_has_ingredient` VALUES (2,1),(6,1),(7,1),(9,1),(2,4),(6,4),(2,5),(7,5),(1,13),(5,13),(6,29),(1,40),(4,44),(6,46),(1,48),(2,53),(1,55),(5,55),(7,55),(7,58),(9,59),(7,71),(2,80),(2,84),(7,87),(9,89),(3,91),(6,94),(7,94),(7,95),(8,95),(7,96);
/*!40000 ALTER TABLE `recipe_has_ingredient` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `recipe_is_a_type_of_meal`
--

DROP TABLE IF EXISTS `recipe_is_a_type_of_meal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `recipe_is_a_type_of_meal` (
  `recipeID` int NOT NULL,
  `typeOfMealID` int NOT NULL,
  PRIMARY KEY (`recipeID`,`typeOfMealID`),
  KEY `fk_Recipe_has_Type_of_Meal_Type_of_Meal1_idx` (`typeOfMealID`),
  KEY `fk_Recipe_has_Type_of_Meal_Recipe1_idx` (`recipeID`),
  CONSTRAINT `fk_Recipe_has_Type_of_Meal_Recipe1` FOREIGN KEY (`recipeID`) REFERENCES `recipe` (`id`),
  CONSTRAINT `fk_Recipe_has_Type_of_Meal_Type_of_Meal1` FOREIGN KEY (`typeOfMealID`) REFERENCES `type_of_meal` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `recipe_is_a_type_of_meal`
--

LOCK TABLES `recipe_is_a_type_of_meal` WRITE;
/*!40000 ALTER TABLE `recipe_is_a_type_of_meal` DISABLE KEYS */;
INSERT INTO `recipe_is_a_type_of_meal` VALUES (2,2),(9,2),(16,2),(21,2),(26,2),(27,2),(28,2),(2,3),(6,3),(7,3),(9,3),(10,3),(12,3),(13,3),(14,3),(15,3),(16,3),(22,3),(24,3),(25,3),(26,3),(27,3),(28,3),(19,4),(5,5),(1,6),(3,6),(11,6),(20,6),(1,8),(5,8),(8,8),(11,8),(23,8),(18,9),(2,10),(27,11),(28,11),(26,12),(6,13),(7,13),(13,13),(17,14),(4,25);
/*!40000 ALTER TABLE `recipe_is_a_type_of_meal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `recipe_uses_kitchenware`
--

DROP TABLE IF EXISTS `recipe_uses_kitchenware`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `recipe_uses_kitchenware` (
  `recipeID` int NOT NULL,
  `kitchenwareID` int NOT NULL,
  PRIMARY KEY (`recipeID`,`kitchenwareID`),
  KEY `fk_Recipe_has_Cookware_Cookware1_idx` (`kitchenwareID`),
  KEY `fk_Recipe_has_Cookware_Recipe1_idx` (`recipeID`),
  CONSTRAINT `fk_Recipe_has_Cookware_Cookware1` FOREIGN KEY (`kitchenwareID`) REFERENCES `kitchenware` (`id`),
  CONSTRAINT `fk_Recipe_has_Cookware_Recipe1` FOREIGN KEY (`recipeID`) REFERENCES `recipe` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `recipe_uses_kitchenware`
--

LOCK TABLES `recipe_uses_kitchenware` WRITE;
/*!40000 ALTER TABLE `recipe_uses_kitchenware` DISABLE KEYS */;
/*!40000 ALTER TABLE `recipe_uses_kitchenware` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `type_of_food`
--

DROP TABLE IF EXISTS `type_of_food`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `type_of_food` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Type` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `type_of_food`
--

LOCK TABLES `type_of_food` WRITE;
/*!40000 ALTER TABLE `type_of_food` DISABLE KEYS */;
INSERT INTO `type_of_food` VALUES (1,'Vegetable'),(2,'Fruit'),(3,'Grain'),(4,'Legume'),(5,'Nut or Seed'),(6,'Dairy'),(7,'Meat'),(8,'Seafood'),(9,'Herb or Spice'),(10,'Baked Good'),(11,'Oil'),(12,'Condiment'),(13,'Garnish'),(14,'Alcohol');
/*!40000 ALTER TABLE `type_of_food` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `type_of_meal`
--

DROP TABLE IF EXISTS `type_of_meal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `type_of_meal` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Type` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `type_of_meal`
--

LOCK TABLES `type_of_meal` WRITE;
/*!40000 ALTER TABLE `type_of_meal` DISABLE KEYS */;
INSERT INTO `type_of_meal` VALUES (1,'Breakfast'),(2,'Lunch'),(3,'Dinner'),(4,'Snack'),(5,'Tea'),(6,'Dessert'),(7,'Appetizer'),(8,'Bread'),(9,'Beer'),(10,'Brunch'),(11,'Pasta, Noodles'),(12,'Salad'),(13,'Soup, Stew, Chili'),(14,'Cocktail'),(15,'Cider'),(16,'Coffee'),(17,'Eggnog'),(18,'Hot chocolate'),(19,'Juice'),(20,'Lemonade'),(21,'Liqueur'),(22,'Mocktail'),(23,'Mulled wine'),(24,'Punch'),(25,'Sangria'),(26,'Shake, Float'),(27,'Slushie'),(28,'Smoothie'),(29,'Tea');
/*!40000 ALTER TABLE `type_of_meal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'recipe_app'
--

--
-- Dumping routines for database 'recipe_app'
--
/*!50003 DROP PROCEDURE IF EXISTS `getAllergens` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `getAllergens`()
BEGIN
	SELECT allergen.id, allergen.allergen
    FROM allergen;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `getEthnicOrigins` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `getEthnicOrigins`()
BEGIN
	SELECT ethnic_origin.id, ethnic_origin.Ethnicity
    FROM ethnic_origin;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `getIngredients` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `getIngredients`()
BEGIN
	SELECT ingredient.id, ingredient.ingredient,
		type_of_food.`Type`, nutrition.stub
    FROM ingredient
		JOIN type_of_food ON type_of_food.id = ingredient.typeOfFoodID
        JOIN nutrition ON nutrition.id = ingredient.nutritionID;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `getIngredientsOfRecipe` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `getIngredientsOfRecipe`(recipeID int)
BEGIN
    IF recipeID < 1 THEN
		SIGNAL SQLSTATE '42000'
			SET MESSAGE_TEXT = 'Invalid recipeID. Cannot be negative number.',
		mysql_errno = 1231;
	END IF;
	SELECT ingredient.id, ingredient.Ingredient, type_of_food.`Type`,
		nutrition.stub
    FROM recipe
		JOIN recipe_has_ingredient ON recipe_has_ingredient.recipeID = recipe.id
        JOIN ingredient ON recipe_has_ingredient.ingredientID = ingredient.id
        JOIN type_of_food ON ingredient.typeOfFoodID = type_of_food.id
        JOIN nutrition ON ingredient.nutritionID = nutrition.id
    WHERE recipe.id = recipeID;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `getKitchenware` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `getKitchenware`()
BEGIN
	SELECT kitchenware.id, kitchenware.Kitchenware
    FROM kitchenware;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `getNutrition` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `getNutrition`()
BEGIN
	SELECT nutrition.id, nutrition.Stub
	FROM nutrition;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `getRecipes` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `getRecipes`()
BEGIN
	SELECT recipe.id, recipe.`Name`, recipe.Instructions, 
		recipe.cooktime, nutrition.stub,
		ethnic_origin.ethnicity
	FROM recipe
		JOIN nutrition ON nutrition.id = recipe.nutritionID
		JOIN ethnic_origin ON recipe.ethnicOriginID = ethnic_origin.id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `getTypeOfFood` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `getTypeOfFood`()
BEGIN
	SELECT type_of_food.id, type_of_food.`Type`
    FROM type_of_food;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `getTypeOfMeal` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `getTypeOfMeal`()
BEGIN
	SELECT type_of_meal.id, type_of_meal.Type
	FROM type_of_meal;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-06-11 15:04:06
