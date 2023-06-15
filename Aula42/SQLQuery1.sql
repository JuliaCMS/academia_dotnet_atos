select * from Pessoas
select * from Emails

create database DBFirst
drop database DBFirst

create table pessoas
(
	id integer identity primary key,
	nome varchar(100) not null
)

create table emails
(
	id integer identity primary key,
	email varchar(80) not null,
	fk_pessoa integer,
	foreign key (fk_pessoa) references pessoas(id)
)

select * from pessoas
select * from emails

