CREATE TABLE [dbo].[Employe] (
    [NumeroNational]     INT IDENTITY (1, 1) NOT NULL,
    [UtilisateurId] INT NOT NULL,
    [IdProjet]      INT NOT NULL,
    [NumeroTVA]     INT NOT NULL,
    [DateDEngagement] DATE NULL, 
    CONSTRAINT [PK_Employe] PRIMARY KEY CLUSTERED ([NumeroNational] ASC),
    CONSTRAINT [FK_Employe_Projets] FOREIGN KEY ([IdProjet]) REFERENCES [dbo].[Projets] ([IdProjet]) ON DELETE CASCADE,
    CONSTRAINT [FK_Employe_Societe] FOREIGN KEY ([NumeroTVA]) REFERENCES [dbo].[Societe] ([NumeroTVA]) ON DELETE CASCADE,
    CONSTRAINT [FK_Employe_Utilisateur] FOREIGN KEY ([UtilisateurId]) REFERENCES [dbo].[Utilisateur] ([UtilisateurId]) ON DELETE CASCADE,
    CONSTRAINT [UK_Employe] UNIQUE NONCLUSTERED ([UtilisateurId] ASC, [IdProjet] ASC, [NumeroTVA] ASC)
);

