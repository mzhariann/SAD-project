CREATE TABLE [dbo].[Student]
(
	[SID] INT NOT NULL PRIMARY KEY, 
    [fname] VARCHAR(50) NULL, 
    [lname] VARCHAR(50) NULL, 
    [email] VARCHAR(50) NULL, 
    [degree] INT NULL, 
    [entranceYear] INT NULL, 
    [major] INT NULL
	foreign key(major) references major
)
