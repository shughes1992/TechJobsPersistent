--Part 1

Jobs Table:
Id : INT
Name : String
EmployerId : INT


--Part 2 SQL TASK: In queries.sql under “Part 2”, write a query to list the names of the employers in St. Louis City.
SELECT name FROM Employers
where Location = "St. Louis City";


--Part 3 SQL TASK: In queries.sql under “Part 3”, write a query to return a list of the names and descriptions of all
--skills that are attached to jobs in alphabetical order. If a skill does not have a job listed,
--it should not be included in the results of this query.

select Name, Description from Skills
inner join JobSkills
on JobSkills.SkillId = Skills.Id
order by Name;