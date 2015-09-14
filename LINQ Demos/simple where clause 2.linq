<Query Kind="Expression">
  <Connection>
    <ID>3d288bdc-3d48-4cc2-8525-dd415cf1c695</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// booking is a variable name that I made up
from booking in Reservations
where booking.EventCode.Equals("A")
select booking