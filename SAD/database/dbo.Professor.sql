CREATE TABLE [dbo].[Professor]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [email] VARCHAR(50) NULL, 
    [fName] VARCHAR(50) NULL, 
    [lName] VARCHAR(50) NULL, 
    [deptManager] BIT NULL
)
