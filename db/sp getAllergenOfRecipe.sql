USE recipe_app;
DROP PROCEDURE IF EXISTS getAllergensOfRecipe;

DELIMITER //

CREATE PROCEDURE getAllergensOfRecipe(recipeID int)
BEGIN
    IF recipeID < 1 THEN
		SIGNAL SQLSTATE '42000'
			SET MESSAGE_TEXT = 'Invalid recipeID. Cannot be negative number.',
		mysql_errno = 1231;
	END IF;
    
	SELECT allergen.id, allergen.allergen
    FROM recipe
		JOIN recipe_has_ingredient ON recipe.id = recipe_has_ingredient.recipeID
        JOIN ingredient ON ingredient.id = recipe_has_ingredient.ingredientID
        JOIN ingredient_has_allergen ON ingredient.id = ingredient_has_allergen.ingredientID
        JOIN allergen ON allergen.id = ingredient_has_allergen.allergenID
    WHERE recipe.id = recipeID;
END //

DELIMITER ;