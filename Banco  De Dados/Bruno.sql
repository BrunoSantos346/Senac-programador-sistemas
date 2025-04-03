CREATE TABLE cliente(
id INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR(100) NOT NULL,
idade INT NOT NULL,
cidade VARCHAR(100) NOT NULL,
saldo DECIMAL NOT NULL
);



INSERT INTO cliente(
nome, 
idade, 
cidade, 
saldo 
)

VALUES
('Carlos', '45', 'São Paulo', 2500.00),
('Mariana', '32', 'Rio de Janeiro', '3200.50'),
('Pedro',  '27', 'Belo Horizonte', '1500.75'),
('Fernada', '38', 'Curitiba', 4200.00);

-- Exercício 1 --

SELECT nome FROM cliente 
WHERE cidade = 'Rio de janeiro';

SELECT nome, saldo FROM cliente
WHERE  saldo > '2000.00';

SELECT nome, idade FROM cliente
WHERE idade > '30';


-- Exercício 2 --

SELECT nome, idade FROM cliente
WHERE idade BETWEEN 25 AND 40;

SELECT * FROM cliente 
WHERE nome 
LIKE '%F%';

SELECT * FROM cliente 
WHERE cidade NOT IN('São Paulo', 'Curitiba');

-- Exercício 3 --

CREATE TABLE pedido(

id INT PRIMARY KEY AUTO_INCREMENT,
cliente_id INT NOT NULL,
valor DECIMAL(10,2) NOT NULL,
data_pedido DATETIME
);

INSERT INTO pedido(
cliente_id,
valor,
data_pedido
)
VALUES
('1', 500.00, '2024-03-10'),
('2', 1200.00, '2024'-03-12),
('3', 300.50, '2024-03-15'),
('1', 800.00, '2024-08-18');

SELECT AVG(valor) FROM pedido
WHERE cliente_id;

SELECT cliente_id, valor FROM pedido
GROUP BY valor;



-- Exercício 4 --

SELECT pedido.id, cliente.nome, valor
FROM cliente
INNER JOIN pedido ON cliente.id = pedido.cliente_id;


 
 
SELECT nome, valor
FROM cliente
LEFT JOIN pedido ON pedido.cliente_id  = cliente_id;

-- Exercício 5 --

SELECT nome, valor
FROM pedido
WHERE cliente_id = (SELECT AVG(valor) FROM pedido WHERE valor > '1000.00');










