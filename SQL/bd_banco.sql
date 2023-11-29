drop database banco;

create database banco;
use banco;

create table Clientes (
    ID int PRIMARY KEY IDENTITY,
    nome VARCHAR(100),
    email VARCHAR(100)
);

CREATE TABLE Pedidos(
    ID INT PRIMARY KEY IDENTITY,
    datapedido date,
    valor decimal(12,2),
    ID_CLIENTE int
    FOREIGN KEY(ID_CLIENTE) REFERENCES Clientes(ID)
);


INSERT INTO Clientes (nome, email) VALUES ('Ricardo Frohlich da Silva', 'ricardosma@gmail.com');
INSERT INTO Clientes (nome, email) VALUES ('Fabrício Tonetto', 'fabriciotonetto@gmail.com');
INSERT INTO Clientes (nome, email) VALUES ('Alexandre de Oliveira Zamberlan', 'alexz@gmail.com');


INSERT INTO Pedidos (datapedido, valor, ID_CLIENTE) VALUES ('2023-12-10', 153.50, 1);
INSERT INTO Pedidos (datapedido, valor, ID_CLIENTE) VALUES ('2023-12-15', 179.50, 2);
INSERT INTO Pedidos (datapedido, valor, ID_CLIENTE) VALUES ('2023-12-25', 1809.50, 3);


--criacao de usuario e senha
create login usuario1 with password='senha1234';
--adicionando usuario ao banco
create user usuario1 from login usuario1;
--adicionando permissões do usuáio no banco
exec sp_addrolemember 'DB_DATAREADER', 'usuario1';
exec sp_addrolemember 'DB_DATAWRITER', 'usuario1';