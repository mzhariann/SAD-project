CREATE TABLE [dbo].[Evaluator] (
    [Id]          INT          NOT NULL,
    [hasSubmited] BIT          NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([Id]) REFERENCES [dbo].[Person] ([Id])
);

