## Miguel Ángel Bustamante 1-DAM

## EXAMEN SQL 2 PARTE - 2º EVALUACIÓN

## Ejercicio 9

SELECT nombre, matricula FROM repartidor WHERE CodigoPostal BETWEEN 46001 AND 46004;

## Ejercicio 10

SELECT c.nombre_apellido AS Nombre, c.email AS Email FROM cliente c
INNER JOIN zona z INNER JOIN repartidor r ON c.CodigoPostal = z.CodigoPostal AND z.CodigoPostal = r.CodigoPostal
WHERE r.Nombre = 'ANDRES';

## Ejercicio 11

SELECT Categoria, AVG(Peso) AS PesoMedio FROM producto GROUP BY categoria ORDER BY AVG(peso) DESC;

## Ejercicio 12

SELECT Nombre , AVG(Precio) AS PrecioMedio FROM producto WHERE categoria LIKE 'C%' GROUP BY Nombre;

## Ejercicio 13

DELETE FROM repartidor WHERE CodigoPostal IN(SELECT CodigoPostal FROM zona WHERE Nombre = 'OESTE'); 

## Ejercicio 14

UPDATE cliente SET psd = 666 WHERE nombre_apellido = 'JUANITO';

## Ejercicio 15

DELETE FROM cliente WHERE CodigoPostal NOT BETWEEN 46001 AND 46004;

## Ejercicio 16

SHOW TABLES FROM supermercado;
SHOW CREATE TABLE pedido;