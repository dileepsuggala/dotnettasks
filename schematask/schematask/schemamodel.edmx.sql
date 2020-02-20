
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/18/2020 10:31:54
-- Generated from EDMX file: D:\DS\c#\schematask\schematask\schemamodel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [task];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_studentarrangement]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[arrangements] DROP CONSTRAINT [FK_studentarrangement];
GO
IF OBJECT_ID(N'[dbo].[FK_coursearrangement]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[arrangements] DROP CONSTRAINT [FK_coursearrangement];
GO
IF OBJECT_ID(N'[dbo].[FK_invigilatorarrangement]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[arrangements] DROP CONSTRAINT [FK_invigilatorarrangement];
GO
IF OBJECT_ID(N'[dbo].[FK_examcenterarrangement]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[arrangements] DROP CONSTRAINT [FK_examcenterarrangement];
GO
IF OBJECT_ID(N'[dbo].[FK_roomarrangement]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[arrangements] DROP CONSTRAINT [FK_roomarrangement];
GO
IF OBJECT_ID(N'[dbo].[FK_schoolarrangement]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[arrangements] DROP CONSTRAINT [FK_schoolarrangement];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[students]', 'U') IS NOT NULL
    DROP TABLE [dbo].[students];
GO
IF OBJECT_ID(N'[dbo].[examcenters]', 'U') IS NOT NULL
    DROP TABLE [dbo].[examcenters];
GO
IF OBJECT_ID(N'[dbo].[invigilators]', 'U') IS NOT NULL
    DROP TABLE [dbo].[invigilators];
GO
IF OBJECT_ID(N'[dbo].[schools]', 'U') IS NOT NULL
    DROP TABLE [dbo].[schools];
GO
IF OBJECT_ID(N'[dbo].[courses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[courses];
GO
IF OBJECT_ID(N'[dbo].[rooms]', 'U') IS NOT NULL
    DROP TABLE [dbo].[rooms];
GO
IF OBJECT_ID(N'[dbo].[arrangements]', 'U') IS NOT NULL
    DROP TABLE [dbo].[arrangements];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'students'
CREATE TABLE [dbo].[students] (
    [sid] int IDENTITY(1,1) NOT NULL,
    [sname] nvarchar(max)  NOT NULL,
    [age] int  NOT NULL,
    [standard] int  NOT NULL,
    [subject] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'examcenters'
CREATE TABLE [dbo].[examcenters] (
    [centerid] int IDENTITY(1,1) NOT NULL,
    [centername] nvarchar(max)  NOT NULL,
    [location] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'invigilators'
CREATE TABLE [dbo].[invigilators] (
    [invigilatorid] int IDENTITY(1,1) NOT NULL,
    [iname] nvarchar(max)  NOT NULL,
    [workingschool] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'schools'
CREATE TABLE [dbo].[schools] (
    [schoolid] int IDENTITY(1,1) NOT NULL,
    [schoolname] nvarchar(max)  NOT NULL,
    [area] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'courses'
CREATE TABLE [dbo].[courses] (
    [courseid] int IDENTITY(1,1) NOT NULL,
    [coursename] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'rooms'
CREATE TABLE [dbo].[rooms] (
    [roomid] int IDENTITY(1,1) NOT NULL,
    [capacity] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'arrangements'
CREATE TABLE [dbo].[arrangements] (
    [day] datetime  NOT NULL,
    [student_sid] int  NOT NULL,
    [course_courseid] int  NOT NULL,
    [invigilator_invigilatorid] int  NOT NULL,
    [examcenter_centerid] int  NOT NULL,
    [room_roomid] int  NOT NULL,
    [school_schoolid] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [sid] in table 'students'
ALTER TABLE [dbo].[students]
ADD CONSTRAINT [PK_students]
    PRIMARY KEY CLUSTERED ([sid] ASC);
GO

-- Creating primary key on [centerid] in table 'examcenters'
ALTER TABLE [dbo].[examcenters]
ADD CONSTRAINT [PK_examcenters]
    PRIMARY KEY CLUSTERED ([centerid] ASC);
GO

-- Creating primary key on [invigilatorid] in table 'invigilators'
ALTER TABLE [dbo].[invigilators]
ADD CONSTRAINT [PK_invigilators]
    PRIMARY KEY CLUSTERED ([invigilatorid] ASC);
GO

-- Creating primary key on [schoolid] in table 'schools'
ALTER TABLE [dbo].[schools]
ADD CONSTRAINT [PK_schools]
    PRIMARY KEY CLUSTERED ([schoolid] ASC);
GO

-- Creating primary key on [courseid] in table 'courses'
ALTER TABLE [dbo].[courses]
ADD CONSTRAINT [PK_courses]
    PRIMARY KEY CLUSTERED ([courseid] ASC);
GO

-- Creating primary key on [roomid] in table 'rooms'
ALTER TABLE [dbo].[rooms]
ADD CONSTRAINT [PK_rooms]
    PRIMARY KEY CLUSTERED ([roomid] ASC);
GO

-- Creating primary key on [day] in table 'arrangements'
ALTER TABLE [dbo].[arrangements]
ADD CONSTRAINT [PK_arrangements]
    PRIMARY KEY CLUSTERED ([day] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [student_sid] in table 'arrangements'
ALTER TABLE [dbo].[arrangements]
ADD CONSTRAINT [FK_studentarrangement]
    FOREIGN KEY ([student_sid])
    REFERENCES [dbo].[students]
        ([sid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_studentarrangement'
CREATE INDEX [IX_FK_studentarrangement]
ON [dbo].[arrangements]
    ([student_sid]);
GO

-- Creating foreign key on [course_courseid] in table 'arrangements'
ALTER TABLE [dbo].[arrangements]
ADD CONSTRAINT [FK_coursearrangement]
    FOREIGN KEY ([course_courseid])
    REFERENCES [dbo].[courses]
        ([courseid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_coursearrangement'
CREATE INDEX [IX_FK_coursearrangement]
ON [dbo].[arrangements]
    ([course_courseid]);
GO

-- Creating foreign key on [invigilator_invigilatorid] in table 'arrangements'
ALTER TABLE [dbo].[arrangements]
ADD CONSTRAINT [FK_invigilatorarrangement]
    FOREIGN KEY ([invigilator_invigilatorid])
    REFERENCES [dbo].[invigilators]
        ([invigilatorid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_invigilatorarrangement'
CREATE INDEX [IX_FK_invigilatorarrangement]
ON [dbo].[arrangements]
    ([invigilator_invigilatorid]);
GO

-- Creating foreign key on [examcenter_centerid] in table 'arrangements'
ALTER TABLE [dbo].[arrangements]
ADD CONSTRAINT [FK_examcenterarrangement]
    FOREIGN KEY ([examcenter_centerid])
    REFERENCES [dbo].[examcenters]
        ([centerid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_examcenterarrangement'
CREATE INDEX [IX_FK_examcenterarrangement]
ON [dbo].[arrangements]
    ([examcenter_centerid]);
GO

-- Creating foreign key on [room_roomid] in table 'arrangements'
ALTER TABLE [dbo].[arrangements]
ADD CONSTRAINT [FK_roomarrangement]
    FOREIGN KEY ([room_roomid])
    REFERENCES [dbo].[rooms]
        ([roomid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_roomarrangement'
CREATE INDEX [IX_FK_roomarrangement]
ON [dbo].[arrangements]
    ([room_roomid]);
GO

-- Creating foreign key on [school_schoolid] in table 'arrangements'
ALTER TABLE [dbo].[arrangements]
ADD CONSTRAINT [FK_schoolarrangement]
    FOREIGN KEY ([school_schoolid])
    REFERENCES [dbo].[schools]
        ([schoolid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_schoolarrangement'
CREATE INDEX [IX_FK_schoolarrangement]
ON [dbo].[arrangements]
    ([school_schoolid]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------