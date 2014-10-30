CREATE TABLE `check_headers` (
  `time_check` bigint(20) unsigned NOT NULL,
  `pos_id` tinyint(1) unsigned NOT NULL,
  `check_id` smallint(5) unsigned NOT NULL,
  `document_id` tinyint(1) unsigned NOT NULL,
  `check_num` tinyint(1) unsigned NOT NULL,
  `discard_code` int(10) unsigned NOT NULL DEFAULT '0',
  `sale` decimal(8,2) NOT NULL DEFAULT '0.00',
  `reject` decimal(8,2) NOT NULL DEFAULT '0.00',
  `discount` decimal(8,2) NOT NULL DEFAULT '0.00',
  `raise` decimal(8,2) NOT NULL DEFAULT '0.00',
  `cash` decimal(8,2) NOT NULL DEFAULT '0.00',
  `check` decimal(8,2) NOT NULL DEFAULT '0.00',
  `credit` decimal(8,2) NOT NULL DEFAULT '0.00',
  `other` decimal(8,2) NOT NULL DEFAULT '0.00',
  `total` decimal(8,2) NOT NULL DEFAULT '0.00',
  `refund` decimal(8,2) NOT NULL DEFAULT '0.00',
  `in` decimal(8,2) NOT NULL DEFAULT '0.00',
  `out` decimal(8,2) NOT NULL DEFAULT '0.00',
  `cashsum` decimal(8,2) NOT NULL DEFAULT '0.00',
  UNIQUE KEY `cash_check` (`time_check`,`pos_id`,`check_id`,`document_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8
/*!50100 PARTITION BY RANGE (time_check)
(PARTITION pMINVALUE VALUES LESS THAN (1356991200) ENGINE = InnoDB,
 PARTITION p2013_01 VALUES LESS THAN (1359669600) ENGINE = InnoDB,
 PARTITION p2013_02 VALUES LESS THAN (1362088800) ENGINE = InnoDB,
 PARTITION p2013_03 VALUES LESS THAN (1364767200) ENGINE = InnoDB,
 PARTITION p2013_04 VALUES LESS THAN (1367359200) ENGINE = InnoDB,
 PARTITION p2013_05 VALUES LESS THAN (1370037600) ENGINE = InnoDB,
 PARTITION p2013_06 VALUES LESS THAN (1372629600) ENGINE = InnoDB,
 PARTITION p2013_07 VALUES LESS THAN (1375308000) ENGINE = InnoDB,
 PARTITION p2013_08 VALUES LESS THAN (1377986400) ENGINE = InnoDB,
 PARTITION p2013_09 VALUES LESS THAN (1380578400) ENGINE = InnoDB,
 PARTITION p2013_10 VALUES LESS THAN (1383256800) ENGINE = InnoDB,
 PARTITION p2013_11 VALUES LESS THAN (1385848800) ENGINE = InnoDB,
 PARTITION p2013_12 VALUES LESS THAN (1388527200) ENGINE = InnoDB,
 PARTITION p2014_01 VALUES LESS THAN (1391205600) ENGINE = InnoDB,
 PARTITION p2014_02 VALUES LESS THAN (1393624800) ENGINE = InnoDB,
 PARTITION p2014_03 VALUES LESS THAN (1396303200) ENGINE = InnoDB,
 PARTITION p2014_04 VALUES LESS THAN (1398895200) ENGINE = InnoDB,
 PARTITION p2014_05 VALUES LESS THAN (1401573600) ENGINE = InnoDB,
 PARTITION p2014_06 VALUES LESS THAN (1404165600) ENGINE = InnoDB,
 PARTITION p2014_07 VALUES LESS THAN (1406844000) ENGINE = InnoDB,
 PARTITION p2014_08 VALUES LESS THAN (1409522400) ENGINE = InnoDB,
 PARTITION p2014_09 VALUES LESS THAN (1412114400) ENGINE = InnoDB,
 PARTITION p2014_10 VALUES LESS THAN (1414792800) ENGINE = InnoDB,
 PARTITION p2014_11 VALUES LESS THAN (1417384800) ENGINE = InnoDB,
 PARTITION p2014_12 VALUES LESS THAN (1420063200) ENGINE = InnoDB,
 PARTITION p2015_01 VALUES LESS THAN (1422741600) ENGINE = InnoDB,
 PARTITION p2015_02 VALUES LESS THAN (1425160800) ENGINE = InnoDB,
 PARTITION p2015_03 VALUES LESS THAN (1427839200) ENGINE = InnoDB,
 PARTITION p2015_04 VALUES LESS THAN (1430431200) ENGINE = InnoDB,
 PARTITION p2015_05 VALUES LESS THAN (1433109600) ENGINE = InnoDB,
 PARTITION p2015_06 VALUES LESS THAN (1435701600) ENGINE = InnoDB,
 PARTITION p2015_07 VALUES LESS THAN (1438380000) ENGINE = InnoDB,
 PARTITION p2015_08 VALUES LESS THAN (1441058400) ENGINE = InnoDB,
 PARTITION p2015_09 VALUES LESS THAN (1443650400) ENGINE = InnoDB,
 PARTITION p2015_10 VALUES LESS THAN (1446328800) ENGINE = InnoDB,
 PARTITION p2015_11 VALUES LESS THAN (1448920800) ENGINE = InnoDB,
 PARTITION p2015_12 VALUES LESS THAN (1451599200) ENGINE = InnoDB,
 PARTITION p2016_01 VALUES LESS THAN (1454277600) ENGINE = InnoDB,
 PARTITION p2016_02 VALUES LESS THAN (1456783200) ENGINE = InnoDB,
 PARTITION p2016_03 VALUES LESS THAN (1459461600) ENGINE = InnoDB,
 PARTITION p2016_04 VALUES LESS THAN (1462053600) ENGINE = InnoDB,
 PARTITION p2016_05 VALUES LESS THAN (1464732000) ENGINE = InnoDB,
 PARTITION p2016_06 VALUES LESS THAN (1467324000) ENGINE = InnoDB,
 PARTITION p2016_07 VALUES LESS THAN (1470002400) ENGINE = InnoDB,
 PARTITION p2016_08 VALUES LESS THAN (1472680800) ENGINE = InnoDB,
 PARTITION p2016_09 VALUES LESS THAN (1475272800) ENGINE = InnoDB,
 PARTITION p2016_10 VALUES LESS THAN (1477951200) ENGINE = InnoDB,
 PARTITION p2016_11 VALUES LESS THAN (1480543200) ENGINE = InnoDB,
 PARTITION p2016_12 VALUES LESS THAN (1483221600) ENGINE = InnoDB,
 PARTITION p2017_01 VALUES LESS THAN (1485900000) ENGINE = InnoDB,
 PARTITION p2017_02 VALUES LESS THAN (1488319200) ENGINE = InnoDB,
 PARTITION p2017_03 VALUES LESS THAN (1490997600) ENGINE = InnoDB,
 PARTITION p2017_04 VALUES LESS THAN (1493589600) ENGINE = InnoDB,
 PARTITION p2017_05 VALUES LESS THAN (1496268000) ENGINE = InnoDB,
 PARTITION p2017_06 VALUES LESS THAN (1498860000) ENGINE = InnoDB,
 PARTITION p2017_07 VALUES LESS THAN (1501538400) ENGINE = InnoDB,
 PARTITION p2017_08 VALUES LESS THAN (1504216800) ENGINE = InnoDB,
 PARTITION p2017_09 VALUES LESS THAN (1506808800) ENGINE = InnoDB,
 PARTITION p2017_10 VALUES LESS THAN (1509487200) ENGINE = InnoDB,
 PARTITION p2017_11 VALUES LESS THAN (1512079200) ENGINE = InnoDB,
 PARTITION p2017_12 VALUES LESS THAN (1514757600) ENGINE = InnoDB,
 PARTITION p2018_01 VALUES LESS THAN (1517436000) ENGINE = InnoDB,
 PARTITION p2018_02 VALUES LESS THAN (1519855200) ENGINE = InnoDB,
 PARTITION p2018_03 VALUES LESS THAN (1522533600) ENGINE = InnoDB,
 PARTITION p2018_04 VALUES LESS THAN (1525125600) ENGINE = InnoDB,
 PARTITION p2018_05 VALUES LESS THAN (1527804000) ENGINE = InnoDB,
 PARTITION p2018_06 VALUES LESS THAN (1530396000) ENGINE = InnoDB,
 PARTITION p2018_07 VALUES LESS THAN (1533074400) ENGINE = InnoDB,
 PARTITION p2018_08 VALUES LESS THAN (1535752800) ENGINE = InnoDB,
 PARTITION p2018_09 VALUES LESS THAN (1538344800) ENGINE = InnoDB,
 PARTITION p2018_10 VALUES LESS THAN (1541023200) ENGINE = InnoDB,
 PARTITION p2018_11 VALUES LESS THAN (1543615200) ENGINE = InnoDB,
 PARTITION p2018_12 VALUES LESS THAN (1546293600) ENGINE = InnoDB,
 PARTITION p2019_01 VALUES LESS THAN (1548972000) ENGINE = InnoDB,
 PARTITION p2019_02 VALUES LESS THAN (1551391200) ENGINE = InnoDB,
 PARTITION p2019_03 VALUES LESS THAN (1554069600) ENGINE = InnoDB,
 PARTITION p2019_04 VALUES LESS THAN (1556661600) ENGINE = InnoDB,
 PARTITION p2019_05 VALUES LESS THAN (1559340000) ENGINE = InnoDB,
 PARTITION p2019_06 VALUES LESS THAN (1561932000) ENGINE = InnoDB,
 PARTITION p2019_07 VALUES LESS THAN (1564610400) ENGINE = InnoDB,
 PARTITION p2019_08 VALUES LESS THAN (1567288800) ENGINE = InnoDB,
 PARTITION p2019_09 VALUES LESS THAN (1569880800) ENGINE = InnoDB,
 PARTITION p2019_10 VALUES LESS THAN (1572559200) ENGINE = InnoDB,
 PARTITION p2019_11 VALUES LESS THAN (1575151200) ENGINE = InnoDB,
 PARTITION p2019_12 VALUES LESS THAN (1577829600) ENGINE = InnoDB,
 PARTITION p2020_01 VALUES LESS THAN (1580508000) ENGINE = InnoDB,
 PARTITION p2020_02 VALUES LESS THAN (1583013600) ENGINE = InnoDB,
 PARTITION p2020_03 VALUES LESS THAN (1585692000) ENGINE = InnoDB,
 PARTITION p2020_04 VALUES LESS THAN (1588284000) ENGINE = InnoDB,
 PARTITION p2020_05 VALUES LESS THAN (1590962400) ENGINE = InnoDB,
 PARTITION p2020_06 VALUES LESS THAN (1593554400) ENGINE = InnoDB,
 PARTITION p2020_07 VALUES LESS THAN (1596232800) ENGINE = InnoDB,
 PARTITION p2020_08 VALUES LESS THAN (1598911200) ENGINE = InnoDB,
 PARTITION p2020_09 VALUES LESS THAN (1601503200) ENGINE = InnoDB,
 PARTITION p2020_10 VALUES LESS THAN (1604181600) ENGINE = InnoDB,
 PARTITION p2020_11 VALUES LESS THAN (1606773600) ENGINE = InnoDB,
 PARTITION p2020_12 VALUES LESS THAN (1609452000) ENGINE = InnoDB,
 PARTITION p2021_01 VALUES LESS THAN (1612130400) ENGINE = InnoDB,
 PARTITION p2021_02 VALUES LESS THAN (1614549600) ENGINE = InnoDB,
 PARTITION p2021_03 VALUES LESS THAN (1617228000) ENGINE = InnoDB,
 PARTITION p2021_04 VALUES LESS THAN (1619820000) ENGINE = InnoDB,
 PARTITION p2021_05 VALUES LESS THAN (1622498400) ENGINE = InnoDB,
 PARTITION p2021_06 VALUES LESS THAN (1625090400) ENGINE = InnoDB,
 PARTITION p2021_07 VALUES LESS THAN (1627768800) ENGINE = InnoDB,
 PARTITION p2021_08 VALUES LESS THAN (1630447200) ENGINE = InnoDB,
 PARTITION p2021_09 VALUES LESS THAN (1633039200) ENGINE = InnoDB,
 PARTITION p2021_10 VALUES LESS THAN (1635717600) ENGINE = InnoDB,
 PARTITION p2021_11 VALUES LESS THAN (1638309600) ENGINE = InnoDB,
 PARTITION p2021_12 VALUES LESS THAN (1640988000) ENGINE = InnoDB,
 PARTITION p2022_01 VALUES LESS THAN (1643666400) ENGINE = InnoDB,
 PARTITION p2022_02 VALUES LESS THAN (1646085600) ENGINE = InnoDB,
 PARTITION p2022_03 VALUES LESS THAN (1648764000) ENGINE = InnoDB,
 PARTITION p2022_04 VALUES LESS THAN (1651356000) ENGINE = InnoDB,
 PARTITION p2022_05 VALUES LESS THAN (1654034400) ENGINE = InnoDB,
 PARTITION p2022_06 VALUES LESS THAN (1656626400) ENGINE = InnoDB,
 PARTITION p2022_07 VALUES LESS THAN (1659304800) ENGINE = InnoDB,
 PARTITION p2022_08 VALUES LESS THAN (1661983200) ENGINE = InnoDB,
 PARTITION p2022_09 VALUES LESS THAN (1664575200) ENGINE = InnoDB,
 PARTITION p2022_10 VALUES LESS THAN (1667253600) ENGINE = InnoDB,
 PARTITION p2022_11 VALUES LESS THAN (1669845600) ENGINE = InnoDB,
 PARTITION p2022_12 VALUES LESS THAN (1672524000) ENGINE = InnoDB,
 PARTITION p2023_01 VALUES LESS THAN (1675202400) ENGINE = InnoDB,
 PARTITION p2023_02 VALUES LESS THAN (1677621600) ENGINE = InnoDB,
 PARTITION p2023_03 VALUES LESS THAN (1680300000) ENGINE = InnoDB,
 PARTITION p2023_04 VALUES LESS THAN (1682892000) ENGINE = InnoDB,
 PARTITION p2023_05 VALUES LESS THAN (1685570400) ENGINE = InnoDB,
 PARTITION p2023_06 VALUES LESS THAN (1688162400) ENGINE = InnoDB,
 PARTITION p2023_07 VALUES LESS THAN (1690840800) ENGINE = InnoDB,
 PARTITION p2023_08 VALUES LESS THAN (1693519200) ENGINE = InnoDB,
 PARTITION p2023_09 VALUES LESS THAN (1696111200) ENGINE = InnoDB,
 PARTITION p2023_10 VALUES LESS THAN (1698789600) ENGINE = InnoDB,
 PARTITION p2023_11 VALUES LESS THAN (1701381600) ENGINE = InnoDB,
 PARTITION p2023_12 VALUES LESS THAN (1704060000) ENGINE = InnoDB,
 PARTITION p2024_01 VALUES LESS THAN (1706738400) ENGINE = InnoDB,
 PARTITION p2024_02 VALUES LESS THAN (1709244000) ENGINE = InnoDB,
 PARTITION p2024_03 VALUES LESS THAN (1711922400) ENGINE = InnoDB,
 PARTITION p2024_04 VALUES LESS THAN (1714514400) ENGINE = InnoDB,
 PARTITION p2024_05 VALUES LESS THAN (1717192800) ENGINE = InnoDB,
 PARTITION p2024_06 VALUES LESS THAN (1719784800) ENGINE = InnoDB,
 PARTITION p2024_07 VALUES LESS THAN (1722463200) ENGINE = InnoDB,
 PARTITION p2024_08 VALUES LESS THAN (1725141600) ENGINE = InnoDB,
 PARTITION p2024_09 VALUES LESS THAN (1727733600) ENGINE = InnoDB,
 PARTITION p2024_10 VALUES LESS THAN (1730412000) ENGINE = InnoDB,
 PARTITION p2024_11 VALUES LESS THAN (1733004000) ENGINE = InnoDB,
 PARTITION pMAXVALUE VALUES LESS THAN MAXVALUE ENGINE = InnoDB) */;
CREATE TABLE `directory_account` (
  `account_id` int(64) NOT NULL AUTO_INCREMENT,
  `account_bonus` double NOT NULL DEFAULT '0',
  `account_change` double NOT NULL DEFAULT '0',
  `account_temp` double NOT NULL DEFAULT '0',
  `pin_code` varchar(45) NOT NULL DEFAULT '0000',
  `category` smallint(5) unsigned NOT NULL DEFAULT '0',
  `fixperc` double NOT NULL DEFAULT '0',
  `is_employee` tinyint(1) unsigned NOT NULL DEFAULT '0',
  `is_subscribe` tinyint(1) unsigned NOT NULL DEFAULT '1',
  `is_active` tinyint(5) unsigned NOT NULL DEFAULT '1',
  `is_bonus` tinyint(1) NOT NULL DEFAULT '0',
  `date_activate` int(64) DEFAULT NULL,
  `date_deactivate` int(64) DEFAULT NULL,
  `description` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`account_id`)
) ENGINE=InnoDB AUTO_INCREMENT=1000505 DEFAULT CHARSET=utf8;
CREATE TABLE `directory_account_cards` (
  `account_id` int(64) NOT NULL,
  `card_id` decimal(15,0) NOT NULL,
  `use_bonus` tinyint(1) unsigned NOT NULL DEFAULT '1',
  `is_active` tinyint(5) unsigned NOT NULL DEFAULT '1',
  `date_activate` int(64) DEFAULT NULL,
  `date_deactivate` int(64) DEFAULT NULL,
  UNIQUE KEY `card_id_UNIQUE` (`card_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `directory_account_details` (
  `account_id` int(64) unsigned NOT NULL,
  `first_name` varchar(45) DEFAULT NULL,
  `middle_name` varchar(45) DEFAULT NULL,
  `last_name` varchar(45) DEFAULT NULL,
  `tel` varchar(45) DEFAULT NULL,
  `tel2` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `maritalstatus` varchar(45) DEFAULT NULL,
  `index` varchar(45) DEFAULT NULL,
  `city` varchar(45) DEFAULT NULL,
  `street` varchar(45) DEFAULT NULL,
  `bld` varchar(45) DEFAULT NULL,
  `apt` varchar(45) DEFAULT NULL,
  `birthday` varchar(45) DEFAULT NULL,
  `birthday1` varchar(45) DEFAULT NULL,
  `birthday2` varchar(45) DEFAULT NULL,
  `birthday3` varchar(45) DEFAULT NULL,
  `birthday4` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`account_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `directory_account_notice` (
  `card_id` int(64) NOT NULL,
  `notice` tinyint(1) NOT NULL DEFAULT '0',
  `notice_reject` tinyint(1) NOT NULL DEFAULT '0',
  `POSID` varchar(45) DEFAULT NULL,
  `operator_name` varchar(45) DEFAULT NULL,
  `datetime` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`card_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `directory_goods` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `code` int(10) unsigned NOT NULL DEFAULT '0',
  `name` varchar(50) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `code_name` (`code`,`name`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=89861 DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;
CREATE TABLE `directory_log` (
  `module_id` int(11) NOT NULL DEFAULT '0',
  `some_id` int(64) NOT NULL DEFAULT '0' COMMENT '����� ID ��� ������ �� ��������� (��� ����� �������� � �������������� � ������� ��������� ��� ����� �������������), �� ��������� 0 ',
  `date` int(64) NOT NULL,
  `operation_id` int(11) NOT NULL,
  `user_id` int(11) DEFAULT NULL,
  `description` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `directory_log_modules` (
  `id` int(11) NOT NULL,
  `name` varchar(45) NOT NULL,
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `directory_log_operations` (
  `operation_id` int(11) NOT NULL,
  `description` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`operation_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `directory_operator` (
  `id` smallint(5) unsigned NOT NULL,
  `pos_id` tinyint(1) unsigned NOT NULL,
  `operator_id` smallint(5) unsigned NOT NULL,
  `name` varchar(50) NOT NULL,
  `pos_rightmask` int(11) NOT NULL,
  `rightmask` int(11) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;
CREATE TABLE `directory_pos` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `fiscal_number` varchar(50) NOT NULL,
  `object_id` int(10) NOT NULL,
  `description` varchar(500) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=52 DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;
CREATE TABLE `directory_pos_groups` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
CREATE TABLE `directory_pos_objects` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) DEFAULT NULL,
  `group_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;
CREATE TABLE `protokol_actions` (
  `time_check` bigint(20) unsigned NOT NULL,
  `pos_id` tinyint(1) unsigned NOT NULL,
  `check_id` smallint(5) unsigned NOT NULL,
  `document_id` tinyint(1) unsigned NOT NULL,
  `time_operation` bigint(20) unsigned NOT NULL,
  `operation_id` tinyint(1) unsigned NOT NULL,
  `goods_id` int(10) unsigned NOT NULL DEFAULT '0',
  `discard_code` int(10) unsigned NOT NULL DEFAULT '0',
  `quantity` decimal(10,3) unsigned NOT NULL DEFAULT '0.000',
  `is_refund` tinyint(1) unsigned NOT NULL DEFAULT '0',
  `operation_sum` decimal(12,2) NOT NULL DEFAULT '0.00',
  `operator_id` smallint(5) unsigned NOT NULL DEFAULT '0',
  KEY `cash_check` (`time_check`,`pos_id`,`check_id`,`document_id`),
  KEY `time_pos_goods` (`time_check`,`pos_id`,`goods_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8
/*!50100 PARTITION BY RANGE (time_check)
(PARTITION pMINVALUE VALUES LESS THAN (1356991200) ENGINE = InnoDB,
 PARTITION p2013_01 VALUES LESS THAN (1359669600) ENGINE = InnoDB,
 PARTITION p2013_02 VALUES LESS THAN (1362088800) ENGINE = InnoDB,
 PARTITION p2013_03 VALUES LESS THAN (1364767200) ENGINE = InnoDB,
 PARTITION p2013_04 VALUES LESS THAN (1367359200) ENGINE = InnoDB,
 PARTITION p2013_05 VALUES LESS THAN (1370037600) ENGINE = InnoDB,
 PARTITION p2013_06 VALUES LESS THAN (1372629600) ENGINE = InnoDB,
 PARTITION p2013_07 VALUES LESS THAN (1375308000) ENGINE = InnoDB,
 PARTITION p2013_08 VALUES LESS THAN (1377986400) ENGINE = InnoDB,
 PARTITION p2013_09 VALUES LESS THAN (1380578400) ENGINE = InnoDB,
 PARTITION p2013_10 VALUES LESS THAN (1383256800) ENGINE = InnoDB,
 PARTITION p2013_11 VALUES LESS THAN (1385848800) ENGINE = InnoDB,
 PARTITION p2013_12 VALUES LESS THAN (1388527200) ENGINE = InnoDB,
 PARTITION p2014_01 VALUES LESS THAN (1391205600) ENGINE = InnoDB,
 PARTITION p2014_02 VALUES LESS THAN (1393624800) ENGINE = InnoDB,
 PARTITION p2014_03 VALUES LESS THAN (1396303200) ENGINE = InnoDB,
 PARTITION p2014_04 VALUES LESS THAN (1398895200) ENGINE = InnoDB,
 PARTITION p2014_05 VALUES LESS THAN (1401573600) ENGINE = InnoDB,
 PARTITION p2014_06 VALUES LESS THAN (1404165600) ENGINE = InnoDB,
 PARTITION p2014_07 VALUES LESS THAN (1406844000) ENGINE = InnoDB,
 PARTITION p2014_08 VALUES LESS THAN (1409522400) ENGINE = InnoDB,
 PARTITION p2014_09 VALUES LESS THAN (1412114400) ENGINE = InnoDB,
 PARTITION p2014_10 VALUES LESS THAN (1414792800) ENGINE = InnoDB,
 PARTITION p2014_11 VALUES LESS THAN (1417384800) ENGINE = InnoDB,
 PARTITION p2014_12 VALUES LESS THAN (1420063200) ENGINE = InnoDB,
 PARTITION p2015_01 VALUES LESS THAN (1422741600) ENGINE = InnoDB,
 PARTITION p2015_02 VALUES LESS THAN (1425160800) ENGINE = InnoDB,
 PARTITION p2015_03 VALUES LESS THAN (1427839200) ENGINE = InnoDB,
 PARTITION p2015_04 VALUES LESS THAN (1430431200) ENGINE = InnoDB,
 PARTITION p2015_05 VALUES LESS THAN (1433109600) ENGINE = InnoDB,
 PARTITION p2015_06 VALUES LESS THAN (1435701600) ENGINE = InnoDB,
 PARTITION p2015_07 VALUES LESS THAN (1438380000) ENGINE = InnoDB,
 PARTITION p2015_08 VALUES LESS THAN (1441058400) ENGINE = InnoDB,
 PARTITION p2015_09 VALUES LESS THAN (1443650400) ENGINE = InnoDB,
 PARTITION p2015_10 VALUES LESS THAN (1446328800) ENGINE = InnoDB,
 PARTITION p2015_11 VALUES LESS THAN (1448920800) ENGINE = InnoDB,
 PARTITION p2015_12 VALUES LESS THAN (1451599200) ENGINE = InnoDB,
 PARTITION p2016_01 VALUES LESS THAN (1454277600) ENGINE = InnoDB,
 PARTITION p2016_02 VALUES LESS THAN (1456783200) ENGINE = InnoDB,
 PARTITION p2016_03 VALUES LESS THAN (1459461600) ENGINE = InnoDB,
 PARTITION p2016_04 VALUES LESS THAN (1462053600) ENGINE = InnoDB,
 PARTITION p2016_05 VALUES LESS THAN (1464732000) ENGINE = InnoDB,
 PARTITION p2016_06 VALUES LESS THAN (1467324000) ENGINE = InnoDB,
 PARTITION p2016_07 VALUES LESS THAN (1470002400) ENGINE = InnoDB,
 PARTITION p2016_08 VALUES LESS THAN (1472680800) ENGINE = InnoDB,
 PARTITION p2016_09 VALUES LESS THAN (1475272800) ENGINE = InnoDB,
 PARTITION p2016_10 VALUES LESS THAN (1477951200) ENGINE = InnoDB,
 PARTITION p2016_11 VALUES LESS THAN (1480543200) ENGINE = InnoDB,
 PARTITION p2016_12 VALUES LESS THAN (1483221600) ENGINE = InnoDB,
 PARTITION p2017_01 VALUES LESS THAN (1485900000) ENGINE = InnoDB,
 PARTITION p2017_02 VALUES LESS THAN (1488319200) ENGINE = InnoDB,
 PARTITION p2017_03 VALUES LESS THAN (1490997600) ENGINE = InnoDB,
 PARTITION p2017_04 VALUES LESS THAN (1493589600) ENGINE = InnoDB,
 PARTITION p2017_05 VALUES LESS THAN (1496268000) ENGINE = InnoDB,
 PARTITION p2017_06 VALUES LESS THAN (1498860000) ENGINE = InnoDB,
 PARTITION p2017_07 VALUES LESS THAN (1501538400) ENGINE = InnoDB,
 PARTITION p2017_08 VALUES LESS THAN (1504216800) ENGINE = InnoDB,
 PARTITION p2017_09 VALUES LESS THAN (1506808800) ENGINE = InnoDB,
 PARTITION p2017_10 VALUES LESS THAN (1509487200) ENGINE = InnoDB,
 PARTITION p2017_11 VALUES LESS THAN (1512079200) ENGINE = InnoDB,
 PARTITION p2017_12 VALUES LESS THAN (1514757600) ENGINE = InnoDB,
 PARTITION p2018_01 VALUES LESS THAN (1517436000) ENGINE = InnoDB,
 PARTITION p2018_02 VALUES LESS THAN (1519855200) ENGINE = InnoDB,
 PARTITION p2018_03 VALUES LESS THAN (1522533600) ENGINE = InnoDB,
 PARTITION p2018_04 VALUES LESS THAN (1525125600) ENGINE = InnoDB,
 PARTITION p2018_05 VALUES LESS THAN (1527804000) ENGINE = InnoDB,
 PARTITION p2018_06 VALUES LESS THAN (1530396000) ENGINE = InnoDB,
 PARTITION p2018_07 VALUES LESS THAN (1533074400) ENGINE = InnoDB,
 PARTITION p2018_08 VALUES LESS THAN (1535752800) ENGINE = InnoDB,
 PARTITION p2018_09 VALUES LESS THAN (1538344800) ENGINE = InnoDB,
 PARTITION p2018_10 VALUES LESS THAN (1541023200) ENGINE = InnoDB,
 PARTITION p2018_11 VALUES LESS THAN (1543615200) ENGINE = InnoDB,
 PARTITION p2018_12 VALUES LESS THAN (1546293600) ENGINE = InnoDB,
 PARTITION p2019_01 VALUES LESS THAN (1548972000) ENGINE = InnoDB,
 PARTITION p2019_02 VALUES LESS THAN (1551391200) ENGINE = InnoDB,
 PARTITION p2019_03 VALUES LESS THAN (1554069600) ENGINE = InnoDB,
 PARTITION p2019_04 VALUES LESS THAN (1556661600) ENGINE = InnoDB,
 PARTITION p2019_05 VALUES LESS THAN (1559340000) ENGINE = InnoDB,
 PARTITION p2019_06 VALUES LESS THAN (1561932000) ENGINE = InnoDB,
 PARTITION p2019_07 VALUES LESS THAN (1564610400) ENGINE = InnoDB,
 PARTITION p2019_08 VALUES LESS THAN (1567288800) ENGINE = InnoDB,
 PARTITION p2019_09 VALUES LESS THAN (1569880800) ENGINE = InnoDB,
 PARTITION p2019_10 VALUES LESS THAN (1572559200) ENGINE = InnoDB,
 PARTITION p2019_11 VALUES LESS THAN (1575151200) ENGINE = InnoDB,
 PARTITION p2019_12 VALUES LESS THAN (1577829600) ENGINE = InnoDB,
 PARTITION p2020_01 VALUES LESS THAN (1580508000) ENGINE = InnoDB,
 PARTITION p2020_02 VALUES LESS THAN (1583013600) ENGINE = InnoDB,
 PARTITION p2020_03 VALUES LESS THAN (1585692000) ENGINE = InnoDB,
 PARTITION p2020_04 VALUES LESS THAN (1588284000) ENGINE = InnoDB,
 PARTITION p2020_05 VALUES LESS THAN (1590962400) ENGINE = InnoDB,
 PARTITION p2020_06 VALUES LESS THAN (1593554400) ENGINE = InnoDB,
 PARTITION p2020_07 VALUES LESS THAN (1596232800) ENGINE = InnoDB,
 PARTITION p2020_08 VALUES LESS THAN (1598911200) ENGINE = InnoDB,
 PARTITION p2020_09 VALUES LESS THAN (1601503200) ENGINE = InnoDB,
 PARTITION p2020_10 VALUES LESS THAN (1604181600) ENGINE = InnoDB,
 PARTITION p2020_11 VALUES LESS THAN (1606773600) ENGINE = InnoDB,
 PARTITION p2020_12 VALUES LESS THAN (1609452000) ENGINE = InnoDB,
 PARTITION p2021_01 VALUES LESS THAN (1612130400) ENGINE = InnoDB,
 PARTITION p2021_02 VALUES LESS THAN (1614549600) ENGINE = InnoDB,
 PARTITION p2021_03 VALUES LESS THAN (1617228000) ENGINE = InnoDB,
 PARTITION p2021_04 VALUES LESS THAN (1619820000) ENGINE = InnoDB,
 PARTITION p2021_05 VALUES LESS THAN (1622498400) ENGINE = InnoDB,
 PARTITION p2021_06 VALUES LESS THAN (1625090400) ENGINE = InnoDB,
 PARTITION p2021_07 VALUES LESS THAN (1627768800) ENGINE = InnoDB,
 PARTITION p2021_08 VALUES LESS THAN (1630447200) ENGINE = InnoDB,
 PARTITION p2021_09 VALUES LESS THAN (1633039200) ENGINE = InnoDB,
 PARTITION p2021_10 VALUES LESS THAN (1635717600) ENGINE = InnoDB,
 PARTITION p2021_11 VALUES LESS THAN (1638309600) ENGINE = InnoDB,
 PARTITION p2021_12 VALUES LESS THAN (1640988000) ENGINE = InnoDB,
 PARTITION p2022_01 VALUES LESS THAN (1643666400) ENGINE = InnoDB,
 PARTITION p2022_02 VALUES LESS THAN (1646085600) ENGINE = InnoDB,
 PARTITION p2022_03 VALUES LESS THAN (1648764000) ENGINE = InnoDB,
 PARTITION p2022_04 VALUES LESS THAN (1651356000) ENGINE = InnoDB,
 PARTITION p2022_05 VALUES LESS THAN (1654034400) ENGINE = InnoDB,
 PARTITION p2022_06 VALUES LESS THAN (1656626400) ENGINE = InnoDB,
 PARTITION p2022_07 VALUES LESS THAN (1659304800) ENGINE = InnoDB,
 PARTITION p2022_08 VALUES LESS THAN (1661983200) ENGINE = InnoDB,
 PARTITION p2022_09 VALUES LESS THAN (1664575200) ENGINE = InnoDB,
 PARTITION p2022_10 VALUES LESS THAN (1667253600) ENGINE = InnoDB,
 PARTITION p2022_11 VALUES LESS THAN (1669845600) ENGINE = InnoDB,
 PARTITION p2022_12 VALUES LESS THAN (1672524000) ENGINE = InnoDB,
 PARTITION p2023_01 VALUES LESS THAN (1675202400) ENGINE = InnoDB,
 PARTITION p2023_02 VALUES LESS THAN (1677621600) ENGINE = InnoDB,
 PARTITION p2023_03 VALUES LESS THAN (1680300000) ENGINE = InnoDB,
 PARTITION p2023_04 VALUES LESS THAN (1682892000) ENGINE = InnoDB,
 PARTITION p2023_05 VALUES LESS THAN (1685570400) ENGINE = InnoDB,
 PARTITION p2023_06 VALUES LESS THAN (1688162400) ENGINE = InnoDB,
 PARTITION p2023_07 VALUES LESS THAN (1690840800) ENGINE = InnoDB,
 PARTITION p2023_08 VALUES LESS THAN (1693519200) ENGINE = InnoDB,
 PARTITION p2023_09 VALUES LESS THAN (1696111200) ENGINE = InnoDB,
 PARTITION p2023_10 VALUES LESS THAN (1698789600) ENGINE = InnoDB,
 PARTITION p2023_11 VALUES LESS THAN (1701381600) ENGINE = InnoDB,
 PARTITION p2023_12 VALUES LESS THAN (1704060000) ENGINE = InnoDB,
 PARTITION p2024_01 VALUES LESS THAN (1706738400) ENGINE = InnoDB,
 PARTITION p2024_02 VALUES LESS THAN (1709244000) ENGINE = InnoDB,
 PARTITION p2024_03 VALUES LESS THAN (1711922400) ENGINE = InnoDB,
 PARTITION p2024_04 VALUES LESS THAN (1714514400) ENGINE = InnoDB,
 PARTITION p2024_05 VALUES LESS THAN (1717192800) ENGINE = InnoDB,
 PARTITION p2024_06 VALUES LESS THAN (1719784800) ENGINE = InnoDB,
 PARTITION p2024_07 VALUES LESS THAN (1722463200) ENGINE = InnoDB,
 PARTITION p2024_08 VALUES LESS THAN (1725141600) ENGINE = InnoDB,
 PARTITION p2024_09 VALUES LESS THAN (1727733600) ENGINE = InnoDB,
 PARTITION p2024_10 VALUES LESS THAN (1730412000) ENGINE = InnoDB,
 PARTITION p2024_11 VALUES LESS THAN (1733004000) ENGINE = InnoDB,
 PARTITION pMAXVALUE VALUES LESS THAN MAXVALUE ENGINE = InnoDB) */;
CREATE TABLE `protokol_fiscal` (
  `device_number` varchar(20) NOT NULL,
  `fiscal_number` varchar(20) NOT NULL,
  `id_z` varchar(20) NOT NULL,
  `time_z` bigint(20) unsigned NOT NULL,
  `check_count` int(10) unsigned NOT NULL DEFAULT '0',
  `sales` decimal(8,2) NOT NULL DEFAULT '0.00',
  `cash` decimal(8,2) NOT NULL DEFAULT '0.00',
  `credit` decimal(8,2) NOT NULL DEFAULT '0.00',
  `checks` decimal(8,2) NOT NULL DEFAULT '0.00',
  `other` decimal(8,2) NOT NULL DEFAULT '0.00',
  `refunds` decimal(8,2) NOT NULL DEFAULT '0.00',
  `cash_in` decimal(8,2) NOT NULL DEFAULT '0.00',
  `cash_out` decimal(8,2) NOT NULL DEFAULT '0.00',
  `cash_sum` decimal(8,2) NOT NULL DEFAULT '0.00',
  KEY `device_number` (`device_number`),
  KEY `fiscal_number` (`fiscal_number`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;
CREATE TABLE `protokol_operations` (
  `id` int(11) NOT NULL,
  `name` varchar(45) NOT NULL,
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `protokol_operations_colors` (
  `op_id` int(11) NOT NULL,
  `color` varchar(45) DEFAULT NULL,
  `text_color` varchar(45) DEFAULT NULL,
  UNIQUE KEY `op_id_UNIQUE` (`op_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `protokol_sales` (
  `time_check` bigint(20) unsigned NOT NULL,
  `pos_id` tinyint(1) unsigned NOT NULL,
  `check_id` smallint(5) unsigned NOT NULL,
  `document_id` tinyint(1) unsigned NOT NULL,
  `time_operation` bigint(20) unsigned NOT NULL,
  `operation_id` tinyint(1) unsigned NOT NULL,
  `goods_id` int(10) unsigned NOT NULL DEFAULT '0',
  `discard_code` int(10) unsigned NOT NULL DEFAULT '0',
  `quantity` decimal(10,3) unsigned NOT NULL DEFAULT '0.000',
  `is_refund` tinyint(1) unsigned NOT NULL DEFAULT '0',
  `operation_sum` decimal(12,2) NOT NULL DEFAULT '0.00',
  `operator_id` smallint(5) unsigned NOT NULL DEFAULT '0',
  KEY `cash_check` (`time_check`,`pos_id`,`check_id`,`document_id`),
  KEY `time_pos_goods` (`time_check`,`pos_id`,`goods_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8
/*!50100 PARTITION BY RANGE (time_check)
(PARTITION pMINVALUE VALUES LESS THAN (1356991200) ENGINE = InnoDB,
 PARTITION p2013_01 VALUES LESS THAN (1359669600) ENGINE = InnoDB,
 PARTITION p2013_02 VALUES LESS THAN (1362088800) ENGINE = InnoDB,
 PARTITION p2013_03 VALUES LESS THAN (1364767200) ENGINE = InnoDB,
 PARTITION p2013_04 VALUES LESS THAN (1367359200) ENGINE = InnoDB,
 PARTITION p2013_05 VALUES LESS THAN (1370037600) ENGINE = InnoDB,
 PARTITION p2013_06 VALUES LESS THAN (1372629600) ENGINE = InnoDB,
 PARTITION p2013_07 VALUES LESS THAN (1375308000) ENGINE = InnoDB,
 PARTITION p2013_08 VALUES LESS THAN (1377986400) ENGINE = InnoDB,
 PARTITION p2013_09 VALUES LESS THAN (1380578400) ENGINE = InnoDB,
 PARTITION p2013_10 VALUES LESS THAN (1383256800) ENGINE = InnoDB,
 PARTITION p2013_11 VALUES LESS THAN (1385848800) ENGINE = InnoDB,
 PARTITION p2013_12 VALUES LESS THAN (1388527200) ENGINE = InnoDB,
 PARTITION p2014_01 VALUES LESS THAN (1391205600) ENGINE = InnoDB,
 PARTITION p2014_02 VALUES LESS THAN (1393624800) ENGINE = InnoDB,
 PARTITION p2014_03 VALUES LESS THAN (1396303200) ENGINE = InnoDB,
 PARTITION p2014_04 VALUES LESS THAN (1398895200) ENGINE = InnoDB,
 PARTITION p2014_05 VALUES LESS THAN (1401573600) ENGINE = InnoDB,
 PARTITION p2014_06 VALUES LESS THAN (1404165600) ENGINE = InnoDB,
 PARTITION p2014_07 VALUES LESS THAN (1406844000) ENGINE = InnoDB,
 PARTITION p2014_08 VALUES LESS THAN (1409522400) ENGINE = InnoDB,
 PARTITION p2014_09 VALUES LESS THAN (1412114400) ENGINE = InnoDB,
 PARTITION p2014_10 VALUES LESS THAN (1414792800) ENGINE = InnoDB,
 PARTITION p2014_11 VALUES LESS THAN (1417384800) ENGINE = InnoDB,
 PARTITION p2014_12 VALUES LESS THAN (1420063200) ENGINE = InnoDB,
 PARTITION p2015_01 VALUES LESS THAN (1422741600) ENGINE = InnoDB,
 PARTITION p2015_02 VALUES LESS THAN (1425160800) ENGINE = InnoDB,
 PARTITION p2015_03 VALUES LESS THAN (1427839200) ENGINE = InnoDB,
 PARTITION p2015_04 VALUES LESS THAN (1430431200) ENGINE = InnoDB,
 PARTITION p2015_05 VALUES LESS THAN (1433109600) ENGINE = InnoDB,
 PARTITION p2015_06 VALUES LESS THAN (1435701600) ENGINE = InnoDB,
 PARTITION p2015_07 VALUES LESS THAN (1438380000) ENGINE = InnoDB,
 PARTITION p2015_08 VALUES LESS THAN (1441058400) ENGINE = InnoDB,
 PARTITION p2015_09 VALUES LESS THAN (1443650400) ENGINE = InnoDB,
 PARTITION p2015_10 VALUES LESS THAN (1446328800) ENGINE = InnoDB,
 PARTITION p2015_11 VALUES LESS THAN (1448920800) ENGINE = InnoDB,
 PARTITION p2015_12 VALUES LESS THAN (1451599200) ENGINE = InnoDB,
 PARTITION p2016_01 VALUES LESS THAN (1454277600) ENGINE = InnoDB,
 PARTITION p2016_02 VALUES LESS THAN (1456783200) ENGINE = InnoDB,
 PARTITION p2016_03 VALUES LESS THAN (1459461600) ENGINE = InnoDB,
 PARTITION p2016_04 VALUES LESS THAN (1462053600) ENGINE = InnoDB,
 PARTITION p2016_05 VALUES LESS THAN (1464732000) ENGINE = InnoDB,
 PARTITION p2016_06 VALUES LESS THAN (1467324000) ENGINE = InnoDB,
 PARTITION p2016_07 VALUES LESS THAN (1470002400) ENGINE = InnoDB,
 PARTITION p2016_08 VALUES LESS THAN (1472680800) ENGINE = InnoDB,
 PARTITION p2016_09 VALUES LESS THAN (1475272800) ENGINE = InnoDB,
 PARTITION p2016_10 VALUES LESS THAN (1477951200) ENGINE = InnoDB,
 PARTITION p2016_11 VALUES LESS THAN (1480543200) ENGINE = InnoDB,
 PARTITION p2016_12 VALUES LESS THAN (1483221600) ENGINE = InnoDB,
 PARTITION p2017_01 VALUES LESS THAN (1485900000) ENGINE = InnoDB,
 PARTITION p2017_02 VALUES LESS THAN (1488319200) ENGINE = InnoDB,
 PARTITION p2017_03 VALUES LESS THAN (1490997600) ENGINE = InnoDB,
 PARTITION p2017_04 VALUES LESS THAN (1493589600) ENGINE = InnoDB,
 PARTITION p2017_05 VALUES LESS THAN (1496268000) ENGINE = InnoDB,
 PARTITION p2017_06 VALUES LESS THAN (1498860000) ENGINE = InnoDB,
 PARTITION p2017_07 VALUES LESS THAN (1501538400) ENGINE = InnoDB,
 PARTITION p2017_08 VALUES LESS THAN (1504216800) ENGINE = InnoDB,
 PARTITION p2017_09 VALUES LESS THAN (1506808800) ENGINE = InnoDB,
 PARTITION p2017_10 VALUES LESS THAN (1509487200) ENGINE = InnoDB,
 PARTITION p2017_11 VALUES LESS THAN (1512079200) ENGINE = InnoDB,
 PARTITION p2017_12 VALUES LESS THAN (1514757600) ENGINE = InnoDB,
 PARTITION p2018_01 VALUES LESS THAN (1517436000) ENGINE = InnoDB,
 PARTITION p2018_02 VALUES LESS THAN (1519855200) ENGINE = InnoDB,
 PARTITION p2018_03 VALUES LESS THAN (1522533600) ENGINE = InnoDB,
 PARTITION p2018_04 VALUES LESS THAN (1525125600) ENGINE = InnoDB,
 PARTITION p2018_05 VALUES LESS THAN (1527804000) ENGINE = InnoDB,
 PARTITION p2018_06 VALUES LESS THAN (1530396000) ENGINE = InnoDB,
 PARTITION p2018_07 VALUES LESS THAN (1533074400) ENGINE = InnoDB,
 PARTITION p2018_08 VALUES LESS THAN (1535752800) ENGINE = InnoDB,
 PARTITION p2018_09 VALUES LESS THAN (1538344800) ENGINE = InnoDB,
 PARTITION p2018_10 VALUES LESS THAN (1541023200) ENGINE = InnoDB,
 PARTITION p2018_11 VALUES LESS THAN (1543615200) ENGINE = InnoDB,
 PARTITION p2018_12 VALUES LESS THAN (1546293600) ENGINE = InnoDB,
 PARTITION p2019_01 VALUES LESS THAN (1548972000) ENGINE = InnoDB,
 PARTITION p2019_02 VALUES LESS THAN (1551391200) ENGINE = InnoDB,
 PARTITION p2019_03 VALUES LESS THAN (1554069600) ENGINE = InnoDB,
 PARTITION p2019_04 VALUES LESS THAN (1556661600) ENGINE = InnoDB,
 PARTITION p2019_05 VALUES LESS THAN (1559340000) ENGINE = InnoDB,
 PARTITION p2019_06 VALUES LESS THAN (1561932000) ENGINE = InnoDB,
 PARTITION p2019_07 VALUES LESS THAN (1564610400) ENGINE = InnoDB,
 PARTITION p2019_08 VALUES LESS THAN (1567288800) ENGINE = InnoDB,
 PARTITION p2019_09 VALUES LESS THAN (1569880800) ENGINE = InnoDB,
 PARTITION p2019_10 VALUES LESS THAN (1572559200) ENGINE = InnoDB,
 PARTITION p2019_11 VALUES LESS THAN (1575151200) ENGINE = InnoDB,
 PARTITION p2019_12 VALUES LESS THAN (1577829600) ENGINE = InnoDB,
 PARTITION p2020_01 VALUES LESS THAN (1580508000) ENGINE = InnoDB,
 PARTITION p2020_02 VALUES LESS THAN (1583013600) ENGINE = InnoDB,
 PARTITION p2020_03 VALUES LESS THAN (1585692000) ENGINE = InnoDB,
 PARTITION p2020_04 VALUES LESS THAN (1588284000) ENGINE = InnoDB,
 PARTITION p2020_05 VALUES LESS THAN (1590962400) ENGINE = InnoDB,
 PARTITION p2020_06 VALUES LESS THAN (1593554400) ENGINE = InnoDB,
 PARTITION p2020_07 VALUES LESS THAN (1596232800) ENGINE = InnoDB,
 PARTITION p2020_08 VALUES LESS THAN (1598911200) ENGINE = InnoDB,
 PARTITION p2020_09 VALUES LESS THAN (1601503200) ENGINE = InnoDB,
 PARTITION p2020_10 VALUES LESS THAN (1604181600) ENGINE = InnoDB,
 PARTITION p2020_11 VALUES LESS THAN (1606773600) ENGINE = InnoDB,
 PARTITION p2020_12 VALUES LESS THAN (1609452000) ENGINE = InnoDB,
 PARTITION p2021_01 VALUES LESS THAN (1612130400) ENGINE = InnoDB,
 PARTITION p2021_02 VALUES LESS THAN (1614549600) ENGINE = InnoDB,
 PARTITION p2021_03 VALUES LESS THAN (1617228000) ENGINE = InnoDB,
 PARTITION p2021_04 VALUES LESS THAN (1619820000) ENGINE = InnoDB,
 PARTITION p2021_05 VALUES LESS THAN (1622498400) ENGINE = InnoDB,
 PARTITION p2021_06 VALUES LESS THAN (1625090400) ENGINE = InnoDB,
 PARTITION p2021_07 VALUES LESS THAN (1627768800) ENGINE = InnoDB,
 PARTITION p2021_08 VALUES LESS THAN (1630447200) ENGINE = InnoDB,
 PARTITION p2021_09 VALUES LESS THAN (1633039200) ENGINE = InnoDB,
 PARTITION p2021_10 VALUES LESS THAN (1635717600) ENGINE = InnoDB,
 PARTITION p2021_11 VALUES LESS THAN (1638309600) ENGINE = InnoDB,
 PARTITION p2021_12 VALUES LESS THAN (1640988000) ENGINE = InnoDB,
 PARTITION p2022_01 VALUES LESS THAN (1643666400) ENGINE = InnoDB,
 PARTITION p2022_02 VALUES LESS THAN (1646085600) ENGINE = InnoDB,
 PARTITION p2022_03 VALUES LESS THAN (1648764000) ENGINE = InnoDB,
 PARTITION p2022_04 VALUES LESS THAN (1651356000) ENGINE = InnoDB,
 PARTITION p2022_05 VALUES LESS THAN (1654034400) ENGINE = InnoDB,
 PARTITION p2022_06 VALUES LESS THAN (1656626400) ENGINE = InnoDB,
 PARTITION p2022_07 VALUES LESS THAN (1659304800) ENGINE = InnoDB,
 PARTITION p2022_08 VALUES LESS THAN (1661983200) ENGINE = InnoDB,
 PARTITION p2022_09 VALUES LESS THAN (1664575200) ENGINE = InnoDB,
 PARTITION p2022_10 VALUES LESS THAN (1667253600) ENGINE = InnoDB,
 PARTITION p2022_11 VALUES LESS THAN (1669845600) ENGINE = InnoDB,
 PARTITION p2022_12 VALUES LESS THAN (1672524000) ENGINE = InnoDB,
 PARTITION p2023_01 VALUES LESS THAN (1675202400) ENGINE = InnoDB,
 PARTITION p2023_02 VALUES LESS THAN (1677621600) ENGINE = InnoDB,
 PARTITION p2023_03 VALUES LESS THAN (1680300000) ENGINE = InnoDB,
 PARTITION p2023_04 VALUES LESS THAN (1682892000) ENGINE = InnoDB,
 PARTITION p2023_05 VALUES LESS THAN (1685570400) ENGINE = InnoDB,
 PARTITION p2023_06 VALUES LESS THAN (1688162400) ENGINE = InnoDB,
 PARTITION p2023_07 VALUES LESS THAN (1690840800) ENGINE = InnoDB,
 PARTITION p2023_08 VALUES LESS THAN (1693519200) ENGINE = InnoDB,
 PARTITION p2023_09 VALUES LESS THAN (1696111200) ENGINE = InnoDB,
 PARTITION p2023_10 VALUES LESS THAN (1698789600) ENGINE = InnoDB,
 PARTITION p2023_11 VALUES LESS THAN (1701381600) ENGINE = InnoDB,
 PARTITION p2023_12 VALUES LESS THAN (1704060000) ENGINE = InnoDB,
 PARTITION p2024_01 VALUES LESS THAN (1706738400) ENGINE = InnoDB,
 PARTITION p2024_02 VALUES LESS THAN (1709244000) ENGINE = InnoDB,
 PARTITION p2024_03 VALUES LESS THAN (1711922400) ENGINE = InnoDB,
 PARTITION p2024_04 VALUES LESS THAN (1714514400) ENGINE = InnoDB,
 PARTITION p2024_05 VALUES LESS THAN (1717192800) ENGINE = InnoDB,
 PARTITION p2024_06 VALUES LESS THAN (1719784800) ENGINE = InnoDB,
 PARTITION p2024_07 VALUES LESS THAN (1722463200) ENGINE = InnoDB,
 PARTITION p2024_08 VALUES LESS THAN (1725141600) ENGINE = InnoDB,
 PARTITION p2024_09 VALUES LESS THAN (1727733600) ENGINE = InnoDB,
 PARTITION p2024_10 VALUES LESS THAN (1730412000) ENGINE = InnoDB,
 PARTITION p2024_11 VALUES LESS THAN (1733004000) ENGINE = InnoDB,
 PARTITION pMAXVALUE VALUES LESS THAN MAXVALUE ENGINE = InnoDB) */;