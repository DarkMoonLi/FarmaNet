USE FarmaNet;

CREATE TABLE Pharmacy
(
	IdPharmacy INT PRIMARY KEY IDENTITY,
	Name VARCHAR(50) NOT NULL,
	Address VARCHAR(255) NOT NULL,
	Email VARCHAR(100) NULL,
	Description VARCHAR(1000) NULL
);

CREATE TABLE Position
(
	IdPosition INT PRIMARY KEY IDENTITY,
	Position VARCHAR(30) NOT NULL,
	SalaryInHours DECIMAL(5, 2) NOT NULL
);

CREATE TABLE WorkerInformation
(
	IdWorkerInformation INT PRIMARY KEY IDENTITY,
	Name VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	DataBirth DATE NOT NULL,
	SeriesPassport TINYINT NOT NULL,
	NumberPassport TINYINT NOT NULL,
	Experience TINYINT NULL,
	Email VARCHAR(100) NULL,
	IdPosition INT NOT NULL,
	FOREIGN KEY (IdPosition) REFERENCES Position (IdPosition),
);

CREATE TABLE WorkerAccount
(
	IdWorkerAccount INT PRIMARY KEY IDENTITY,
	Login VARCHAR(255) NOT NULL,
	Password VARCHAR(255) NOT NULL,
	IdWorkerInformation INT NOT NULL,
	IdPharmacy INT NOT NULL,
	FOREIGN KEY (IdPharmacy) REFERENCES Pharmacy (Id),
	FOREIGN KEY (IdWorkerInformation) REFERENCES WorkerInformation (IdWorkerInformation)
);

/*Нужно создать таблицу для связи типа медикамента с медикаментом*/
CREATE TABLE TypeMedication
(
	IdTypeMedication INT PRIMARY KEY IDENTITY,
	Name VARCHAR(80) NOT NULL,
);

CREATE TABLE Medication
(
	IdMedication INT PRIMARY KEY IDENTITY,
	Name VARCHAR(50) NOT NULL,
	Recipe VARCHAR(500) NOT NULL,
	IdTypeMedication INT NOT NULL,
	FOREIGN KEY (IdTypeMedication) REFERENCES TypeMedication (IdTypeMedication)
);

CREATE TABLE Supplier
(
	IdSupplier INT PRIMARY KEY IDENTITY,
	Name VARCHAR(50) NOT NULL,
	Inn VARCHAR(20) NOT NULL
);

CREATE TABLE Import
(
	IdImport INT PRIMARY KEY IDENTITY,
	Number SMALLINT NOT NULL,
	Date DATE NOT NULL,
	SumPrice DECIMAL(11, 2) NOT NULL,
	IdSupplier INT NOT NULL,
	IdPharmacy INT NOT NULL,
	FOREIGN KEY (IdSupplier) REFERENCES Supplier (IdSupplier),
	FOREIGN KEY (IdPharmacy) REFERENCES Pharmacy (IdPharmacy)
);

CREATE TABLE Manufacturer
(
	IdManufacturer INT PRIMARY KEY IDENTITY,
	Name VARCHAR(100) NOT NULL,
	Address VARCHAR(100) NOT NULL
);

CREATE TABLE WorkingHours
(
	IdWorkingHours INT PRIMARY KEY IDENTITY,
	IdWorkerAccount INT NOT NULL,
	Date DATE NOT NULL,
	Time TIME NOT NULL,
	Description VARCHAR(1000) NOT NULL,
	FOREIGN KEY (IdWorkerAccount) REFERENCES WorkerAccount (IdWorkerAccount)
);

CREATE TABLE Sale
(
	IdMedication INT NOT NULL,
	IdPharmacy INT NOT nULL,
	PRIMARY KEY (IdMedication, IdPharmacy),
	FOREIGN KEY (IdMedication) REFERENCES Medication (IdMedication),
	FOREIGN KEY (IdPharmacy) REFERENCES Pharmacy (IdPharmacy)
);

CREATE TABLE WriteDowns
(
	IdMedication INT NOT NULL,
	IdPharmacy INT NOT NULL,
	Quantity INT NOT NULL,
	PRIMARY KEY (IdMedication, IdPharmacy),
	FOREIGN KEY (IdMedication) REFERENCES Medication (IdMedication),
	FOREIGN KEY (IdPharmacy) REFERENCES Pharmacy (IdPharmacy)
);

CREATE TABLE ImportWithMedication
(
	IdInvoice INT NOT NULL,
	IdMedication INT NOT NULL,
	Quantity INT NOT NULL,
	Price DECIMAL(7, 2) NOT NULL,
	PRIMARY KEY (IdInvoice, IdMedication),
	FOREIGN KEY (IdInvoice) REFERENCES Import (IdImport),
	FOREIGN KEY (IdMedication) REFERENCES Medication (IdMedication)
);

CREATE TABLE MedicationWithManufacturer
(
	IdManufacturer INT NOT NULL,
	IdMedication INT NOT NULL,
	PRIMARY KEY (IdManufacturer, IdMedication),
	FOREIGN KEY (IdManufacturer) REFERENCES Manufacturer (IdManufacturer),
	FOREIGN KEY (IdMedication) REFERENCES Medication (IdMedication)
);

CREATE TABLE PharmacyWithMedication
(
	IdMedication INT NOT NULL,
	IdPharmacy INT NOT NULL,
	Quantity INT NOT NULL,
	Price DECIMAL(7, 2) NOT NULL,
	PRIMARY KEY (IdMedication, IdPharmacy),
	FOREIGN KEY (IdMedication) REFERENCES Medication (IdMedication),
	FOREIGN KEY (IdPharmacy) REFERENCES Pharmacy (IdPharmacy)
);