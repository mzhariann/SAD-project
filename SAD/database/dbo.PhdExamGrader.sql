CREATE TABLE [dbo].[PhdExamGrader]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [professorId] INT NULL
	foreign key (professorId) references [dbo].[Professor]
)
