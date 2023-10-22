CREATE DATABASE Test
GO

USE Test
GO


CREATE TABLE Divisions
(
    id INT
    PRIMARY KEY IDENTITY, 
    min_Age INT, 
    max_Age INT
);
GO

INSERT INTO Divisions(min_Age, max_Age)
VALUES
(5,null),
(20,null),
(null,30);
GO

SELECT *FROM Divisions
GO

--ISNULL
SELECT ISNULL(min_Age,0) ReplacementMinAge, 
       ISNULL(max_Age,99) ReplacementMaxAge
FROM Divisions
GO

--COALESCE 
SELECT COALESCE(null,10) MINAGE  FROM Divisions
GO

--SELF JOIN
CREATE TABLE Employee
(Id int primary key,
Name varchar(10),
Boss_Id int
);
GO

INSERT INTO Employee(Id,Name,Boss_Id)
VALUES
(1,'John',3),
(2,'Mathew',1),
(3,'Raj',2)
GO

SELECT *FROM Employee
GO

SELECT ONE.Name , TWO.Name As Boss
FROM Employee ONE
INNER JOIN Employee TWO on ONE.Boss_id = TWO.Id
GO

---STORED PROCEDURE WITH OUT PARAMETER
create procedure Out_testOne (@InValue int, @OutValue int output)
as
begin
set @OutValue = @InValue
end
GO

declare @Number int ;
exec Out_testOne @InValue=3, @OutValue = @Number output
select @Number 'Integer'
GO

