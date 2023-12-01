drop database mini_erp;
create database mini_erp;
use mini_erp;

create table categoria
(
	id integer primary key identity,
	nome varchar(50) not null
);

create table fornecedor
(
	id integer primary key identity,
	nome varchar(50) not null
);

create table produto
(
	id integer primary key identity,
	nome varchar(60) not null,
	quantidade int not null,
	descricao varchar(200),
	preco float not null,
	fk_categoria integer not null,
	foreign key(fk_categoria) references categoria(id),
	fk_fornecedor integer not null,
	foreign key(fk_fornecedor) references fornecedor(id)
);

create table cliente
(
	id integer primary key identity,
	nome varchar(60) not null,
	dataNascimento varchar(10),
	telefone varchar(16),
	sexo varchar(15)
)


--criacao de usuario e senha
create login usuario3 with password='senha1234';
--adicionando usuario ao banco
create user usuario3 from login usuario3;
--adicionando permissões do usuáio no banco
exec sp_addrolemember 'DB_DATAREADER', 'usuario3';
exec sp_addrolemember 'DB_DATAWRITER', 'usuario3';

select * from cliente;