if not exists(select 1 from dbo.[User])
begin
	insert into dbo.[User] (FirstName, LastName)
	values ('Mohssin', 'Abihilal'),
	('John', 'Stone'),
	('Abdul', 'Mo');
end
GO
