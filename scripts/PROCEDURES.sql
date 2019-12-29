

--PROCEDURE CADASTRAR
CREATE PROC proc_cadastrarPessoa
@pessoaCodigo int output,
@pessoaCPF varchar(11),
@pessoaNome varchar(50),
@pessoaTipo char
AS
INSERT INTO PESSOA (PESCOD,	PESCPF, PESNOM,	PESTIP)
	VALUES (@pessoaCodigo, @pessoaCPF, @pessoaNome, @pessoaTipo)
GO

--PROCEDURE ALTERAR
CREATE PROC proc_alterarPessoa
@pessoaCodigo int,
@pessoaCPF varchar(11),
@pessoaNome varchar(50),
@pessoaTipo char
AS
UPDATE PESSOA SET 
	PESCPF = @pessoaCPF,
	PESNOM = @pessoaNome,
	PESTIP = @pessoaTipo
WHERE PESCOD = @pessoaCodigo
GO

--PROCEDURE EXCLUIR
CREATE PROC proc_excluirPessoa
@pessoaCodigo int
AS
DELETE FROM PESSOA 
WHERE PESCOD = @pessoaCodigo
GO

--PROCEDURE CONSULTAR
CREATE PROC proc_consultarPessoa
@pessoaCodigo int
AS
SELECT * FROM PESSOA
WHERE PESCOD = @pessoaCodigo
GO