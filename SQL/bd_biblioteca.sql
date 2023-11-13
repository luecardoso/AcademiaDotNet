--drop database biblioteca;
create database biblioteca;
use biblioteca;

create table editoras
(
	id integer not null primary key identity,
	nome varchar(60) not null
);

create table autores
(
	id integer not null primary key identity,
	nome varchar(50) not null,
	nacionalidade varchar(40)
);

create table categorias
(
	id integer primary key not null identity,
	nome varchar(50) not null
);

create table livros
(
	isbn varchar(22) primary key not null,
	titulo varchar(50) not null,
	ano integer not null,
	fk_editora integer not null,
	fk_categoria integer not null,
	foreign key (fk_editora) references editoras(id),
	foreign key (fk_categoria) references categorias(id)
);

create table livro_autor
(
	id integer not null primary key identity,
	fk_livro varchar(22) not null,
	fk_autor integer not null,
	foreign key (fk_livro) references livros(isbn),
	foreign key (fk_autor) references autores(id)
);


-- INSERT
-- EDITORAS
insert into editoras (nome)
values ('Companhia das Letras'),
		('Editora Rocco'),
		('Editora Arqueiro'),
		('Editora Intrínseca'),
		('Editora Sextante'),
		('Editora Record');

select * from editoras;

--AUTORES
insert into autores (nome,nacionalidade)
values ('José de Alencar','Brasileiro'),
		('Machado de Assis','Português'),
		('Cecília Meireles','Brasileiro'),
		('Guimarães Rosa','Brasileiro'),
		('Clarice Lispector','Português'),
		('Vinicius de Moraes','Brasileiro');

select * from autores;

--CATEGORIAS
insert into categorias (nome)
values ('Fantasia'),
		('Ficção científica'),
		('Distopia'),
		('Ação e aventura'),
		('Horror'),
		('Romance'),
		('Infantil'),
		('Biografia'),
		('Conto'),
		('Literatura Juvenil'),
		('Thriller e Suspense');

select * from categorias;

--LIVROS
insert into livros(isbn, titulo, ano, fk_editora, fk_categoria)
values  ('45612374124','Livro 01', 1922,2,1),
		('49644837412','Livro 02', 1839,3,8),
		('96301445455','Livro 03', 2010,4,11),
		('71212199225','Livro 04', 2022,2,3),
		('65854505959','Livro 05', 1008,1,4),
		('18895652008','Livro 06', 1980,5,1),
		('25458441665','Livro 07', 1980,2,5),
		('37004595227','Livro 08', 1980,4,2),
		('39850004545','Livro 09', 1996,2,2),
		('49996510055','Livro 10', 1996,5,8),
		('79555552046','Livro 11', 2005,1,10),
		('99665544228','Livro 12', 2003,3,1),
		('36987410259','Livro 13', 1987,2,1),
		('44136599507','Livro 14', 1970,4,3),
		('99666388444','Livro 15', 1973,4,9),
		('12555536963','Livro 16', 1950,2,1),
		('84456995274','Livro 17', 2010,2,9),
		('80236947741','Livro 18', 2022,2,6),
		('13646979511','Livro 19', 1999,1,8),
		('78570700142','Livro 20', 199,2,3),
		('99733400278','Livro 21', 1996,2,7),
		('23466450770','Livro 22', 1993,6,4),
		('23646649975','Livro 23', 1922,6,1),
		('99466785210','Livro 24', 2005,2,3),
		('44698722443','Livro 25', 2009,3,8),
		('66455458813','Livro 26', 1998,2,6),
		('66788899461','Livro 27', 1978,1,1),
		('63312455791','Livro 28', 2000,2,5),
		('22133455810','Livro 29', 2001,6,5),
		('33649845575','Livro 30', 1998,5,9);

select * from livros;

--LIVROS_AUTOR
insert into livro_autor(fk_livro,fk_autor)
values ('79555552046',5),
		('45612374124',6),
		('84456995274',5),
		('63312455791',4),
		('63312455791',5),
		('36987410259',4),
		('22133455810',3),
		('37004595227',1),
		('49996510055',6),
		('84456995274',6),
		('44698722443',2),
		('44698722443',4),
		('71212199225',3),
		('13646979511',2),
		('99466785210',3),
		('25458441665',1);

select * from livro_autor;

--Dados disponiveis em ordem alfabetica
--7
select * from livros, editoras, categorias
where livros.fk_editora = editoras.id 
and
livros.fk_categoria = categorias.id
order by livros.titulo;
--order by categorias.nome;
--order by editoras.nome;

select livros.isbn, livros.titulo, livros.ano,
		editoras.nome,
		categorias.nome
from livros, categorias, editoras
where livros.fk_editora = editoras.id 
and
livros.fk_categoria = categorias.id
order by livros.titulo, livros.ano asc;
--quando o titulo for igual ordena pelo ano

--8
select livros.isbn, livros.titulo, livros.ano,
		autores.nome,
		editoras.nome,
		categorias.nome
from livros, categorias, editoras, autores, livro_autor
where livros.fk_editora = editoras.id 
and
livros.fk_categoria = categorias.id
and
livro_autor.fk_livro = livros.isbn
and
livro_autor.fk_autor = autores.id
order by autores.nome;

--9
select * from categorias;

select  livros.titulo, livros.ano,
		autores.nome as 'autor',
		editoras.nome as 'editora',
		categorias.nome as 'categoria'
from livros, categorias, editoras, autores, livro_autor
where categorias.nome = 'Fantasia'
and
livros.fk_editora = editoras.id 
and
livros.fk_categoria = categorias.id
and
livro_autor.fk_livro = livros.isbn
and
livro_autor.fk_autor = autores.id
order by livros.ano asc;

--10
select  livros.titulo, livros.ano,
		autores.nome as 'autor',
		editoras.nome as 'editora',
		categorias.nome as 'categoria'
from livros, categorias, editoras, autores, livro_autor
where 
livros.fk_editora = editoras.id 
and
livros.fk_categoria = categorias.id
and
livro_autor.fk_livro = livros.isbn
and
livro_autor.fk_autor = autores.id
and
(categorias.nome = 'Fantasia' or categorias.nome = 'Horror')
and
livros.ano > 2000 and livros.ano < 2010
order by livros.ano asc;

