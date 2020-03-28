CREATE TABLE [dbo].[Financeur] (
    [IdFinanceur]   INT           IDENTITY (1, 1) NOT NULL,
    [UtilisateurId] INT           NOT NULL,
    [IdProjet]      INT           NOT NULL,
    [Montant]       MONEY           NOT NULL,
    [Prime]         NVARCHAR (50) NULL,
    CONSTRAINT [PK_Financeur] PRIMARY KEY CLUSTERED ([IdFinanceur] ASC),
    CONSTRAINT [FK_Financeur_Droit] FOREIGN KEY ([IdProjet]) REFERENCES [dbo].[Projets] ([IdProjet]) ON DELETE CASCADE,
    CONSTRAINT [FK_Financeur_Utilisateur] FOREIGN KEY ([UtilisateurId]) REFERENCES [dbo].[Utilisateur] ([UtilisateurId]) ON DELETE CASCADE,
    CONSTRAINT [UK_Financeur] UNIQUE NONCLUSTERED ([UtilisateurId] ASC, [IdProjet] ASC)
);

