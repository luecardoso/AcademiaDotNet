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
	nome varchar(50) not null unique
);

create table produto
(
	id integer primary key identity,
	nome varchar(60) not null,
	quantidade int not null,
	descricao varchar(200),
	preco decimal(6,2) not null,
	--fk_categoria integer not null,
	--foreign key(fk_categoria) references categoria(id),
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

create table pedido
(
	id integer primary key identity,
	total decimal(6,2),
	dataCompra datetime,
	fk_cliente integer not null,
	foreign key(fk_cliente) references cliente(id),
);

create table itempedido
(
	id integer primary key identity,
	quantidadeComprada int,
	valorUnitario decimal(6,2),
	valorTotal decimal(6,2),
	fk_produto integer not null,
	foreign key(fk_produto) references produto(id),
	fk_pedido integer not null,
	foreign key(fk_pedido) references pedido(id)
);

--criacao de usuario e senha
create login usuario3 with password='senha1234';
--adicionando usuario ao banco
create user usuario3 from login usuario3;
--adicionando permissões do usuáio no banco
exec sp_addrolemember 'DB_DATAREADER', 'usuario3';
exec sp_addrolemember 'DB_DATAWRITER', 'usuario3';

insert into fornecedor(nome)
values('Fornecedor A'),
('Fornecedor B'),
('Fornecedor C'),
('Fornecedor D'),
('Fornecedor E'),
('Fornecedor F'),
('Fornecedor G'),
('Fornecedor H'),
('Fornecedor I'),
('Fornecedor J'),
('Fornecedor K'),
('Fornecedor L'),
('Fornecedor M'),
('Fornecedor N'),
('Fornecedor O');

select * from fornecedor;

insert into produto(nome,quantidade,preco,fk_fornecedor)
values('Leite Integral',64,3.90,3);

insert into produto(nome,quantidade,preco,fk_fornecedor)
values('Leite Integral',64,3.90,6),
('Arroz',100,23.0,9),
('Feijão',88,8.99,1),
('Bolacha recheada',205,4.30,1),
('Bolacha recheada',55,3.90,9),
('Leite Integral',154,3.70,5),
('Caixa de ovos 30un',88,18.90,8),
('Margarina 500g',78,7.90,4),
('Margarina 500g',66,7.50,2),
('Leite Integral',160,4.10,2),
('Arroz',25,19.90,1),
('Feijão',97,8.19,7),
('Caixa de ovos 30un',108,20.90,6),
('Açúcar',100,5.90,10),
('Açúcar',55,3.90,11),
('Leite Integral',64,3.50,12);

select * from produto 
inner join fornecedor on fornecedor.id = produto.fk_fornecedor
order by fornecedor.nome;

insert into cliente(nome)
values('Beatriz'),
('Alice'),
('Helena'),
('Isabela'),
('Júlia'),
('Artur'),
('Bernardo'),
('Davi'),
('Gabriel'),
('Lucas'),
('Antônio'),
('Breno'),
('Cauã'),
('João'),
('Luan');

select * from cliente;

select * from pedido;
select * from itempedido;

insert into produto(nome, quantidade,preco,fk_fornecedor)
values ('teste 01',5,59,5);

select * from produto;

insert into pedido(total,fk_cliente)
values(420,1);

insert into itempedido(valorUnitario,quantidadeComprada,valorTotal,fk_produto,fk_pedido)
values (34.90,4,(34.90*45),3,1),
(54.90,2,(54.90*2),7,1),
(14.90,5,(14.90*5),2,1),
(20.90,3,(20.90*3),5,1);

select * from itempedido 
where fk_pedido = 1;

select * from fornecedor;
delete from fornecedor where fornecedor.id = 14;