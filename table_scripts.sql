CREATE TABLE Users
(
  id_User int NOT NULL PRIMARY KEY,
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
)
CREATE INDEX Announcement_Index
ON Announcement (Price, Longitude, Latitude)


