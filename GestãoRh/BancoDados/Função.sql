CREATE TABLE IF NOT EXISTS funcao(
Id  INT PRIMARY KEY AUTO_INCREMENT,
FuncionarioId INT NOT NULL,
Cargo VARCHAR(50) NOT NULL,
Departamento VARCHAR(60) NOT NULL,
DataAdmissao DATE NOT NULL,
Salario DECIMAL(10,2) NOT NULL,
FOREIGN KEY (FuncionarioId) REFERENCES Funcionario(Id)
);


INSERT INTO funcao (FuncionarioId, Cargo, Departamento, DataAdmissao, Salario) VALUES
( 1, 'Desenvolvedor', 'TI', '2022-03-01', 3500.00),
( 2, 'Analista', 'RH', '2018-06-10', 4200.00);



SELECT * FROM funcao;

DROP TABLE funcao;
