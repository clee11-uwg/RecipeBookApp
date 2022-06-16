USE recipe_app;
DROP PROCEDURE IF EXISTS getNutrition;

DELIMITER //

CREATE PROCEDURE getNutrition()
BEGIN
	SELECT nutrition.id, nutrition.Stub
	FROM nutrition;
END //

DELIMITER ;