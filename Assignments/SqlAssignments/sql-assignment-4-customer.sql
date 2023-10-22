create database CustomerDB
go

use CustomerDB
go

create table Customer
(
ID int identity(1,1),
Name varchar(15),
Gender varchar(15),
City varchar(15),
Salary int,
constraint PK_Customer_ID primary key(ID),
);
go

insert into Customer(Name,Gender,Salary,City)
values
('Tom','Male',4000,'London'),
('Pam','Female',3000,'New York'),
('John','Male',3500,'London'),
('Sam','Male',4500,'London'),
('Todd','Male',2800,'Sydney'),
('Ben','Male',7000,'New York'),
('Sara','Female',4800,'Sydney'),
('Valarie','Female',5500,'New York'),
('James','Male',6500,'London'),
('Russell','Male',8800,'London');
go

create procedure sp_TotalSalaryByCity
as
begin
select City,sum(Salary) as total_salary from Customer group by City
end
go

execute sp_TotalSalaryByCity
go

create procedure sp_TotalSalaryByCityAndByGender
as
begin
select City,Gender, sum(Salary) as total_salary from Customer group by City,Gender
end
go

execute sp_TotalSalaryByCityAndByGender
go

create procedure sp_TotalSalaryAndTotalCustomerByCityAndByGender
as
begin
select City, Gender,sum(Salary) as total_salary,count(*) as total_Customers from Customer group by City,Gender
end
go

execute sp_TotalSalaryAndTotalCustomerByCityAndByGender
go

create procedure sp_GetAllCustomers(@Gender varchar(15),@City varchar(15))
as
begin
select *from Customer where Gender=@Gender and City=@City
end
go

execute sp_GetAllCustomers 'Female','New York'
go






