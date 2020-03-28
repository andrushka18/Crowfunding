SET IDENTITY_INSERT [Droit] ON;
GO

IF EXISTS(SELECT [UtilisateurId] FROM [Utilisateur] JOIN [Droit] ON [Utilisateur].[UtilisateurId] = [Droit].[IdDroit]  WHERE NomUtilisateur = 'Administrateur' AND [Password] = dbo.SF_HashPassword('Admin'))
	BEGIN
		DELETE FROM [Utilisateur] WHERE NomUtilisateur = 'Administrateur' AND [Password] = dbo.SF_HashPassword('Admin');
	END
INSERT INTO Utilisateur ([UtilisateurId],[Nom],[Prenom],[NomUtilisateur],[Password],[Droit])
	VALUES(0,'Admin','Admin','Administrateur',dbo.SF_HashPassword('Admin'),'Administrateur');
GO

SET IDENTITY_INSERT [Droit] OFF;
GO