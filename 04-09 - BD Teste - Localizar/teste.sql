
create database Teste
go
use Teste
go
create table contatos
(
	id int primary key identity,
	nome varchar(80),
	fone varchar(20)
)
insert into contatos values('ETESP','111')
insert into contatos values('Aluno2','222')
insert into contatos values('Aluno3','333')

select * from contatos