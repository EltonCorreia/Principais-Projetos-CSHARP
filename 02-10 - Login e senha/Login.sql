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
	senha varchar(20)
)
insert into contatos values('admin','123')

select * from contatos