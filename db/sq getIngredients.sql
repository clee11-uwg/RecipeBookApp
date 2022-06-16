USE recipe_app;
DROP PROCEDURE IF EXISTS getIngredients;

DELIMITER //

CREATE PROCEDURE getIngredients()
BEGIN
	SELECT ingredient.id, ingredient.ingredient, 
		ingredient.typeOfFoodID, ingredient.nutritionID
	FROM ingredient;
END //

DELIMITER ;