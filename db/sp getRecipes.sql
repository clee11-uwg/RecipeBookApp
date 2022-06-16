USE recipe_app;
DROP PROCEDURE IF EXISTS getRecipes;

DELIMITER //

CREATE PROCEDURE getRecipes()
BEGIN
	SELECT recipe.id, recipe.`Name`, recipe.Instructions, 
		recipe.cooktime, recipe.nutritionID,
		recipe.ethnicOriginID
	FROM recipe;
END

DELIMITER ;