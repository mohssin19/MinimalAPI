CREATE PROCEDURE [dbo].[spUser_Insert]
	@FirstName Nvarchar(50),
	@LastName Nvarchar(50)
AS
begin
	insert into dbo.[User] (FirstName, LastName)
	values (@FirstName, @LastName);
end