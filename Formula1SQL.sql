CREATE DATABASE [Formula1]

CREATE TABLE [Teams](
[TeamId] INT PRIMARY KEY IDENTITY (1,1),
[TeamName] VARCHAR (255),
[Country] VARCHAR (100),
[FoundationYear] INT
)
CREATE TABLE [Drivers](
[DriverId] INT PRIMARY KEY IDENTITY (1,1),
[FirstName] VARCHAR (100),
[LastName] VARCHAR (100),
[BirthDate] DATE,
[Nationality] VARCHAR (100),
[TeamId] INT FOREIGN KEY REFERENCES Teams(TeamId)
)
CREATE TABLE [Races](
[RaceId] INT PRIMARY KEY IDENTITY (1,1),
[RaceName] VARCHAR (255),
[Location] VARCHAR (255),
[RaceDate] DATE,
[SeasonYear] INT
)
CREATE TABLE [RaseResults](
[RaceResult] INT PRIMARY KEY IDENTITY (1,1),
[RaceId] INT FOREIGN KEY REFERENCES Races(RaceId),
[DriverId] INT FOREIGN KEY REFERENCES Drivers(DriverId),
[Position] INT,
[Points] DECIMAL (5,2),
[Laps] INT,
[Time] TIME
)

INSERT INTO Teams (TeamName, Country, FoundationYear) 
VALUES
('Mercedes-AMG Petronas', 'Germany', 2010),
('Red Bull Racing', 'Austria', 2005),
('Scuderia Ferrari', 'Italy', 1929),
('McLaren F1 Team', 'United Kingdom', 1963),
('Alpine F1 Team', 'France', 2021)

INSERT INTO Drivers (FirstName, LastName, BirthDate, Nationality, TeamId) 
VALUES
('Lewis', 'Hamilton', '1985-01-07', 'British', 1),
('Max', 'Verstappen', '1997-09-30', 'Dutch', 2),
('Charles', 'Leclerc', '1997-10-16', 'Monegasque', 3),
('Lando', 'Norris', '1999-11-13', 'British', 4),
('Fernando', 'Alonso', '1981-07-29', 'Spanish', 5)

INSERT INTO Races (RaceName, Location, RaceDate, SeasonYear) 
VALUES
('Australian Grand Prix', 'Melbourne, Australia', '2025-03-16', 2025),
('Bahrain Grand Prix', 'Sakhir, Bahrain', '2025-03-30', 2025),
('Monaco Grand Prix', 'Monte Carlo, Monaco', '2025-05-25', 2025),
('British Grand Prix', 'Silverstone, UK', '2025-07-06', 2025),
('Italian Grand Prix', 'Monza, Italy', '2025-09-07', 2025)

INSERT INTO RaseResults (RaceId, DriverId, Position, Points, Laps, Time) 
VALUES
(1, 2, 1, 25.00, 58, '01:32:45'),
(1, 1, 2, 18.00, 58, '01:32:50'),
(2, 3, 1, 25.00, 57, '01:30:20'),
(3, 4, 3, 15.00, 78, '02:00:45'),
(4, 5, 2, 18.00, 52, '01:28:30')