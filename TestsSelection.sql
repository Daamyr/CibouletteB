select c.NoCham, c.Etage, c.CodTypCham, com.CodCom, com.DescCom 
from Chambre c join Ayant a on c.NoCham = a.NoCham join Commodite com on a.CodCom = com.CodCom

select *
from Client

select c.NoCham, c.Etage, c.CodTypCham, r.DateDebut, r.DateFin, cli.Nom as 'Réservé par', r.DateReser
from Chambre c, De d, Reservation r, Client cli
where c.NoCham = d.NoCham
	AND d.IdReser = r.IdReser
	AND r.IdCli = cli.IdCli