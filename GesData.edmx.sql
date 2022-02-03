
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/03/2022 18:27:36
-- Generated from EDMX file: C:\Users\HP\Documents\TROISIEME ANNEE\C#\Gescom\gescom22\GesData.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [gescom22];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ProduitCategorie]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Produit] DROP CONSTRAINT [FK_ProduitCategorie];
GO
IF OBJECT_ID(N'[dbo].[FK_ProduitDetailsCommande]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetailCommande] DROP CONSTRAINT [FK_ProduitDetailsCommande];
GO
IF OBJECT_ID(N'[dbo].[FK_CommandeLivraison]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Commande] DROP CONSTRAINT [FK_CommandeLivraison];
GO
IF OBJECT_ID(N'[dbo].[FK_LivreurLivraison]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Livraison] DROP CONSTRAINT [FK_LivreurLivraison];
GO
IF OBJECT_ID(N'[dbo].[FK_PaiementCommande]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Paiement] DROP CONSTRAINT [FK_PaiementCommande];
GO
IF OBJECT_ID(N'[dbo].[FK_ClientCommande]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Commande] DROP CONSTRAINT [FK_ClientCommande];
GO
IF OBJECT_ID(N'[dbo].[FK_CommandeDetailsCommande]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetailCommande] DROP CONSTRAINT [FK_CommandeDetailsCommande];
GO
IF OBJECT_ID(N'[dbo].[FK_Livreur_inherits_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[User_Livreur] DROP CONSTRAINT [FK_Livreur_inherits_User];
GO
IF OBJECT_ID(N'[dbo].[FK_Client_inherits_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[User_Client] DROP CONSTRAINT [FK_Client_inherits_User];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[User]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User];
GO
IF OBJECT_ID(N'[dbo].[Produit]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Produit];
GO
IF OBJECT_ID(N'[dbo].[Categorie]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categorie];
GO
IF OBJECT_ID(N'[dbo].[DetailCommande]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetailCommande];
GO
IF OBJECT_ID(N'[dbo].[Commande]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Commande];
GO
IF OBJECT_ID(N'[dbo].[Paiement]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Paiement];
GO
IF OBJECT_ID(N'[dbo].[Livraison]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Livraison];
GO
IF OBJECT_ID(N'[dbo].[User_Livreur]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User_Livreur];
GO
IF OBJECT_ID(N'[dbo].[User_Client]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User_Client];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'User'
CREATE TABLE [dbo].[User] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Login] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [NomComplet] nvarchar(max)  NOT NULL,
    [Role] nvarchar(max)  NOT NULL,
    [Telephone] nvarchar(max)  NULL
);
GO

-- Creating table 'Produit'
CREATE TABLE [dbo].[Produit] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Libelle] nvarchar(max)  NOT NULL,
    [Prix] float  NOT NULL,
    [Stock] int  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Image] varbinary(max)  NOT NULL,
    [Categorie_Id] int  NOT NULL
);
GO

-- Creating table 'Categorie'
CREATE TABLE [dbo].[Categorie] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Libelle] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DetailCommande'
CREATE TABLE [dbo].[DetailCommande] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Quantite] int  NOT NULL,
    [Produit_Id] int  NOT NULL,
    [Commande_Id] int  NOT NULL
);
GO

-- Creating table 'Commande'
CREATE TABLE [dbo].[Commande] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NOT NULL,
    [Montant] float  NOT NULL,
    [AdresseLivraison] nvarchar(max)  NOT NULL,
    [Etat] nvarchar(max)  NOT NULL,
    [Client_Id] int  NOT NULL
);
GO

-- Creating table 'Paiement'
CREATE TABLE [dbo].[Paiement] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Type] nvarchar(max)  NULL,
    [Date] datetime  NULL,
    [Montant] float  NULL,
    [Commande_Id] int  NOT NULL
);
GO

-- Creating table 'Livraison'
CREATE TABLE [dbo].[Livraison] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NULL,
    [Etat] nvarchar(max)  NULL,
    [Livreur_Id] int  NOT NULL,
    [Commande_Id] int  NOT NULL
);
GO

-- Creating table 'User_Livreur'
CREATE TABLE [dbo].[User_Livreur] (
    [Matricule] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'User_Client'
CREATE TABLE [dbo].[User_Client] (
    [Adresse] nvarchar(max)  NOT NULL,
    [Solde] float  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'User'
ALTER TABLE [dbo].[User]
ADD CONSTRAINT [PK_User]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Produit'
ALTER TABLE [dbo].[Produit]
ADD CONSTRAINT [PK_Produit]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Categorie'
ALTER TABLE [dbo].[Categorie]
ADD CONSTRAINT [PK_Categorie]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DetailCommande'
ALTER TABLE [dbo].[DetailCommande]
ADD CONSTRAINT [PK_DetailCommande]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Commande'
ALTER TABLE [dbo].[Commande]
ADD CONSTRAINT [PK_Commande]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Paiement'
ALTER TABLE [dbo].[Paiement]
ADD CONSTRAINT [PK_Paiement]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Livraison'
ALTER TABLE [dbo].[Livraison]
ADD CONSTRAINT [PK_Livraison]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'User_Livreur'
ALTER TABLE [dbo].[User_Livreur]
ADD CONSTRAINT [PK_User_Livreur]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'User_Client'
ALTER TABLE [dbo].[User_Client]
ADD CONSTRAINT [PK_User_Client]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Categorie_Id] in table 'Produit'
ALTER TABLE [dbo].[Produit]
ADD CONSTRAINT [FK_ProduitCategorie]
    FOREIGN KEY ([Categorie_Id])
    REFERENCES [dbo].[Categorie]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProduitCategorie'
CREATE INDEX [IX_FK_ProduitCategorie]
ON [dbo].[Produit]
    ([Categorie_Id]);
GO

-- Creating foreign key on [Produit_Id] in table 'DetailCommande'
ALTER TABLE [dbo].[DetailCommande]
ADD CONSTRAINT [FK_ProduitDetailsCommande]
    FOREIGN KEY ([Produit_Id])
    REFERENCES [dbo].[Produit]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProduitDetailsCommande'
CREATE INDEX [IX_FK_ProduitDetailsCommande]
ON [dbo].[DetailCommande]
    ([Produit_Id]);
GO

-- Creating foreign key on [Livreur_Id] in table 'Livraison'
ALTER TABLE [dbo].[Livraison]
ADD CONSTRAINT [FK_LivreurLivraison]
    FOREIGN KEY ([Livreur_Id])
    REFERENCES [dbo].[User_Livreur]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LivreurLivraison'
CREATE INDEX [IX_FK_LivreurLivraison]
ON [dbo].[Livraison]
    ([Livreur_Id]);
GO

-- Creating foreign key on [Client_Id] in table 'Commande'
ALTER TABLE [dbo].[Commande]
ADD CONSTRAINT [FK_ClientCommande]
    FOREIGN KEY ([Client_Id])
    REFERENCES [dbo].[User_Client]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientCommande'
CREATE INDEX [IX_FK_ClientCommande]
ON [dbo].[Commande]
    ([Client_Id]);
GO

-- Creating foreign key on [Commande_Id] in table 'DetailCommande'
ALTER TABLE [dbo].[DetailCommande]
ADD CONSTRAINT [FK_CommandeDetailsCommande]
    FOREIGN KEY ([Commande_Id])
    REFERENCES [dbo].[Commande]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CommandeDetailsCommande'
CREATE INDEX [IX_FK_CommandeDetailsCommande]
ON [dbo].[DetailCommande]
    ([Commande_Id]);
GO

-- Creating foreign key on [Commande_Id] in table 'Livraison'
ALTER TABLE [dbo].[Livraison]
ADD CONSTRAINT [FK_CommandeLivraison]
    FOREIGN KEY ([Commande_Id])
    REFERENCES [dbo].[Commande]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CommandeLivraison'
CREATE INDEX [IX_FK_CommandeLivraison]
ON [dbo].[Livraison]
    ([Commande_Id]);
GO

-- Creating foreign key on [Commande_Id] in table 'Paiement'
ALTER TABLE [dbo].[Paiement]
ADD CONSTRAINT [FK_PaiementCommande]
    FOREIGN KEY ([Commande_Id])
    REFERENCES [dbo].[Commande]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PaiementCommande'
CREATE INDEX [IX_FK_PaiementCommande]
ON [dbo].[Paiement]
    ([Commande_Id]);
GO

-- Creating foreign key on [Id] in table 'User_Livreur'
ALTER TABLE [dbo].[User_Livreur]
ADD CONSTRAINT [FK_Livreur_inherits_User]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[User]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'User_Client'
ALTER TABLE [dbo].[User_Client]
ADD CONSTRAINT [FK_Client_inherits_User]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[User]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------