SELECT * FROM Worker
INNER JOIN Bonus ON 
Worker.Worker_ID = Bonus.Worker_Ref_ID;