create database mini_erp;
use mini_erp;

create database categoria
(
	id integer primary key identity,
	nome varchar(50) not null,
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
	preco double not null,
	fk_categoria integer not null,
	foreign key(fk_categoria) references categoria(id),
	fk_fornecedor integer not null,
	foreign key(fk_fornecedor) references fornecedor(id)
);

create table cliente
(
	id integer primary key identity,
	nome varchar(60) not null,
	idade int,
	telefone varchar(12),
	sexo char check( sexo in ('F', 'M'))
)