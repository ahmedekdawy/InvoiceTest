IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Items] (
    [Id] int NOT NULL IDENTITY,
    [AddedDate] datetime2 NULL,
    [ModifiedDate] datetime2 NULL,
    [Name] nvarchar(max) NULL,
    CONSTRAINT [PK_Items] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Stores] (
    [Id] int NOT NULL IDENTITY,
    [AddedDate] datetime2 NULL,
    [ModifiedDate] datetime2 NULL,
    [Name] nvarchar(max) NULL,
    CONSTRAINT [PK_Stores] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Units] (
    [Id] int NOT NULL IDENTITY,
    [AddedDate] datetime2 NULL,
    [ModifiedDate] datetime2 NULL,
    [Name] nvarchar(max) NULL,
    CONSTRAINT [PK_Units] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Invoices] (
    [Id] int NOT NULL IDENTITY,
    [AddedDate] datetime2 NULL,
    [ModifiedDate] datetime2 NULL,
    [InvoiceNo] nvarchar(max) NULL,
    [Date] datetime2 NOT NULL,
    [StoreId] int NOT NULL,
    [Total] nvarchar(max) NULL,
    [Taxes] nvarchar(max) NULL,
    [Net] nvarchar(max) NULL,
    CONSTRAINT [PK_Invoices] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Invoices_Stores_StoreId] FOREIGN KEY ([StoreId]) REFERENCES [Stores] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [InvoiceDetails] (
    [Id] int NOT NULL IDENTITY,
    [AddedDate] datetime2 NULL,
    [ModifiedDate] datetime2 NULL,
    [InvoiceId] int NOT NULL,
    [ItemId] int NOT NULL,
    [UnitId] int NOT NULL,
    [Price] nvarchar(max) NULL,
    [QTY] nvarchar(max) NULL,
    [Total] nvarchar(max) NULL,
    [Discount] nvarchar(max) NULL,
    [Net] nvarchar(max) NULL,
    CONSTRAINT [PK_InvoiceDetails] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_InvoiceDetails_Invoices_InvoiceId] FOREIGN KEY ([InvoiceId]) REFERENCES [Invoices] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_InvoiceDetails_Items_ItemId] FOREIGN KEY ([ItemId]) REFERENCES [Items] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_InvoiceDetails_Units_UnitId] FOREIGN KEY ([UnitId]) REFERENCES [Units] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_InvoiceDetails_InvoiceId] ON [InvoiceDetails] ([InvoiceId]);

GO

CREATE INDEX [IX_InvoiceDetails_ItemId] ON [InvoiceDetails] ([ItemId]);

GO

CREATE INDEX [IX_InvoiceDetails_UnitId] ON [InvoiceDetails] ([UnitId]);

GO

CREATE INDEX [IX_Invoices_StoreId] ON [Invoices] ([StoreId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200913191256_dd', N'3.1.7');

GO

