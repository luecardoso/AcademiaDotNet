create database ado_net;
use ado_net;

create table pessoas
(
	id integer primary key identity,
	nome varchar(50) not null,
	idade integer
)

--criacao de usuario e senha
create login adonet with password='senha1234';
--adicionando usuario ao banco
create user adonet from login adonet;
--adicionando permissões do usuáio no banco
exec sp_addrolemember 'DB_DATAREADER', 'adonet';
exec sp_addrolemember 'DB_DATAWRITER', 'adonet';

insert into pessoas 
values('Lucas',23),
	  ('Felipe',25);

select * from pessoas;