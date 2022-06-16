USE recipe_app;
DROP PROCEDURE IF EXISTS getAllergensOfIngredient;

DELIMITER //

CREATE PROCEDURE getAllergensOfIngredient(ingredientID int)
BEGIN
    IF ingredientID < 1 THEN
		SIGNAL SQLSTATE '42000'
			SET MESSAGE_TEXT = 'Invalid ingredientID. Cannot be negative number.',
		mysql_errno = 1231;
	END IF;
    
	SELECT allergen.id, allergen.allergen
    FROM ingredient
		JOIN ingredient_has_allergen ON ingredient.id = ingredient_has_allergen.ingredientID
        JOIN allergen ON allergen.id = ingredient_has_allergen.allergenID
    WHERE ingredient.id = ingredientID;
END //

DELIMITER ;