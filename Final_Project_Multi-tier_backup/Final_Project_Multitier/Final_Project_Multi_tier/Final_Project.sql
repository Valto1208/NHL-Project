SELECT * FROM login
SELECT * FROM Patients
SELECT * FROM AdmissionRecords
SELECT * FROM Beds

INSERT INTO login values ('admin', '123')


ALTER TABLE	login ADD Position NVARCHAR(20) NULL 

ALTER TABLE Login ALTER COLUMN Login NOT NULL PRIMARY KEY
ALTER TABLE Login ALTER COLUMN UserName NVARCHAR(20) NOT NULL
ALTER TABLE Login ADD PRIMARY KEY (UserName)


UPDATE login set Position ='Admin' where UserName = 'admin'

SELECT Position FROM login WHERE UserName= 'admin'


INSERT INTO login values ('Jose', '123', 'Admissions')

INSERT INTO login values ('Nurse', '123', 'Nurse')
DELETE FROM Login WHERE UserName= 'Admissions'

INSERT INTO login values ('EmiKing', '123', 'Doctor')



ALTER TABLE Patients ADD  InsuranceCompany NVARCHAR(30)

ALTER TABLE Patients
DROP COLUMN InsuranceCompany;


ALTER TABLE Patients ADD  PatientID NVARCHAR(15) NOT NULL PRIMARY KEY


ALTER TABLE Doctors ALTER COLUMN DoctorID VARCHAR(4) NOT NULL
ALTER TABLE Doctors ADD PRIMARY KEY (DoctorID)

ALTER TABLE Patients ALTER COLUMN Doctor VARCHAR(4) NOT NULL
ALTER TABLE Patients ADD FOREIGN KEY (Doctor) REFERENCES Doctors (DoctorID)


ALTER TABLE AdmissionRecords ALTER COLUMN BedNumber VARCHAR(3) NOT NULL
ALTER TABLE Beds ADD PRIMARY KEY (BedNumber) 



ALTER TABLE Beds ADD PatientID NVARCHAR(15) FOREIGN KEY REFERENCES Patients (PatientID)

---BedNumber cambiar a not null
ALTER TABLE AdmissionRecords ALTER COLUMN BedNumber VARCHAR(3) NOT NULL
ALTER TABLE AdmissionRecords ADD BedNumber VARCHAR(3) FOREIGN KEY REFERENCES Beds (BedNumber)
ALTER TABLE AdmissionRecords ADD FOREIGN KEY (BedNumber) REFERENCES Beds (BedNumber)


ALTER table AdmissionRecords DROP COLUMN BedNumber



DROP TABLE AdmissionRecords

CREATE TABLE AdmissionRecords
(
AdmissionID NVARCHAR(30) NOT NULL PRIMARY KEY,
PatientID  NVARCHAR (15)NOT NULL FOREIGN KEY REFERENCES Patients (PatientID),
BedNumber NVARCHAR(3),
SurgeryScheduled BIT NOT NULL,
AdmitDate DATETIME,
SurgeryDate DATETIME,
DischargeDate DATETIME
)




CREATE PROCEDURE SP_INSERT_Patients
	@PatientID NVARCHAR(15),
	@HealthNumber NVARCHAR(15),
	@DateOfBirth VARCHAR(15),
	@LastName NVARCHAR(30),
	@FirstName  NVARCHAR(30),
	@Address NVARCHAR(50),
	@City  NVARCHAR(30),
	@Province  NVARCHAR(15),
	@PostalCode  NVARCHAR(7),
	@Phone  NVARCHAR(14),
	@InsuranceCompany  NVARCHAR(30),
	@InsuranceNumber  NVARCHAR(15),
	@NextOfKin  NVARCHAR(30),
	@NextOfKinRelationship  NVARCHAR(10),
	@Doctor  NVARCHAR(4)
AS 


	
	INSERT INTO  Patients(HealthNumber,DateOfBirth,LastName,FirstName,Address,City,Province,PostalCode,Phone,InsuranceNumber,NextOfKin,NextOfKinRelationship,Doctor,PatientID,InsuranceCompany)
	VALUES (@HealthNumber,@DateOfBirth,@LastName,@FirstName,@Address,@City,@Province,@PostalCode,@Phone,@InsuranceNumber,@NextOfKin,@NextOfKinRelationship,@Doctor,@PatientID,@InsuranceCompany)
	RETURN 


	INSERT INTO Doctors VALUES ('4321','Juguetes','Doctora','Brain')

	INSERT INTO Beds VALUES ('B01','Private',1,'Brain')
	DELETE FROM Beds WHERE BedNumber='124'

	INSERT INTO Beds VALUES ('H01','Semi-Private',1,'Heart')

	INSERT INTO AdmissionRecords VALUES ('1234','123456789101112', 0, SYSDATETIME(),SYSDATETIME(), SYSDATETIME(), 'B01')
	INSERT INTO AdmissionRecords VALUES ('1235','123456789101112', 1, SYSDATETIME(),SYSDATETIME(), SYSDATETIME(),'H01')
	DELETE FROM AdmissionRecords WHERE AdmissionID='1233'
	DELETE FROM AdmissionRecords WHERE AdmissionID='1234'


	SELECT BedNumber FROM AdmissionRecords WHERE PatientID = '123456789101112'
	SELECT * FROM Patients
	SELECT * FROM AdmissionRecords

	SELECT * FROM Beds
	SELECT * FROM Extra_Rates
	
	INSERT INTO Extra_Rates VALUES ('SemiPriv', 267 )
	INSERT INTO Extra_Rates VALUES ('Private', 571 )
	INSERT INTO Extra_Rates VALUES ('TV', 42.50 )
	INSERT INTO Extra_Rates VALUES ('Phone', 7.50 )




CREATE PROCEDURE SP_INSERT_AdmissionRecords
	@AdmissionID NVARCHAR(30),
	@PatientID NVARCHAR(15),
	@BedNumber NVARCHAR(3),
	@SurgeryScheduled BIT,
	@AdmitDate DATETIME,
	@SurgeryDate DATETIME,
	@DischargeDate DATETIME
AS 
	INSERT INTO  AdmissionRecords(AdmissionID,PatientID,BedNumber,SurgeryScheduled,AdmitDate,SurgeryDate ,DischargeDate)
	VALUES (@AdmissionID,@PatientID,@BedNumber,@SurgeryScheduled,@AdmitDate,@SurgeryDate ,@DischargeDate)
	RETURN 


	2022-12-11 21:57:28.743


DROP PROCEDURE SP_INSERT_Extras
CREATE PROCEDURE SP_INSERT_Extras
	@PatientID NVARCHAR(15),
	@AdmissionRecordID NVARCHAR(30),
	@TV BIT,
	@Phone BIT,
	@SemiPrivate BIT,
	@Private BIT,
	@Ward BIT
AS 
	INSERT INTO  Extras(PatientID,AdmissionRecordID,TV,Phone,SemiPrivate,Private,Ward)
	VALUES (@PatientID,@AdmissionRecordID,@TV,@Phone,@SemiPrivate,@Private,@Ward)
	RETURN 

SELECT * FROM Extras



ALTER TABLE Extras ALTER COLUMN PatientID NVARCHAR(15) NOT NULL 
ALTER TABLE Extras ADD FOREIGN KEY (PatientID) REFERENCES Patients (PatientID)


ALTER TABLE Extras ALTER COLUMN AdmissionRecordID NVARCHAR(30) NOT NULL 
ALTER TABLE Extras ADD FOREIGN KEY (AdmissionRecordID) REFERENCES AdmissionRecords (AdmissionID)


ALTER TABLE Extras ADD Ward Bit

select * from Extras
	DELETE FROM Extras WHERE PatientID='123456789101112'
	DELETE FROM Extras WHERE AdmissionID='1234'

ALTER TABLE Beds DROP Constraint  FK__Beds__PatientID__0D7A0286

ALTER TABLE Beds DROP COLUMN PatientID



