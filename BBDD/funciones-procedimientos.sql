CALL hola_mundo();
CALL r1(56);

SELECT r2(25);

SELECT suma(20, 10);
SELECT resta(30, 10);
SELECT longconcat('hola', 'adios');

CALL proc2(7);
SELECT @X;

CALL proc3(@Y);
SELECT @Y;

SET @z = 10;
CALL proc4(@z);
SELECT @z;

SELECT hipotenusa(10.2, 13.4);

SELECT estado('P');

SELECT es_impar(5);
SELECT es_par(4);

CALL muestra_estado(4);

CREATE TABLE t (
	c INT PRIMARY KEY,
	s1 INT
);

INSERT INTO t VALUES (0, 20);

CALL proc7(2);
CALL proc7(-1);
CALL proc8(-1);
CALL proc8(4);

SELECT actividad2(3, 5, 2);

CALL proc9();
CALL proc10(100);

CALL proc11(6);

CALL actividad3(10);

SELECT ASCII('h');
SELECT CHAR(105);

CALL actividad3_2("hola", @X);
SELECT @X;

CALL actividad3_2_2("hola", 2, @X);
SELECT @X;

CALL descifrar("ipmb", @x);
SELECT @X;

SELECT encriptar("Hola");


