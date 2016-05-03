CREATE TABLE [dbo].[BillDetails]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [BillId] INT NOT NULL, 
    [ProductId] INT NOT NULL, 
    [Quantity] INT NOT NULL, 
    [UnitPrice] MONEY NULL, 
    [Amount] MONEY NULL, 
    CONSTRAINT [FK_BillDetails_ToBills] FOREIGN KEY ([BillId]) REFERENCES [Bills]([Id]), 
    CONSTRAINT [FK_BillDetails_ToProducts] FOREIGN KEY ([ProductId]) REFERENCES [Products]([Id])
)
