CREATE DATABASE bitacora;

CREATE TABLE estudiantes (
	estudiante INT(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
	nombre VARCHAR(35) NOT NULL
);	

CREATE TABLE bitacora (
	bitacora INT(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
	accion VARCHAR(100) NOT NULL
);

INSERT INTO estudiantes VALUES (NULL, "Pedro Porro"), (NULL, "Jaime Garcia"), (NULL, "Luis Torres");

SELECT * FROM bitacora;