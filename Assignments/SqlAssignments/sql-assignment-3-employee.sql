create database EmployeeDB
go

use EmployeeDB
go

create table Country
(
CountryId int identity(1,1),
CountryName varchar(20),
constraint PK_Country_CountryId primary key(CountryId),
);
go

insert into Country(CountryName)
values
('India'),
('USA'),
('England'),
('France');
go


create table Gender
(
GenderId int identity(1,1),
GenderType varchar(20),
constraint PK_Gender_GenderId primary key(GEnderId),
);
go


insert into Gender(GenderType)
values
('Male'),
('Female');
go


create table Employee
(
ID int identity(1000,5),
Name varchar(20),
CountryId int,
GenderId int,
constraint PK_Employee_ID primary key(ID),
constraint FK_Employee_CountryId foreign key(CountryId)
references Country(CountryId),
constraint FK_Employee_GenderId foreign key(GenderId)
references Gender(GenderId),
);
go


insert into Employee(Name,CountryId,GenderId)
values
('John',1,1),
('Jessie',4,2),
('Tina',2,2),
('Thomas',3,1),
('Johnson',2,1),
('Riya',3,2),
('Tommy',4,1),
('Preeti',1,2);
go


Select E.ID,E.Name, G.GenderType, C.CountryName from Employee E
join Gender G on E.GenderId=G.GenderId
join Country C on E.CountryId=C.CountryId
go

Select E.ID,E.Name, G.GenderType, C.CountryName from Employee E 
join Gender G on E.GenderId=G.GenderId
join Country C on E.CountryId=C.CountryId where GenderType='Male'
go

select E.ID,E.Name, G.GenderType, C.CountryName from Employee E 
join Gender G on E.GenderId=G.GenderId
join Country C on E.CountryId=C.CountryId where GenderType='Female'
go


select G.GenderType, count(*) as Total_Employees from Employee E
join Gender G on E.GenderId=G.GenderId
group by G.GenderType
go


select C.CountryName, count(*) as Total_Employees from Employee E
join Country C on E.CountryId = C.CountryId
group by C.CountryName
go







