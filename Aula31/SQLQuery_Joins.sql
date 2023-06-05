create table java
(
professor varchar(20) null
)

create table net
(
professor varchar(20) null
)

insert into net
values ('Fabricio'), ('Ricardo'), ('Alexandre')

insert into java
values ('Fabricio'), ('Lucas'), ('Deivison')

select * from net
select * from java

select * from net
union
select * from java



-- Inner Join
select * from java
inner join net
on java.professor = net.professor

-- Left join
select * from java
left join net
on java.professor = net.professor

-- left join exclusivo
select * from java
left join net
on java.professor = net.professor
where net.professor is null

-- right join
select * from java
right join net
on java.professor = net.professor

-- right join exclusivo
select * from java
right join net
on java.professor = net.professor
where java.professor is null

-- full outer join
select * from java
full outer join net
on java.professor = net.professor

-- full outer join exclusivo
select * from java
full outer join net
on java.professor = net.professor
where java.professor is null
	or net.professor is null



-------------------------------


create table log 
(
    id integer not null primary key identity,
    acao varchar(10) not null,
    descricao varchar(100),
    quando datetime not null
)



create trigger primeiratrigger
on java
AFTER DELETE
as
BEGIN
	insert into log values ('Exclusão', 'Um professor de Java foi excluido', GETDATE())
END


delete from java where professor = 'Lucas'
select * from java
select * from log




create trigger segundatrigger
on java
AFTER insert
as
BEGIN
	insert into log values ('inserção', 'add prof java', GETDATE());
	print ('dados inseridos');
END

insert into java values ('Lucas')


select * from java
select * from log





create trigger terceiratrigger
on java
AFTER insert
as
BEGIN
	declare @contagem int
	select @contagem = (select count(professor) from java)
	print ('Quantidade de professores: ' + CONVERT(varchar(10), @contagem))

	IF @contagem < 3
		begin
			insert into log values ('Inserção', 'Add prof java', GETDATE());
			print('Inserido com sucesso');
		end
	ELSE
		begin
			ROLLBACK;
			insert into log values ('Inserção', 'Tentativa de inserção mal sucedida!', GETDATE());
			RAISERROR('INVALIDO', 14, 1);
			RETURN;
		end
END


DROP TRIGGER SEGUNDATRIGGER
delete from java where professor = 'Fabricio'
insert into java values ('Lucas')
insert into java values ('Fabricio')

DROP TRIGGER TERCEIRATRIGGER








create trigger quartatrigger
on java
after update
as
begin
	declare @anterior varchar(20)
	declare @novo varchar(20)
	select @anterior = (select deleted.professor from deleted)
	select @novo = (select inserted.professor from inserted)

	IF(ROWCOUNT_BIG() = 0)
		return;

	IF @anterior= @novo
		begin
			raiserror('SEM ALTERAÇÕES', 14, 1);
			rollback transaction;
			insert into log values ('Atualização', 'Tentativa de update mal sucedida!', GETDATE());
		end
	ELSE
		begin
			insert into log values ('upd', 'Alteração do prof, ' + @anterior + ' para ' + @novo, GETDATE());
		end
end

select * from java
select * from log

update java set professor = 'Fabrício' 
where professor = 'Lucas'

