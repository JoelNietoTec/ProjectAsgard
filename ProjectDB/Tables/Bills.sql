CREATE TABLE [dbo].[Bills]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ClientId] INT NOT NULL, 
    [VendorId] INT NOT NULL, 
    [TotalAmount] MONEY NOT NULL, 
    [Date] DATETIME NOT NULL, 
    CONSTRAINT [FK_Bills_ToClients] FOREIGN KEY ([ClientId]) REFERENCES [Clients]([Id]), 
    CONSTRAINT [FK_Bills_ToVendors] FOREIGN KEY ([VendorId]) REFERENCES [Vendors]([Id])
)
