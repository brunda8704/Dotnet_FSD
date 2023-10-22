---****CONSTRAINTS****
SELECT *FROM Student


--****CHECK CONSTRAINT****
ALTER TABLE Student 
ADD CONSTRAINT CK_Student_age 
CHECK (age>0 and age<100)

--ERROR
INSERT INTO Student(age) VALUES (-1)

--REMOVE CHECK CONSTRAINT
ALTER TABLE Student
DROP CONSTRAINT CK_Student_age



--****DEFAULT CONSTRAINT****
ALTER TABLE Student 
ADD CONSTRAINT Default_Student_id
DEFAULT 0 FOR id

--insert values except age
INSERT INTO Student(firstName,lastName,age,email) VALUES('Surya','Raj',59,'surya@gmail.com')

--REMOVE DEFAULT CONSTRAINT
ALTER TABLE Student
DROP CONSTRAINT Default_Student_id
