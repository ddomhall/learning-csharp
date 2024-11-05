CREATE TABLE [dbo].[People]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [AddressId] INT NOT NULL, 
    [EmployerId] INT NOT NULL,
    [Name] VARCHAR(20) NOT NULL 
)
