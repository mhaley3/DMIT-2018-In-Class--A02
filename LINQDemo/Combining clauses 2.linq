<Query Kind="Expression">
  <Connection>
    <ID>274bc064-2990-4ae8-ad61-f3c55a4658f2</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// List all the menu items that are Entrees in order from most to least expensive
from food in Items
orderby food.CurrentPrice descending
where food.MenuCategory.Description == "Entree"
|| 	  food.MenuCategory.Description == "Beverage"

group food by food.MenuCategoryID into result

select result