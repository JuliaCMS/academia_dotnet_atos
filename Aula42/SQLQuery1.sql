select * from Pessoas
select * from Emails

create database DBFirst

create table pessoas
(
	id integer identity primary key,
	email varchar(80) not null,
	fk_pessoa integer,
	foreign key (fk_pessoa) references pessoas(id)
)

create database CodeFirstAlunosCursos