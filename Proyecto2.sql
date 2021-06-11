--
-- File generated with SQLiteStudio v3.3.3 on jue. jun. 10 22:41:47 2021
--
-- Text encoding used: System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: Academia
CREATE TABLE "Academia" (
	"Clave"	TINYINT(4) NOT NULL,
	"Nombre"	VARCHAR(40) NOT NULL,
	"Plantel"	SMALLINT(6) NOT NULL,
	PRIMARY KEY("Clave"),
	FOREIGN KEY("Plantel") REFERENCES "Plantel"("ID_plantel")
);
INSERT INTO Academia (Clave, Nombre, Plantel) VALUES (2001, 'Electronica', 1256);
INSERT INTO Academia (Clave, Nombre, Plantel) VALUES (2002, 'Informatica', 1256);
INSERT INTO Academia (Clave, Nombre, Plantel) VALUES (2003, 'Electricidad', 1258);
INSERT INTO Academia (Clave, Nombre, Plantel) VALUES (2004, 'Literatura', 1258);
INSERT INTO Academia (Clave, Nombre, Plantel) VALUES (2005, 'Pintura', 1258);
INSERT INTO Academia (Clave, Nombre, Plantel) VALUES (2006, 'Danza', 1257);
INSERT INTO Academia (Clave, Nombre, Plantel) VALUES (2007, 'Musica', 1257);
INSERT INTO Academia (Clave, Nombre, Plantel) VALUES (2008, 'Quimica', 1256);

-- Table: Docente
CREATE TABLE Docente (ID_docente INT (4) NOT NULL, Nombre VARCHAR (40) NOT NULL, Apellido_paterno VARCHAR (40) NOT NULL, Apellido_materno VARCHAR (40) NOT NULL, Fecha_de_nacimiento date NOT NULL, Academia TINYINT (4) NOT NULL, Contrasena VARCHAR (8) NOT NULL, Fecha_ingreso date NOT NULL, Ocupacion INTEGER NOT NULL, PRIMARY KEY (ID_docente), FOREIGN KEY (Ocupacion) REFERENCES Tipo_usuario (ID), FOREIGN KEY (Academia) REFERENCES Academia (Clave));
INSERT INTO Docente (ID_docente, Nombre, Apellido_paterno, Apellido_materno, Fecha_de_nacimiento, Academia, Contrasena, Fecha_ingreso, Ocupacion) VALUES (1528, 'ANTONIO', 'FRANCIS', 'DE LA CRUZ', '1964-03-20', 2001, 'useruser', '2004-12-25', 1);
INSERT INTO Docente (ID_docente, Nombre, Apellido_paterno, Apellido_materno, Fecha_de_nacimiento, Academia, Contrasena, Fecha_ingreso, Ocupacion) VALUES (1459, 'MANUEL', 'ABREU', 'HERNANDEZ', '1965-12-13', 2004, 'useruser', '2013-12-27', 1);
INSERT INTO Docente (ID_docente, Nombre, Apellido_paterno, Apellido_materno, Fecha_de_nacimiento, Academia, Contrasena, Fecha_ingreso, Ocupacion) VALUES (1337, 'JOSE', 'ACOSTA', 'TORRES', '1969-07-20', 2005, 'useruser', '2004-11-02', 1);
INSERT INTO Docente (ID_docente, Nombre, Apellido_paterno, Apellido_materno, Fecha_de_nacimiento, Academia, Contrasena, Fecha_ingreso, Ocupacion) VALUES (1719, 'FRANCISCO', 'AGUAYO', 'GONZALEZ', '1965-07-23', 2003, 'useruser', '2004-12-19', 1);
INSERT INTO Docente (ID_docente, Nombre, Apellido_paterno, Apellido_materno, Fecha_de_nacimiento, Academia, Contrasena, Fecha_ingreso, Ocupacion) VALUES (2565, 'DAVID', 'AGUILAR', 'NAVARRO', '1964-10-16', 2001, 'useruser', '2007-07-05', 2);
INSERT INTO Docente (ID_docente, Nombre, Apellido_paterno, Apellido_materno, Fecha_de_nacimiento, Academia, Contrasena, Fecha_ingreso, Ocupacion) VALUES (2428, 'JUAN', 'AGUILAR', 'SALINAS', '1958-11-16', 2002, 'useruser', '2007-03-16', 2);
INSERT INTO Docente (ID_docente, Nombre, Apellido_paterno, Apellido_materno, Fecha_de_nacimiento, Academia, Contrasena, Fecha_ingreso, Ocupacion) VALUES (6584, 'JAVIER', 'AGUILAR', 'SETIEN', '1967-03-20', 2003, 'useruser', '2015-02-09', 2);
INSERT INTO Docente (ID_docente, Nombre, Apellido_paterno, Apellido_materno, Fecha_de_nacimiento, Academia, Contrasena, Fecha_ingreso, Ocupacion) VALUES (1448, 'JOSE ANTONIO', 'AGUIRRE', 'CRUZ', '1966-09-17', 2004, 'useruser', '2009-05-30', 1);
INSERT INTO Docente (ID_docente, Nombre, Apellido_paterno, Apellido_materno, Fecha_de_nacimiento, Academia, Contrasena, Fecha_ingreso, Ocupacion) VALUES (6749, 'DANIEL', 'AGUIRRE', 'GARCIA', '1967-10-10', 2005, 'useruser', '2011-03-20', 1);
INSERT INTO Docente (ID_docente, Nombre, Apellido_paterno, Apellido_materno, Fecha_de_nacimiento, Academia, Contrasena, Fecha_ingreso, Ocupacion) VALUES (3258, 'JOSE LUIS', 'AGUIRRE', 'GAS', '1960-05-29', 2004, 'useruser', '2011-01-21', 1);
INSERT INTO Docente (ID_docente, Nombre, Apellido_paterno, Apellido_materno, Fecha_de_nacimiento, Academia, Contrasena, Fecha_ingreso, Ocupacion) VALUES (5921, 'FRANCISCO JAVIER', 'ALBERU', 'GOMEZ', '1968-03-11', 2004, 'useruser', '2015-03-20', 2);
INSERT INTO Docente (ID_docente, Nombre, Apellido_paterno, Apellido_materno, Fecha_de_nacimiento, Academia, Contrasena, Fecha_ingreso, Ocupacion) VALUES (4586, 'CARLOS', 'ALCANTAR', 'CURIEL', '1964-09-23', 2007, 'useruser', '2002-08-31', 1);
INSERT INTO Docente (ID_docente, Nombre, Apellido_paterno, Apellido_materno, Fecha_de_nacimiento, Academia, Contrasena, Fecha_ingreso, Ocupacion) VALUES (9875, 'JESUS', 'ALCARAZ', 'VERDUZCO', '1966-01-13', 2004, 'useruser', '2010-09-12', 1);
INSERT INTO Docente (ID_docente, Nombre, Apellido_paterno, Apellido_materno, Fecha_de_nacimiento, Academia, Contrasena, Fecha_ingreso, Ocupacion) VALUES (6967, 'ALEJANDRO', 'ALCOCER', 'VARELA', '1957-09-02', 2004, 'useruser', '2012-11-25', 1);
INSERT INTO Docente (ID_docente, Nombre, Apellido_paterno, Apellido_materno, Fecha_de_nacimiento, Academia, Contrasena, Fecha_ingreso, Ocupacion) VALUES (3519, 'MIGUEL', 'ALEXANDERSON', 'ROSAS', '1969-07-18', 2005, 'useruser', '2008-09-01', 2);
INSERT INTO Docente (ID_docente, Nombre, Apellido_paterno, Apellido_materno, Fecha_de_nacimiento, Academia, Contrasena, Fecha_ingreso, Ocupacion) VALUES (4369, 'JOSE MANUEL', 'ALMEDA', 'VALDES', '1969-01-30', 2001, 'useruser', '2003-08-30', 1);
INSERT INTO Docente (ID_docente, Nombre, Apellido_paterno, Apellido_materno, Fecha_de_nacimiento, Academia, Contrasena, Fecha_ingreso, Ocupacion) VALUES (7859, 'RAFAEL', 'ALONSO', 'VANEGAS', '1967-04-02', 2002, 'useruser', '2007-08-28', 1);
INSERT INTO Docente (ID_docente, Nombre, Apellido_paterno, Apellido_materno, Fecha_de_nacimiento, Academia, Contrasena, Fecha_ingreso, Ocupacion) VALUES (5963, 'MIGUEL ANGEL', 'ALONSO', 'VIVEROS', '1958-09-03', 2006, 'useruser', '2012-11-05', 2);
INSERT INTO Docente (ID_docente, Nombre, Apellido_paterno, Apellido_materno, Fecha_de_nacimiento, Academia, Contrasena, Fecha_ingreso, Ocupacion) VALUES (5896, 'PABLO', 'ALPUCHE', 'ARANDA', '1966-05-31', 2004, 'useruser', '2007-09-19', 1);
INSERT INTO Docente (ID_docente, Nombre, Apellido_paterno, Apellido_materno, Fecha_de_nacimiento, Academia, Contrasena, Fecha_ingreso, Ocupacion) VALUES (5847, 'PEDRO', 'ALVA', 'ESPINOSA', '1967-09-21', 2008, 'useruser', '2012-03-25', 1);
INSERT INTO Docente (ID_docente, Nombre, Apellido_paterno, Apellido_materno, Fecha_de_nacimiento, Academia, Contrasena, Fecha_ingreso, Ocupacion) VALUES (5874, 'ANGEL', 'ALVARADO', 'CABRERO', '1963-02-23', 2007, 'useruser', '2012-03-12', 2);
INSERT INTO Docente (ID_docente, Nombre, Apellido_paterno, Apellido_materno, Fecha_de_nacimiento, Academia, Contrasena, Fecha_ingreso, Ocupacion) VALUES (1234, 'SERGIO', 'ALVAREZ', 'CORDERO', '1958-01-26', 2008, 'useruser', '2011-01-17', 2);
INSERT INTO Docente (ID_docente, Nombre, Apellido_paterno, Apellido_materno, Fecha_de_nacimiento, Academia, Contrasena, Fecha_ingreso, Ocupacion) VALUES (5678, 'JOSE MARIA', 'ALVAREZ', 'DEL RIO', '1960-09-23', 2006, 'useruser', '2002-10-04', 1);
INSERT INTO Docente (ID_docente, Nombre, Apellido_paterno, Apellido_materno, Fecha_de_nacimiento, Academia, Contrasena, Fecha_ingreso, Ocupacion) VALUES (9856, 'FERNANDO', 'ALVAREZ', 'LEFFMANS', '1964-09-27', 2008, 'useruser', '2012-08-26', 1);
INSERT INTO Docente (ID_docente, Nombre, Apellido_paterno, Apellido_materno, Fecha_de_nacimiento, Academia, Contrasena, Fecha_ingreso, Ocupacion) VALUES (2574, 'JORGE', 'ALVAREZ', 'MALDONADO', '1962-03-22', 2006, 'useruser', '2004-01-08', 1);
INSERT INTO Docente (ID_docente, Nombre, Apellido_paterno, Apellido_materno, Fecha_de_nacimiento, Academia, Contrasena, Fecha_ingreso, Ocupacion) VALUES (6512, 'LUIS', 'ALVAREZ', 'NEMEGYEI', '1965-07-23', 2005, 'useruser', '2011-02-26', 1);
INSERT INTO Docente (ID_docente, Nombre, Apellido_paterno, Apellido_materno, Fecha_de_nacimiento, Academia, Contrasena, Fecha_ingreso, Ocupacion) VALUES (6532, 'ALBERTO', 'AMATO', 'MARTÍNEZ', '1969-05-13', 2003, 'useruser', '2010-09-27', 1);
INSERT INTO Docente (ID_docente, Nombre, Apellido_paterno, Apellido_materno, Fecha_de_nacimiento, Academia, Contrasena, Fecha_ingreso, Ocupacion) VALUES (3619, 'ALVARO', 'AMIGO', 'CASTANEDA', '1966-05-17', 2006, 'useruser', '2014-05-31', 1);
INSERT INTO Docente (ID_docente, Nombre, Apellido_paterno, Apellido_materno, Fecha_de_nacimiento, Academia, Contrasena, Fecha_ingreso, Ocupacion) VALUES (9173, 'JUAN CARLOS', 'ARROYO', 'DIAZ', '1959-08-02', 2007, 'useruser', '2013-06-05', 1);
INSERT INTO Docente (ID_docente, Nombre, Apellido_paterno, Apellido_materno, Fecha_de_nacimiento, Academia, Contrasena, Fecha_ingreso, Ocupacion) VALUES (1793, 'ADRIAN', 'GRACIA', 'ALVARADO', '1959-01-04', 2005, 'useruser', '2005-08-10', 1);

-- Table: Log_in
CREATE TABLE Log_in (ID_usuario INT (4) NOT NULL, Contrasena VARCHAR (8) NOT NULL, Usuario INTEGER NOT NULL, PRIMARY KEY (Usuario), FOREIGN KEY (ID_usuario) REFERENCES Docente (ID_docente));
INSERT INTO Log_in (ID_usuario, Contrasena, Usuario) VALUES (1528, 'useruser', 1);
INSERT INTO Log_in (ID_usuario, Contrasena, Usuario) VALUES (1459, 'useruser', 2);
INSERT INTO Log_in (ID_usuario, Contrasena, Usuario) VALUES (1337, 'useruser', 3);
INSERT INTO Log_in (ID_usuario, Contrasena, Usuario) VALUES (1719, 'useruser', 4);
INSERT INTO Log_in (ID_usuario, Contrasena, Usuario) VALUES (2565, 'useruser', 5);
INSERT INTO Log_in (ID_usuario, Contrasena, Usuario) VALUES (2428, 'useruser', 6);
INSERT INTO Log_in (ID_usuario, Contrasena, Usuario) VALUES (6584, 'useruser', 7);
INSERT INTO Log_in (ID_usuario, Contrasena, Usuario) VALUES (1448, 'useruser', 8);
INSERT INTO Log_in (ID_usuario, Contrasena, Usuario) VALUES (6749, 'useruser', 9);
INSERT INTO Log_in (ID_usuario, Contrasena, Usuario) VALUES (3258, 'useruser', 10);
INSERT INTO Log_in (ID_usuario, Contrasena, Usuario) VALUES (5921, 'useruser', 11);
INSERT INTO Log_in (ID_usuario, Contrasena, Usuario) VALUES (4586, 'useruser', 12);
INSERT INTO Log_in (ID_usuario, Contrasena, Usuario) VALUES (9875, 'useruser', 13);
INSERT INTO Log_in (ID_usuario, Contrasena, Usuario) VALUES (6967, 'useruser', 14);
INSERT INTO Log_in (ID_usuario, Contrasena, Usuario) VALUES (3519, 'useruser', 15);
INSERT INTO Log_in (ID_usuario, Contrasena, Usuario) VALUES (4369, 'useruser', 16);
INSERT INTO Log_in (ID_usuario, Contrasena, Usuario) VALUES (7859, 'useruser', 17);
INSERT INTO Log_in (ID_usuario, Contrasena, Usuario) VALUES (5963, 'useruser', 18);
INSERT INTO Log_in (ID_usuario, Contrasena, Usuario) VALUES (5896, 'useruser', 19);
INSERT INTO Log_in (ID_usuario, Contrasena, Usuario) VALUES (5847, 'useruser', 20);
INSERT INTO Log_in (ID_usuario, Contrasena, Usuario) VALUES (5874, 'useruser', 21);
INSERT INTO Log_in (ID_usuario, Contrasena, Usuario) VALUES (1234, 'useruser', 22);
INSERT INTO Log_in (ID_usuario, Contrasena, Usuario) VALUES (5678, 'useruser', 23);
INSERT INTO Log_in (ID_usuario, Contrasena, Usuario) VALUES (9856, 'useruser', 24);
INSERT INTO Log_in (ID_usuario, Contrasena, Usuario) VALUES (2574, 'useruser', 25);
INSERT INTO Log_in (ID_usuario, Contrasena, Usuario) VALUES (6512, 'useruser', 26);
INSERT INTO Log_in (ID_usuario, Contrasena, Usuario) VALUES (6532, 'useruser', 27);
INSERT INTO Log_in (ID_usuario, Contrasena, Usuario) VALUES (3619, 'useruser', 28);
INSERT INTO Log_in (ID_usuario, Contrasena, Usuario) VALUES (9173, 'useruser', 29);
INSERT INTO Log_in (ID_usuario, Contrasena, Usuario) VALUES (1793, 'useruser', 30);

-- Table: Permiso
CREATE TABLE Permiso(
	Matricula INT(4) PRIMARY KEY NOT NULL,
	Nombre VARCHAR(40) NOT NULL,
	Apellido_paterno VARCHAR(40) NOT NULL,
	Apellido_materno VARCHAR(40) NOT NULL,
	Fecha_permiso date NOT NULL,
	Fecha_inicio date NOT NULL,
	Fecha_termino date NOT NULL,
	Horario time,
	Estado BINARY NOT NULL,
	Id_permiso TINYINT(4) NOT NULL,
	Motivo VARCHAR(200) NOT NULL,
	Cantidad_permisos SMALLINT(4) NOT NULL,
	FOREIGN KEY(Id_permiso) REFERENCES Tipo_permiso(ID_permiso)
);

-- Table: Permiso_Docente
CREATE TABLE Permiso_Docente(
	Numero INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
	Permiso INT(4) NOT NULL,
	Docente INT(4) NOT NULL,
	FOREIGN KEY(Permiso) REFERENCES Permiso(Matricula),
	FOREIGN KEY(Docente) REFERENCES Docente(ID_docente)
);

-- Table: Plantel
CREATE TABLE "Plantel" (
	"ID_plantel"	SMALLINT(6) NOT NULL,
	"Nombre"	VARCHAR(40) NOT NULL,
	PRIMARY KEY("ID_plantel")
);
INSERT INTO Plantel (ID_plantel, Nombre) VALUES (1256, 'Alabama');
INSERT INTO Plantel (ID_plantel, Nombre) VALUES (1257, 'Mississippi');
INSERT INTO Plantel (ID_plantel, Nombre) VALUES (1258, 'California');

-- Table: Tipo_permiso
CREATE TABLE Tipo_permiso(
	ID_permiso TINYINT(4) PRIMARY KEY NOT NULL,
	Nombre VARCHAR(40) NOT NULL
);
INSERT INTO Tipo_permiso (ID_permiso, Nombre) VALUES (1, 'Cumpleanios');
INSERT INTO Tipo_permiso (ID_permiso, Nombre) VALUES (2, 'Permiso por 2 horas');
INSERT INTO Tipo_permiso (ID_permiso, Nombre) VALUES (3, 'Dia(s) economicos');

-- Table: Tipo_usuario
CREATE TABLE Tipo_usuario(
	ID INTEGER PRIMARY KEY AUTOINCREMENT,
	Nombre VARVHAR(40)
);
INSERT INTO Tipo_usuario (ID, Nombre) VALUES (1, 'Docente');
INSERT INTO Tipo_usuario (ID, Nombre) VALUES (2, 'Coordinador');

COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
