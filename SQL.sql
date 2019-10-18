Create table TypeOfInstrument(
	IDtype int primary key,
	Nametype nvarchar(max),
	introduction nvarchar(max)
);

Create table Manufacturers(
	IDmanu int primary key,
	Namemanu nvarchar(max),
	Addressmanu nvarchar(max),
	Emailmanu nvarchar(max),
	Phonenumber varchar(10),
	Information nvarchar(max),
	Logoaddress nvarchar(max)
);

Create table MusicInstruments(
	IDmi int primary key,
	Namemi nvarchar(max),
	Costmanu float,
	IDmanu int foreign key references Manufacturers(IDmanu)
);