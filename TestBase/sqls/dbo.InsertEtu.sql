CREATE PROCEDURE [dbo].[InsertEtu]
	@id int ,
	@Name varchar(25),
	@CNE varchar(25)
AS
	INSERT INTO Etu Values (@id,@Name,@CNE);
RETURN 0