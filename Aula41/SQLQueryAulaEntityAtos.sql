create database CodeFirst

create login atos with password='Senh@_12331-05';
create user usuario from login atos;
exec sp_addrolemember 'DB_DATAREADER', 'usuario';
exec sp_addrolemember 'DB_DATAWRITER', 'usuario';

USE CodeFirst;
GRANT CREATE TABLE TO usuario;

select * from Pessoas
