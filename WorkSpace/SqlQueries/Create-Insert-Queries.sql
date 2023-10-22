create database StudentDB
use StudentDB

Alter database StudentDB Modify Name=StudentsDB
Drop database StudentsDB

CREATE TABLE Student(
id INT,
firstName VARCHAR(50),
lastName VARCHAR(50),
age INT
);

ALTER TABLE Student ADD email VARCHAR(20)
DROP TABLE Student

SELECT *FROM Student

INSERT INTO Student(id,firstName,lastName,age,email) 
VALUES 
(1,'Rakshith','Shetty',30,'rakshith@gmail.com'),
(2,'Ajay','Reddy',25,'ajayreddy@gmail.com')

INSERT INTO Student
VALUES
(3,'Brunda','Mahesh',25,'brunda@gmail.com'),
(4,'Senthil','Kumar',45,'senthil@gmail.com')

