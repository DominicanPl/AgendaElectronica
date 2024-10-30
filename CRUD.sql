Create Database AgendaEDB

Use AgendaEDB

Create Table Contactos (
	ID INT Primary Key Identity(1,1),
	Nombre Nvarchar(50),
	Apellido Nvarchar(50),
	FechaNacimiento Date,
	Direccion Nvarchar(100),
	Genero Nvarchar(10),
	EstadoCivil Nvarchar(10),
	Movil Nvarchar(50),
	Telefono Nvarchar(15),
	Correo Nvarchar(50)
);



