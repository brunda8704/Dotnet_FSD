create database StudentDB
go

use StudentDB
go

create table Student
(
ID int identity(1000,5),
Name varchar(20),
Gender varchar (10),
Mark int,
constraint CK_Student_Mark check(Mark>0 and Mark<=100)
);
go

insert into Student(Name,Gender,Mark)
values
('John' ,'Male', 80),
('Jessie','Female' ,92),
('Jeena','Female' ,75),
('Thomas', 'Male' ,65),
('Johnson', 'Male', 45),
('Meena', 'Female' ,50);
go

select *from Student;
go

--creating a view
create view view_Students
as
select ID,Name,Mark from Student 
where Mark>90 
go

select *from view_Students
go

--View does not allow to update the data
--create view view_student
--as
--update Student
--set Mark = 100
--where ID = 1000;
--go

 --Update the underlying Student table
update Student
set Mark = 100
where ID = 1000;
go

-- Refresh the view_Students view
alter view view_students 
as
select ID, Name, Mark
from student
where mark=100
go

select *from view_students
go
 









