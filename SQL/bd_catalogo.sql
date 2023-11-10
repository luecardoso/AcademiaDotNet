--drop database catalogo;
create database catalogo;
use catalogo;

create table grupo
(
	ID integer not null primary key,
	nome varchar(20) not null
)

create table cientista
(
	ID integer not null primary key,
	nome varchar(50) not null,
	nacionalidade varchar(35)
)

/*
create table era
(
	ID integer not null primary key,
	nome varchar(20) not null,
	inicio_era integer,
	fim_era integer
)
*/
create table dinossauro
(
	nome varchar(50) not null,
	toneladas integer,
	ano_descoberta varchar(4) not null,
	pais_descoberto varchar(20),
	era varchar(20) not null,
	inicio_era integer,
	fim_era integer,
	fk_grupo integer not null,
	foreign key(fk_grupo) references grupo(ID),
	fk_descobridor integer not null,
	foreign key(fk_descobridor) references cientista(ID)
)