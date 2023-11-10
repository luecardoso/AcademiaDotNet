create database biblioteca;
use biblioteca;

create table editora
(
	ID integer primary key not null identity,
	nome varchar(30) not null
)

create table autor
(
	ID integer primary key not null identity,
	nome varchar(30) not null,
	nacionalidade varchar(30)
)

create table categoria
(
	ID integer primary key not null identity,
	nome varchar(30) not null
)

create table livro
(
	ID integer primary key not null identity,
	ISBN varchar(14) not null,
	titulo varchar(40) not null,
	ano varchar(4),
	fk_editora integer not null,
	foreign key (fk_editora) references editora(ID),
	fk_autor integer not null,
	foreign key (fk_autor) references autor(ID),
	fk_categoria integer not null,
	foreign key (fk_categoria) references categoria(ID)
)

