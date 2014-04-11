CREATE DATABASE Arrenda_me;

CREATE LOGIN [RentMe] WITH PASSWORD = '123456', DEFAULT_DATABASE=[Arrenda_me], DEFAULT_LANGUAGE=[English]

CREATE TABLE [User]
(
  id_User int identity(1,1) NOT NULL PRIMARY KEY,
  email varchar(50) NOT NULL,
  pass varchar(20) NOT NULL,
  contact int,
);


CREATE TABLE Announcement
(
	Id_Announcement INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Id_Property INT NOT NULL,
	Price FLOAT NOT NULL,
	Longitude FLOAT NOT NULL,
	Latitude FLOAT NOT NULL,
	StartDate DATETIME NOT NULL,
	EndDate DATETIME NOT NULL
	FOREIGN KEY (id_Property) REFERENCES Property(id_Property)
)
CREATE INDEX Announcement_Index
ON Announcement (Price, Longitude, Latitude)


 CREATE TABLE Property
(
id_District int  NOT NULL,
id_City int  NOT NULL,
id_Locality int  NOT NULL, --freguesia
id_Classification int  NOT NULL,
active bit  NOT NULL,
area int NULL,
title varchar(255)  NOT NULL,
description varchar(MAX)  NOT NULL,
id_User int  NOT NULL, 
FOREIGN KEY (id_User) REFERENCES Users(id_User),
id_Property int NOT NULL PRIMARY KEY
);

CREATE TABLE Attribute
(
	id__Attribute int identity(1,1) PRIMARY KEY,
	furnished bit,
	equipped bit,
	lift bit,
	animals bit,
	pool bit,
);

CREATE TABLE [Notification]

(	
Id_Notification INT NOT NULL PRIMARY KEY,
Name varchar (50),
Contact int,
Email varchar (50),
Mensage varchar (Max),
id_User Int,
id_Announcement int, 
FOREIGN KEY (id_User) REFERENCES [User](id_User),
FOREIGN KEY (id_Announcement) REFERENCES [Announcement](id_Announcement),


)
