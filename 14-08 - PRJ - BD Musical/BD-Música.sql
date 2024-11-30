-- BD para C#

-- Criar BD para conectar ao C#:

	--txtNome.Text = ds.tables[].Rows[0][1].ToString();
	--txtNome.Text = dt.rows[0][1].ToString();

----------------------------------------------------------------------

use master
drop database musical

create database musical
go
use musical
go

create table musica
(
id int primary key identity,
Descricao varchar(60),
Localizacao varchar(60)
)

insert into musica values ('Ana Frango El�trico - Me Chama de Gato Que Eu Sou Sua','Corredor 1 - Prateleira A1 - (MPB - Atualidades)')
insert into musica values ('Ana Frango El�trico - Little Eletric Chicken Heart','Corredor 1 - Prateleira A2 - (MPB - Atualidades)')
insert into musica values ('Ana Frango El�trico - Morma�o Queima','Corredor 1 - Prateleira A3 - (MPB - Atualidades)')

insert into musica values ('Quem � voc� Alice? - Rol� Trevas pt2','Corredor 2 - Prateleira B1 - (Midwest Nacional P�s-G�nero)')
insert into musica values ('Chocorn and the Sugarcanes - Siam�s','Corredor 2 - Prateleira B2 - (Midwest Nacional P�s-G�nero)')
insert into musica values ('N�o Ao Futebol Moderno - Vida Que Segue','Corredor 2 - Prateleira B3 - (Midwest Nacional P�s-G�nero)')

insert into musica values ('Lamp - Yume','Corredor 3 - Prateleira C1 - (Shibuya-Kei)')
insert into musica values ('Lamp - Tokyo Utopia Tsushin','Corredor 3 - Prateleira C2 - (Shibuya-Kei)')
insert into musica values ('Lamp - For Lovers','Corredor 3 - Prateleira C3 - (Shibuya-Kei)')

select * from musica
