create database FinshedGoods;
use FinshedGoods;

create table OrderDetails( 
OrderID varchar(50),
CustomerID varchar(50),
ProductTypeID varchar(50),
Quantity INT,
Date varchar(50),
DueDate varchar(50),
Status varchar(50));

drop table OrderDetails;

SELECT * FROM OrderDetails;

Insert into OrderDetails values(
                      "KLE1234",
                      "dep0145",
                      "large",
                       2,
                      "02/08/2023",
                      "15/08/2023",
                      "In progress");

