USE FarmaNet;

CREATE TABLE Pharmacy
(
	Id INT PRIMARY KEY IDENTITY,
	Name VARCHAR(50) NOT NULL,
	Address VARCHAR(255) NOT NULL,
	Email VARCHAR(50) NOT NULL,
	Description VARCHAR(1000) NULL
);

CREATE TABLE Position
(
	Id INT PRIMARY KEY IDENTITY,
	Position VARCHAR(30) NOT NULL,
	SalaryInHours DECIMAL(5, 2) NOT NULL
);

CREATE TABLE WorkerInformation
(
	Id INT PRIMARY KEY IDENTITY,
	Name VARCHAR(20) NOT NULL,
	LastName VARCHAR(30) NOT NULL,
	DataBirth DATE NOT NULL,
	SeriesPassport TINYINT NOT NULL,
	NumberPassport TINYINT NOT NULL,
	Experience TINYINT NULL,
	Email VARCHAR(50) NOT NULL,
	IdPosition INT NOT NULL,
	FOREIGN KEY (IdPosition) REFERENCES Position (Id),
);

CREATE TABLE WorkerAccount
(
	Id INT PRIMARY KEY IDENTITY,
	Login VARCHAR(255) NOT NULL,
	Password VARCHAR(255) NOT NULL,
	IdWorkerInformation INT NOT NULL,
	IdPharmacy INT NOT NULL,
	FOREIGN KEY (IdPharmacy) REFERENCES Pharmacy (Id),
	FOREIGN KEY (IdWorkerInformation) REFERENCES WorkerInformation (Id)
);

CREATE TABLE TypeMedication
(
	Id INT PRIMARY KEY IDENTITY,
	Name VARCHAR(80) NOT NULL,
);

CREATE TABLE Medication
(
	Id INT PRIMARY KEY IDENTITY,
	Name VARCHAR(20) NOT NULL,
	Recipe VARCHAR(1) NOT NULL,
	IdType INT NOT NULL,
	FOREIGN KEY (IdType) REFERENCES TypeMedication (Id)
);

CREATE TABLE Supplier
(
	Id INT PRIMARY KEY IDENTITY,
	Name VARCHAR(30) NOT NULL,
	Inn VARCHAR(20) NOT NULL
);

CREATE TABLE Import
(
	Id INT PRIMARY KEY IDENTITY,
	Number SMALLINT NOT NULL,
	Date DATE NOT NULL,
	SumPrice DECIMAL(11, 2) NOT NULL,
	IdSupplier INT NOT NULL,
	IdPharmacy INT NOT NULL,
	FOREIGN KEY (IdSupplier) REFERENCES Supplier (Id),
	FOREIGN KEY (IdPharmacy) REFERENCES Pharmacy (Id)
);

CREATE TABLE Manufacturer
(
	Id INT PRIMARY KEY IDENTITY,
	Name VARCHAR(30) NOT NULL,
	Address VARCHAR(100) NOT NULL
);

CREATE TABLE WorkingHours
(
	Id INT PRIMARY KEY IDENTITY,
	IdWorker INT NOT NULL,
	Date DATE NOT NULL,
	Time TIME NOT NULL,
	Description VARCHAR(255) NOT NULL,
	FOREIGN KEY (IdWorker) REFERENCES WorkerAccount (Id)
);

CREATE TABLE Sale
(
	IdMedication INT NOT NULL,
	IdPharmacy INT NOT nULL,
	PRIMARY KEY (IdMedication, IdPharmacy),
	FOREIGN KEY (IdMedication) REFERENCES Medication (Id),
	FOREIGN KEY (IdPharmacy) REFERENCES Pharmacy (Id)
);

CREATE TABLE WriteDowns
(
	IdMedication INT NOT NULL,
	IdPharmacy INT NOT NULL,
	Quantity INT NOT NULL,
	PRIMARY KEY (IdMedication, IdPharmacy),
	FOREIGN KEY (IdMedication) REFERENCES Medication (Id),
	FOREIGN KEY (IdPharmacy) REFERENCES Pharmacy (Id)
);

CREATE TABLE ImportWithMedication
(
	IdInvoice INT NOT NULL,
	IdMedication INT NOT NULL,
	Quantity INT NOT NULL,
	Price DECIMAL(7, 2) NOT NULL,
	PRIMARY KEY (IdInvoice, IdMedication),
	FOREIGN KEY (IdInvoice) REFERENCES Import (Id),
	FOREIGN KEY (IdMedication) REFERENCES Medication (Id)
);

CREATE TABLE MedicationWithManufacturer
(
	IdManufacturer INT NOT NULL,
	IdMedication INT NOT NULL,
	PRIMARY KEY (IdManufacturer, IdMedication),
	FOREIGN KEY (IdManufacturer) REFERENCES Manufacturer (Id),
	FOREIGN KEY (IdMedication) REFERENCES Medication (Id)
);

CREATE TABLE PharmacyWithMedication
(
	IdMedication INT NOT NULL,
	IdPharmacy INT NOT NULL,
	Quantity INT NOT NULL,
	Price DECIMAL(7, 2) NOT NULL,
	PRIMARY KEY (IdMedication, IdPharmacy),
	FOREIGN KEY (IdMedication) REFERENCES Medication (Id),
	FOREIGN KEY (IdPharmacy) REFERENCES Pharmacy (Id)
);