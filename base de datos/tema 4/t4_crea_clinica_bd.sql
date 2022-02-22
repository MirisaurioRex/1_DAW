-- creamos el tablespace
CREATE SMALLFILE TABLESPACE "veterinariBD" 
DATAFILE 'F:\Users\Miri-chan\Downloads\oradata\XE\veterinari.dbf' SIZE 100M 
LOGGING EXTENT MANAGEMENT LOCAL SEGMENT SPACE MANAGEMENT AUTO;

--creamos el usuario que trabajará con esta BD
ALTER SESSION SET "_ORACLE_SCRIPT"=true;
CREATE USER vet IDENTIFIED BY vet DEFAULT TABLESPACE "veterinariBD" QUOTA UNLIMITED ON "veterinariBD"
TEMPORARY TABLESPACE "TEMP";
--comprobamos que se ha creado bien.
SELECT * FROM all_users ORDER BY created DESC;
--le damos todos los permisos al usuario vet
GRANT CONNECT, RESOURCE, CREATE VIEW, CREATE SYNONYM TO vet;

--creamos la tabla sala
CREATE TABLE sala (
    sal_numero NUMBER NOT NULL CHECK(sal_numero > 0),
    sal_descripcion NVARCHAR2(200),
    CONSTRAINT pk_sala PRIMARY KEY (sal_numero)
);

--cremos la tabla cliente
CREATE TABLE cliente (
	cli_id NUMBER GENERATED ALWAYS AS IDENTITY,
	cli_nombre NVARCHAR2(100),
	cli_tlf NUMBER(9),
	cli_direccion NVARCHAR2(100),
	cli_email NVARCHAR2(50),
	CONSTRAINT pk_cliente PRIMARY KEY(cli_id)
);

--creamos la tabla veterinario
CREATE TABLE veterinario (
	vet_id NUMBER GENERATED ALWAYS AS IDENTITY,
	vet_dni VARCHAR(9) NOT NULL CHECK (vet_dni = UPPER(vet_dni)),
	vet_nombre NVARCHAR2(100),
	vet_tlf NUMBER(9),
	vet_autonomo NUMBER(1) DEFAULT '0',
	vet_fecha_incorporacion DATE DEFAULT CURRENT_DATE,
	CONSTRAINT pk_veterinario PRIMARY KEY(vet_id),
	CONSTRAINT uk_dni UNIQUE(vet_dni)
);

--creamos la tabla mascota
CREATE TABLE mascota (
	mas_id_cliente NUMBER(9) NOT NULL,
	mas_numero NUMBER(9) NOT NULL CHECK(mas_numero > 0),
	mas_nombre NVARCHAR2(100),
	mas_fecha_nacimiento DATE,
	CONSTRAINT pk_mascota PRIMARY KEY(mas_id_cliente, mas_numero),
	CONSTRAINT fk_id_cliente 
	FOREIGN KEY(mas_id_cliente) REFERENCES cliente(cli_id) ON DELETE CASCADE
);

--creamos la tabla atiende
CREATE TABLE atiende (
	ati_id_veterinario NUMBER(9) NOT NULL,
	ati_numero_sala NUMBER NOT NULL,
	ati_id_cliente NUMBER(9) NOT NULL,
	ati_numero_mascota NUMBER(9) NOT NULL,
	ati_fecha_cita DATE NOT NULL,
	CONSTRAINT pk_atiende PRIMARY KEY(ati_id_veterinario, ati_numero_sala,
	ati_id_cliente, ati_numero_mascota),
	CONSTRAINT fk_id_veterinario 
	FOREIGN KEY(ati_id_veterinario) REFERENCES veterinario(vet_id) ON DELETE CASCADE,
	CONSTRAINT fk_numero_sala 
	FOREIGN KEY(ati_numero_sala) REFERENCES sala(sal_numero),
	CONSTRAINT fk_numero_mascota
	FOREIGN KEY(ati_id_cliente, ati_numero_mascota) REFERENCES mascota(mas_id_cliente, mas_numero) ON DELETE CASCADE
);

--vaciado de tablas
DELETE FROM cliente;
DELETE FROM veterinario;
DELETE FROM sala;

--creamos los índices para fecha_cita y cliente_nombre
CREATE INDEX ix_atiende_fecha_cita ON atiende (ati_fecha_cita);
CREATE INDEX ix_cliente_nombre ON cliente (cli_nombre);

--creamos la vista para ver los veterinarios que se incorporaron en 2019
CREATE VIEW v_veterinarios_2019 AS
SELECT vet_nombre, vet_fecha_incorporacion
FROM veterinario
WHERE vet_fecha_incorporacion = '2019-01-01';

--creamos un sinónimo para la tabla veterinario
CREATE SYNONYM veterinarios_clinica FOR veterinario;

--añadimos una columna más a la tabla cliente llamado "comentarios".
ALTER TABLE cliente ADD (cli_comentarios NVARCHAR2(1000) DEFAULT 'Sin comentarios');

--para cambiar la entrada de la fecha al formato ISO.
ALTER SESSION SET NLS_DATE_FORMAT = 'YYYY-MM-DD';

--añadimos 5 registros a la tabla sala
INSERT INTO sala (sal_numero, sal_descripcion) VALUES (1, 'gatos');
INSERT INTO sala (sal_numero, sal_descripcion) VALUES (2, 'perros');
INSERT INTO sala (sal_numero, sal_descripcion) VALUES (3, 'patos');
INSERT INTO sala (sal_numero, sal_descripcion) VALUES (4, 'vacas');
INSERT INTO sala (sal_numero, sal_descripcion) VALUES (5, 'periquitos');

--añadimos 5 registros a la tabla cliente
INSERT INTO cliente (cli_nombre, cli_tlf, cli_direccion, cli_email, cli_comentarios) VALUES ('Paco Soria', 111222333, 'Calle falsa, n1', 'ps@gmail.com', 'blabla');
INSERT INTO cliente (cli_nombre, cli_tlf, cli_direccion, cli_email, cli_comentarios) VALUES ('Maria Gutierrez', 222333444, 'Calle falsa, n2', 'mg@gmail.com', NULL);
INSERT INTO cliente (cli_nombre, cli_tlf, cli_direccion, cli_email, cli_comentarios) VALUES ('Bonifacio Cabrera', 333444555, 'Calle falsa, n3', 'bc@gmail.com', NULL);
INSERT INTO cliente (cli_nombre, cli_tlf, cli_direccion, cli_email, cli_comentarios) VALUES ('Gavina Gomez de Cadiz', 444555666, 'Calle falsa, n4', 'ggc@gmail.com', NULL);
INSERT INTO cliente (cli_nombre, cli_tlf, cli_direccion, cli_email, cli_comentarios) VALUES ('Random Vince', 555666777, 'Calle falsa, n5', 'rv@gmail.com', NULL);

--añadimos 5 registros a la tabla veterinario
INSERT INTO veterinario (vet_dni, vet_nombre, vet_tlf, vet_autonomo, vet_fecha_incorporacion) VALUES ('48717751W', 'Pepe', 123456789, 1, '2019-04-24');
INSERT INTO veterinario (vet_dni, vet_nombre, vet_tlf, vet_autonomo, vet_fecha_incorporacion) VALUES ('48717745L', 'Paco', 123456459, 0, '2020-04-24');
INSERT INTO veterinario (vet_dni, vet_nombre, vet_tlf, vet_autonomo, vet_fecha_incorporacion) VALUES ('48717746L', 'Pan', 123456458, 0, '2021-04-24');
INSERT INTO veterinario (vet_dni, vet_nombre, vet_tlf, vet_autonomo, vet_fecha_incorporacion) VALUES ('48717743L', 'Patricia', 124556458, 1, '2014-04-24');
INSERT INTO veterinario (vet_dni, vet_nombre, vet_tlf, vet_autonomo, vet_fecha_incorporacion) VALUES ('48717753L', 'Paloma', 124553458, 0, '2020-10-24');

--añadimos 5 registros a la tabla mascota
INSERT INTO mascota (mas_id_cliente, mas_numero, mas_nombre, mas_fecha_nacimiento) VALUES (2, 4, 'Conchi', '2000-04-10');
INSERT INTO mascota (mas_id_cliente, mas_numero, mas_nombre, mas_fecha_nacimiento) VALUES (1, 2, 'Chiqui', '2000-04-10');
INSERT INTO mascota (mas_id_cliente, mas_numero, mas_nombre, mas_fecha_nacimiento) VALUES (4, 1, 'Toby', '2010-04-10');
INSERT INTO mascota (mas_id_cliente, mas_numero, mas_nombre, mas_fecha_nacimiento) VALUES (4, 2, 'Tara', '2010-04-10');
INSERT INTO mascota (mas_id_cliente, mas_numero, mas_nombre, mas_fecha_nacimiento) VALUES (5, 4, 'Bob', '2010-04-10');

--añadimos 5 registros a la tabla atiende 
INSERT INTO atiende (ati_id_veterinario, ati_numero_sala, ati_id_cliente, ati_numero_mascota, ati_fecha_cita) VALUES (1, 1, 1, 1, '2022-01-26');
INSERT INTO atiende (ati_id_veterinario, ati_numero_sala, ati_id_cliente, ati_numero_mascota, ati_fecha_cita) VALUES (2, 2, 1, 2, '2022-01-26');
INSERT INTO atiende (ati_id_veterinario, ati_numero_sala, ati_id_cliente, ati_numero_mascota, ati_fecha_cita) VALUES (3, 3, 4, 1, '2022-01-26');
INSERT INTO atiende (ati_id_veterinario, ati_numero_sala, ati_id_cliente, ati_numero_mascota, ati_fecha_cita) VALUES (4, 1, 4, 2, '2022-01-26');
INSERT INTO atiende (ati_id_veterinario, ati_numero_sala, ati_id_cliente, ati_numero_mascota, ati_fecha_cita) VALUES (2, 5, 5, 4, '2022-01-26');
