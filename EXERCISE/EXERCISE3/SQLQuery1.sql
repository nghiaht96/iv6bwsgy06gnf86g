select p.Name, sum(o.Amout) as bestsale from Product p,OrderDetail o where p.ID = o.ID_Pro group by p.ID,p.Name 
having sum(o.Amout) >= all(select sum(Amout) from OrderDetail group by ID_Pro)