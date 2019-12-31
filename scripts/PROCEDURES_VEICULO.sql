
--###  PROCEDURES VEÍCULO ###
--CADASTRAR 
CREATE PROC proc_cadastrarVeiculo
@veiculoPlaca varchar(7),
@veiculoDescricao varchar(50)
AS
INSERT INTO VEICULO (
	VEIPLC, 
	VEIDES, 
	VEIDISP)
VALUES (
	@veiculoPlaca, 
	@veiculoDescricao,
	'S')
GO

--ALTERAR
CREATE PROC proc_alterarVeiculo
@veiculoCodigo int,
@veiculoPlaca varchar(7),
@veiculoDescricao varchar(50)
AS
UPDATE VEICULO 
SET VEIPLC = @veiculoPlaca,
	VEIDES = @veiculoDescricao
WHERE VEICOD = @veiculoCodigo
GO

--EXCLUIR
CREATE PROC proc_excluirVeiculo
@veiculoCodigo int
AS
DELETE FROM VEICULO 
WHERE VEICOD = @veiculoCodigo
GO

--CONSULTAR
CREATE PROC proc_consultarVeiculo
@veiculoCodigo int
AS
SELECT * FROM VEICULO
WHERE VEICOD = @veiculoCodigo
GO

--RECUPERAR ÚLTIMO REGISTRO CADASTRADO
CREATE PROC proc_recuperarUltimoCadastroVeiculo
AS
SELECT TOP 1 * FROM VEICULO 
ORDER BY VEICOD DESC

--LIBERAR VEÍCULO
CREATE PROC proc_LiberarVeiculo
@veiculoCodigo INT
AS
UPDATE VEICULO 
SET VEIDISP = 'S'
WHERE VEICOD = @veiculoCodigo
GO

--LOCAR VEÍCULO
CREATE PROC proc_LocarVeiculo
@veiculoCodigo INT
AS
UPDATE VEICULO 
SET VEIDISP = 'N'
WHERE VEICOD = @veiculoCodigo
GO
