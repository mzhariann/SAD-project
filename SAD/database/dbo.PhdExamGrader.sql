CREATE TABLE [dbo].[PhdExamGrader] (
    [Id]          INT NOT NULL,
    [hasSubmitedGrade] BIT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([Id]) REFERENCES [dbo].[Professor] ([Id])
);

