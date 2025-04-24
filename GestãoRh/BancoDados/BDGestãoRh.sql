create DATABASE GestaoRH;















CREATE TABLE UsuarioExistente (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    Data_Admissao DATE,
    salario DECIMAL(10 , 2 ) NOT NULL
);

 
select * from UsuarioExistente;




insert into UsuarioExistente( nome, Data_Admissao, Salario)

values 
('João','25/06/2020', 1500.00),
('Brenno','18/06/2022', 2000.00),
('Carlos','23/11/2012', 2300.00);