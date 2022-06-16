USE recipe_app;
DROP PROCEDURE IF EXISTS getKitchenware;

DELIMITER //

CREATE PROCEDURE getKitchenware()
BEGIN
	SELECT kitchenware.id, kitchenware.Kitchenware
    FROM kitchenware;
END //

DELIMITER ;