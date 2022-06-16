USE recipe_app;
DROP PROCEDURE IF EXISTS getRecipe;

DELIMITER //

CREATE PROCEDURE getRecipe(recipeID int)
BEGIN
    IF recipeID < 1 THEN
		SIGNAL SQLSTATE '42000'
			SET MESSAGE_TEXT = 'Invalid recipeID. Cannot be negative number.',
		mysql_errno = 1231;
	END IF;
    
	SELECT recipe.id, recipe.`Name`, recipe.Instructions, 
		recipe.cooktime, recipe.nutritionID, recipe.ethnicOriginID
	FROM recipe
    WHERE recipe.id = recipeID;
END //

DELIMITER ;