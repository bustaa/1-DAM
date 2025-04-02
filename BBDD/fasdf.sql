CALL ej_rutina(20000);

SET @SUM = 0;
INSERT INTO t VALUES (550, 7);
INSERT INTO t VALUES (551, 12);
SELECT @SUM;

CREATE TABLE t_auditoria (
	id INT NOT NULL AUTO_INCREMENT,
	usuario VARCHAR(40),
	fecha DATETIME,
	PRIMARY KEY(id)
);

UPDATE t SET s1 = 999 WHERE c = 550;
SELECT * FROM t_auditoria;

INSERT INTO clientes VALUES (3000, "Toni", 103, 5);

INSERT INTO oficinas VALUES (210, "Alicante", "norte", 104, 0, 450);
INSERT INTO oficinas VALUES (211, "Valencia", "norte", 104, 150000, 600);