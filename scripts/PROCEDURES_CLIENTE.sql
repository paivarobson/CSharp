
--###  PROCEDURES CLIENTE ###
--CADASTRAR
CREATE PROC proc_cadastrarCliente
@clienteCPF varchar(11),
@clienteNome varchar(50)
AS
INSERT INTO CLIENTE (
	CLICPF, 
	CLINOM)
VALUES (
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

--RECUPERAR ÚLTIMO REGISTRO CADASTRADO
CREATE PROC proc_recuperarUltimoCadastroCliente
AS
SELECT TOP 1 * FROM CLIENTE 
ORDER BY CLICOD DESC