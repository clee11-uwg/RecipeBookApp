USE recipe_app;
DROP PROCEDURE IF EXISTS getKitchenwareOfRecipe;

DELIMITER //

CREATE PROCEDURE getKitchenwareOfRecipe(recipeID int)
BEGIN
    IF recipeID < 1 THEN
		SIGNAL SQLSTATE '42000'
			SET MESSAGE_TEXT = 'Invalid recipeID. Cannot be negative number.',
		mysql_errno = 1231;
	END IF;
    
	SELECT kitchenware.id, kitchenware.kitchenware
    FROM recipe
		JOIN recipe_uses_kitchenware ON recipe.id = recipe_uses_kitchenware.recipeID
        JOIN kitchenware ON kitchenware.id = recipe_uses_kitchenware.kitchenwareID
    WHERE recipe.id = recipeID;
END //

DELIMITER ;