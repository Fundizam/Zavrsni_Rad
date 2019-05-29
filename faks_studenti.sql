CREATE DATABASE Faks_Studenti

CREATE TABLE Studenti (
OIB CHAR (11) NOT NULL PRIMARY KEY,
Ime VARCHAR (30) NOT NULL,
Prezime VARCHAR (30) NOT NULL,
DatRod Date NOT NULL,
ID_Studij INT NOT NULL,
ID_Grad INT NOT NULL,
ID_Status INT NOT NULL);

CREATE TABLE Drzave (
ID_Drzave INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
Naziv_Drzave VARCHAR(40) NOT NULL);

CREATE TABLE Gradovi (
ID_Grad INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
Naziv_Grada VARCHAR (40) NOT NULL,
PostanskiBroj INT NOT NULL,
ID_Drzave INT NOT NULL);

CREATE TABLE Studij (
ID_Studij INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
Naziv_Studija VARCHAR (60) NOT NULL);

CREATE TABLE StatusStudenta (
ID_Status INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
Naziv_Statusa VARCHAR (15) NOT NULL);

ALTER TABLE Studenti ADD CONSTRAINT FK_Studij FOREIGN KEY (ID_Studij) REFERENCES Studij (ID_Studij)
ALTER TABLE Studenti ADD CONSTRAINT FK_Grad FOREIGN KEY (ID_Grad) REFERENCES Gradovi (ID_Grad)
ALTER TABLE Studenti ADD CONSTRAINT FK_Status FOREIGN KEY (ID_Status) REFERENCES StatusStudenta (ID_Status)

ALTER TABLE Gradovi ADD CONSTRAINT FK_Drzava FOREIGN KEY (ID_Drzave) REFERENCES Drzave (ID_Drzave)

INSERT INTO Studij VALUES 
('Turistièki menadžment'),
('Informatièki menadžment'),
('Promet'),
('Upravni studij'),
('Energetika'),
('ERASMUS')

INSERT INTO Drzave VALUES
('Hrvatska'),
('Makedonija'),
('Slovenija'),
('Bosna i Hercegovina'),
('Crna Gora'),
('Srbija'),
('Slovaèka'),
('Maðarska'),
('Španjolska'),
('Èeška')

INSERT INTO Gradovi VALUES
('Šibenik', 22000, 1),
('Split', 21000, 1),
('Zagreb',10000, 1),
('Zadar', 23000, 1),
('Bjelovar', 43000, 1),
('Makarska', 21300, 1),
('Opatija', 51410, 1),
('Pula', 52100, 1),
('Rijeka', 51000, 1),
('Sinj',21230, 1),
('Imotski', 21260, 1),
('Senj', 53270, 1),
('Slavonski Brod', 35000, 1),
('Osijek', 31000, 1),
('Ðakovo', 31400, 1),
('Knin', 22300, 1),
('Dubrovnik', 20000, 1),
('Varaždin', 42000, 1),
('Skopje', 1000, 2),
('Ohrid', 6000, 2),
('Makedonska Kamenica', 2304, 2),
('Sarajevo', 71000, 4),
('Banja Luka', 78000, 4),
('Mostar', 88000, 4),
('Beograd', 11000, 6),
('Novi Sad', 21000, 6),
('Podgorica', 81000, 5),
('Ljubljana', 1000, 3),
('Maribor', 2000, 3),
('Budimpešta', 1011, 8),
('Bratislava', 80000, 7),
('Prag', 10000, 10),
('Brno', 60200, 10),
('Madrid', 28000, 9),
('Barcelona', 08001, 9)

INSERT INTO StatusStudenta VALUES
('Redovni'),
('Izvanredni'),
('ERASMUS')
