create database adonet

create table pessoas
(
id integer primary key identity,
nome varchar(50) not null,
profissao varchar(30)
)

create login atos with password='Senh@_12331-05';
create user usuario from login atos;
exec sp_addrolemember 'DB_DATAREADER', 'usuario';
exec sp_addrolemember 'DB_DATAWRITER', 'usuario';

insert into pessoas values ('Fabricio', 'Professor')
insert into pessoas values ('Zé', 'Programador')
select * from pessoas
