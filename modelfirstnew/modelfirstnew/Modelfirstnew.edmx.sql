
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/17/2020 13:30:00
-- Generated from EDMX file: D:\DS\c#\modelfirstnew\modelfirstnew\Modelfirstnew.edmx
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


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'cats'
CREATE TABLE [dbo].[cats] (
    [cid] int IDENTITY(1,1) NOT NULL primary key,
    [ctitle] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'pros'
CREATE TABLE [dbo].[pros] (
    [pid] int IDENTITY(1,1) NOT NULL primary key,
    [ptype] nvarchar(max)  NOT NULL,
    [price] float  NOT NULL,
    [cid] int  NOT NULL constraint fk_p foreign key references cats(cid)
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [cid] in table 'cats'
ALTER TABLE [dbo].[cats]
ADD CONSTRAINT [PK_cats]
    PRIMARY KEY CLUSTERED ([cid] ASC);
GO

-- Creating primary key on [pid] in table 'pros'
ALTER TABLE [dbo].[pros]
ADD CONSTRAINT [PK_pros]
    PRIMARY KEY CLUSTERED ([pid] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------