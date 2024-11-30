use master
drop database Teste

create database Teste
go
use Teste
go
create table contatos
(
	id int primary key identity,
	nome varchar(80),
	senha varchar(20),
	endereco varchar(100),
	cargo varchar(100)
)
insert into contatos values('admin','123','Rua dos Bobos','Advogado')

select * from contatos