CREATE TABLE IF NOT EXISTS Endereco(
Id INT PRIMARY KEY AUTO_INCREMENT,
FuncionarioId INT NOT NULL,
Cep VARCHAR(50) NOT NULL,
Logradouro VARCHAR(50) NOT NULL,
Numero VARCHAR(10) NOT NULL,
Complemento VARCHAR(30) NOT NULL,
Bairro VARCHAR(100) NOT NULL,
Cidade VARCHAR(100) NOT NULL, 
Estado VARCHAR (2) NOT NULL,
FOREIGN KEY (FuncionarioId) REFERENCES Funcionario(Id)
);


INSERT INTO Endereco (FuncionarioId, CEP, Logradouro, Numero, Complemento, Bairro, Cidade, Estado) 
VALUES
(1, '12345-678', 'Rua das Flores', '123', 'Apto 301', 'Jardim das Rosas', 'São Paulo', 'SP'),
(2, '98765-432', 'Avenida Paulista', '456', 'apto 500', 'Centro', 'São Paulo', 'SP');

SELECT * FROM endereco;

ALTER TABLE endereço 
ADD cidade VARCHAR(100),
ADD estado VARCHAR(2);



DROP TABLE endereço;