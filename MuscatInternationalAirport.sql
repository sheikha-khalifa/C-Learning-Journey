--create database MuscatInternationalAirport;
create table MuscatInternationalAirport (id int identity(1,1)primary key,Name varchar(25)not null,
location varchar(25) not null);

create table Passengers (passportNumber int identity(1,1)primary key,FirstName varchar(25)not null,
LastName varchar(25)not null,DOB int not null,Gender varchar (20),Nationality varchar(25) not null,
contactNumber int not null,contactEmail varchar(30) not null);

create table baggage (id int identity(1,1)primary key,Passengerid int ,weight int ,TrackingNo int,
passportNumber int foreign key REFERENCES Passengers(passportNumber),
location varchar(25) not null);

create table Airline (AirlineID int identity(1,1)primary key,person varchar(25) ,contactNumber int ,name varchar(25),
contactEmail varchar(25) not null);


create table Flights (GateNumber int identity(1,1)primary key,flightstatus varchar(25) ,DepartureCity varchar(25) ,
DestinationCity varchar(25) ,ArraivalTime int ,
AirlineID int foreign key REFERENCES Airline(AirlineID),
location varchar(25) not null);

create table AirportOfficer (PersonalID int identity(1,1)primary key,Position varchar(25) ,ContactPhone int ,
contactEmail varchar(25) ,department varchar(25) ,FirstName varchar(25),LastName varchar(25));

create table Terminal (TerminalID int identity(1,1)primary key,Capacity int,location varchar(25),TerminalName varchar(25),
passportNumber int foreign key REFERENCES Passengers(passportNumber));

create table Gates (GateID int identity(1,1)primary key,AvailavilityStatus varchar(25),GateNumber int,
AirlineID int foreign key REFERENCES Airline(AirlineID),TerminalID int foreign key REFERENCES Terminal(TerminalID));

create table securityCheckPoint (CheckPointID int identity(1,1)primary key,TerminalName varchar(25),Location varchar(25),
PersonalID int foreign key REFERENCES AirportOfficer(PersonalID)
,id int foreign key REFERENCES MuscatInternationalAirport(id),TerminalID int foreign key REFERENCES Terminal(TerminalID));


