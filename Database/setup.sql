CREATE DATABASE sampledb;
GO
USE sampledb;
GO
CREATE TABLE hobbies(
   hobby_id int NOT NULL   IDENTITY   PRIMARY KEY,
   hobby NVARCHAR (50) UNIQUE NOT NULL
);
GO

INSERT INTO hobbies(hobby) VALUES('jogging');
GO
INSERT INTO hobbies(hobby) VALUES('hiking');
GO
INSERT INTO hobbies(hobby) VALUES('swimming');
GO
INSERT INTO hobbies(hobby) VALUES('diving');
GO
INSERT INTO hobbies(hobby) VALUES('cooking');
GO
INSERT INTO hobbies(hobby) VALUES('reading');
GO


