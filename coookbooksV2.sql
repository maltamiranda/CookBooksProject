CREATE DATABASE  IF NOT EXISTS cookbooks;
USE cookbooks;

DROP TABLE IF EXISTS autores;
DROP TABLE IF EXISTS libros;
DROP TABLE IF EXISTS libro_autor;
DROP TABLE IF EXISTS usuarios;
DROP TABLE IF EXISTS compra;
DROP TABLE IF EXISTS libroCompra;

CREATE TABLE autores (
  idautor int(11) NOT NULL AUTO_INCREMENT,
  nombre varchar(45) DEFAULT NULL,
  apellido varchar(45) DEFAULT NULL,
  nacionalidad varchar(45) DEFAULT NULL,
  PRIMARY KEY (idautor)
);


CREATE TABLE libros (
  idlibros int(11) NOT NULL AUTO_INCREMENT,
  nombre varchar(45) DEFAULT NULL,
  tema varchar(45) DEFAULT NULL,
  editorial varchar(45) DEFAULT NULL,
  precio int(11) DEFAULT NULL,
  cantidad int(11) DEFAULT NULL,
  fecha_ingreso datetime DEFAULT NULL,
  PRIMARY KEY (idlibros)
);


CREATE TABLE libro_autor (
  idlibro_autor int(11) NOT NULL AUTO_INCREMENT,
  idLibro int(11) DEFAULT NULL,
  idAutor int(11) DEFAULT NULL,
  PRIMARY KEY (idlibro_autor),
  KEY id_libro_idx (idLibro),
  KEY id_autor_idx (idAutor),
  CONSTRAINT id_libro FOREIGN KEY (idLibro) REFERENCES libros (idlibros) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT id_autor FOREIGN KEY (idAutor) REFERENCES autores (idautor) ON DELETE NO ACTION ON UPDATE NO ACTION
);

CREATE TABLE privilegios(
	id INT auto_increment,
	nombre TEXT not null,
	PRIMARY KEY(id)
);

CREATE TABLE usuarios (
	user VARCHAR(12) not null,
	pw TEXT not null,
	mail TEXT not null,
	direccion TEXT not null,
	idPriv int not null,
	PRIMARY KEY (user),
	FOREIGN KEY (idPriv) REFERENCES privilegios (id)
);

DROP TABLE IF EXISTS compra;
CREATE TABLE compra (
	id INT AUTO_INCREMENT,
	user VARCHAR(12) NOT NULL,
	importe decimal(6,2),
	PRIMARY KEY (id),
	FOREIGN KEY (user) REFERENCES usuarios (user)
);

DROP TABLE IF EXISTS libroCompra;
CREATE TABLE libroCompra (
	idCompra INT NOT NULL,
	idLibro INT NOT NULL,
	cantidad INT,
	PRIMARY KEY (idCompra, idLibro),
	FOREIGN KEY (idCompra) REFERENCES compra (id),
	FOREIGN KEY (idLibro) REFERENCES libros (idLibros)
);