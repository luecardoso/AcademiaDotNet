--drop database catalogo;
create database catalogo;
use catalogo;

create table grupo
(
	id integer not null primary key identity,
	nome varchar(30) not null
);

create table cientista
(
	id integer not null primary key identity,
	nome varchar(50) not null,
	nacionalidade varchar(35)
);

create table era
(
	id integer not null primary key identity,
	nome varchar(20) not null,
	inicio_era integer,
	fim_era integer
);

create table dinossauro
(
	ID integer not null primary key identity,
	nome varchar(50) not null,
	toneladas integer,
	ano_descoberta varchar(4) not null,
	pais_descoberto varchar(20),
	/*
	era varchar(20) not null,
	inicio_era integer,
	fim_era integer,
	*/
	fk_grupo integer not null,
	foreign key(fk_grupo) references grupo(id),
	fk_descobridor integer not null,
	foreign key(fk_descobridor) references cientista(id),
	fk_era integer not null,
	foreign key(fk_era) references era(id)
);

insert into grupo (nome)
values ('Anquilossauros'),
		('Ceratopsídeos'),
		('Estegossauros'),
		('Terápodes');

select * from grupo;

insert into era (nome,inicio_era, fim_era)
values ('Cretácio',145,63),
		('Jurássico',205,142);


select * from era;