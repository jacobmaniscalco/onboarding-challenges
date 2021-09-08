SELECT Department, Count(Worker_ID) 
FROM Employee
GROUP BY Department 
ORDER BY Count(Worker_ID) DESC;