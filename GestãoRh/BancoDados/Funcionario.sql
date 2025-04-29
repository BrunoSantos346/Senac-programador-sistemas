CREATE TABLE IF NOT EXISTS funcionario(
Id INT PRIMARY KEY AUTO_INCREMENT,
FuncionarioId INT NOT NULL,
NomeCompleto VARCHAR(100) NOT  NULL,
Cpf VARCHAR(14) NOT NULL UNIQUE,
Rg VARCHAR(20) NOT NULL,
DataNascimento DATE,
Genero VARCHAR(20) NOT NULL,
EstadoCivil VARCHAR(20) NOT NULL,
Salario DECIMAL(10,2) NOT NULL,
FOREIGN KEY (FuncionarioId) REFERENCES Funcionario(Id)


);
DROP TABLE funcionario;

INSERT INTO funcionario (FuncionarioId, NomeCompleto, Cpf, Rg, DataNascimento, Genero, EstadoCivil, Salario)
VALUES
(1,'João da Silva', '123.456.789-00', 'MG-12.345.678', '1990-05-12', 'Masculino', 'Solteiro', '2.540');





SELECT * FROM funcionario WHERE Id IN (1, 2);

SELECT 
    f.NomeCompleto,
    f.Cpf,
    e.Cep,
    e.Logradouro,
    e.Numero,
    e.Complemento,
    e.Bairro,
    e.Cidade,
    e.Estado
FROM
    funcionario f
        INNER JOIN
    endereco e ON f.Id = e.FuncionarioId;

ALTER TABLE funcionario
ADD COLUMN Salario  DECIMAL(10,2) NOT NULL;

SELECT * FROM funcionario;

SELECT 
f.NomeCompleto,
f.Cpf,
f.Genero,
fn.Cargo,
fn.Departamento,
fn.DataAdmissao,
fn.Salario
FROM funcionario f
INNER JOIN funcao fn ON f.Id = fn.FuncionarioId;

SELECT 
f.NomeCompleto AS NomeFuncionario,
f.Cpf AS CpfFuncionario,
d.NomeCompleto AS NomeDependente,
d.Cpf AS CpfDependente,
d.Parentesco,
d.DataNascimento,
d.Genero

FROM funcionario f
INNER JOIN dependentes d ON f.Id = d.FuncionarioId;

SELECT 
f.Id AS IdFuncionario,
f.NomeCompleto AS NomeSistema,
dp.NomeCompleto AS NomeOficial,
dp.Cpf,
dp.Rg,
dp.datadenascimento,
dp.Genero,
dp.estadocivil

FROM funcionario f
INNER JOIN dadospessoais dp ON f.Id = dp.FuncionarioId;





DELETE f1 FROM funcionario f1
JOIN funcionario f2 
ON f1.Cpf = f2.Cpf AND f1.Id > f2.Id;

DROP TABLE dadospessoais;
DROP TABLE dependentes;
DROP TABLE Endereco;




