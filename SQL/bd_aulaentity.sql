create database aulaentity;
use aulaentity;

--criacao de usuario e senha
create login aulaentity with password='senha1234';
--adicionando usuario ao banco
create user aulaentity from login aulaentity;
--adicionando permissões do usuáio no banco
exec sp_addrolemember 'DB_DATAREADER', 'aulaentity';
exec sp_addrolemember 'DB_DATAWRITER', 'aulaentity';

select * from Pessoas;
select * from Emails;