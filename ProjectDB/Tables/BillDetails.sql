CREATE TABLE [dbo].[BillDetails]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Bill] INT NOT NULL, 
    [Product] INT NOT NULL, 
    [Quantity] INT NOT NULL, 
    [UnitPrice] MONEY NULL, 
    [Amount] NCHAR(10) NULL, 
    CONSTRAINT [FK_BillDetails_ToBills] FOREIGN KEY ([Bill]) REFERENCES [Bills]([Id]), 
    CONSTRAINT [FK_BillDetails_ToProducts] FOREIGN KEY ([Product]) REFERENCES [Products]([Id])
)
