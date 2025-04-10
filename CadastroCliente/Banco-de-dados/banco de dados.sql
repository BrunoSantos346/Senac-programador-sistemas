

CREATE TABLE cliente (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    nome_social VARCHAR(100) NULL,
    data_nascimento DATE NOT NULL,
    email VARCHAR(50) NOT NULL UNIQUE,
    telefone VARCHAR(11) NOT NULL UNIQUE,
    tipo INT NOT NULL,
    etnia INT NOT NULL,
    genero INT NOT NULL,
    estrangeiro BIT NOT NULL,
    id_endereco INT NOT NULL,
    FOREIGN KEY (id_endereco) REFERENCES endereco (id)
);

INSERT INTO cliente
(nome, data_nascimento, email, telefone, tipo, etnia, genero, estrangeiro, id_endereco)
VALUES
('Bruno Santos','1998-03-12', 'bruno@senac', '11987854247', 0, 2, 0, 0, (SELECT id FROM endereco WHERE logradouro = 'Endereco do Bruno')),
('Luana', '1999-03-08', 'Luana@email', '11978745533', 0, 0, 1, 0, (SELECT id FROM endereco WHERE logradouro = 'Endereco dA Luana')),
('Jairo', '1971-07-14', 'jairo@email.com', '11987744596', 0, 1, 0, 0, (SELECT id FROM endereco WHERE logradouro = 'Endereco dA jairo'));