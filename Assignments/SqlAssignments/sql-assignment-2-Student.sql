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

select *from Student
go

select *from Student where Gender='Male'
go

select *from Student where Gender='female'
go

select *from Student where Mark>45
go

select *from Student where Name like'j%'
go

select *from Student where Name like'%a'
go

select Gender, sum(Mark) as TotalMark from Student group by Gender
go

select Gender, count(*) as TotalStudents from Student group by Gender
go

select Gender, count(*) as TotalStudents from Student where Mark>70 group by Gender
go

