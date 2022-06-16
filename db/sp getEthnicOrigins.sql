USE recipe_app;
DROP PROCEDURE IF EXISTS getEthnicOrigins;

DELIMITER //

CREATE PROCEDURE getEthnicOrigins()
BEGIN
	SELECT ethnic_origin.id, ethnic_origin.Ethnicity
    FROM ethnic_origin;
END //

DELIMITER ;