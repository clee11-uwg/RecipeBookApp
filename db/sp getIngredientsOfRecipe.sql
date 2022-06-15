USE recipe_app;
DROP PROCEDURE IF EXISTS getIngredientsOfRecipe;

DELIMITER //

CREATE PROCEDURE getIngredientsOfRecipe(recipeID int)
BEGIN
    IF recipeID < 1 THEN
		SIGNAL SQLSTATE '42000'
			SET MESSAGE_TEXT = 'Invalid recipeID. Cannot be negative number.',
		mysql_errno = 1231;
	END IF;
	SELECT ingredient.id, ingredient.Ingredient, type_of_food.`Type`,
		nutrition.stub
    FROM recipe
		JOIN recipe_has_ingredient ON recipe_has_ingredient.recipeID = recipe.id
        JOIN ingredient ON recipe_has_ingredient.ingredientID = ingredient.id
        JOIN type_of_food ON ingredient.typeOfFoodID = type_of_food.id
        JOIN nutrition ON ingredient.nutritionID = nutrition.id
    WHERE recipe.id = recipeID;
END //

DELIMITER ;