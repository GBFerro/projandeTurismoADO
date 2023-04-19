select a.Id, a.Street, a.Number, a.District, a.ZipCode,
a.Complement, c.Name, a.RegisterDate from Address a join City c on a.Id = c.Id

select cl.Id, cl.Name, cl.Phone, cl.RegisterDate
from Client cl join Address a on cl.IdAddress = a.Id join City c on a.Id = c.Id

select * from Client