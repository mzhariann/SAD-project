CREATE TABLE [dbo].[PhdExamDesigner]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [professorId] INT NULL
	foreign key (professorId) references [dbo].[Professor]
)
