-- MySQL dump 10.13  Distrib 8.0.16, for Linux (x86_64)
--
-- Host: 127.0.0.1    Database: test
-- ------------------------------------------------------
-- Server version	8.0.16

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8mb4 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `dinner_table`
--

DROP TABLE IF EXISTS `dinner_table`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `dinner_table` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `code` varchar(50) DEFAULT NULL,
  `name` varchar(32) DEFAULT NULL,
  `status` int(11) DEFAULT NULL,
  `uniquecode` varchar(50) DEFAULT NULL,
  `date` datetime DEFAULT NULL,
  `is_deleted` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dinner_table`
--

LOCK TABLES `dinner_table` WRITE;
/*!40000 ALTER TABLE `dinner_table` DISABLE KEYS */;
INSERT INTO `dinner_table` VALUES (1,'1','1',1,'code1','2019-06-05 13:41:40',0),(2,'2','2',1,'code1','2019-06-05 13:43:10',0),(3,'3','3',1,'code2','2019-06-05 13:43:12',0),(4,'4','4',1,'code2','2019-06-05 13:43:13',0),(5,'5','5',1,'code2','2019-06-05 13:43:13',0),(6,'6','6',1,'code2','2019-06-05 13:46:48',0),(7,'7','7',1,'code2','2019-06-05 13:47:27',0),(8,'8','8',1,'code2','2019-06-05 13:47:29',0),(9,'9','9',1,'code2','2019-06-05 13:47:30',0),(10,'10','10',1,'code2','2019-06-05 13:47:31',0),(11,'3e2b2d02-481f-4155-ab68-9ea9e3d0fd93','1234',0,'code2','2019-06-06 23:19:19',1),(12,'774c190d-fc3f-4bce-8b28-9dfcb851a652','234',0,'code2','2019-06-06 23:19:37',0),(13,'875370de-4075-4cb8-a738-375fdd4294aa','125',0,'code2','2019-06-06 23:20:42',0),(14,'db16f82b-689e-47ff-a4d7-329440949e23','11',0,'code2','2019-06-06 23:28:11',1),(15,'c431ff5f-5755-4685-a2ee-7804e1c5cc62','12',0,'code2','2019-06-06 23:28:45',1),(16,'55502cc5-e42b-4bb1-8ff7-18e1ddd4f234','131',0,'code2','2019-06-07 12:50:56',1),(17,'b53b828b-0003-48fe-822c-77c9c31b43a5','130',0,'code2','2019-06-08 21:09:28',1),(18,'70cfc3e9-a991-4fdc-8e15-3c00f536699f','131',0,'code2','2019-06-08 21:13:19',1),(19,'4ec56eb7-2511-484f-96e4-5164a9f1dfbf','12',0,'code2','2019-06-08 21:54:36',1),(20,'ff8eb3d9-a3a9-4bcc-8a90-2214edc03ed9','1',0,'code2','2019-06-08 21:56:08',1),(21,'877dff57-509d-4991-9756-64e3e15db5d7','2',0,'code2','2019-06-08 21:56:25',1),(22,'24720bba-6952-4292-8c5c-020f04dd0a9e','1',0,'code2','2019-06-14 22:39:17',0),(23,'c11ec222-a59d-4f94-b9c5-41ffc7104fa6','2',0,'code2','2019-06-14 22:39:21',0);
/*!40000 ALTER TABLE `dinner_table` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `main_user`
--

DROP TABLE IF EXISTS `main_user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `main_user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `code` varchar(50) DEFAULT NULL,
  `username` varchar(32) DEFAULT NULL,
  `password` varchar(32) DEFAULT NULL,
  `uniquecode` varchar(50) DEFAULT NULL,
  `is_deleted` int(11) DEFAULT NULL,
  `date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `main_user`
--

LOCK TABLES `main_user` WRITE;
/*!40000 ALTER TABLE `main_user` DISABLE KEYS */;
INSERT INTO `main_user` VALUES (1,'1','zhangjie','123456','code1',0,'2019-06-05 13:27:02'),(2,'2','admin','123456','code2',0,'2019-06-05 13:27:20'),(3,'3','zj','123456','code3',0,'2019-06-05 13:27:22');
/*!40000 ALTER TABLE `main_user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `order`
--

DROP TABLE IF EXISTS `order`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `order` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `code` varchar(50) DEFAULT NULL,
  `status` int(11) DEFAULT NULL,
  `allprice` double DEFAULT NULL,
  `uniquecode` varchar(50) DEFAULT NULL,
  `table_code` varchar(50) DEFAULT NULL,
  `is_deleted` int(11) DEFAULT NULL,
  `date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order`
--

LOCK TABLES `order` WRITE;
/*!40000 ALTER TABLE `order` DISABLE KEYS */;
INSERT INTO `order` VALUES (1,'46012fc1-7656-4aa9-8b5e-52677dc31e5d',1,3702,'code1','1',NULL,NULL),(2,'7f886154-befd-48e3-9386-b9d84ac99fbd',1,3702,'code1','1',NULL,NULL),(3,'9c8b3296-6c4a-4bcd-af25-1107f0edf468',1,2468,'code1','1',NULL,NULL),(4,'76ae42f1-8f6a-4be8-9b1e-adde5db00db5',1,3702,'code2','2',NULL,NULL),(5,'610ad228-a3a3-4b59-80c6-6d8fde6595df',1,2468,'code2','2',NULL,NULL),(6,'de6858bb-1b76-4810-baf2-475744c958f1',1,3702,'code2','2',NULL,NULL),(7,'aef901f8-b8e9-45f8-a828-6428c2eb6aad',1,2468,'code3','3',NULL,NULL),(8,'a3a7c5e6-666f-4b10-a304-b3e95786eec1',1,2468,'code3','4',NULL,NULL),(9,'4c8c846f-82a1-448b-9354-4b1a5827374c',1,2468,'code3','4',NULL,NULL),(10,'bef66e81-f7df-4de6-a58d-b010607ef5c8',1,2468,'code3','4',NULL,NULL),(11,'b06613da-9fd5-4526-bcda-ecb131f14670',1,1234,'code3','5',NULL,NULL),(12,'748cf6d9-f48a-4ea8-968a-530624ecc1e9',1,2468,'code3','2',NULL,NULL),(13,'94873167-89e6-4554-ad00-843ac9aa5355',1,2468,'code3','2',NULL,NULL),(14,'ae7a2491-2853-4697-b894-c776c7f44425',1,2468,'code3','3',NULL,NULL),(15,'d26e59f5-9e09-4718-9d2e-099e35cad813',1,2468,'code3','4',NULL,NULL),(16,'2b5ccd09-58b0-4bcd-9627-9c7a84f3e410',1,2468,NULL,NULL,NULL,NULL),(17,'837b47b2-dc13-4ca3-9788-1165ebc7dc27',1,2468,NULL,NULL,NULL,NULL),(18,'9e7506ef-6c66-4117-849b-9f5249cde71b',1,2468,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `order` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `order_recipe`
--

DROP TABLE IF EXISTS `order_recipe`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `order_recipe` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `code` varchar(50) DEFAULT NULL,
  `order_code` varchar(50) DEFAULT NULL,
  `recipe_code` varchar(50) DEFAULT NULL,
  `type` int(11) DEFAULT NULL,
  `num` int(11) DEFAULT NULL,
  `is_deleted` int(11) DEFAULT NULL,
  `date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=58 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order_recipe`
--

LOCK TABLES `order_recipe` WRITE;
/*!40000 ALTER TABLE `order_recipe` DISABLE KEYS */;
INSERT INTO `order_recipe` VALUES (1,'0fc88ec8-3fe9-45c3-93ed-76e2b57c1b9a','46012fc1-7656-4aa9-8b5e-52677dc31e5d','1',1,1,NULL,NULL),(2,'108d3199-a5b7-4914-9fb7-1a35d5c360bb','46012fc1-7656-4aa9-8b5e-52677dc31e5d','2',1,1,NULL,NULL),(3,'019a3757-aaf9-4975-a203-4c09d433a108','46012fc1-7656-4aa9-8b5e-52677dc31e5d','3',1,1,NULL,NULL),(4,'dc12bba8-f6aa-4c38-8be8-cc684e85eff5','46012fc1-7656-4aa9-8b5e-52677dc31e5d','1',2,1,NULL,NULL),(5,'98e4846d-8e08-486f-8766-9fe37082cdcb','7f886154-befd-48e3-9386-b9d84ac99fbd','1',1,1,NULL,NULL),(6,'87859356-f71f-4dc2-aff8-1f005c602b28','7f886154-befd-48e3-9386-b9d84ac99fbd','2',1,1,NULL,NULL),(7,'a46a7573-2e31-475e-bfbb-249fc02ea620','7f886154-befd-48e3-9386-b9d84ac99fbd','3',1,1,NULL,NULL),(8,'ce7ab6df-c946-43a6-b9dd-268db6cb4e91','7f886154-befd-48e3-9386-b9d84ac99fbd','1',2,1,NULL,NULL),(9,'f5924096-cc88-4b8e-80a4-402b0822da0a','9c8b3296-6c4a-4bcd-af25-1107f0edf468','1',1,1,NULL,NULL),(10,'f5a19c1a-65a7-4318-8764-7f7c62057193','9c8b3296-6c4a-4bcd-af25-1107f0edf468','2',1,1,NULL,NULL),(11,'73bd87d7-02bb-4770-80a2-557cd0737826','9c8b3296-6c4a-4bcd-af25-1107f0edf468','3',2,1,NULL,NULL),(12,'aac8a867-fef5-4de3-a0bb-af2ade23c690','76ae42f1-8f6a-4be8-9b1e-adde5db00db5','1',1,1,NULL,NULL),(13,'6aac6883-aedd-452d-b155-c67c76327353','76ae42f1-8f6a-4be8-9b1e-adde5db00db5','2',1,1,NULL,NULL),(14,'33e08aec-1d3b-4325-88e1-2d5e1c391c00','76ae42f1-8f6a-4be8-9b1e-adde5db00db5','3',1,1,NULL,NULL),(15,'1c7902dc-663f-4dc1-bbf5-7481533176c2','76ae42f1-8f6a-4be8-9b1e-adde5db00db5','1',2,1,NULL,NULL),(16,'1d8e017f-0a9a-4f71-9a00-950c1e67bfde','610ad228-a3a3-4b59-80c6-6d8fde6595df','1',1,1,NULL,NULL),(17,'a0411d2c-365a-41e2-a3e3-463c35aa60cb','610ad228-a3a3-4b59-80c6-6d8fde6595df','2',1,1,NULL,NULL),(18,'6cd7ccfd-9ace-480a-9d99-49843fdca54b','610ad228-a3a3-4b59-80c6-6d8fde6595df','1',2,1,NULL,NULL),(19,'0ba67fd8-4ba2-4ead-940a-ba49bf66c7e2','de6858bb-1b76-4810-baf2-475744c958f1','1',1,1,NULL,NULL),(20,'21481a0f-5d20-4ca0-b0bb-5b04b9df9f06','de6858bb-1b76-4810-baf2-475744c958f1','2',1,1,NULL,NULL),(21,'f459fd71-0d46-47db-8da5-47125e5fc990','de6858bb-1b76-4810-baf2-475744c958f1','3',1,1,NULL,NULL),(22,'e289b802-fef7-47cc-a6ad-0b4817264fc4','de6858bb-1b76-4810-baf2-475744c958f1','2',2,1,NULL,NULL),(23,'0af17670-587a-4211-af8b-0129d3ba2ae7','aef901f8-b8e9-45f8-a828-6428c2eb6aad','1',1,1,NULL,NULL),(24,'0fd04b17-5483-4150-98b7-73bf36fa1142','aef901f8-b8e9-45f8-a828-6428c2eb6aad','2',1,1,NULL,NULL),(25,'e943a38d-5adb-480c-9a14-02e381cae050','aef901f8-b8e9-45f8-a828-6428c2eb6aad','1',2,1,NULL,NULL),(26,'7ea74276-2f5e-412f-97dc-8ac9410ef309','a3a7c5e6-666f-4b10-a304-b3e95786eec1','1',1,1,NULL,NULL),(27,'ec97ca4e-cca9-494b-8d03-ac4b61f53239','a3a7c5e6-666f-4b10-a304-b3e95786eec1','2',1,1,NULL,NULL),(28,'562ffce7-1ca0-4297-9286-acc2a454b313','a3a7c5e6-666f-4b10-a304-b3e95786eec1','3',2,1,NULL,NULL),(29,'cb358224-f482-467e-b3ed-47c4b11377cb','4c8c846f-82a1-448b-9354-4b1a5827374c','1',1,1,NULL,NULL),(30,'945b566f-0fcb-4575-9612-7e146151e02b','4c8c846f-82a1-448b-9354-4b1a5827374c','2',1,1,NULL,NULL),(31,'e5050d79-7090-42be-b06e-a943b2efe874','4c8c846f-82a1-448b-9354-4b1a5827374c','4',2,1,NULL,NULL),(32,'4be48dd5-dc01-4714-be85-0cd93cdec7dc','bef66e81-f7df-4de6-a58d-b010607ef5c8','1',1,1,NULL,NULL),(33,'55dfd88f-1b84-474c-a57f-b11a8e620928','bef66e81-f7df-4de6-a58d-b010607ef5c8','2',1,1,NULL,NULL),(34,'f32ab841-bd85-4d18-97cb-9292e6596b73','bef66e81-f7df-4de6-a58d-b010607ef5c8','2',2,1,NULL,NULL),(35,'4cf56d0f-6d9f-4628-b68c-01b5bd48a304','b06613da-9fd5-4526-bcda-ecb131f14670','1',1,1,NULL,NULL),(36,'ebee1307-5a7e-4a6e-a756-cb29de0b981d','b06613da-9fd5-4526-bcda-ecb131f14670','3',2,1,NULL,NULL),(37,'f5664dac-67a8-43b0-9165-51cd8069cf95','748cf6d9-f48a-4ea8-968a-530624ecc1e9','1',1,1,NULL,NULL),(38,'25bbbf41-849a-414d-b5b5-6399d8bb5871','748cf6d9-f48a-4ea8-968a-530624ecc1e9','2',1,1,NULL,NULL),(39,'5f9ebc00-3471-4809-9177-7c721f2a41a4','748cf6d9-f48a-4ea8-968a-530624ecc1e9','1',2,1,NULL,NULL),(40,'bf42a679-a811-4702-8f4b-e9f167b6a8e8','94873167-89e6-4554-ad00-843ac9aa5355','1',1,1,NULL,NULL),(41,'1bd44aef-0a85-4f9d-b577-324fd1c96c5b','94873167-89e6-4554-ad00-843ac9aa5355','2',1,1,NULL,NULL),(42,'db365ec3-04af-48b7-be30-2228b9dff47b','94873167-89e6-4554-ad00-843ac9aa5355','4',2,1,NULL,NULL),(43,'aff91c5d-87db-4d01-bec2-3b688a56faae','ae7a2491-2853-4697-b894-c776c7f44425','1',1,1,NULL,NULL),(44,'921db827-bd16-43ff-adcb-f41685d3a19b','ae7a2491-2853-4697-b894-c776c7f44425','2',1,1,NULL,NULL),(45,'63ba6c83-b0e1-406e-bf2b-20df6e737706','ae7a2491-2853-4697-b894-c776c7f44425','1',2,1,NULL,NULL),(46,'df46e6c0-699f-49a0-82b6-1dbf1c3d5172','d26e59f5-9e09-4718-9d2e-099e35cad813','1',1,1,NULL,NULL),(47,'8188e75c-a424-4a65-b741-82d577cb563d','d26e59f5-9e09-4718-9d2e-099e35cad813','2',1,1,NULL,NULL),(48,'cf30841c-9a34-44d9-9a1b-1b493020fdee','d26e59f5-9e09-4718-9d2e-099e35cad813','2',2,1,NULL,NULL),(49,'13574e9a-cfd1-45fe-bc52-8f9b2d89cea8','2b5ccd09-58b0-4bcd-9627-9c7a84f3e410','1',1,1,NULL,NULL),(50,'db31b2cb-dac9-4112-80c8-ed25488d759e','2b5ccd09-58b0-4bcd-9627-9c7a84f3e410','2',1,1,NULL,NULL),(51,'17090f46-8036-43cc-ab07-fa6a21903cc1','2b5ccd09-58b0-4bcd-9627-9c7a84f3e410','3',2,1,NULL,NULL),(52,'883e2658-5625-4df3-8f90-03fdfbe08c5c','837b47b2-dc13-4ca3-9788-1165ebc7dc27','1',1,1,NULL,NULL),(53,'49b809fd-2be3-46f2-9a94-2c140b7e791b','837b47b2-dc13-4ca3-9788-1165ebc7dc27','2',1,1,NULL,NULL),(54,'ed881857-e0b1-4880-b03f-34958d0a2193','837b47b2-dc13-4ca3-9788-1165ebc7dc27','4',2,1,NULL,NULL),(55,'29557bff-b017-41b4-8306-12698a066f54','9e7506ef-6c66-4117-849b-9f5249cde71b','1',1,1,NULL,NULL),(56,'00c762c5-c0de-4fcb-8bc5-443dd627b308','9e7506ef-6c66-4117-849b-9f5249cde71b','2',1,1,NULL,NULL),(57,'c970db1b-c53b-4125-8a42-06dcb5d77bb5','9e7506ef-6c66-4117-849b-9f5249cde71b','5',2,1,NULL,NULL);
/*!40000 ALTER TABLE `order_recipe` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `recipe`
--

DROP TABLE IF EXISTS `recipe`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `recipe` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(32) NOT NULL,
  `code` varchar(50) NOT NULL,
  `type_code` varchar(50) DEFAULT NULL,
  `price` double NOT NULL,
  `url` varchar(128) DEFAULT NULL,
  `date` datetime DEFAULT NULL,
  `is_deleted` int(11) DEFAULT NULL,
  `uniquecode` varchar(32) DEFAULT NULL,
  `is_use` int(11) DEFAULT '1',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `recipe`
--

LOCK TABLES `recipe` WRITE;
/*!40000 ALTER TABLE `recipe` DISABLE KEYS */;
INSERT INTO `recipe` VALUES (1,'name1','1','1',1234,'https://shadow.elemecdn.com/app/element/hamburger.9cf7b091-55e9-11e9-a976-7f4d0b07eef6.png','2019-06-05 13:42:39',0,'code2',0),(2,'name2','2','2',1234,'https://shadow.elemecdn.com/app/element/hamburger.9cf7b091-55e9-11e9-a976-7f4d0b07eef6.png','2019-06-05 13:42:50',0,'code2',1),(3,'name3','3','1',1234,'https://shadow.elemecdn.com/app/element/hamburger.9cf7b091-55e9-11e9-a976-7f4d0b07eef6.png','2019-06-05 13:42:49',0,'code2',0),(4,'name4','4','3',1234,'https://shadow.elemecdn.com/app/element/hamburger.9cf7b091-55e9-11e9-a976-7f4d0b07eef6.png','2019-06-05 13:42:48',0,'code2',0),(5,'name5','5','1',1234,'https://shadow.elemecdn.com/app/element/hamburger.9cf7b091-55e9-11e9-a976-7f4d0b07eef6.png','2019-06-05 13:42:47',0,'code2',0),(6,'name6','6','4',1234,'https://shadow.elemecdn.com/app/element/hamburger.9cf7b091-55e9-11e9-a976-7f4d0b07eef6.png','2019-06-05 13:42:46',0,'code2',1),(7,'name7','7','5',1234,'https://shadow.elemecdn.com/app/element/hamburger.9cf7b091-55e9-11e9-a976-7f4d0b07eef6.png','2019-06-05 13:42:45',0,'code2',1),(8,'name8','8','2',1234,'https://shadow.elemecdn.com/app/element/hamburger.9cf7b091-55e9-11e9-a976-7f4d0b07eef6.png','2019-06-05 13:42:43',0,'code2',1),(9,'name9','9','1',1234,'https://shadow.elemecdn.com/app/element/hamburger.9cf7b091-55e9-11e9-a976-7f4d0b07eef6.png','2019-06-05 13:42:43',0,'code2',1),(10,'name10','10','2',1234,'https://shadow.elemecdn.com/app/element/hamburger.9cf7b091-55e9-11e9-a976-7f4d0b07eef6.png','2019-06-05 13:42:35',0,'code2',0),(11,'name11','11','1',1234,'https://shadow.elemecdn.com/app/element/hamburger.9cf7b091-55e9-11e9-a976-7f4d0b07eef6.png','2019-06-05 13:42:36',0,'code2',0),(12,'name12','12','2',1234,'https://shadow.elemecdn.com/app/element/hamburger.9cf7b091-55e9-11e9-a976-7f4d0b07eef6.png','2019-06-05 13:42:38',0,'code2',0),(13,'name13','13','1',1234,'https://shadow.elemecdn.com/app/element/hamburger.9cf7b091-55e9-11e9-a976-7f4d0b07eef6.png','2019-06-05 13:41:28',0,'code2',1),(14,'name14','14','1',1234,'https://shadow.elemecdn.com/app/element/hamburger.9cf7b091-55e9-11e9-a976-7f4d0b07eef6.png','2019-06-05 13:42:39',0,'code2',0),(15,'name15','15','4',1234,'https://shadow.elemecdn.com/app/element/hamburger.9cf7b091-55e9-11e9-a976-7f4d0b07eef6.png','2019-06-05 13:42:40',0,'code2',0),(16,'name16','16','1',1234,'https://shadow.elemecdn.com/app/element/hamburger.9cf7b091-55e9-11e9-a976-7f4d0b07eef6.png','2019-06-05 13:42:41',0,'code2',0),(17,'name17','17','1',1234,'https://shadow.elemecdn.com/app/element/hamburger.9cf7b091-55e9-11e9-a976-7f4d0b07eef6.png','2019-06-05 13:42:42',0,'code2',1),(18,'name18','18','3',1234,'https://shadow.elemecdn.com/app/element/hamburger.9cf7b091-55e9-11e9-a976-7f4d0b07eef6.png','2019-06-05 13:42:35',0,'code2',0),(19,'name19','19','1',1234,'https://shadow.elemecdn.com/app/element/hamburger.9cf7b091-55e9-11e9-a976-7f4d0b07eef6.png','2019-06-05 13:42:33',0,'code2',0),(20,'name20','20','4',1234,'https://shadow.elemecdn.com/app/element/hamburger.9cf7b091-55e9-11e9-a976-7f4d0b07eef6.png','2019-06-05 13:42:34',0,'code2',0),(21,'name21','21','1',1234,'https://shadow.elemecdn.com/app/element/hamburger.9cf7b091-55e9-11e9-a976-7f4d0b07eef6.png','2019-06-05 13:42:32',0,'code2',0),(22,'name22','22','1',1234,'https://shadow.elemecdn.com/app/element/hamburger.9cf7b091-55e9-11e9-a976-7f4d0b07eef6.png','2019-06-05 13:42:30',0,'code2',1),(23,'name23','23','5',1234,'https://shadow.elemecdn.com/app/element/hamburger.9cf7b091-55e9-11e9-a976-7f4d0b07eef6.png','2019-06-05 13:41:31',0,'code2',1),(24,'name24','24','3',1234,'https://shadow.elemecdn.com/app/element/hamburger.9cf7b091-55e9-11e9-a976-7f4d0b07eef6.png','2019-06-05 13:41:30',0,'code2',1),(25,'name25','25','1',1234,'https://shadow.elemecdn.com/app/element/hamburger.9cf7b091-55e9-11e9-a976-7f4d0b07eef6.png','2019-06-05 13:41:29',0,'code2',1),(26,'qwer1','fcf4cc16-607e-45a4-9734-6319dd547db9','62b8843b-acc7-4b95-ae34-3f2bd0453559',3321,'/file/20190721/06d0f04d-80e0-42b0-b31c-4ca3ff7dba3b.png','2019-07-21 16:39:50',1,'code2',1),(27,'name43g','343370dd-3549-451b-bc9e-ff99683e74f0','2feb0e89-9187-4afe-8f70-216792de60de',223,'/file/20190721/f2d5a53a-3f11-4f8a-bb52-80ef1dd7d63d.png','2019-07-21 16:50:30',1,'code2',1),(28,'name342','01f043a5-296e-4150-866d-d0e45a56acd5','62b8843b-acc7-4b95-ae34-3f2bd0453559',123413,'/file/20190721/2bf5f474-dd10-41ce-8aab-8a3cf95984b3.png','2019-07-21 22:41:09',0,'code2',1);
/*!40000 ALTER TABLE `recipe` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `recipe_type`
--

DROP TABLE IF EXISTS `recipe_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `recipe_type` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `code` varchar(50) DEFAULT NULL,
  `name` varchar(32) DEFAULT NULL,
  `is_deleted` int(11) DEFAULT NULL,
  `date` datetime DEFAULT NULL,
  `uniquecode` varchar(32) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `recipe_type`
--

LOCK TABLES `recipe_type` WRITE;
/*!40000 ALTER TABLE `recipe_type` DISABLE KEYS */;
INSERT INTO `recipe_type` VALUES (1,'1','类型1',0,'2019-06-05 13:39:29','code2'),(2,'2','类型2',0,'2019-06-05 13:39:34','code2'),(3,'3','类型3',0,'2019-06-05 13:39:35','code2'),(4,'4','类型4',0,'2019-06-05 13:39:36','code2'),(5,'5','类型5',0,'2019-06-05 13:39:37','code2'),(6,'b60d9c86-114b-46d5-a88e-c52b6267a0fd','l面食',1,'2019-06-23 20:56:23','code2'),(7,'5484fece-acb2-483e-b8ec-98bfbba9891a','肉食3',1,'2019-06-23 20:57:13','code2'),(8,'62b8843b-acc7-4b95-ae34-3f2bd0453559','面食',0,'2019-06-23 20:59:28','code2'),(9,'2feb0e89-9187-4afe-8f70-216792de60de','肉食',0,'2019-06-23 20:59:41','code2');
/*!40000 ALTER TABLE `recipe_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `upload_file`
--

DROP TABLE IF EXISTS `upload_file`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `upload_file` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `code` varchar(50) DEFAULT NULL,
  `name` varchar(100) DEFAULT NULL,
  `data_name` varchar(50) DEFAULT NULL,
  `date` datetime DEFAULT NULL,
  `uniquecode` varchar(50) DEFAULT NULL,
  `file_path` varchar(100) DEFAULT NULL,
  `file_hash` varchar(100) DEFAULT NULL,
  `type` varchar(20) DEFAULT NULL,
  `is_deleted` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `upload_file`
--

LOCK TABLES `upload_file` WRITE;
/*!40000 ALTER TABLE `upload_file` DISABLE KEYS */;
INSERT INTO `upload_file` VALUES (1,'86029f18-ddee-47ca-b4e0-ce3fb92d7b8f','深度截图_选择区域_20190519140516.png','1c02b101-3047-447b-998e-f1506ab0af89.png','2019-07-21 12:23:59','code2','file/20190721/1c02b101-3047-447b-998e-f1506ab0af89.png','adsfa','image/png',0),(2,'e9746a0b-17f2-4df8-8315-1f846b2d791f','深度截图_选择区域_20190519140516.png','e55db688-e049-4738-a155-583d3cc04943.png','2019-07-21 12:26:28','code2','file/20190721/e55db688-e049-4738-a155-583d3cc04943.png','adsfa','image/png',0),(3,'3e1445b0-97b1-4753-9056-766d5b0dc165','深度截图_选择区域_20190519140516.png','8f95cc82-8b08-4a53-b192-bc2fa59f2933.png','2019-07-21 12:29:41','code2','file/20190721/8f95cc82-8b08-4a53-b192-bc2fa59f2933.png','adsfa','image/png',0),(4,'1013f51b-fcc0-494a-a933-9f7b399b78be','深度截图_选择区域_20190519140516.png','221940ce-467c-4d89-83f9-2f81725cc410.png','2019-07-21 12:29:49','code2','file/20190721/221940ce-467c-4d89-83f9-2f81725cc410.png','adsfa','image/png',0),(5,'c909a92a-d421-4b4e-8e2b-b7c2bd32a5e8','深度截图_选择区域_20190519140516.png','b9526b94-9334-40a0-a7f5-a92f5a98dec1.png','2019-07-21 12:31:19','code2','file/20190721/b9526b94-9334-40a0-a7f5-a92f5a98dec1.png','adsfa','image/png',0),(6,'0cbafa30-c1c2-477b-876e-252ec8d3125d','深度截图_选择区域_20190519140516.png','806f11c2-eff6-4c34-b074-848e6d071955.png','2019-07-21 12:52:25','code2','file/20190721/806f11c2-eff6-4c34-b074-848e6d071955.png','adsfa','image/png',0),(7,'bc3c54b4-c0f0-445a-9570-a892e7b3fe27','深度截图_选择区域_20190519140516.png','0a9a8def-16d0-48b8-b21c-3e92b98759cc.png','2019-07-21 12:53:05','code2','file/20190721/0a9a8def-16d0-48b8-b21c-3e92b98759cc.png','adsfa','image/png',0),(8,'555fe28a-b818-41a0-876f-40ec831127ca','深度截图_选择区域_20190519140516.png','3355380c-c139-42d5-90c7-f289c7874223.png','2019-07-21 12:58:27','code2','file/20190721/3355380c-c139-42d5-90c7-f289c7874223.png','adsfa','image/png',0),(9,'e747dc46-e3ac-40b5-a7ec-838a8758da71','深度截图_选择区域_20190519140516.png','24c05e06-9484-4200-954a-1dbc4a7c5281.png','2019-07-21 12:58:51','code2','file/20190721/24c05e06-9484-4200-954a-1dbc4a7c5281.png','adsfa','image/png',0),(10,'2c38fb7b-4659-4996-8584-92fe55c06cd7','深度截图_选择区域_20190519140516.png','353b58fa-6008-49cb-b3ba-4ebb7146de77.png','2019-07-21 13:53:36','code2','file/20190721/353b58fa-6008-49cb-b3ba-4ebb7146de77.png','adsfa','image/png',0),(11,'29969a3d-3f7d-49e6-acf2-5595a17e18d3','深度截图_选择区域_20190519140516.png','a35a30f6-6a65-480d-8be3-35a3472a3aa8.png','2019-07-21 13:56:25','code2','file/20190721/a35a30f6-6a65-480d-8be3-35a3472a3aa8.png','adsfa','image/png',0),(12,'507cd42f-2a61-4ab2-8f50-0a378c892582','深度截图_选择区域_20190519140516.png','8a555214-25f0-45c2-abb3-8b2ece464572.png','2019-07-21 15:28:39','code2','file/20190721/8a555214-25f0-45c2-abb3-8b2ece464572.png','adsfa','image/png',0),(13,'4b2fa1e4-23db-4676-8365-ca98cd9ed515','深度截图_选择区域_20190519140516.png','e0b83bdb-0e8a-436f-8239-b2ecfc591c2f.png','2019-07-21 15:28:50','code2','file/20190721/e0b83bdb-0e8a-436f-8239-b2ecfc591c2f.png','adsfa','image/png',0),(14,'c8f0769a-3d30-436b-9135-37255a456613','深度截图_选择区域_20190519140516.png','c452900c-43f6-46ec-9f96-1f6246409b08.png','2019-07-21 15:29:50','code2','file/20190721/c452900c-43f6-46ec-9f96-1f6246409b08.png','adsfa','image/png',0),(15,'b65b01ca-6573-471c-ab41-4f9a65433187','深度截图_选择区域_20190519140516.png','d5a470b1-de62-4532-96cb-a268b3fe91db.png','2019-07-21 15:31:42','code2','file/20190721/d5a470b1-de62-4532-96cb-a268b3fe91db.png','adsfa','image/png',0),(16,'4670c74e-e57c-4275-9119-e8adf92e54eb','深度截图_选择区域_20190519140516.png','b360b819-0bf9-49d6-ac48-b94ec4407a67.png','2019-07-21 16:17:17','code2','file/20190721/b360b819-0bf9-49d6-ac48-b94ec4407a67.png','adsfa','image/png',0),(17,'2ccafa83-4abd-41c6-88d6-f51233e4fb83','深度截图_选择区域_20190519140516.png','0c20037a-597b-4c04-b66b-12c95c763046.png','2019-07-21 16:39:35','code2','file/20190721/0c20037a-597b-4c04-b66b-12c95c763046.png','adsfa','image/png',0),(18,'71683938-3ed2-4b2a-b329-2a7a139899d7','hamburger.9cf7b091-55e9-11e9-a976-7f4d0b07eef6.png','f2d5a53a-3f11-4f8a-bb52-80ef1dd7d63d.png','2019-07-21 16:50:26','code2','/file/20190721/f2d5a53a-3f11-4f8a-bb52-80ef1dd7d63d.png','adsfa','image/png',0),(19,'df4707f8-b6b1-4d50-80d9-763791440256','hamburger.9cf7b091-55e9-11e9-a976-7f4d0b07eef6.png','2bf5f474-dd10-41ce-8aab-8a3cf95984b3.png','2019-07-21 22:40:55','code2','/file/20190721/2bf5f474-dd10-41ce-8aab-8a3cf95984b3.png','adsfa','image/png',0),(20,'2d15115c-4ca4-49f4-babf-3ff1a056f21b','hamburger.9cf7b091-55e9-11e9-a976-7f4d0b07eef6.png','06d0f04d-80e0-42b0-b31c-4ca3ff7dba3b.png','2019-07-21 23:07:33','code2','/file/20190721/06d0f04d-80e0-42b0-b31c-4ca3ff7dba3b.png','adsfa','image/png',0);
/*!40000 ALTER TABLE `upload_file` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-08-12 19:31:25
