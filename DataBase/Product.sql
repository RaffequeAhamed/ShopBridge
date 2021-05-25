IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Product' and xtype='U')
BEGIN 
 CREATE TABLE [dbo].Product(
    [ProductID] [int] IDENTITY(1,1) NOT NULL,
    [ProductName] [nvarchar](200) NOT NULL,
    [ProductDescription] VARCHAR(max) NULL,
	[ProductUnit] int NOT NULL,
	[ProductPrice] decimal NOT NULL,
	[ProductQuantity] int NOT NULL,
	[ProductStatus] int NOT NULL,
	[ProductManufacturedDate] DATETIME NOT NULL,
 CONSTRAINT [PK_Properties] PRIMARY KEY CLUSTERED 
(
    [ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
end