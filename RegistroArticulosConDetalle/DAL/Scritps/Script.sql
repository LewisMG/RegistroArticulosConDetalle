CREATE DATABASE ArticulosDb
GO
USE ArticulosDb
GO
CREATE TABLE Articulos
(
	ArticuloId int primary key identity(1,1),
	FechaVencimiento date,
	Descripcion varchar(40),
	Precio money,
	Existencia int,
	CantCotizada int,
);

