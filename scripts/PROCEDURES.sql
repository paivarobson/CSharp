
--###  PROCEDURES CLIENTE ###
--CADASTRAR
CREATE PROC proc_cadastrarCliente
@clienteCodigo int output,
@clienteCPF varchar(11),
@clienteNome varchar(50)
AS
INSERT INTO CLIENTE (
	CLICOD, 
	CLICPF, 
	CLINOM)
VALUES (
	@clienteCodigo, 
	@clienteCPF, 
	@clienteNome)
GO

--ALTERAR
CREATE PROC proc_alterarCliente
@clienteCodigo int,
@clienteCPF varchar(11),
@clienteNome varchar(50)
AS
UPDATE CLIENTE 
SET CLICPF = @clienteCPF,
	CLINOM = @clienteNome
WHERE CLICOD = @clienteCodigo
GO

--EXCLUIR
CREATE PROC proc_excluirCliente
@clienteCodigo int
AS
DELETE FROM CLIENTE 
WHERE CLICOD = @clienteCodigo
GO

--CONSULTAR
CREATE PROC proc_consultarCliente
@clienteCodigo int
AS
SELECT * FROM CLIENTE
WHERE CLICOD = @clienteCodigo
GO

