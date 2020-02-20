
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/17/2020 13:11:26
-- Generated from EDMX file: D:\DS\c#\modelfirstconsole\modelfirstconsole\Modelfirstentity.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [dileep];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_categoryproduct]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[products] DROP CONSTRAINT [FK_categoryproduct];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[products];
GO
IF OBJECT_ID(N'[dbo].[categories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[categories];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'products'
CREATE TABLE [dbo].[products] (
    [Pid] int IDENTITY(1,1) NOT NULL,
    [Ptype] nvarchar(max)  NOT NULL,
    [Price] float  NOT NULL,
    [category_cid] int  NOT NULL
);
GO

-- Creating table 'categories'
CREATE TABLE [dbo].[categories] (
    [cid] int IDENTITY(1,1) NOT NULL,
    [ctitle] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Pid] in table 'products'
ALTER TABLE [dbo].[products]
ADD CONSTRAINT [PK_products]
    PRIMARY KEY CLUSTERED ([Pid] ASC);
GO

-- Creating primary key on [cid] in table 'categories'
ALTER TABLE [dbo].[categories]
ADD CONSTRAINT [PK_categories]
    PRIMARY KEY CLUSTERED ([cid] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [category_cid] in table 'products'
ALTER TABLE [dbo].[products]
ADD CONSTRAINT [FK_categoryproduct]
    FOREIGN KEY ([category_cid])
    REFERENCES [dbo].[categories]
        ([cid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_categoryproduct'
CREATE INDEX [IX_FK_categoryproduct]
ON [dbo].[products]
    ([category_cid]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------