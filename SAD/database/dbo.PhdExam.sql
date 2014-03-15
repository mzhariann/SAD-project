CREATE TABLE [dbo].[PhdExam]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [examDate] DATE NULL, 
    [designDeadline] VARCHAR(50) NULL, 
    [keyPoints] VARCHAR(50) NULL, 
    [grades] VARCHAR(50) NULL
)
