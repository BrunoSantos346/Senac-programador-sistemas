CREATE TABLE IF NOT EXISTS produto 
(id INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR(50) NOT NULL,
categoria VARCHAR (50) NOT NULL,
preco INT NOT NULL,
estoque VARCHAR (50),
fornecedor_id INT NOT NULL,
FOREIGN KEY (fornecedor_id) REFERENCES fornecedor(id)

);


SELECT * FROM produto;


CREATE TABLE IF NOT EXISTS pedido
(id INT PRIMARY KEY AUTO_INCREMENT,
produto_id INT NOT NULL,
quantidades INT NOT NULL,
data_pedido DATE,
cliente_id INT NOT NULL,
FOREIGN KEY (produto_id) REFERENCES produto(id),
FOREIGN KEY (cliente_id) REFERENCES cliente(id)

);


CREATE TABLE IF NOT EXISTS cliente 
(id INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR(100),
cidade VARCHAR(100),
idade INT NOT NULL
);



INSERT INTO produto(nome, categoria, preco, estoque, fornecedor_id)

VALUES 
('Celular X', 'Eletronicos', 2500.00, 30, 1),
('Notbook Y', 'Eletronicos', 4800.00, 15, 2),
('Mesa de Madeira', 'Movéis', 750.00, 10, 3),
('Cadeira z', 'Movéis', 300.00, 25, 3),
('Tv 50', 'eletronicos', 3500.00, 8, 1);

INSERT INTO cliente(nome, cidade, idade)

VALUES 
('João silva', 'São Paulo', 35),
('Maria Santos','Belo Horizonte', 28),
('Carlos Lima', 'Rio de Janeiro', 42),
('Fernanda Rocha', 'Curitiba', 30);


CREATE TABLE fornecedor (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(255),
    cidade VARCHAR(255)
);
 
INSERT INTO fornecedor (nome, cidade)
VALUES
('TechBrasil', 'São Paulo'),
('Computech', 'Rio de Janeiro'),
('Moveis&Co', 'Curitiba');





INSERT INTO pedido(produto_id, quantidades, data_pedido, cliente_id)

VALUES 
(41, 2, '2024-03-10', 1),
(43, 1, '2024-03-11', 2),
(42, 1, '2024-03-15', 3),
(45, 3, '2024-03-18', 1),
(44, 4, '2024-03-20', 4);


SELECT * FROM pedido;



-- EXERCÍCIO ---


SELECT preco, categoria FROM produto 
WHERE preco > 3000.00  
ORDER BY preco DESC;

SELECT nome, idade, cidade FROM cliente
WHERE cidade <> 'São Paulo'  AND idade > 30;
SELECT * FROM cliente;

SELECT data_pedido FROM pedido 
WHERE data_pedido BETWEEN '2024-03-10' AND '2024-03-15'
ORDER BY data_pedido ASC;

SELECT estoque FROM produto
WHERE estoque < 10 
ORDER BY estoque ASC;

SELECT categoria, AVG(preco) AS preco_medio
FROM produto
GROUP BY categoria;

SELECT COUNT(*) AS total_pedido
FROM pedido
GROUP BY cliente_id;

SELECT categoria, SUM(estoque) AS total_estoque
FROM produto
GROUP BY categoria;


SELECT id, produto_id, quantidades
FROM pedido
WHERE quantidades =(SELECT MAX(quantidades) FROM pedido);

SELECT cidade, COUNT(*) AS total_clientes
FROM cliente 
GROUP BY cidade
ORDER BY total_clientes DESC;


SELECT 
    p.nome AS produto, f.nome AS fonecedor
FROM
    produto p
        INNER JOIN
    fornecedor f ON p.fornecedor_id = f.id
ORDER BY f.nome;


SELECT c.nome AS cliente, pr.nome AS produto, pe.data_pedido FROM pedido pe 
INNER JOIN cliente c ON pe.cliente_id = c.id

INNER JOIN produto pr ON pe.produto_id = pr.id
ORDER BY pe.data_pedido;


SELECT c.nome AS cliente, pr.nome AS produto, f.nome AS fornecedor 
FROM pedido pe
INNER JOIN cliente c ON pe.cliente_id = c.id
INNER JOIN produto pr ON pe.produto_id = pr.id
INNER JOIN fornecedor f ON pr.fornecedor_id = f.id;



SELECT c.nome AS cliente, SUM(pe.quantidades) AS total_comprados FROM pedido pe
INNER JOIN cliente c ON pe.cliente_id = c.id
GROUP BY c.nome;



SELECT * FROM produto p
WHERE preco > (SELECT AVG (preco) FROM produto WHERE categoria = p.categoria );

UPDATE produto
SET preco = preco * 1.10 WHERE categoria = 'Eletronicos';


SELECT * FROM pedido;




INSERT INTO cliente(nome, cidade, idade)

VALUES
('Ricardo Lopes', 'Porto Alegre', 38);


INSERT INTO pedido(produto_id, quantidades, data_pedido, cliente_id)

VALUES 
(43, 1, 2, '2024-03-25', 1);


SELECT DISTINCT
    c.nome AS nome_cliente
FROM
    cliente c
        INNER JOIN
    pedido p ON c.id = p.cliente_id
        INNER JOIN
    produto pr ON p.produto_id = pr.id
WHERE
    pr.categoria = 'Móveis';









