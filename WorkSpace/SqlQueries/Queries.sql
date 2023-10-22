SELECT *FROM Student

--returns the number of rows in the Student table
SELECT COUNT(*) AS Student_Count
FROM Student

--returns the max of age 
SELECT MAX(age) AS MAX_AGE 
FROM Student


SELECT MIN(age) FROM Student

UPDATE Student SET age=40
WHERE id=4

DELETE FROM Student
WHERE id = 3

--removes all rows from table
--TRUNCATE table Student

--select age between 40 and 50
SELECT age
FROM Student
WHERE age BETWEEN 40 AND 50







