USE [UserStatus.Data.UserContext]

CREATE TABLE Users (
	username VARCHAR(20) PRIMARY KEY NOT NULL,
	stat VARCHAR(1) NOT NULL
)

-- stat : [U]nderstood | [I]nformation Required | [N]o respose

DELETE FROM Users

INSERT INTO Users VALUES ('User1', 'N');
INSERT INTO Users VALUES ('User2', 'N');
INSERT INTO Users VALUES ('User3', 'N');
INSERT INTO Users VALUES ('User4', 'N');
INSERT INTO Users VALUES ('User5', 'N');
INSERT INTO Users VALUES ('User6', 'N');
INSERT INTO Users VALUES ('User7', 'N');
INSERT INTO Users VALUES ('User8', 'N');
INSERT INTO Users VALUES ('User9', 'N');
INSERT INTO Users VALUES ('User10', 'N');

SELECT * FROM Users ;
SELECT COUNT(*) FROM Users WHERE Stat = 'I';

SELECT * FROM USERS WHERE Username = 'User20859';

INSERT INTO [Users] VALUES ('User10', null);

UPDATE Users SET Stat = null;
UPDATE Users SET Stat = 'N' FROM Users WHERE Username IN (SELECT TOP 5 Username FROM Users );

SELECT TOP 1 * FROM Users ;

GO
DECLARE @i int = 0
WHILE @i < 5000
BEGIN
    UPDATE Users SET Stat = 'U' WHERE Username = CONCAT('User', @i)
	SET @i = @i + 1
END

