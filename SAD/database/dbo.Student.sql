CREATE TABLE [dbo].[Student] (
    [Id]           INT          NOT NULL,
    [fname]        VARCHAR (50) NULL,
    [lname]        VARCHAR (50) NULL,
    [email]        VARCHAR (50) NULL,
    [degree]       INT          NULL,
    [entranceYear] INT          NULL,
    [majorId]      INT          NULL,
    [supervisor]   INT          NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([majorId]) REFERENCES [dbo].[Major] ([Id]),
    FOREIGN KEY ([supervisor]) REFERENCES [dbo].[Professor] ([Id]),
	FOREIGN KEY ([Id]) REFERENCES [dbo].[Person] ([Id]),
);

