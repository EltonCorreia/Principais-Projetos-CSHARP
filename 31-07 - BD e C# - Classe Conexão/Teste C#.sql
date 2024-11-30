-- BD para C#

-- Criar BD para conectar ao C#:

	--txtNome.Text = ds.tables[].Rows[0][1].ToString();
	--txtNome.Text = dt.rows[0][1].ToString();

----------------------------------------------------------------------

create database Teste
go
use Teste
go

create table contatos1
(
id int primary key identity,
nome varchar(100),
fone varchar(20)
)

create table contatos2
(
id int primary key identity,
nome varchar(100),
fone varchar(20)
)

insert into contatos1 values ('ETESP','111')
insert into contatos1 values ('Teste2','222')
insert into contatos1 values ('Teste3','333')

