create database livraria;
use livraria;

create table editoras
(
	id integer not null primary key identity,
	nome varchar(60) not null
)

create table autores
(
	id integer not null primary key identity,
	nome varchar(50) not null,
	nacionalidade varchar(40)
)

create table categorias
(
	id integer primary key not null identity,
	nome varchar(50) not null
)

create table livros
(
	isbn varchar(22) primary key not null,
	titulo varchar(50) not null,
	ano integer not null,
	fk_editora integer not null,
	fk_categoria integer not null,
	foreign key (fk_editora) references editoras(id),
	foreign key (fk_categoria) references categorias(id)
)

create table livro_autor
(
	id integer not null primary key identity,
	fk_livro varchar(22) not null,
	fk_autor integer not null,
	foreign key (fk_livro) references livros(isbn),
	foreign key (fk_autor) references autores(id)
)


select * from livros;
select * from categorias;

select nome from categorias;

insert into categorias (nome)
values('Terror');

insert into categorias (nome)
values('Comédia');

insert into categorias (nome)
values('Romance');

insert into editoras
values('Rocco');

insert into editoras
values('Darkside');

select * from editoras;

insert into autores (nome)
values('Fernando Pessoa');

insert into autores (nome, nacionalidade)
values('Carlos Drummond','Brasileiro');

select * from autores;


insert into livros(isbn, titulo, ano, fk_editora, fk_categoria)
values('4561237412','Livro 1', 1922,2,1)

select * from livros;

update autores
set nome = 'Machado de Assis'
where id = 2;

select * from autores;

/*
udate livros set fk_categoria = 3
where ano > 1950
*/

delete from categorias where id = 4;

delete from categorias where id = 1;