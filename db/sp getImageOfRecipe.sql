USE recipe_app;
DROP PROCEDURE IF EXISTS getImageOfRecipe;

DELIMITER //

CREATE PROCEDURE getImageOfrecipe(recipeID int)
BEGIN
    IF recipeID < 1 THEN
		SIGNAL SQLSTATE '42000'
			SET MESSAGE_TEXT = 'Invalid recipeID. Cannot be negative number.',
		mysql_errno = 1231;
	END IF;
    
	SELECT image.image
    FROM recipe
		JOIN image ON recipe.id = image.recipeID
    WHERE recipe.id = recipeID;
END //

DELIMITER ;