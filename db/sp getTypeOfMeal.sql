USE recipe_app;
DROP PROCEDURE IF EXISTS getTypeOfMeal;

DELIMITER //

CREATE PROCEDURE getTypeOfMeal()
BEGIN
	SELECT type_of_meal.id, type_of_meal.Type
	FROM type_of_meal;
END //

DELIMITER ;