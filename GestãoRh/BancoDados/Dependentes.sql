CREATE TABLE IF NOT EXISTS dependentes(
Id INT PRIMARY KEY AUTO_INCREMENT,
FuncionarioId INT NOT NULL,
NomeCompleto VARCHAR(100) NOT NULL,
Cpf VARCHAR(14) NOT NULL,
Rg VARCHAR(15) NOT NULL,
DataNascimento DATE,
Genero VARCHAR(20) NOT NULL,
Parentesco VARCHAR(30) NOT NULL,
FOREIGN KEY (FuncionarioId) REFERENCES Funcionario(Id)

);

INSERT INTO dependentes (FuncionarioId, NomeCompleto, Cpf, Rg, DataNascimento, Genero, Parentesco) VALUES
(1, 'Maria Silva', '987.654.321-00', '98.765.432-1', '2000-02-14', 'Feminino', 'Filha'),
(2, 'Carlos Oliveira', '876.543.210-11', '87.654.321-0', '2010-09-18', 'Masculino', 'Marido');


SELECT * FROM dependentes;



