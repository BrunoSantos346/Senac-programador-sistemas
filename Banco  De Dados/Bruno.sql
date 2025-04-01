CREATE TABLE IF NOT EXISTS empregado(
id INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR(100),
idade INT NOT NULL,
id_departamento INT,
FOREIGN KEY (id_departamento) REFERENCES departamento(id),
salario DECIMAL NOT NULL
);



INSERT INTO empregado (
nome, idade, id_departamento, salario
)VALUES
 ('João',30,'1',50000),
 ('Sarah',28,'2',60000),
 ('Miguel',35,'3',55000),
 ('Ana', 27, '2', 62000);
 
 SELECT * FROM empregado 
 WHERE departamento 
 LIKE 'Ti';
 
 SELECT nome, salario FROM empregado 
 WHERE salario > 55000;
 
 SELECT * FROM empregado 
 ORDER BY idade DESC;
 
 
 -- Exercício 2 --


SELECT * FROM empregado
WHERE idade 
IN (28, 35);

SELECT * FROM empregado
WHERE nome 
LIKE '%M%';

SELECT * FROM empregado
WHERE departamento != 'RH';


 -- Excercício 3 --
 
 
 SELECT COUNT(*) FROM empregado 
 WHERE departamento = 'Ti';
 
 SELECT COUNT(*) FROM empregado
 WHERE departamento = 'RH';
 
  SELECT COUNT(*) FROM empregado
 WHERE departamento = 'Vendas';
 
 SELECT AVG(salario) FROM empregado
 WHERE departamento = 'Ti';
 
 SELECT SUM(salario) FROM empregado
 WHERE departamento = 'Vendas';
 
 
 -- Exercício 4 --
 
 SELECT empregado.nome, departamento.nome FROM empregado
 INNER JOIN departamento 
 ON empregado.id_departamento = departamento.id;
 
 SELECT *
 FROM departamento
 LEFT JOIN empregado
 ON departamento.id = empregado.id;
 
 -- Exercício 5 --
 
SELECT nome, salario
FROM empregado
WHERE salario > (SELECT AVG(salario) FROM empregado);
 
 
 
 
 

 
 
 
 

