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
	inicio integer,
	fim integer,
	fk_grupo integer not null,
	foreign key(fk_grupo) references grupo(id),
	fk_descobridor integer not null,
	foreign key(fk_descobridor) references cientista(id),
	fk_era integer not null,
	foreign key(fk_era) references era(id)
);

insert into grupo (nome)
values ('Anquilossauros'),
		('Ceratops�deos'),
		('Estegossauros'),
		('Ter�podes');

select * from grupo;

insert into era (nome,inicio_era, fim_era)
values  ('Tri�ssico',251,200),
		('Jur�ssico',200,145),
		('Cret�cio',145,65);


select * from era;

insert into cientista(nome)
values('Maryanska'),
		('Jhon Bell Hatcher'),
		('Cientistas Alem�es'),
		('Museu Americano de Hist�ria Natural'),
		('Othniel Charles Marsh'),
		('Jhon Bell Hatcher'),
		('Barnum Brown');

insert into dinossauro (nome,fk_grupo,toneladas,ano_descoberta,fk_descobridor,fk_era, inicio, fim, pais_descoberto)
values ('Saichania',1,4,'1977',1,3,145,66, 'Mong�lia'),
		('Tricer�tops',2,6,'1887',2,3,70,66,'Canad�'),
		('Kentrossauro',3,2,'1909',3,2,200,145,'Tanz�nia'),
		('Pinacossauro',1,6,'1999',4,1,85,75,'China'),
		('Alossauro',4,3,'1877',5,2,155,150,'Am�rica do Norte'),
		('Torossauro',2,8,'1891',2,3,67,65,'USA'),
		('Anquilossauro',1,8,'1906',7,1,66,63,'Am�rica do Norte');

/*
create procedure procedimento (@parametro int)
as
seu c�digo

create procedure teste2
as
select nome, year(ano_descoberta) as Ano
from dinossauro;

exec teste2;
exec sp_helptext teste2

drop procedure teste2
*/

select * from dinossauro where toneladas in (3,6, 4)

select * from dinossauro where toneladas between 2 and 6

select * from dinossauro where year(ano_descoberta) > 1900

--COUNT SUM AVG  
select fk_grupo, avg(toneladas) as Media  
from dinossauro  
GROUP BY fk_grupo;

select fk_grupo, count(*) as quantidade  
from dinossauro  
group by fk_grupo;

select fk_grupo, SUM(toneladas) as somatorio  
from dinossauro  
group by fk_grupo  
having sum(toneladas) > 5;

--AAAA-MM-DD
/*
create procedure teste4 (@ano as int)
as
select * from dinossauro where year(ano_descoberta) = @ano

teste4 1999


create procedure teste5 (@nome as Varchar(50))  
as  
insert into descobridor values (@nome)

exec teste5 'Fabr�cio'  
exec teste5 @nome='Isaque'
*/

--Retornar o nome dos dinossauros que pertencem ao nome do grupo informado

--Fa�a uma store procedure que receba dois parametros, um ID e um peso em toneladas. Altere o peso do dinossauro �pelo seu ID.


/*
E - Evento
C - Condi��o
A - A��o
*/
--triggers


create table java
(
	professor varchar(50) not null
);
 
create table dotnet
(
	professor varchar(50) not null
);
 
create table log
(
	id integer not null primary key identity,
	acao varchar(15) not null,
	descricao varchar(250),
	quando datetime not null
);

/*
create trigger primeiratrigger
on java
(after before instead) insert
as 
begin
--condi��o
--a��o
end
*/

go
create trigger primeratrigger
on java
after insert
as 
begin
	insert into log values ('Inser��o', 'Foi inserido um novo professor em Java', GETDATE());
	PRINT('Professor inserido com sucesso!');
end;

select * from java;
select * from log;

insert into java values('Gabirel'),('Fabricio'),('Luan');
---

go
create trigger triggerdelete
on java
after delete
as 
begin
	insert into log values('Exclus�o', 'O professor foi exclu�do com sucesso!', GETDATE());
	print('Exclu�do com sucesso!');
end;

select * from java;
select * from log;

delete from java where professor = 'Lucas';

drop trigger triggerdelete;

go
create trigger triggerdelete
on java
after delete
as
--declara��o
declare @nome varchar(15)
select @nome = (select deleted.professor from deleted)
--select @nome2 = (select inserted.professor from inserted)
begin
	insert into log values ('Exclus�o','O profesor ' + @nome + ' foi 
	exclu�do da academia', GETDATE());
	print(@nome + ' exclu�do com sucesso');
end;

delete from java where professor = 'Lucas';
select * from log;


drop trigger primeratrigger;

go
create trigger triggerinsert
on java
after insert
as
	declare @quantidade integer
	declare @nome varchar(15)
	select @quantidade = (select count(professor) from java)
	select @nome = (select professor from inserted)
begin
	print('Quantidade de registros: ' + convert(varchar(3), @quantidade) );
	if(@quantidade <= 3)
		begin
			insert into log values ('Inser��o','O profesor ' + @nome + ' foi 
			inserido da academia', GETDATE());
			print(@nome + ' inserido com sucesso');
		end
	else
		begin
			ROLLBACK; --desfaz tudo!
			insert into log values ('Inser��o','O profesor ' + @nome + ' n�o foi 
			inserido da academia devido ao limite de professores ter sido atingido', GETDATE());
			--print(@nome + ' n�o foi inserido!');
			RAISERROR('Regra de 3 professores bloqueou o insert',14,1);
		end
end;

insert into java values('Lucas');

select * from java;
select * from log;
delete from java where professor = 'Lucas';
delete from java where professor = 'Ricardo';

-- update

go
create trigger triggerupdate
on java
after update
as 
    declare @novo varchar(15)
    declare @antigo varchar(15)

    select @novo  = (select professor from inserted)
    select @antigo = (select professor from deleted)

    IF(ROWCOUNT_BIG() = 0)
        return;

begin 
    if(@novo = @antigo)
        begin
            raiserror('sem altera��es, dados identicos', 14,1);
            rollback transaction;
            insert into log values ('Altera��o', 'Nada alterado, pois ' + @novo + ' n�o foi alterado',
            GETDATE());
        end
    else
        begin
            insert into log values ('Altera��o', 'Professor ' + @antigo + ' foi subistituido pelo ' + @novo,
            GETDATE());
        end
end

select * from era;

--5

--6
go
create trigger validaInsereDinossauroEra
on dinossauro
after insert
as
begin
	declare @dinoIni int
	declare @dinoFim int
	declare @eraIni int
	declare @eraFim int

	select @dinoIni = (select inserted.inicio from inserted)
	select @dinoFim = (select inserted.fim from inserted)
	select @eraIni = (select era.inicio_era from era where era.id = (select inserted.fk_era from inserted))
	select @eraFim = (select era.fim_era from era where era.id = (select inserted.fk_era from inserted))

	if (@dinoIni > @eraIni) and (@dinoFim < @eraFim)
		begin
			insert into log values ('Inser��o', 'Novo dinossauro inserido em Dinossauros', GETDATE());
			print('Dinossauro inseridos com sucesso!')
		end
	else
		begin
			ROLLBACK;
			insert into log values ('Inser��o', 'tentativa de inser��o de novo dinossauro na tabela Dinossauros', GETDATE());
			RAISERROR('INVALIDO', 14,1);
			RETURN;
		end
end;
