-- Teste BD para login e registro da Zelar:

-- O BD consiste em colunas de user e senha;

create database teste
go
use teste
go

create table testelogin
(
usuario varchar(60),
senha varchar(60)
)

select*from testelogin