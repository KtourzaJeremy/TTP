CREATE TABLE `User` (
	`IdUser` INT NOT NULL,
	`MailUser` varchar NOT NULL,
	`MdpUser` varchar NOT NULL,
	`NiveauUser` INT NOT NULL,
	`NomUser` varchar NOT NULL UNIQUE,
	`PrenomUser` varchar,
	`AgeUser` INT,
	`GenreUser` varchar,
	`VilleUser` varchar,
	`DeptUser` varchar,
	`TelUser` varchar,
	`PhotoUser` varchar,
	PRIMARY KEY (`IdUser`)
);

CREATE TABLE `Event` (
	`IdEvt` INT NOT NULL,
	`TitreEvt` varchar NOT NULL,
	`LocEvt` varchar NOT NULL,
	`DateEvt` DATE NOT NULL,
	`PhotoEvt` varchar,
	`EtatEvt` BOOLEAN NOT NULL,
	PRIMARY KEY (`IdEvt`)
);

CREATE TABLE `Participants` (
	`IdListeParticipants` INT NOT NULL,
	`NbMaxParticipants` INT,
	`IdEvt` INT NOT NULL AUTO_INCREMENT,
	`IdUser` INT NOT NULL AUTO_INCREMENT,
	PRIMARY KEY (`IdListeParticipants`)
);

ALTER TABLE `Participants` ADD CONSTRAINT `Participants_fk0` FOREIGN KEY (`IdEvt`) REFERENCES `Event`(`IdEvt`);

ALTER TABLE `Participants` ADD CONSTRAINT `Participants_fk1` FOREIGN KEY (`IdUser`) REFERENCES `User`(`IdUser`);



vrai script

drop table User_ttp ;
drop table Event_ttp;
drop table Participants;

CREATE TABLE User_ttp
 (
	IdUser INT Primary Key identity,
	MailUser varchar NOT NULL,
	MdpUser varchar NOT NULL,
	NomUser varchar NOT NULL UNIQUE,
	PrenomUser varchar,
	AgeUser INT,
	GenreUser varchar,
	TelUser varchar,
	PhotoUser varchar,
	
);

CREATE TABLE Event_ttp (
	IdEvt  INT primary key identity,
	 TitreEvt  varchar NOT NULL,
	 LocEvt  varchar NOT NULL,
	 DateEvt  DATE NOT NULL,
	 PhotoEvt  varchar,
	 EtatEvt  BIT NOT NULL,
	 NbMaxParticipants  INT,

);

CREATE TABLE  Participants  (
	 IdEvt  INT Not Null,
	 IdUser  INT NOT NULL ,
	 CONSTRAINT pk_ID PRIMARY KEY (IdEvt,IdUser)
);

ALTER TABLE Participants
ADD Foreign KEY (IdUser)
References User_ttp(IdUser)

ALTER TABLE Participants
ADD Foreign KEY (IdEvt)
References Event_ttp(IdEvt)

