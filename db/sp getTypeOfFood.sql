USE recipe_app;
DROP PROCEDURE IF EXISTS getTypeOfFood;

DELIMITER //

CREATE PROCEDURE getTypeOfFood()
BEGIN
	SELECT type_of_food.id, type_of_food.`Type`
    FROM type_of_food;
END //

DELIMITER ;