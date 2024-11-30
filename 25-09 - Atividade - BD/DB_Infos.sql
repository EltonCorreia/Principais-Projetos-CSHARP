USE MASTER
DROP DATABASE infos

CREATE DATABASE infos
GO
USE infos
GO

CREATE TABLE contatos
(
id INT PRIMARY KEY IDENTITY,
nome VARCHAR (100),
fone VARCHAR (100),
status CHAR (1),
data_inc DATE,
valor decimal (10,2)
)
GO

SELECT * FROM contatos

