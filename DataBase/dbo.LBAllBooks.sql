CREATE TABLE [dbo].[LBAllBooks] (
    [Id]           INT          NOT NULL,
    [Name]         VARCHAR (50) NULL,
    [Author]       VARCHAR (50) NULL,
    [Publisher]    VARCHAR (50) NULL,
    [Genre]        VARCHAR (50) NULL,
    [Quantity]     VARCHAR (50) NULL,
    [Availability] VARCHAR (50) NULL,
    [Price] VARCHAR(50) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

