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
            
--9
SELECT DNI FROM cliente
INNER JOIN ventas ON DNI = DNI_cliente
INNER JOIN coche ON coche.codigo = ventas.codigo_coche
INNER JOIN concesionario ON CIF = cif_concesionario
WHERE EXISTS (SELECT * FROM concesionario 
              WHERE CIF = '0001');
    
--10
SELECT DNI FROM cliente
WHERE cliente.ciudad = (SELECT MAX(concesionario.ciudad) FROM concesionario);


--11
SELECT C1.nombre, C1.apellidos FROM cliente C1
WHERE C1.DNI IN (SELECT DISTINCT C2.DNI FROM cliente C2
                INNER JOIN ventas V2 ON C2.DNI = V2.DNI_cliente
                INNER JOIN coche CO ON CO.codigo = V2.codigo_coche
                WHERE V2.color = 'rojo') 
AND C1.DNI IN (SELECT DISTINCT C3.DNI FROM cliente C3
                INNER JOIN ventas V3 ON C3.DNI = V3.DNI_cliente
                INNER JOIN coche C3 ON C3.codigo = V3.codigo_coche
                WHERE V3.color = 'blanco');


--12
SELECT concesionario.nombre, AVG(cantidad) AS MEDIA FROM distribucion
INNER JOIN concesionario ON CIF = CIF_concesionario
GROUP BY concesionario.nombre;

--13
SELECT CIF FROM concesionario 
INNER JOIN distribucion ON CIF = cif_concesionario
GROUP BY CIF
HAVING AVG(cantidad) = (SELECT * FROM (
                            SELECT AVG(cantidad) AS MEDIA FROM distribucion
                            INNER JOIN concesionario ON CIF = CIF_concesionario
                            WHERE ciudad NOT LIKE Upper('Madrid')
                            GROUP BY concesionario.nombre
                            ORDER BY AVG(cantidad) DESC)
                        resultSet
                        WHERE ROWNUM=1);


--14
SELECT COUNT(*), concesionario.CIF AS CIF FROM concesionario
INNER JOIN ventas ON CIF = CIF_CONCESIONARIO
GROUP BY CIF 
ORDER BY COUNT(*) DESC;

--15
SELECT DNI, COUNT(*) FROM cliente
INNER JOIN ventas ON DNI = DNI_cliente
GROUP BY DNI
HAVING COUNT (*) > 1;