CREATE TABLE [dbo].[Evaluator] (
    [Id]    INT          NOT NULL,
    [email] VARCHAR (50) NULL,
    [fName] VARCHAR (50) NULL,
    [lName] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
	FOREIGN KEY ([Id]) REFERENCES [dbo].[Person] ([Id]),
);

