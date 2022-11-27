CREATE DATABASE Exam;
USE Exam;
-- ETUDIANT
CREATE TABLE Etudiant(
	etudiantId int PRIMARY KEY NOT NULL IDENTITY(1,1),
	nomComplet varchar(100),
	cne varchar(10) UNIQUE NOT NULL,
	email varchar(250) UNIQUE NOT NULL
);
SELECT * FROM Etudiant;


-- Professeur
CREATE TABLE Professeur(
	professeurId int PRIMARY KEY NOT NULL IDENTITY(1,1),
	nomComplet varchar(100),
	cne varchar(10) UNIQUE NOT NULL,
	email varchar(250) UNIQUE NOT NULL
);

-- Exam
CREATE TABLE Exam(
	examId int PRIMARY KEY NOT NULL IDENTITY(1,1),
	examNom varchar(100) NOT NULL,
	dateDebut date ,
	Duree int,
	professeurId int REFERENCES Professeur(professeurId)
);


SELECT * FROM Exam;
--EXAM_ETUDIANT
CREATE TABLE Etudiant_Exam(
	examId int REFERENCES Exam(examId),
	etudiantId int REFERENCES Etudiant(etudiantId)
);


CREATE TABLE QuestionChoixMultiple(
	questionId int PRIMARY KEY NOT NULL IDENTITY(1,1),
	enonce varchar(max),
	examId int REFERENCES Exam(examId),
	nombrePoint int
);

CREATE TABLE Proposition(
	propositionId int PRIMARY KEY NOT NULL IDENTITY(1,1),
	vrai bit ,
	Contenu varchar(max),
	certitude int,
	questionId int REFERENCES QuestionChoixMultiple(QuestionId)
);

CREATE TABLE QuestionOuverte(
	questionId int PRIMARY KEY NOT NULL IDENTITY(1,1),
	enonce varchar(max),
	reponse varchar(max),
	examId int REFERENCES Exam(examId),
);

