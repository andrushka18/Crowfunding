CREATE TABLE [dbo].[Role_Utilisateur] (
    [IdRole_Utilisateur] INT IDENTITY (1, 1) NOT NULL,
    [UtilisateurId]      INT NOT NULL,
    [IdDroit]            INT NOT NULL,
    CONSTRAINT [PK_Role_Utilisateur] PRIMARY KEY CLUSTERED ([IdRole_Utilisateur] ASC),
    CONSTRAINT [FK_Role_Utilisateur_Droit] FOREIGN KEY ([IdDroit]) REFERENCES [dbo].[Droit] ([IdDroit]) ON DELETE CASCADE,
    CONSTRAINT [FK_Role_Utilisateur_Utilisateur] FOREIGN KEY ([UtilisateurId]) REFERENCES [dbo].[Utilisateur] ([UtilisateurId]) ON DELETE CASCADE,
    CONSTRAINT [UK_Role_Utilisateur] UNIQUE NONCLUSTERED ([UtilisateurId] ASC, [IdDroit] ASC)
);

