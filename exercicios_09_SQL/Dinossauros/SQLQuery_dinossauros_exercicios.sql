-------------- exercício 6
insert into era (nome)
values ('Jurássico'), ('Cretáceo');

insert into grupo (nome)
values ('Anquilossauros'), ('Ceratopsídeos'), ('Estegossauros'), ('Terápodes')

insert into pais (nome)
values ('Mongólia'), ('Canadá'), ('Tanzânia'), ('China'), ('América do Norte')

select * from pais

DELETE FROM pais
WHERE id IN (6, 7, 8, 9, 10, 11)

insert into descobridor (nome, fk_pais)
values ('Maryanska', 1), ('John Bell Hatcher', 2), ('Cientistas Almães', 3), ('Museu Americano de História Natural', 4), 
	('Othniel Charles Marsh', 5), ('Barnum Brown', 5)

select * from dinossauro
select * from descobridor
select * from grupo
select * from era
select * from pais
INSERT INTO dinossauro(especie, toneladas, ano_descoberta, inicio, fim, fk_descobridor, fk_grupo, fk_era, fk_pais)
VALUES ('Saichania', 4, 1977, 145, 66, 1, 1, 2, 1),
('Triceratops', 6, 1887, 145, 66, 2, 2, 2, 2),
('Kentrossauro', 2, 1909, 201, 145, 3, 3, 1, 3),
('Pinacossauro', 6, 1999, 85, 75, 4, 1, 2, 4),
('Alossauro', 3, 1877, 155, 150, 5, 4, 1, 5),
('Torossauro', 8, 1891, 67, 65, 2, 2, 2, 5),
('Anquilossauro', 8, 1906, 66, 63, 6, 1, 1, 5)

-------------- exercício 7
SELECT dinossauro.especie, dinossauro.toneladas, dinossauro.ano_descoberta, dinossauro.inicio, dinossauro.fim,
	descobridor.nome AS 'descobridor', grupo.nome AS 'grupo', era.nome AS 'era', pais.nome AS 'pais'
FROM dinossauro
INNER JOIN descobridor ON descobridor.id = dinossauro.fk_descobridor
INNER JOIN grupo ON grupo.id = dinossauro.fk_grupo
INNER JOIN era ON era.id = dinossauro.fk_era
INNER JOIN pais ON pais.id = dinossauro.fk_pais
ORDER BY dinossauro.especie;

-------------- exercício 8
SELECT dinossauro.especie, dinossauro.toneladas, dinossauro.ano_descoberta, dinossauro.inicio, dinossauro.fim,
	descobridor.nome AS 'descobridor', grupo.nome AS 'grupo', era.nome AS 'era', pais.nome AS 'pais'
FROM dinossauro
INNER JOIN descobridor ON descobridor.id = dinossauro.fk_descobridor
INNER JOIN grupo ON grupo.id = dinossauro.fk_grupo
INNER JOIN era ON era.id = dinossauro.fk_era
INNER JOIN pais ON pais.id = dinossauro.fk_pais
ORDER BY descobridor.nome

-------------- exercício 9
SELECT dinossauro.especie, dinossauro.toneladas, dinossauro.ano_descoberta, dinossauro.inicio, dinossauro.fim,
	descobridor.nome AS 'descobridor', grupo.nome AS 'grupo', era.nome AS 'era', pais.nome AS 'pais'
FROM dinossauro
INNER JOIN descobridor ON descobridor.id = dinossauro.fk_descobridor
INNER JOIN grupo ON grupo.id = dinossauro.fk_grupo
INNER JOIN era ON era.id = dinossauro.fk_era
INNER JOIN pais ON pais.id = dinossauro.fk_pais
WHERE grupo.nome LIKE '%anquilossauro%'
ORDER BY ano_descoberta ASC

-------------- exercício 10
SELECT dinossauro.especie, dinossauro.toneladas, dinossauro.ano_descoberta, dinossauro.inicio, dinossauro.fim,
	descobridor.nome AS 'descobridor', grupo.nome AS 'grupo', era.nome AS 'era', pais.nome AS 'pais'
FROM dinossauro
INNER JOIN descobridor ON descobridor.id = dinossauro.fk_descobridor
INNER JOIN grupo ON grupo.id = dinossauro.fk_grupo
INNER JOIN era ON era.id = dinossauro.fk_era
INNER JOIN pais ON pais.id = dinossauro.fk_pais
WHERE grupo.nome LIKE '%ceratop%' OR grupo.nome LIKE '%anquilo%'
	AND YEAR(ano_descoberta) BETWEEN 1900 AND 1999
ORDER BY ano_descoberta ASC;