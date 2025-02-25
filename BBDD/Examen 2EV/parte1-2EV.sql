## Miguel Ángel Bustamante

## EXAMEN SQL 1 PARTE - 2ºEVALUACIÓN

## Ejercicio 1

CREATE DATABASE IF NOT EXISTS LIGA CHARACTER SET UTF8;

## Ejercicio 2

USE LIGA;

CREATE TABLE IF NOT EXISTS partidos (
	id_equipo_casa INT(2) PRIMARY KEY,
	id_equipo_fuera INT(2) PRIMARY KEY,
	fecha DATE PRIMARY KEY,
	goles_casa INT(2),
	goles_fuera INT(2),
	observaciones VARCHAR(200)
);

## Ejercicio 3

CREATE TABLE equipos(
	id_equipo INT(2),
	nombre VARCHAR(50),
	estadio VARCHAR(50),  
	aforo INT(6), 
	ano_fundacion INT(4), 
	ciudad VARCHAR(50),
	constraint pk_equipos PRIMARY KEY(id_equipo))
	ENGINE="INNODB";

CREATE TABLE jugadores (
	id_jugador INT(3),
	nombre VARCHAR(50),
	fecha_nac DATE, 
	demarcacion VARCHAR(50),  
	internacional INT(3),  
	id_equipo INT(2),
	CONSTRAINT pk_jugadores PRIMARY KEY(id_jugador),
	CONSTRAINT fk_jugadores FOREIGN KEY (id_equipo) REFERENCES equipos(id_equipo))
	ENGINE="INNODB";
	
## Ejercicio 4

ALTER TABLE partidos ADD hora_partidos DATETIME;

## Ejercicio 5

UPDATE equipos RENAME ano_fundacion = fundacion INT(4);

## Ejercicio 6

ALTER TABLE equipos ADD INDEX (estadio);

## Ejercicio 7

INSERT INTO equipos VALUES 
	(1, "Real Madrid", "Santiago Bernabéu", 80000, 1950, "Madrid"), 
	(2, "F.C. Barcelona", "Camp Nou", 70000, 1948, "Barcelona"), 
	(3, "Valencia C.F.", "Mestalla", 60000, 1952, "Valencia"), 
	(4, "Atlético de Madrid", "Vicente Calderón", 55000, 1945, "Madrid");



INSERT INTO jugadores VALUES 
	(1, "Iker Casillas", "1980-05-06", "Portero", 50, 1), 
	(2, "Ronaldo", "1974-07-07", "Delantero", 80, 1), 
	(3, "Zinedine Zidane", "1968-06-06", "Centrocampista", 75, 1), 
	(4, "Samuel Etoo", "1966-03-03", "Delantero", 75, 2), 
	(5, "Ronaldinho", "1979-05-05", "Centrocampista", 50, 2), 
	(6, "Deco", "1976-03-03", "Centrocampista", 25, 2), 
	(7, "Baraja", "1965-05-05", "Centrocampista", 40, 3), 
	(8, "Albelda", "1973-03-03", "Centrocampista", 40, 3), 
	(9, "Aimar", "1975-05-05", "Centrocampista", 35, 3), 
	(10, "Vicente", "1976-06-05", "Centrocampista", 20, 3);

INSERT INTO partidos VALUES 
	(1, 2, "2005-03-05", 2, 1, null,null), 
	(1, 3, "2005-04-04", 3, 1, null,null), 
	(2, 3, "2005-04-03", 0, 4, null,null);

## Ejercicio 8

INSERT INTO goles LOAD DATA OUTFILE 'C:\\Users\\mibucu\\Documents\\Examen SQL 2Ev\\goles.txt'
FIELDS TERMINATED BY '\n';
