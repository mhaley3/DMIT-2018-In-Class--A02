<Query Kind="Expression">
  <Connection>
    <ID>274bc064-2990-4ae8-ad61-f3c55a4658f2</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from info in Bills
where info.BillDate.Year == 2014
&& info.BillDate.Month == 5
&& info.BillDate.Day == 25 
&& info.ReservationID != null
select info
