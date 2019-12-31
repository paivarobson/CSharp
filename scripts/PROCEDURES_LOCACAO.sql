
--###  PROCEDURES LOCAÇÃO ###
--CADASTRAR 
CREATE PROC proc_cadastrarLocacao
@veiculoCodigo INT,
@clienteCodigo INT,
@locacaoData DATETIME,
@locacaoDataDevolucao DATETIME,
@locacaoValorDiaria DECIMAL
AS
INSERT INTO LOCACAO(
	VEICOD, 
	CLICOD,
	LOCDAT,
	LOCDATDEV,
	LOCVLRDIA)
VALUES (
	@veiculoCodigo, 
	@clienteCodigo,
	@locacaoData,
	@locacaoDataDevolucao,
	@locacaoValorDiaria)
GO

--ALTERAR
CREATE PROC proc_alterarLocacao
@locacaoCodigo INT,
@veiculoCodigo INT,
@clienteCodigo INT,
@locacaoData DATETIME,
@locacaoDataDevolucao DATETIME,
@locacaoValorDiaria DECIMAL
AS
UPDATE LOCACAO 
SET VEICOD = @veiculoCodigo,
	CLICOD = @clienteCodigo,
	LOCDAT = @locacaoData,
	LOCDATDEV = @locacaoDataDevolucao,
	LOCVLRDIA = @locacaoValorDiaria
WHERE LOCCOD = @locacaoCodigo
GO

--EXCLUIR
CREATE PROC proc_excluirLocacao
@locacaoCodigo INT
AS
DELETE FROM LOCACAO 
WHERE LOCCOD = @locacaoCodigo
GO

--CONSULTAR
CREATE PROC proc_consultarLocacao
@locacaoCodigo INT
AS
SELECT 
	LOCCOD, 
	V.VEICOD, 
	V.VEIDES, 
	C.CLICOD, 
	C.CLINOM, 
	LOCDAT, 
	LOCDATDEV,
	LOCVLRDIA 
FROM LOCACAO L
	INNER JOIN VEICULO V ON V.VEICOD = L.VEICOD
	INNER JOIN CLIENTE C ON C.CLICOD = L.CLICOD
WHERE LOCCOD = @locacaoCodigo
GO

--RECUPERAR ÚLTIMO REGISTRO CADASTRADO
CREATE PROC proc_recuperarUltimoCadastroLocacao
AS
SELECT TOP 1 * FROM LOCACAO 
ORDER BY LOCCOD DESC