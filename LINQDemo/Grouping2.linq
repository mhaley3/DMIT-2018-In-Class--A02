<Query Kind="Expression">
  <Connection>
    <ID>274bc064-2990-4ae8-ad61-f3c55a4658f2</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from food in Items
group food by new {food.MenuCategoryID, food.CurrentPrice}
//No need for the select clause if all you want is grouping