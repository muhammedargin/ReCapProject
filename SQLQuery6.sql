CREATE TABLE Colors(
	ColorID int PRIMARY KEY IDENTITY(1,1),
	ColorName nvarchar(25),
)

CREATE TABLE Brands(
	BrandID int PRIMARY KEY IDENTITY(1,1),
	BrandName nvarchar(25),
)
CREATE TABLE Cars(
	CarID int PRIMARY KEY IDENTITY(1,1),
	BrandID int,
	ColorID int,
	ModelYear nvarchar(25),
	DailyPrice decimal,
	Descriptions nvarchar(25),
	FOREIGN KEY (ColorID) REFERENCES Colors(ColorID),
	FOREIGN KEY (BrandID) REFERENCES Brands(BrandID)
)




INSERT INTO Cars(BrandID,ColorID,ModelYear,DailyPrice,Descriptions)
VALUES
	('1','2','2012','150','Manuel Benzin'),
	('2','1','2015','249','Otomatik Dizel'),
	('1','3','2017','249','Otomatik,Hesaplı Renault'),
	('3','3','2019','499','Otomatik Dizel');

INSERT INTO Colors(ColorName)
VALUES
	('Kırmızı'),
	('Metalik Gri'),
	('Mat Siyah');


INSERT INTO Brands(BrandName)
VALUES
	('Renault'),
	('BMW'),
	('Mercedes');