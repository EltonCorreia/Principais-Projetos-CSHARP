use master
drop database deposito

create database deposito
go
use deposito
go

create table f1
(
id int primary key identity,
descricao varchar(100),
lugar varchar(100)
)

insert into f1 values ('Martelo','Andar - 1')
insert into f1 values ('Parafusadeira','Andar - 2')
insert into f1 values ('Serra','Andar - 3')

select * from f1
