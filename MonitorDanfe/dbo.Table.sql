CREATE TABLE [dbo].[ConfiguraçõesBanco]
(
	[ID] INT NOT NULL PRIMARY KEY, 
    [CaminhoEntradaUnimake] VARCHAR(MAX) NULL, 
    [Saida] VARCHAR(MAX) NULL, 
    [timer] INT NULL
);

CREATE TABLE [dbo].[Notas]
(
	[ID] INT NOT NULL PRIMARY KEY, 
    [status] VARCHAR(MAX) NULL, 
    [Caminho] VARCHAR(MAX) NULL, 
    [Detalhes] VARCHAR(MAX) NULL, 
    [Numero] VARCHAR(MAX) NULL, 
    [DataProcess] Datetime NULL
)
