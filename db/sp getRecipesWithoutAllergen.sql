USE recipe_app;
DROP PROCEDURE IF EXISTS getRecipesWithoutAllergen;

DELIMITER //

CREATE PROCEDURE getRecipesWithoutAllergen(allergenID int)
BEGIN
    IF allergenID < 1 THEN
		SIGNAL SQLSTATE '42000'
			SET MESSAGE_TEXT = 'Invalid allergenID. Cannot be negative number.',
		mysql_errno = 1231;
	END IF;
    
	DROP TABLE IF EXISTS tempAllergicRecipes;
	CREATE TEMPORARY TABLE tempAllergicRecipes AS
    SELECT recipe.id AS `id`
    FROM recipe
		JOIN nutrition ON nutrition.id = recipe.nutritionID
		JOIN ethnic_origin ON recipe.ethnicOriginID = ethnic_origin.id
		JOIN recipe_has_ingredient ON recipe.id = recipe_has_ingredient.recipeID
		JOIN ingredient ON ingredient.id = recipe_has_ingredient.ingredientID
		JOIN ingredient_has_allergen ON ingredient.id = ingredient_has_allergen.ingredientID
		JOIN allergen ON allergen.id = ingredient_has_allergen.allergenID
	WHERE allergen.id = 3;
    
	SELECT recipe.id, recipe.`Name`, recipe.Instructions, 
		recipe.cooktime, nutrition.stub,
		ethnic_origin.ethnicity
	FROM recipe
		JOIN nutrition ON recipe.nutritionID = nutrition.id
		JOIN ethnic_origin ON recipe.ethnicOriginID = ethnic_origin.id
	WHERE recipe.id NOT IN tempAllergicRecipes;
END //

DELIMITER ;