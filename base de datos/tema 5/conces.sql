-- Tema 5 – Tarea evaluable concesionario
-- Miranda Azorín Vidal

--1 
SELECT codigo FROM coche WHERE codigo LIKE 'C%';

--2
SELECT CIF FROM concesionario
INNER JOIN distribucion ON CIF = cif_concesionario
WHERE cantidad>=10 AND cantidad<=18;

--3
SELECT codigo FROM coche
INNER JOIN distribucion ON codigo = codigo_coche
INNER JOIN concesionario ON CIF = cif_concesionario
WHERE Upper(ciudad) = 'BARCELONA';

--4
SELECT codigo FROM coche
INNER JOIN ventas ON codigo = codigo_coche
INNER JOIN concesionario ON CIF = cif_concesionario
WHERE Upper(ciudad) = 'MADRID';

--5
SELECT codigo FROM coche
INNER JOIN ventas ON codigo = codigo_coche
INNER JOIN concesionario ON CIF = cif_concesionario
INNER JOIN cliente ON DNI = DNI_cliente
WHERE Upper(cliente.ciudad)= Upper(concesionario.ciudad);

--6
SELECT cliente.nombre, cliente.apellidos FROM cliente
INNER JOIN ventas ON DNI = DNI_cliente
INNER JOIN coche ON coche.codigo = ventas.codigo_coche
INNER JOIN distribucion ON coche.codigo = distribucion.codigo_coche
WHERE cantidad>1 AND modelo LIKE '%GTI%';

--7
SELECT cliente.nombre, cliente.apellidos FROM cliente
WHERE DNI> (SELECT DNI FROM CLIENTE
            WHERE Upper(nombre) LIKE 'JUAN MARTIN');
            
--INSERT INTO CLIENTE VALUES ('37000000','Juan Martin','Esteve','Zaragoza');

--8
SELECT C1.nombre, C1.apellidos FROM cliente C1
WHERE C1.nombre LIKE 'A%' 
AND (C1.DNI> (SELECT MAX(C2.DNI) FROM cliente C2
            GROUP BY C2.ciudad 
            having C2.ciudad LIKE 'Madrid')
OR C1.DNI< (SELECT MIN(C3.DNI) FROM cliente C3
            GROUP BY C3.ciudad 
            HAVING C3.ciudad LIKE 'Valencia'));
