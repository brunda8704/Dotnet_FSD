CREATE DATABASE SchoolDB
GO

USE SchoolDB
GO

CREATE TABLE Students
(
Id INT IDENTITY(100, 1),
FirstName VARCHAR(20),
LastName VARCHAR(20),
Marks INT,
CONSTRAINT CK_Students_Marks CHECK (Marks>0 AND Marks<=100),
CONSTRAINT PK_Students_Id PRIMARY KEY(Id)
);
GO

INSERT INTO Students(FirstName,LastName,Marks) 
VALUES
('John','Ryan',55),
('Tina','Mari',75),
('Tim','Keith',65),
('Vineetha','Mathew',88),
('Varun','John',92),
('Tarun','Varghese',94);
GO

SELECT *FROM Students
GO

SELECT Id,FirstName,LastName FROM Students 
WHERE Marks>60
GO

SELECT MAX(Marks) AS HighestMarks FROM Students
GO

SELECT MIN(Marks) AS LowestMarks FROM Students
GO

Select AVG(Marks) AS AverageMarks FROM Students
G0

