use ttp;


DROP TABLE Users CASCADE CONSTRAINTS PURGE;
DROP TABLE Event CASCADE CONSTRAINTS PURGE;
DROP TABLE Participants CASCADE CONSTRAINTS PURGE;



CREATE TABLE Users (
	IdUser integer NOT NULL AUTO_INCREMENT,
	MailUser varchar(20) NOT NULL,
	MdpUser varchar(20) NOT NULL,
	NiveauUser INTEGER NOT NULL,
	NomUser varchar(20) NOT NULL,
	PrenomUser varchar(20),
	AgeUser INTEGER,
	GenreUser varchar(20),
	VilleUser varchar(20),
	DeptUser varchar(20),
	TelUser varchar(20),
	PhotoUser varchar(20),
	PRIMARY KEY (IdUser)
);

CREATE TABLE Event (
	IdEvt INT NOT NULL AUTO_INCREMENT,
	TitreEvt varchar(20) NOT NULL,
	LocEvt varchar(20) NOT NULL,
	DateEvt DATE NOT NULL,
	PhotoEvt varchar(20),
	EtatEvt BOOLEAN NOT NULL,
	NbMaxParticipants INT NOT NULL,
	PRIMARY KEY (IdEvt)
);

CREATE TABLE Participants (
	IdEvt INT NOT NULL,
	IdUser INT NOT NULL,
	PRIMARY KEY (IdEvt, IdUser)
);

ALTER TABLE Participants ADD CONSTRAINT Participants_fk0 FOREIGN KEY (IdEvt) REFERENCES Event(IdEvt);

ALTER TABLE Participants ADD CONSTRAINT Participants_fk1 FOREIGN KEY (IdUser) REFERENCES User(IdUser);

PROMPT -->> Creation du compte administrateur

insert into COMPTES (Login, Mdp, Role) values ('admin', 'admin', 'Administrateur');

commit;

SET FEEDBACK ON