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
		('Ceratopsídeos'),
		('Estegossauros'),
		('Terápodes');

select * from grupo;

insert into era (nome,inicio_era, fim_era)
values  ('Triássico',251,200),
		('Jurássico',200,145),
		('Cretácio',145,65);


select * from era;

insert into cientista(nome)
values('Maryanska'),
		('Jhon Bell Hatcher'),
		('Cientistas Alemães'),
		('Museu Americano de História Natural'),
		('Othniel Charles Marsh'),
		('Jhon Bell Hatcher'),
		('Barnum Brown');

insert into dinossauro (nome,fk_grupo,toneladas,ano_descoberta,fk_descobridor,fk_era, inicio, fim, pais_descoberto)
values ('Saichania',1,4,'1977',1,3,145,66, 'Mongólia'),
		('Tricerátops',2,6,'1887',2,3,70,66,'Canadá'),
		('Kentrossauro',3,2,'1909',3,2,200,145,'Tanzânia'),
		('Pinacossauro',1,6,'1999',4,1,85,75,'China'),
		('Alossauro',4,3,'1877',5,2,155,150,'América do Norte'),
		('Torossauro',2,8,'1891',2,3,67,65,'USA'),
		('Anquilossauro',1,8,'1906',7,1,66,63,'América do Norte');

/*
create procedure procedimento (@parametro int)
as
seu código

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

exec teste5 'Fabrício'  
exec teste5 @nome='Isaque'
*/

--Retornar o nome dos dinossauros que pertencem ao nome do grupo informado

--Faça uma store procedure que receba dois parametros, um ID e um peso em toneladas. Altere o peso do dinossauro  pelo seu ID.


/*
E - Evento
C - Condição
A - Ação
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
--condição
--ação
end
*/

go
create trigger primeratrigger
on java
after insert
as 
begin
	insert into log values ('Inserção', 'Foi inserido um novo professor em Java', GETDATE());
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
	insert into log values('Exclusão', 'O professor foi excluído com sucesso!', GETDATE());
	print('Excluído com sucesso!');
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
--declaração
declare @nome varchar(15)
select @nome = (select deleted.professor from deleted)
--select @nome2 = (select inserted.professor from inserted)
begin
	insert into log values ('Exclusão','O profesor ' + @nome + ' foi 
	excluído da academia', GETDATE());
	print(@nome + ' excluído com sucesso');
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
			insert into log values ('Inserção','O profesor ' + @nome + ' foi 
			inserido da academia', GETDATE());
			print(@nome + ' inserido com sucesso');
		end
	else
		begin
			ROLLBACK; --desfaz tudo!
			insert into log values ('Inserção','O profesor ' + @nome + ' não foi 
			inserido da academia devido ao limite de professores ter sido atingido', GETDATE());
			--print(@nome + ' não foi inserido!');
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
            raiserror('sem alterações, dados identicos', 14,1);
            rollback transaction;
            insert into log values ('Alteração', 'Nada alterado, pois ' + @novo + ' não foi alterado',
            GETDATE());
        end
    else
        begin
            insert into log values ('Alteração', 'Professor ' + @antigo + ' foi subistituido pelo ' + @novo,
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
			insert into log values ('Inserção', 'Novo dinossauro inserido em Dinossauros', GETDATE());
			print('Dinossauro inseridos com sucesso!')
		end
	else
		begin
			ROLLBACK;
			insert into log values ('Inserção', 'tentativa de inserção de novo dinossauro na tabela Dinossauros', GETDATE());
			RAISERROR('INVALIDO', 14,1);
			RETURN;
		end
end;
