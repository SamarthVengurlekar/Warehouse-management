use FinshedGoods;

create table ProductDetails(
OrderID varchar(50),
ProductID varchar(50),
TypeID varchar(50),
StorageLocation varchar(50),
Status varchar(50));

Insert into ProductDetails values(
					  "",
                      "lar46",
                      "large",
                      "",
                      "Consumable");
                      
update ProductDetails set StorageLocation = '' WHERE 1 LIMIT 100;
SELECT * FROM ProductDetails;

DROP TABLE ProductDetails;