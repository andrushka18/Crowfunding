CREATE TABLE [dbo].[Utilisateur] (
    [UtilisateurId]  INT            IDENTITY (1, 1) NOT NULL,
    [Nom]            NVARCHAR (32)  NOT NULL,
    [Prenom]         NVARCHAR (32)  NOT NULL,
    [NomUtilisateur] NVARCHAR (32)  NOT NULL,
    [Password]       VARBINARY (32) NOT NULL,
    CONSTRAINT [PK_Utilisateur] PRIMARY KEY CLUSTERED ([UtilisateurId] ASC),
    CONSTRAINT [UK_Utilisateur_NomUtilisateur] UNIQUE NONCLUSTERED ([NomUtilisateur] ASC)
);

