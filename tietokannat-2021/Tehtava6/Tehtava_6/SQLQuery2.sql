﻿USE asiakaspalvelu;
SET IDENTITY_INSERT tilausrivi ON;
INSERT INTO tilausrivi (tilausrivinro, tilausnro, tuotenro, maara)
VALUES (4,1,3,1), 
(5,1,3,2), 
(6,1,5,1), 
(7,1,6,2), 
(8,2,2,2), 
(9,2,7,1), 
(10,3,5,2), 
(11,3,1,5), 
(12,3,6,5), 
(13,3,7,3), 
(14,4,4,1), 
(15,4,6,2), 
(16,4,7,1), 
(17,5,3,2), 
(18,5,5,1), 
(19,5,6,1), 
(20,6,1,1), 
(21,6,7,1), 
(22,7,3,2), 
(23,7,6,5), 
(24,7,7,8), 
(25,7,5,2), 
(26,8,4,1), 
(27,8,7,3), 
(28,9,2,3), 
(29,9,6,3), 
(30,10,1,2), 
(31,11,3,2), 
(32,12,4,1), 
(33,13,7,2), 
(34,13,6,2), 
(35,14,3,2), 
(36,14,5,1), 
(37,14,7,2), 
(38,15,2,2), 
(39,15,7,2), 
(40,16,1,1), 
(41,17,3,3), 
(42,17,5,1), 
(43,17,7,3);
SET IDENTITY_INSERT tilausrivi OFF;