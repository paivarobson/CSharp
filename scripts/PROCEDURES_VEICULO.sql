
--###  PROCEDURES VEÍCULO ###
--CADASTRAR 
CREATE PROC proc_cadastrarLocacao
@veiculoCodigo INT,
@clienteCodigo INT,
@locacaoValorDiaria DECIMAL,
@locacaoData DATETIME,
@locacaoDataDevolucao DATETIME
AS
INSERT INTO LOCACAO(
	VEICOD, 
	CLICOD,
	LOCVLRDIA,
	LOCDAT,
	LOCDATDEV)
VALUES (
	@veiculoCodigo, 
	@clienteCodigo,
	@locacaoValorDiaria,
	@locacaoData,
	@locacaoDataDevolucao)
GO

--ALTERAR
CREATE PROC proc_alterarLocacao
@locacaoCodigo int,
@veiculoCodigo INT,
@clienteCodigo INT,
@locacaoValorDiaria DECIMAL,
@locacaoData DATETIME,
@locacaoDataDevolucao DATETIME
AS
UPDATE LOCACAO 
SET VEICOD = @veiculoCodigo,
	CLICOD = @clienteCodigo,
	LOCVLRDIA = @locacaoValorDiaria,
	LOCDAT = @locacaoData,
	LOCDATDEV = @locacaoDataDevolucao
WHERE LOCCOD = @locacaoCodigo
GO

--EXCLUIR
CREATE PROC proc_excluirLocacao
@locacaoCodigo int
AS
DELETE FROM LOCACAO 
WHERE LOCCOD = @locacaoCodigo
GO

--CONSULTAR
CREATE PROC proc_consultarLocacao
@locacaoCodigo int
AS
SELECT * FROM LOCACAO
WHERE LOCCOD = @locacaoCodigo
GO

--RECUPERAR ÚLTIMO REGISTRO CADASTRADO
CREATE PROC proc_recuperarUltimoCadastroLocacao
AS
SELECT TOP 1 * FROM LOCACAO 
ORDER BY LOCCOD DESC