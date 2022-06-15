USE recipe_app;
DROP PROCEDURE IF EXISTS getAllergens;

DELIMITER //

CREATE PROCEDURE getAllergens()
BEGIN
	SELECT allergen.id, allergen.allergen
    FROM allergen;
END //

DELIMITER ;