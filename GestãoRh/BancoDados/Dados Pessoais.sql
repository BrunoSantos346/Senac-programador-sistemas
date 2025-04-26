CREATE TABLE IF NOT EXISTS dadospessoais (
id INT PRIMARY KEY AUTO_INCREMENT,
FuncionarioId INT NOT NULL,
NomeCompleto VARCHAR(100) NOT NULL,
cpf VARCHAR(25) NOT NULL,
rg VARCHAR(15) NOT NULL,
datadenascimento DATE ,
genero VARCHAR(40) NOT NULL,
estadocivil VARCHAR(50) NOT NULL,
FOREIGN KEY (FuncionarioId) REFERENCES Funcionario(Id)


);
INSERT INTO dadospessoais (FuncionarioId, NomeCompleto, cpf , rg, datadenascimento, genero, estadocivil) VALUES
(1, 'João Silva', '123.456.789-00', '12.345.678-9', '1990-05-12', 'Masculino', 'Solteiro'),
(2,'Maria Oliveira', '987.654.321-00', 'SP-98.765.432', '1988-11-23', 'Feminino', 'Casada');


SELECT * FROM dadospessoais;



