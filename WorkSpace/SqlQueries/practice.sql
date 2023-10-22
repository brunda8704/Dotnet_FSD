
create database CompanyDB
go

use CompanyDB
go

create table Departments
(
Id int identity(1,1),
DepartmentName varchar(20),
Location varchar(20) default 'London',
DepartmentHead varchar(20)
constraint PK_Departments_Id primary key(Id)
);
go

insert into Departments(DepartmentName,DepartmentHead) values('IT','Rick');
go

insert into Departments(DepartmentName,Location,DepartmentHead)
values
('Payroll','Delhi','ROn'),
('HR','New York','Christie'),
('Other Department','Sydney','Cindrella');
go


create table Employees
(
ID int primary key identity(1,1),
Name varchar(20),
Gender varchar(20),
Salary int check (Salary>2500),
DepartmentId int foreign key(DepartmentId)
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
join Departments D on E.DepartmentId=D.Id
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
select E.Gender, Sum(Salary) Salary from Employees E 
group by Gender
end
go

execute sp_GetTotalSalaryByGender
go

create procedure sp_ByDepartmentName
as
begin
select D.DepartmentName , sum(Salary) Salary from Employees E 
join Departments D on E.DepartmentId = D.Id
group by DepartmentName
end
go

execute sp_ByDepartmentName
go


create procedure sp_GetTotalEmployees
as
begin
select D.DepartmentName, count(*) Employees  from Employees E
join Departments D on E.DepartmentId=D.Id
group by DepartmentName
end
go

execute sp_GetTotalEmployees
go


create procedure sp_UpdateSalary(@ID int,@Salary int)
as
begin
update Employees set Salary=@Salary 
where ID=@ID 
end
go

execute sp_UpdateSalary 1,5000
go


--select *from Employees

create procedure sp_DeleteById(@ID int)
as
begin
Delete Employees where ID=@ID
end
go

execute sp_DeleteById 1
go

--subquery
select *from Employees where Salary=
(select Max(Salary) from Employees)
go

create function func_Get(@DepartmentId int)
returns table
as
return (select E.Name,E.Gender,D.DepartmentName from Employees E 
join Departments D on E.DepartmentId=D.Id
where DepartmentId=@DepartmentId)
go

select * from func_Get(1)
go

select *from Employees
select *from Employees where Name like'T%'
--wildcards
select *from Employees where Name like 'S[m]%' 
