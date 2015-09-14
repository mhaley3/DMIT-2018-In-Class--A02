<Query Kind="Expression">
  <Connection>
    <ID>3d288bdc-3d48-4cc2-8525-dd415cf1c695</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from row in Tables
where row.Capacity > 3
select row