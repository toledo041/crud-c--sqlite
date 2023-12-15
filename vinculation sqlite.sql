CREATE TABLE "Student" (
	"idUser"	INTEGER NOT NULL UNIQUE,
	"name"	TEXT NOT NULL,
	"lastName"	TEXT NOT NULL,
	"mothersthestName"	TEXT NOT NULL,
	"enrollment"	INTEGER,
	"birthdate"	TEXT,
	"curp"	TEXT,
	"phone"	TEXT,
	"rfc"	TEXT,
	"socialSegurity"	TEXT,
	"idEmployee"	INTEGER,
	"status"	INTEGER DEFAULT 1,
	"idUserCreate"	INTEGER NOT NULL,
	"dateCreate"	TEXT NOT NULL,
	"idUserModified"	INTEGER,
	"dateModified"	TEXT,
	PRIMARY KEY("idUser" AUTOINCREMENT)
);


CREATE TABLE "Employee" (
	"idEmployee" INTEGER NOT NULL UNIQUE,
	"name" TEXT NOT NULL,
	"lastname" TEXT NOT NULL,
	"mothersLastName" TEXT NOT NULL,
	"gender" TEXT NOT NULL,
	"phone" TEXT NOT NULL,
	"email" TEXT NOT NULL,
	"address" TEXT, 
	"socialSecurity" TEXT,
	"dateOfHire" TEXT,
	"idSubject" INT NOT NULL,
	"status"	INTEGER DEFAULT 1,
	"idUserCreate"	INTEGER NOT NULL,
	"dateCreate"	TEXT NOT NULL,
	"idUserModified"	INTEGER,
	"dateModified"	TEXT,
	PRIMARY KEY("idEmployee" AUTOINCREMENT)
);

CREATE TABLE "User"
(   
	 "idUser" INTEGER NOT NULL UNIQUE,
	 "name" TEXT NOT NULL,
	 "password" TEXT NOT NULL,
	 "email" TEXT NOT NULL,
	 "status"	INTEGER DEFAULT 1,
	 PRIMARY KEY("idUser" AUTOINCREMENT)
);


INSERT INTO "User" ("name","password", "email")
VALUES ('Nallely', '130218','toledo@');

INSERT INTO "Employee"("name","lastname","mothersLastName","gender","phone","email","address","socialSecurity","dateOfHire","idSubject","idUserCreate","dateCreate","idUserModified","dateModified")
VALUES ('Luis Alfonso','Rodriguez','Perez','Hombre','8662567822','luis@gmail.com','Ayuntamiento 212 Occidental','44180032044','2023-01-23',1,1,'2007-09-17',1,null),
       ('Alberto','Salazar','Zuñiga','Hombre','8662347822','alberto@gmail.com','Ignacio allende 313 La sierrita','44180032042','2023-02-12',2,1,'2007-09-17',1,null),
	   ('Antonio','Rodriguez','Tovar','Hombre','8661227822','antonio@gmail.com','Jalisco nte 1700 Monclova','44180032043','2023-02-10',3,1,'2007-09-17',1,null),
	   ('Gabriela','Mendoza','Aguilar','Mujer','8662137822','gabriela@gmail.com','C. Monaco 1010 Monclova','44180032044','2023-04-11',4,1,'2007-09-17',1,null),
	   ('Patricia','Hernendez','Mata','Mujer','8665437822','patricia@gmail.com','C. Zaragoza 227 Frontera','44180032045','2023-07-25',5,1,'2007-09-17',1,null);

INSERT INTO "Student" ("name","lastName","mothersthestName","enrollment","birthdate","curp","phone","rfc","socialSegurity","idEmployee","idUserCreate","dateCreate","idUserModified","dateModified")
VALUES ('Nallely','Toledo','Alonso','I15171917','1996-06-09','TOASMNL000NLLN9654','8667882323','TOASMNL000NLL','44180032043',1,1,null,1,null),
       ('Alberto','Salazar','Zuñiga','I18050517','2000-04-08','SAZA000408HCLLXLA6','8661222321','SAZA000408K61','44180032089',2,1,null,1,null),
	   ('Antonio','Perez','Gaitan','I23050517','2003-08-20','PEGA030820HCLLXKLR','8664322321','PEGA030820HCL','44180032090',3,1,null,1,null),
	   ('Maria','Rivera','Soledad','I20050517','2005-01-25','RISM000408HCLLXLA6','8662332321','RISM000408HCL','44180032011',4,1,null,1,null),
	   ('Bertha','Ibarra','Vazquez','I17050517','2007-09-17','VAVB000408HCLLXLO6','8666542321','VAVB000408HCL','44180032055',5,1,null,1,null);
