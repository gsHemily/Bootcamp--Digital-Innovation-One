	SELECT *
	FROM HistoricoViagens

	
	
	ALTER TABLE HistoricoViagens ADD CONSTRAINT fK_HistoricoViagens_PilotosNaves foreign Key (IdPiloto, IdNave) REFERENCES PilotosNaves (IdPiloto,IdNave)
	ALTER TABLE HistoricoViagens CHECK CONSTRAINT fK_HistoricoViagens_PilotosNaves
	