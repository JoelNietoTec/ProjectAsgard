CREATE TABLE [dbo].[Bills]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Client] INT NOT NULL, 
    [Vendor] INT NOT NULL, 
    [TotalAmount] MONEY NOT NULL, 
    [Date] DATETIME NOT NULL, 
    CONSTRAINT [FK_Bills_ToClients] FOREIGN KEY ([Client]) REFERENCES [Clients]([Id]), 
    CONSTRAINT [FK_Bills_ToVendors] FOREIGN KEY ([Vendor]) REFERENCES [Vendors]([Id])
)
