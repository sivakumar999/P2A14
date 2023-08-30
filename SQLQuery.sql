create database PlayerSDB
use PlayerSDB

CREATE TABLE Players (
    PlayerId INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    JerseyNumber INT,
    Position VARCHAR(50),
    Team VARCHAR(50)
)

INSERT INTO Players (FirstName, LastName, JerseyNumber, Position, Team)
VALUES
    ('Rohit', 'Sharma', 10, 'Batsman', 'Mumbai'),
    ('Kohili', 'Virat', 11, 'Batsman', 'RCB')

select * from Players