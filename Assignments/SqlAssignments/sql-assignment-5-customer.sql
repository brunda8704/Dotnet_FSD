create database CustomerDB
go

use CustomerDB
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
constraint PK_Gender_GenderId primary key(GenderId),
);
go

insert into Gender(GenderType)
values
('Male'),
('Female');
go


create table Customer
(
ID int identity(1000,5),
Name varchar(20),
CountryId int,
GenderId int,
constraint PK_Customer_ID primary key(ID),
constraint FK_Customer_CountryId foreign key(CountryId) references Country(CountryId),
constraint FK_Customer_GenderId foreign key(GenderId) references Gender(GenderId),
);
go



insert into Customer(Name,CountryId,GenderId)
values
('John',1,1),
('Jessie',4,2),
('Tina',2,2),
('Thomas',3,NULL),
('Johnson',2,1),
('Riya',3,2),
('Tommy',4,NULL),
('Preeti',1,2);
go


create procedure sp_GetAllCustomer
as
begin
select Cust.ID, Cust.Name, G.GenderType, C.CountryName from Customer Cust
left join Gender G on Cust.GenderId=G.GenderId
join Country C on Cust.CountryId=C.CountryId
end
go

execute sp_GetAllCustomer
go


create procedure sp_DisplayCustomerByGenderType(@GenderType varchar(20))
as
begin
select Cust.ID, Cust.Name, G.GenderType, C.CountryName from Customer Cust
join Gender G on Cust.GenderId=G.GenderId
join Country C on Cust.CountryId=C.CountryId where @GenderType=GenderType 
end
go

execute sp_DisplayCustomerByGenderType 'Male'
go


create function func_CustomerMatching(@CountryId int,@GenderId int)
returns table
as
return (select Cust.ID, Cust.Name,G.GenderType, C.CountryName from Customer Cust
join Gender G on Cust.GenderId=G.GenderId
join Country C on Cust.CountryId=C.CountryId
where C.CountryId=@CountryId and G.GenderId=@GenderId)
go

select *from func_CustomerMatching(1,1)
go

create procedure sp_GetTotalCustomersByCountryName
as
begin 
select C.CountryName, count(*) as Total_Customers from Customer Cust
join Country C on Cust.CountryId= C.CountryId 
group by C.CountryName
end
go

execute sp_GetTotalCustomersByCountryName
go

