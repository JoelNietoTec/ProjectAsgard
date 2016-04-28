CREATE TABLE [dbo].[Clients]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(200) NOT NULL, 
    [BillName] NVARCHAR(200) NULL, 
    [ClientType] INT NOT NULL, 
    [DocumentId] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(150) NULL, 
    [Address] NTEXT NULL, 
    [CreateDate] DATETIME NOT NULL, 
    [LastUpdate] DATETIME NULL, 
    CONSTRAINT [FK_Clients_ToClientTypes] FOREIGN KEY ([ClientType]) REFERENCES [ClientTypes]([Id])
)
