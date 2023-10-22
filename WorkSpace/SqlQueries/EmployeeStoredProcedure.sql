create procedure sp_GetAllEmployee
as 
Begin
select *from Employee
End

execute sp_GetAllEmployee
go


create proc sp_GetEmployeeById(@id int)
as
Begin
SELECT Employee.id,Gender.gender  FROM  Employee
JOIN Gender ON
Employee.id = Gender.id
End

execute sp_GetEmployeeById 2
go

