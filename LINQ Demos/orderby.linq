<Query Kind="Expression">
  <Connection>
    <ID>3d288bdc-3d48-4cc2-8525-dd415cf1c695</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from food in Items
orderby food.Description descending
select food