create database CompanyDB
go

use CompanyDB
go

create table Departments
(
Id int identity(1,1),
DepartmentName varchar(20),
Location varchar(20) default 'London',
DepartmentHead varchar(20),
constraint PK_Departments_Id primary key(Id)
);
go

Insert into Departments(DepartmentName,DepartmentHead)
values('IT','Rick');
go

Insert into Departments(DepartmentName,Location,DepartmentHead)
values
('Payroll','Delhi','ROn'),
('HR','New York','Christie'),
('Other Department','Sydney','Cindrella');
go

create table Employees
(
ID int identity(1,1),
Name varchar(20),
Gender varchar(10),
Salary int,
DepartmentId int,
constraint CK_Employees_Salary check (Salary>2500),
constraint PK_Employees_ID primary key(ID),
constraint FK_Employees_DepartmentId foreign key(DepartmentId)
references Departments(Id)
);
go

insert into Employees(Name,Gender,Salary,DepartmentId)
values
('Tom','Male',4000,1),
('Pam','Female',3000,3),
('John','Male',3500,1),
('Sam','Male',4500,2),
('Todd','Male',2800,2),
('Ben','Male',7000,1),
('Sara','Female',4800,3),
('Valarie','Female',5500,1),
('James','Male',6500,NULL),
('Russell','Male',8800,NULL);
go

create procedure sp_GetAllEmployees
as
begin
select E.Name,E.Gender,E.Salary,D.DepartmentName from Employees E
join Departments D on E.DepartmentId = D.Id
end
go

execute sp_GetAllEmployees
go

create procedure sp_GetAllEmployeesWithNull
as
begin
select E.Name,E.Gender,E.Salary,D.DepartmentName from Employees E
left join Departments D on E.DepartmentId = D.Id
end
go

execute sp_GetAllEmployeesWithNull
go

create procedure sp_GetTotalSalaryByGender
as
begin
select E.Gender, sum(Salary) as TotalSalary from Employees E
group by Gender
end
go

execute sp_GetTotalSalaryByGender
go

create procedure sp_GetTotalSalaryByDepartmentName
as
begin
select D.DepartmentName, sum(Salary) as TotalSalary from Employees E
left join Departments D on E.DepartmentId = D.Id
group by DepartmentName
end
go

execute sp_GetTotalSalaryByDepartmentName
go

--create procedure sp_UpdateSalary(@ID int,@Salary int)
--as
--begin

--end
--go

--execute sp_UpdateSalary
--go

--create procedure sp_DeleteById(@ID int)
--as
--begin

--end
--go

--execute sp_DeleteById
--go

create procedure sp_GetTotalEmployeesByDepartmentName
as
begin
select D.DepartmentName, count(*) as TotalEmployess from Employees E
left join Departments D on E.DepartmentId =D.Id
group by DepartmentName
end
go

execute sp_GetTotalEmployeesByDepartmentName
go



