CREATE PROCEDURE [dbo].[UpdateEtu]
	@Name varchar(25),
	@CNE varchar(25)
AS
	UPDATE Etu Set name= @Name  ,CNE=@CNE ;
RETURN 0