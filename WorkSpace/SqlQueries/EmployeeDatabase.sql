CREATE DATABASE EmployeeDB
GO

USE EmployeeDB
GO

--employee table
CREATE TABLE Employee
(
id INT,
firstName VARCHAR(20),
lastName VARCHAR(20),
gender VARCHAR(10)
);
GO

--default constraint
ALTER TABLE Employee
ADD CONSTRAINT Df_Employee_gender
DEFAULT 'unknown' for gender
GO

--insert values
INSERT INTO Employee
VALUES 
(1,'Bhoomika','Mahesh','female'),
(2,'Raj','Kishore','male'),
(3,'Rakshith','Shetty','male'),
(4,'Navya','Shree','female'),
(5,'Arun','Kumar','male')
GO

--not null
ALTER TABLE Employee
ALTER COLUMN id INT NOT NULL
GO

--primary key
ALTER TABLE Employee
ADD CONSTRAINT PK_Employee_id PRIMARY KEY(id)
GO

--displays all records in employee table
SELECT *FROM Employee
GO

--gender table
CREATE TABLE Gender
(
id INT,
gender VARCHAR(10),
CONSTRAINT PK_Gender_id PRIMARY KEY(id)
);
GO

INSERT INTO Gender
VALUES
(1,'male'),
(2,'female'),
(3,'unkown');
GO

--displays all gender table records
SELECT *FROM Gender
GO

--drop table employee
DROP TABLE Employee
GO


--The syntax of the SQL FOREIGN KEY constraint is:

--CREATE TABLE table_name (
--    column1 data_type,
--    column2 data_type,
--    ...,
--    FOREIGN KEY (column_name)
--    REFERENCES referenced_table_name (referenced_column_name)
--);

--employee table
CREATE TABLE Employee
(
id INT,
firstName VARCHAR(20),
lastName VARCHAR(20),
gender INT,
CONSTRAINT FK_Employee_gender FOREIGN KEY(gender)
REFERENCES Gender(id)
);
GO

INSERT INTO Employee
VALUES 
(1,'Bhoomika','Mahesh',2),
(2,'Raj','Kishore',1),
(3,'Rakshith','Shetty',3),
(4,'Navya','Shree',2),
(5,'Arun','Kumar',1)
GO

--The INSERT statement conflicted with the FOREIGN KEY constraint "FK_Employee_gender". 
--The conflict occurred in database "EmployeeDB", table "dbo.Gender", column 'id'.
INSERT INTO Employee
VALUES(6,'Amal','Raja',5)
GO

--displays all employee records
SELECT *FROM Employee
GO

--join
SELECT Employee.id,Employee.firstName,Employee.lastName, Gender.gender  FROM  Employee
JOIN Gender ON
Employee.id = Gender.id
GO









