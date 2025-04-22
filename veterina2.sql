------ Creacion de mi base de datos con el nombre de veterinaria
Begin
    Create database VETERINARIA
END
GO

------ Ponemos en uso la Base de  datos
 Use VETERINARIA;
 Go
 
 ------ Creacion de mis tablas
CREATE TABLE USUARIOS (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Usuario VARCHAR(50) UNIQUE NOT NULL,
    Contraseña VARBINARY(64) NOT NULL,  -- Se almacena la contraseña encriptada
    TipoUsuario VARCHAR(20) NOT NULL DEFAULT 'Empleado' -- Puede ser 'Empleado' o 'Jefe'
);

CREATE TABLE Clientes (
    IdCliente INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(255),
    ApellidoPaterno VARCHAR(255),
    ApellidoMaterno VARCHAR(255),
    Telefono VARCHAR(20),
    CorreoElectronico VARCHAR(255) ,
    Genero VARCHAR(10),
    Edad INT,
    EstadoCivil VARCHAR(50)
);

CREATE TABLE Mascotas (
    ID INT PRIMARY KEY IDENTITY(1,1),
    NombreMascota Varchar(255),
	TipoMascota VARCHAR(20),
    Sexo VARCHAR(10),
    Raza VARCHAR(50),
    Peso DECIMAL(5, 2),
    Edad INT,
    Vacunas BIT,
    TiposVacunas VARCHAR(255),
    EnfermedadesCronicas VARCHAR(255),
    Alergias BIT,
    TiposAlergias VARCHAR(255)
);

CREATE TABLE ProductosServicios (
    ID INT PRIMARY KEY IDENTITY(1,1),
    CorteCabello BIT NOT NULL CHECK (CorteCabello IN (0, 1)),
    RecorteUnas BIT NOT NULL CHECK (RecorteUnas IN (0, 1)),
    Alimentacion BIT NOT NULL CHECK (Alimentacion IN (0, 1)),
    DetalleAlimentacion VARCHAR(255),
    AseoSaludable BIT NOT NULL CHECK (AseoSaludable IN (0, 1)),
    MasajeCorporal BIT NOT NULL CHECK (MasajeCorporal IN (0, 1))
);


------ Insertar valores a mis tablas con la contraseña encriptado 
INSERT INTO USUARIOS (Usuario, Contraseña)  
VALUES 
('Jesus', HASHBYTES('SHA2_256', '12345'));

------ Ver mi tabla con los registros
SELECT ID, Usuario, Contraseña,TipoUsuario FROM USUARIOS;

SELECT * FROM Clientes
SELECT * FROM USUARIOS
SELECT * FROM Mascotas --- El Bit (1 = Sí, 0 = No)
SELECT * FROM ProductosServicios --- El Bit (1 = Sí, 0 = No)


---- Eliminar Tabla
--- Drop Table Mascotas

---- Eliminar un Usuario en especifico
--- DELETE FROM USUARIOS WHERE Usuario = 'Jesus';


----- Ver a un usuario en especifico 
--- SELECT * FROM USUARIOS WHERE Usuario = 'Vanesa' AND Contraseña = HASHBYTES('SHA2_256', '2468');






