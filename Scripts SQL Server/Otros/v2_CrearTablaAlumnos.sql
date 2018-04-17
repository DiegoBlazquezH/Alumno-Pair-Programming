USE AlumnosDB;

CREATE TABLE Alumnos(
UUID nvarchar(38),
ID int identity(1,1),
Nombre nvarchar(50),
Apellido nvarchar(50),
DNI nvarchar(10),
FechaNacimiento nvarchar(50),
Edad int,
FechaRegistro nvarchar(50),
PRIMARY KEY (UUID, ID)
);