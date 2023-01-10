--comando para criar um banco de dados
CREATE DATABASE uc9SA3PBE10

--comando para usar o banco de dados criado
USE uc9SA3PBE10

--comandos para criar uma tabela
CREATE TABLE Usuarios(
Id INT PRIMARY KEY IDENTITY,
Email VARCHAR(50) UNIQUE NOT NULL,
Senha VARCHAR(50) NOT NULL
)

--comando para inserir usuarios dentro de uma tabela
INSERT INTO Usuarios VALUES('adriano@gmail.com', 'admin1234')
INSERT INTO Usuarios VALUES('gustavo@gmail.com', 'admin1234')
INSERT INTO Usuarios VALUES('marlon@gmail.com', 'admin1234')

--comandos para consutar dados de uma tabela
SELECT * FROM Usuarios 

--comandos para consutar dados de uma tabela usando a funcao de hashbytes
--nesse exemplo vamos fazer um hash da senha cadastrada
SELECT Email, HASHBYTES('MD2', Senha) AS Senha FROM Usuarios
SELECT Email, HASHBYTES('MD4', Senha) AS Senha FROM Usuarios
SELECT Email, HASHBYTES('MD5', Senha) AS Senha FROM Usuarios
SELECT Email, HASHBYTES('SHA', Senha) AS Senha FROM Usuarios
SELECT Email, HASHBYTES('SHA2_256', Senha) AS Senha FROM Usuarios
SELECT Email, HASHBYTES('SHA2_512', Senha) AS Senha FROM Usuarios

--comandos para consutar com condicional
--dados de apenas um usuario dentro da tabela
SELECT Email, HASHBYTES('SHA2_512', Senha) AS Senha FROM Usuarios WHERE ID = 1

--comando para consultar usando a funcao PWDEncrypt (senhas iguais geram hashes diferentes)
SELECT Email, PWDENCRYPT(Senha) AS Senha FROM Usuarios

