SELECT *FROM Student

SELECT firstName,lastName,age FROM Student

--selecting id,firstName,lastName where age>25
SELECT id,firstName,lastName 
FROM Student
WHERE age>25 

--display fullname where age>25
SELECT id,(firstName+ ' ' +lastName) AS "fullName"
FROM Student
WHERE age>25