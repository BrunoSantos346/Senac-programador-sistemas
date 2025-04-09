CREATE TABLE usuario (
id INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR(100) NOT NULL,
email VARCHAR (50) NOT NULL,
senha VARCHAR (20) NOT NULL
);

INSERT INTO usuario(nome, email, senha )

VALUES 
('Neymar Jr', 'jr@email.com','Bruna@123'),
('Pablo', 'vitar@email.com','vitar@123'),
('Sukuna', 'Sukuna@email.com','Sukuna@123');



SELECT * FROM usuario
WHERE email = 'vitar@email.com';

