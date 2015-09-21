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
where info.OrderServed == null
orderby info.TableID
select new
{
	Table = info.TableID,
	
	Order = from item in Items
			orderby item.Description
			select new
			{
				Description = item.Description,
				Price = item.CurrentPrice,
			}
			
}

