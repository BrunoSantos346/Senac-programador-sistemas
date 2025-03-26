use Aula01;


CREATE TABLE IF NOT EXISTS Aula01(

id INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR (40),
modelo VARCHAR (40),
ano INT 


);

INSERT INTO Aula01(
nome,
modelo,
Ano )
VALUES
('Gol', 'Hatch', 2020),
('Onix', 'Sedan', 2021),
('Civic', 'Sedan', 2019),
('Corolla', 'Sedan', 2022),
('Onix', 'Sedan', 2021),
('Civic', 'Sedan', 2019),
('Corolla', 'Sedan', 2022),
('Fiesta', 'Hatch', 2018),
('Polo', 'Hatch', 2023),
('HB20', 'Hatch', 2022),
('Cruze', 'Sedan', 2020),
('Uno', 'Hatch', 2017),
('Palio', 'Hatch', 2016),
('Strada', 'Picape', 2021),
('Toro', 'Picape', 2023),
('S10', 'Picape', 2022),
('Ranger', 'Picape', 2021),
('Hilux', 'Picape', 2023),
('Duster', 'SUV', 2020),
('Captur', 'SUV', 2021),
('EcoSport', 'SUV', 2019),
('T-Cross', 'SUV', 2022),
('Compass', 'SUV', 2023);

SELECT 
 *
 FROM
 Aula01
 WHERE  
 modelo = 'SUV';


 