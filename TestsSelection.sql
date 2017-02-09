select c.NoCham, c.Etage, c.CodTypCham, com.CodCom, com.DescCom 
from Chambre c join Ayant a on c.NoCham = a.NoCham join Commodite com on a.CodCom = com.CodCom

select *
from Client

select c.NoCham, c.Etage, c.CodTypCham, r.DateDebut, r.DateFin, r.IdCli as 'Réservé par', r.DateReser
from Chambre c join De d on c.NoCham = d.NoCham join Reservation r on d.IdReser = r.IdReser