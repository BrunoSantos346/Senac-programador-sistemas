USE usuario;

CREATE TABLE IF NOT EXISTS Usuario (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(50) NOT NULL UNIQUE,
    senha VARCHAR(16) NOT NULL
);

SELECT 
    *
FROM
    usuario;
    
    INSERT  INTO  usuario (
    nome, 
    email, 
    senha)
    
    VALUES (
    'Bruno',
    'Bruno@Senac',
    'Bruno123');
    
