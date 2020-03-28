CREATE TABLE [dbo].[Valideur] (
    [IdValideur]    INT           IDENTITY (1, 1) NOT NULL,
    [UtilisateurId] INT           NOT NULL,
    [IdProjet]      INT           NOT NULL,
    [Status]        NVARCHAR (50) NOT NULL,
    [Commentaire]   NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Valideur] PRIMARY KEY CLUSTERED ([IdValideur] ASC),
    CONSTRAINT [FK_Valideur_Droit] FOREIGN KEY ([IdProjet]) REFERENCES [dbo].[Projets] ([IdProjet]) ON DELETE CASCADE,
    CONSTRAINT [FK_Valideur_Utilisateur] FOREIGN KEY ([UtilisateurId]) REFERENCES [dbo].[Utilisateur] ([UtilisateurId]) ON DELETE CASCADE,
    CONSTRAINT [UK_Valideur] UNIQUE NONCLUSTERED ([UtilisateurId] ASC, [IdProjet] ASC)
);

