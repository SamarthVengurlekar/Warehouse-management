use FinshedGoods;

CREATE TABLE WareHouseLocations (
	ProductID varchar(50),
    Building INT NOT NULL,
    Aisle varchar(50) NOT NULL,
    Bay INT NOT NULL,
    Tier varchar(50) NOT NULL,
    Position INT NOT NULL,
    PRIMARY KEY (Building, Aisle, Bay, Tier, Position)
);

INSERT INTO WareHouseLocations values(
"", 1, "AAA", 6, "E", 3);

select * from WareHouseLocations;

update WareHouseLocations set ProductID = '' WHERE 1 LIMIT 100;









Drop table WareHouseLocations;
