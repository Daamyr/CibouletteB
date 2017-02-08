select c.NoCham, c.Etage, c.CodTypCham, com.CodCom, com.DescCom 
from Chambre c join Ayant a on c.NoCham = a.NoCham join Commodite com on a.CodCom = com.CodCom

select * from Client