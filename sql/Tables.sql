CREATE TABLE Csapat(
id int PRIMARY KEY,
nev varchar2(50));

CREATE TABLE Poszt(
id int PRIMARY KEY,
megnevezes varchar2(50));

CREATE TABLE Focista(
id int PRIMARY KEY,
szuletesi_ev int,
vezeteknev varchar2(50),
keresztnev varchar2(50));

CREATE TABLE Tagja(
Focista int references Focista(id),
Csapat int references Csapat(id),
Mezszam int,
primary key (Focista, Csapat, Mezszam));

CREATE TABLE Jatszik(
Focista int references Focista(id),
Poszt int references Poszt(id),
primary key (Focista, Poszt));

CREATE TABLE Users(
id int PRIMARY KEY,
felhasznalonev varchar2(50),
jelszo varchar2(50));

CREATE TABLE User_logs(
id int references Users(id),
bejelentkezes TIMESTAMP);

commit;


INSERT INTO Csapat VALUES ('1', 'Zamora FC'); 
INSERT INTO Csapat VALUES ('2', 'Ferlach'); 
INSERT INTO Csapat VALUES ('3', 'Cornella'); 
INSERT INTO Csapat VALUES ('4', 'Atlético Madrid'); 
INSERT INTO Csapat VALUES ('5', 'Lugo'); 

INSERT INTO Poszt VALUES ('1', 'Csatár');
INSERT INTO Poszt VALUES ('2', 'Védõ');
INSERT INTO Poszt VALUES ('5', 'Kapus');
INSERT INTO Poszt VALUES ('6','Középpályás');

Insert Into Focista Values ('1', '1995', 'Végh', 'Béla');

Insert Into Tagja Values ('4', '2', '2');

INSERT INTO Users Values ('1', 'zolya', 'almafa123');
INSERT INTO Users Values ('2', 'teszt', 'teszt123');