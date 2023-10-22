create database ModuleDB
go

use ModuleDB
go

create table Department
(
Id int identity(1,1) primary key,
Name varchar(10),
DeptHead varchar(10),
Location varchar(10)
);
go

insert into Department(Name,DeptHead,Location)
values
('IT','Tony','Chennai'),
('Payroll','Yamuna','Kerala'),
('HR','Ram','Pune'),
('Timesheet','George','Bangalore');
go

create table GenderType
(
Id int identity(1,1) primary key,
Gender varchar(10)
);
go

insert into GenderType(Gender)
values
('Male'),
('Female');
go

create table Employee
(
Id int primary key,
Name varchar(10),
Country varchar(10),
Salary int,
DepartmentId int foreign key 
references Department(Id),
GenderID int foreign key 
references GenderType(Id)
);
go

insert into Employee(Id,Name,Country,Salary,DepartmentId,GenderID)
values
(1,'Jitu','India',4000,1,1),
(3,'Dibas','India',6500,2,1),
(4,'Gajendra','India',3800,2,1),
(5,'Raja','India',9000,1,1),
(6,'Jeni','India',5800,3,2),
(7,'Chandin','India',8500,1,2),
(8,'Pintu','India',9500,NULL,1),
(9,'Subrat','India',9800,NULL,1);
go

create procedure sp_GetAllEmployeeDetails
as
begin 
Select E.Name,E.Country,E.Salary,D.Name,G.Gender from Employee E
left join Department D on E.DepartmentId=D.Id
join GenderType G on E.GenderID=G.Id
end
go

execute sp_GetAllEmployeeDetails
go








