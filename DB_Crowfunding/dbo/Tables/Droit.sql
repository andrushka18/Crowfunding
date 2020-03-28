CREATE TABLE [dbo].[Droit] (
    [IdDroit]  INT           IDENTITY (1, 1) NOT NULL,
    [NomDroit] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Droit] PRIMARY KEY CLUSTERED ([IdDroit] ASC),
    CONSTRAINT [CK_Droit] CHECK ([NomDroit]='Utilisateur' OR [NomDroit]='Administrateur'),
    CONSTRAINT [UK_Droit] UNIQUE NONCLUSTERED ([NomDroit] ASC)
);

