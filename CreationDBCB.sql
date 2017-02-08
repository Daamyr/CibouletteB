set dateformat dmy

IF OBJECT_ID (N'Ayant', N'U') IS NOT NULL
DROP TABLE Ayant
IF OBJECT_ID (N'De', N'U') IS NOT NULL
DROP TABLE De
IF OBJECT_ID (N'Arrive', N'U') IS NOT NULL
DROP TABLE Arrive
IF OBJECT_ID (N'Trx', N'U') IS NOT NULL
DROP TABLE Trx
IF OBJECT_ID (N'TypeTrx', N'U') IS NOT NULL
DROP TABLE TypeTrx
IF OBJECT_ID (N'Commodite', N'U') IS NOT NULL
DROP TABLE Commodite
IF OBJECT_ID (N'Depart', N'U') IS NOT NULL
DROP TABLE Depart
IF OBJECT_ID (N'Chambre', N'U') IS NOT NULL
DROP TABLE Chambre
IF OBJECT_ID (N'Localisation', N'U') IS NOT NULL
DROP TABLE Localisation
IF OBJECT_ID (N'TypeCham', N'U') IS NOT NULL
DROP TABLE TypeCham
IF OBJECT_ID (N'Reservation', N'U') IS NOT NULL
DROP TABLE Reservation
IF OBJECT_ID (N'Client', N'U') IS NOT NULL
DROP TABLE Client

create table Localisation
(
	CodLoc				varchar(2)			not null,
	DescLoc				varchar(25)			null,

	constraint PK_LOC		primary key (CodLoc),
)

create table TypeCham
(
	CodTypCham			varchar(2)			not null,
	DescTyp				varchar(25)			null,
	NbDispo				int					null,

	constraint PK_TYPC		primary key (CodTypCham),
)

create table Commodite
(
	CodCom				varchar(2)			not null,
	DescCom				varchar(25)			null,

	constraint PK_COM		primary key (CodCom),
)

create table Client
(
	IdCli				int identity(1,1)	not null,
	Nom					varchar(100)		null,
	Adresse				varchar(100)		null,
	Telephone			varchar(10)			null,
	NoCarte				varchar(16)			null,
	TypeCarte			varchar(15)			null,
	DateExp				date				null,
	Solde_Du			decimal(12,2)		null,


	constraint PK_CLI		primary key(IdCli),
)

create table Reservation
(
	IdReser				int identity(1,1)	not null,
	DateReser			date				null,
	DateDebut			date				null,
	DateFin				date				null,
	IdCli				int					not null,

	constraint PK_RES		primary key (IdReser),
	constraint FK_RESCLI	foreign key (IdCli)	references Client (IdCli),
)

create table Chambre
(
	NoCham				varchar(4)			not null,
	Etage				varchar(2)			null,
	Prix				dec(12,2)			null,
	Etat				tinyint				null,
	Memo				varchar				null,
	CodLoc				varchar(2)			not null,
	CodTypCham			varchar(2)			not null,
	
	constraint PK_CHAM		primary key (NoCham),
	constraint FK_CHAMLOC	foreign key (CodLoc)		references Localisation (CodLoc),
	constraint FK_CHAMTYP	foreign key (CodTypCham)	references TypeCham (CodTypCham),
)

create table Ayant
(
	NoCham				varchar(4)			not null,
	CodCom				varchar(2)			not null,

	constraint FK_AYANTCHAM	foreign key (NoCham)	references Chambre (NoCham),
	constraint FK_AYANTCOM	foreign key (CodCom)	references Commodite (CodCom),
)

create table De
(
	Attribue			tinyint				null,
	IdReser				int					not null,
	NoCham				varchar(4)			not null,

	constraint FK_DERES		foreign key(IdReser)	references Reservation (IdReser),
	constraint FK_DECHAM	foreign key(NoCham)		references Chambre (NoCham),
)

create table Arrive
(
	IdArrive			int identity(1,1)	not null,
	DateArrive			date				null,
	IdCli				int					not null,
	IdReser				int					not null,
	NoCham				varchar(4)			not null,

	constraint PK_ARR		primary key (IdArrive),
	constraint FK_ARRCLI	foreign key (IdCli)		references Client (IdCli),
	constraint FK_ARRRES	foreign key (IdReser)	references Reservation (IdReser),
	constraint FK_ARRCHAM	foreign key (NoCham)	references Chambre (NoCham),
)

create table Depart
(
	IdDepart			int identity(1,1)	not null,
	DateDepart			date				null,
	ConfirmerPar		varchar(2)			null,
	IdReser				int					not null,
	NoCham				varchar(4)			not null,
	IdCli				int					not null,

	constraint PK_DEP		primary key(IdDepart),
	constraint FK_DEPRES	foreign key	(IdReser)	references Reservation (IdReser),
	constraint FK_DEPCHAM	foreign key	(NoCham)	references Chambre (NoCham),
	constraint FK_DEPCLI	foreign key	(IdCli)		references Client (IdCli),
)

create table TypeTrx
(
	CodTypTrx			varchar(2)			not null,
	DescTrx				varchar(25)			null,
	Nature				varchar(2)			null,			/* DB (debit) or CR (credit) */

	constraint PK_TYPT		primary key (CodTypTrx),
)

create table Trx
(
	IdTrx				int	identity(1,1)	not null,
	DateTrx				date				null,
	MontantTrx			dec(12,2)			null,
	Reportee			tinyint				null,
	CodTypTrx			varchar(2)			not null,
	IdReser				int					not null,
	NoCham				varchar(4)			not null,
	IdCli				int					not null,

	constraint PK_TRX		primary key (IdTrx),
	constraint FK_TRXTYP	foreign key (CodTypTrx) references TypeTrx (CodTypTrx),
	constraint FK_TRXRES	foreign key	(IdReser)	references Reservation (IdReser),
	constraint FK_TRXCHAM	foreign key	(NoCham)	references Chambre (NoCham),
	constraint FK_TRXCLI	foreign key	(IdCli)		references Client (IdCli),
)