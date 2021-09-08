SELECT Department, Count(Worker_ID) 
FROM Worker
GROUP BY Department 
ORDER BY Count(Worker_ID) DESC;