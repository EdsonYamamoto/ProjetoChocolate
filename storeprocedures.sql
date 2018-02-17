------------------------
--STORE PROCEDURE BAIRRO
------------------------
--Inserir Bairro
GO
DROP PROCEDURE spInserirBairro;
GO
CREATE PROCEDURE spInserirBairro
	@nome VARCHAR(150),
	@descricao VARCHAR(250)
AS
BEGIN
	INSERT INTO Bairro(Nome, Descricao) 
	VALUES (@nome,@descricao); SELECT @@IDENTITY;
	
END;
/*
GO
DECLARE	@nome VARCHAR(150), @descricao VARCHAR(250)
	SET @nome = 'teste' SET @descricao = 'desc'
EXECUTE spInserirBairro	@nome, @descricao
*/

--Alterar bairro
GO
DROP PROCEDURE spAlteraBairro;
GO
CREATE PROCEDURE spAlteraBairro
	@nome VARCHAR(150),
	@descricao VARCHAR(250),
	@codigo NUMERIC(18,0)
AS
BEGIN
	UPDATE Bairro 
	SET 
		Nome = @nome, 
		Descricao = @descricao 
	WHERE ID_Bairro = @codigo;
END;
/*
GO
DECLARE	@nome VARCHAR(150), @descricao VARCHAR(250), @codigo NUMERIC(18,0)
	SET @nome = 'teste' SET @descricao = 'desc', @codigo = 5,
EXECUTE spAlteraBairro	@nome, @descricao, @codigo
*/

--Excluir Bairro
GO
DROP PROCEDURE spExcluiBairro;
GO
CREATE PROCEDURE spExcluiBairro
	@codigo NUMERIC(18,0)
AS
BEGIN
	DELETE FROM Bairro WHERE ID_Bairro = @codigo;
END;

--Procurar por bairro
GO
DROP PROCEDURE spProcuraBairro;
GO
CREATE PROCEDURE spProcuraBairro
	@valor VARCHAR(150)
AS
BEGIN
	SELECT * FROM Bairro WHERE Nome LIKE '%'+@valor+'%'
END;

--Procurar por ID bairro
GO
DROP PROCEDURE spProcuraIDBairro;
GO
CREATE PROCEDURE spProcuraIDBairro
	@codigo NUMERIC(18,0)
AS
BEGIN
	SELECT * FROM Bairro WHERE ID_Bairro = @codigo
END;
/*
GO
DECLARE
	@valor VARCHAR(150)
	SET @valor = 't'
	EXECUTE spProcuraBairro	@valor
*/
--Procura por bairro existente

GO
DROP PROCEDURE spVerificaBairroExistente;
GO
CREATE PROCEDURE spVerificaBairroExistente
	@nome VARCHAR(150)
AS
BEGIN
	SELECT * FROM Bairro WHERE Nome = @nome
END;

------------------------
--STORE PROCEDURE CIDADE
------------------------
GO
DROP PROCEDURE spInserirCidade;
GO
CREATE PROCEDURE spInserirCidade
	@nome VARCHAR(150),
	@descricao VARCHAR(250)
AS
BEGIN
	INSERT INTO Cidade(Nome, Descricao) 
	VALUES (@nome,@descricao); SELECT @@IDENTITY;
	
END;

GO
DROP PROCEDURE spAlteraCidade;
GO
CREATE PROCEDURE spAlteraCidade
	@nome VARCHAR(150),
	@descricao VARCHAR(250),
	@codigo NUMERIC(18,0)
AS
BEGIN
	UPDATE Cidade SET Nome = @nome, Descricao = @descricao WHERE ID_Cidade = @codigo;
END;
/*
GO
DECLARE	@nome VARCHAR(150), @descricao VARCHAR(250), @codigo NUMERIC(18,0)
	SET @nome = 'teste' SET @descricao = 'desc', @codigo = 5,
EXECUTE spAlteraBairro	@nome, @descricao, @codigo
*/

--Excluir Cidade
GO
DROP PROCEDURE spExcluiCidade;
GO
CREATE PROCEDURE spExcluiCidade
	@codigo NUMERIC(18,0)
AS
BEGIN
	DELETE FROM Cidade WHERE ID_Cidade = @codigo;
END;

--Procurar por Cidade
GO
DROP PROCEDURE spProcuraCidade;
GO
CREATE PROCEDURE spProcuraCidade
	@valor VARCHAR(150)
AS
BEGIN

	SELECT * FROM Cidade WHERE Nome LIKE '%'+@valor+'%'
END;

--Procurar por ID Cidade
GO
DROP PROCEDURE spProcuraIDCidade;
GO
CREATE PROCEDURE spProcuraIDCidade
	@codigo NUMERIC(18,0)
AS
BEGIN
	SELECT * FROM Cidade WHERE ID_Cidade = @codigo
END;
/*
GO
DECLARE
	@valor VARCHAR(150)
	SET @valor = 't'
	EXECUTE spProcuraCidade	@valor
*/
--Procura por Cidade existente

GO
DROP PROCEDURE spVerificaCidadeExistente;
GO
CREATE PROCEDURE spVerificaCidadeExistente
	@nome VARCHAR(150)
AS
BEGIN
	SELECT * FROM Cidade WHERE Nome = @nome
END;


------------------------
--STORE PROCEDURE CaracteristicaManufaturado1
------------------------
GO
DROP PROCEDURE spInserirCaracteristicaManufaturado1;
GO
CREATE PROCEDURE spInserirCaracteristicaManufaturado1
	@nome VARCHAR(150),
	@descricao VARCHAR(250)
AS
BEGIN
	INSERT INTO CaracteristicaManufaturado1(Nome, Descricao) 
	VALUES (@nome,@descricao); SELECT @@IDENTITY;
	
END;

GO
DROP PROCEDURE spAlteraCaracteristicaManufaturado1;
GO
CREATE PROCEDURE spAlteraCaracteristicaManufaturado1
	@nome VARCHAR(150),
	@descricao VARCHAR(250),
	@codigo NUMERIC(18,0)
AS
BEGIN
	UPDATE CaracteristicaManufaturado1 
	SET 
		Nome = @nome, 
		Descricao = @descricao 
	WHERE ID_CaracteristicaManufaturado1 = @codigo;
END;
/*
GO
DECLARE	@nome VARCHAR(150), @descricao VARCHAR(250), @codigo NUMERIC(18,0)
	SET @nome = 'teste' SET @descricao = 'desc', @codigo = 5,
EXECUTE spAlteraBairro	@nome, @descricao, @codigo
*/

--Excluir CaracteristicaManufaturado1
GO
DROP PROCEDURE spExcluiCaracteristicaManufaturado1;
GO
CREATE PROCEDURE spExcluiCaracteristicaManufaturado1
	@codigo NUMERIC(18,0)
AS
BEGIN
	DELETE FROM CaracteristicaManufaturado1 WHERE ID_CaracteristicaManufaturado1 = @codigo;
END;

--Procurar por CaracteristicaManufaturado1
GO
DROP PROCEDURE spProcuraCaracteristicaManufaturado1;
GO
CREATE PROCEDURE spProcuraCaracteristicaManufaturado1
	@valor VARCHAR(150)
AS
BEGIN
	SELECT * FROM CaracteristicaManufaturado1 WHERE Nome LIKE '%'+@valor+'%'
END;

--Procurar por ID CaracteristicaManufaturado1
GO
DROP PROCEDURE spProcuraIDCaracteristicaManufaturado1;
GO
CREATE PROCEDURE spProcuraIDCaracteristicaManufaturado1
	@codigo NUMERIC(18,0)
AS
BEGIN
	SELECT * FROM CaracteristicaManufaturado1 WHERE ID_CaracteristicaManufaturado1 = @codigo
END;
/*
GO
DECLARE
	@valor VARCHAR(150)
	SET @valor = 't'
	EXECUTE spProcuraCaracteristicaManufaturado1	@valor
*/
--Procura por CaracteristicaManufaturado1 existente

GO
DROP PROCEDURE spVerificaCaracteristicaManufaturado1Existente;
GO
CREATE PROCEDURE spVerificaCaracteristicaManufaturado1Existente
	@nome VARCHAR(150)
AS
BEGIN
	SELECT * FROM CaracteristicaManufaturado1 WHERE Nome = @nome
END;


------------------------
--STORE PROCEDURE CaracteristicaManufaturado2
------------------------
GO
DROP PROCEDURE spInserirCaracteristicaManufaturado2;
GO
CREATE PROCEDURE spInserirCaracteristicaManufaturado2
	@nome VARCHAR(150),
	@descricao VARCHAR(250)
AS
BEGIN
	INSERT INTO CaracteristicaManufaturado2(Nome, Descricao) 
	VALUES (@nome,@descricao); SELECT @@IDENTITY;
	
END;

GO
DROP PROCEDURE spAlteraCaracteristicaManufaturado2;
GO
CREATE PROCEDURE spAlteraCaracteristicaManufaturado2
	@nome VARCHAR(150),
	@descricao VARCHAR(250),
	@codigo NUMERIC(18,0)
AS
BEGIN
	UPDATE CaracteristicaManufaturado2 SET Nome = @nome, Descricao = @descricao WHERE ID_CaracteristicaManufaturado2 = @codigo;
END;
/*
GO
DECLARE	@nome VARCHAR(150), @descricao VARCHAR(250), @codigo NUMERIC(18,0)
	SET @nome = 'teste' SET @descricao = 'desc', @codigo = 5,
EXECUTE spAlteraBairro	@nome, @descricao, @codigo
*/

--Excluir CaracteristicaManufaturado2
GO
DROP PROCEDURE spExcluiCaracteristicaManufaturado2;
GO
CREATE PROCEDURE spExcluiCaracteristicaManufaturado2
	@codigo NUMERIC(18,0)
AS
BEGIN
	DELETE FROM CaracteristicaManufaturado2 WHERE ID_CaracteristicaManufaturado2 = @codigo;
END;

--Procurar por CaracteristicaManufaturado2
GO
DROP PROCEDURE spProcuraCaracteristicaManufaturado2;
GO
CREATE PROCEDURE spProcuraCaracteristicaManufaturado2
	@valor VARCHAR(150)
AS
BEGIN
	SELECT * FROM CaracteristicaManufaturado2 WHERE Nome LIKE '%'+@valor+'%'
END;

--Procurar por ID CaracteristicaManufaturado2
GO
DROP PROCEDURE spProcuraIDCaracteristicaManufaturado2;
GO
CREATE PROCEDURE spProcuraIDCaracteristicaManufaturado2
	@codigo NUMERIC(18,0)
AS
BEGIN
	SELECT * FROM CaracteristicaManufaturado2 WHERE ID_CaracteristicaManufaturado2 = @codigo
END;
/*
GO
DECLARE
	@valor VARCHAR(150)
	SET @valor = 't'
	EXECUTE spProcuraCaracteristicaManufaturado2	@valor
*/
--Procura por CaracteristicaManufaturado2 existente

GO
DROP PROCEDURE spVerificaCaracteristicaManufaturado2Existente;
GO
CREATE PROCEDURE spVerificaCaracteristicaManufaturado2Existente
	@nome VARCHAR(150)
AS
BEGIN
	SELECT * FROM CaracteristicaManufaturado2 WHERE Nome = @nome
END;

------------------------
--STORE PROCEDURE Cliente
------------------------
GO
DROP PROCEDURE spInserirCliente;
GO
CREATE PROCEDURE spInserirCliente
	@nome VARCHAR(50),
	@telefone NUMERIC(18, 0), 
	@celular NUMERIC(18, 0), 
	@idcidade NUMERIC(18, 0), 
	@idbairro NUMERIC(18, 0)
AS
BEGIN
	INSERT INTO Cliente(Nome, Telefone, Celular, ID_Cidade, ID_Bairro) 
	VALUES (@nome, @telefone, @celular, @idcidade, @idbairro); SELECT @@IDENTITY;
END;

GO
DROP PROCEDURE spAlteraCliente;
GO
CREATE PROCEDURE spAlteraCliente
	@nome VARCHAR(50),
	@telefone NUMERIC(18, 0), 
	@celular NUMERIC(18, 0), 
	@idcidade NUMERIC(18, 0), 
	@idbairro NUMERIC(18, 0),
	@codigo NUMERIC(18,0)
AS
BEGIN
	UPDATE Cliente 
		SET Nome = @nome, 
		Telefone = @telefone,
		Celular = @celular,
		ID_Bairro = @idbairro,
		ID_Cidade = @idcidade
		WHERE ID_Cliente = @codigo;
END;
/*
GO
DECLARE	@nome VARCHAR(150), @descricao VARCHAR(250), @codigo NUMERIC(18,0)
	SET @nome = 'teste' SET @descricao = 'desc', @codigo = 5,
EXECUTE spAlteraBairro	@nome, @descricao, @codigo
*/

--Excluir cliente
GO
DROP PROCEDURE spExcluiCliente;
GO
CREATE PROCEDURE spExcluiCliente
	@codigo NUMERIC(18,0)
AS
BEGIN
	DELETE FROM Cliente WHERE ID_Cliente = @codigo;
END;

--Procurar por cliente
GO
DROP PROCEDURE spProcuraCliente;
GO
CREATE PROCEDURE spProcuraCliente
	@valor VARCHAR(150)
AS
BEGIN
SELECT Cliente.ID_Cliente, Cliente.Nome , Cliente.Telefone, Cliente.Celular, Cidade.Nome Cidade, Bairro.Nome Bairro, Cliente.SYSDATETIME FROM Cliente 
                    INNER JOIN Cidade ON Cidade.ID_Cidade = Cliente.ID_Cidade 
                    INNER JOIN Bairro ON Bairro.ID_Bairro = Cliente.ID_Bairro 
                    WHERE Cliente.Nome LIKE '%' + @valor + '%'
	--SELECT * FROM Cliente WHERE Nome LIKE '%'+@valor+'%'
END;

--Procurar por ID cliente
GO
DROP PROCEDURE spProcuraIDCliente;
GO
CREATE PROCEDURE spProcuraIDCliente
	@codigo NUMERIC(18,0)
AS
BEGIN
	SELECT * FROM Cliente WHERE ID_Cliente = @codigo
END;

--Procura por Cliente existente

GO
DROP PROCEDURE spVerificaClienteExistente;
GO
CREATE PROCEDURE spVerificaClienteExistente
	@nome VARCHAR(150)
AS
BEGIN
	SELECT * FROM Cliente WHERE Nome = @nome
END;


------------------------
--STORE PROCEDURE Custo
------------------------
--Inserir Custo
GO
DROP PROCEDURE spInserirCusto;
GO
CREATE PROCEDURE spInserirCusto
	@idfabricante NUMERIC(18, 0), 
	@nome VARCHAR(50), 
	@precocusto NUMERIC(18, 2), 
	@qtdcusto INT, 
	@unidad NUMERIC(18, 2), 
	@unidade NUMERIC(18, 0), 
	@descricao VARCHAR(255)
AS
BEGIN
	INSERT INTO Custo(ID_Fabricante,Nome ,Preco ,Quantidade, Unidade, ID_UnidadeMedida , Descricao, DataCompra) 
	VALUES (@idfabricante, @nome, @precocusto, @qtdcusto, @unidad, @unidade, @descricao, GETDATE()); SELECT @@IDENTITY;
	
END;
/*
GO
DECLARE	@nome VARCHAR(150), @descricao VARCHAR(250)
	SET @nome = 'teste' SET @descricao = 'desc'
EXECUTE spInserirCusto	@nome, @descricao
*/

--Alterar Custo
GO
DROP PROCEDURE spAlteraCusto;
GO
CREATE PROCEDURE spAlteraCusto
	@idfabricante numeric(18, 0),
	@nome varchar(50),
	@precocusto numeric(18, 2),
	@qtdcusto int,
	@unidad numeric(18, 2),
	@unidade numeric(18, 0),
	@descricao varchar(255),
	@codigo NUMERIC(18,0)
AS
BEGIN
	UPDATE Custo SET 
	ID_Fabricante = @idfabricante ,
	Nome = @nome, 
	Preco = @precocusto ,
	Quantidade = @qtdcusto,
	Unidade = @unidad, 
	ID_UnidadeMedida = @unidade , 
	Descricao = @descricao 

	WHERE ID_Custo = @codigo;
END;
/*
GO
DECLARE	@nome VARCHAR(150), @descricao VARCHAR(250), @codigo NUMERIC(18,0)
	SET @nome = 'teste' SET @descricao = 'desc', @codigo = 5,
EXECUTE spAlteraCusto	@nome, @descricao, @codigo
*/

--Excluir Custo
GO
DROP PROCEDURE spExcluiCusto;
GO
CREATE PROCEDURE spExcluiCusto
	@codigo NUMERIC(18,0)
AS
BEGIN
	DELETE FROM Custo WHERE ID_Custo = @codigo;
END;

--Procurar por Custo
GO
DROP PROCEDURE spProcuraCusto;
GO
CREATE PROCEDURE spProcuraCusto
	@valor VARCHAR(150)
AS
BEGIN
SELECT Custo.ID_Custo, Fabricante.Nome Fabricante, Custo.Nome, Custo.Quantidade,Custo.Unidade , UnidadeMedida.Nome UnMedida, Custo.Preco, Custo.Descricao, Custo.DataCompra FROM Custo 
                INNER JOIN Fabricante ON Fabricante.ID_Fabricante = Custo.ID_Fabricante 
                INNER JOIN UnidadeMedida ON UnidadeMedida.ID_UnidadeMedida = Custo.ID_UnidadeMedida 
                WHERE Custo.Nome LIKE '%'+@valor+'%'
END;

--Procurar por ID Custo
GO
DROP PROCEDURE spProcuraIDCusto;
GO
CREATE PROCEDURE spProcuraIDCusto
	@codigo NUMERIC(18,0)
AS
BEGIN
	SELECT * FROM Custo WHERE ID_Custo = @codigo
END;
/*
GO
DECLARE
	@valor VARCHAR(150)
	SET @valor = 't'
	EXECUTE spProcuraCusto	@valor
*/
--Procura por Custo existente

GO
DROP PROCEDURE spVerificaCustoExistente;
GO
CREATE PROCEDURE spVerificaCustoExistente
	@nome VARCHAR(150)
AS
BEGIN
	SELECT * FROM Custo WHERE Nome = @nome
END;


------------------------
--STORE PROCEDURE Fabricante
------------------------
--Inserir Fabricante
GO
DROP PROCEDURE spInserirFabricante;
GO
CREATE PROCEDURE spInserirFabricante
	@nome VARCHAR(150),
	@descricao VARCHAR(250)
AS
BEGIN
	INSERT INTO Fabricante(Nome, Descricao) 
	VALUES (@nome,@descricao); SELECT @@IDENTITY;
	
END;
/*
GO
DECLARE	@nome VARCHAR(150), @descricao VARCHAR(250)
	SET @nome = 'teste' SET @descricao = 'desc'
EXECUTE spInserirFabricante	@nome, @descricao
*/

--Alterar Fabricante
GO
DROP PROCEDURE spAlteraFabricante;
GO
CREATE PROCEDURE spAlteraFabricante
	@nome VARCHAR(150),
	@descricao VARCHAR(250),
	@codigo NUMERIC(18,0)
AS
BEGIN
	UPDATE Fabricante 
	SET 
		Nome = @nome, 
		Descricao = @descricao 
	WHERE ID_Fabricante = @codigo;
END;
/*
GO
DECLARE	@nome VARCHAR(150), @descricao VARCHAR(250), @codigo NUMERIC(18,0)
	SET @nome = 'teste' SET @descricao = 'desc', @codigo = 5,
EXECUTE spAlteraFabricante	@nome, @descricao, @codigo
*/

--Excluir Fabricante
GO
DROP PROCEDURE spExcluiFabricante;
GO
CREATE PROCEDURE spExcluiFabricante
	@codigo NUMERIC(18,0)
AS
BEGIN
	DELETE FROM Fabricante WHERE ID_Fabricante = @codigo;
END;

--Procurar por Fabricante
GO
DROP PROCEDURE spProcuraFabricante;
GO
CREATE PROCEDURE spProcuraFabricante
	@valor VARCHAR(150)
AS
BEGIN
	SELECT * FROM Fabricante WHERE Nome LIKE '%'+@valor+'%'
END;

--Procurar por ID Fabricante
GO
DROP PROCEDURE spProcuraIDFabricante;
GO
CREATE PROCEDURE spProcuraIDFabricante
	@codigo NUMERIC(18,0)
AS
BEGIN
	SELECT * FROM Fabricante WHERE ID_Fabricante = @codigo
END;
/*
GO
DECLARE
	@valor VARCHAR(150)
	SET @valor = 't'
	EXECUTE spProcuraFabricante	@valor
*/
--Procura por Fabricante existente

GO
DROP PROCEDURE spVerificaFabricanteExistente;
GO
CREATE PROCEDURE spVerificaFabricanteExistente
	@nome VARCHAR(150)
AS
BEGIN
	SELECT * FROM Fabricante WHERE Nome = @nome
END;

------------------------
--STORE PROCEDURE Manufaturado
------------------------
--Inserir Manufaturado
GO
DROP PROCEDURE spInserirManufaturado;
GO
CREATE PROCEDURE spInserirManufaturado
	@idtipo NUMERIC(18, 0),
	@caracteristica1 NUMERIC(18, 0),
	@caracteristica2 NUMERIC(18, 0),
	@nome VARCHAR(50),
	@unidademedida NUMERIC(18, 0),
	@peso NUMERIC(18, 2),
	@preco NUMERIC(18, 2),
	@descricao VARCHAR(250)
AS
BEGIN
	INSERT INTO Manufaturado(ID_TipoManufaturado,ID_CaracteristicaManufaturado1,ID_CaracteristicaManufaturado2, Nome, ID_UnidadeMedida, Peso, Preco, Descricao) 
		VALUES (@idtipo,@caracteristica1,@caracteristica2,@nome,@unidademedida,@peso,@preco,@descricao); SELECT @@IDENTITY;
	
END;
/*
GO
DECLARE	@nome VARCHAR(150), @descricao VARCHAR(250)
	SET @nome = 'teste' SET @descricao = 'desc'
EXECUTE spInserirManufaturado	@nome, @descricao
*/

--Alterar Manufaturado
GO
DROP PROCEDURE spAlteraManufaturado;
GO
CREATE PROCEDURE spAlteraManufaturado
	@idtipo NUMERIC(18, 0),
	@caracteristica1 NUMERIC(18, 0),
	@caracteristica2 NUMERIC(18, 0),
	@nome VARCHAR(50),
	@unidademedida NUMERIC(18, 0),
	@peso NUMERIC(18, 2),
	@preco NUMERIC(18, 2),
	@descricao VARCHAR(250),
	@codigo NUMERIC(18,0)
AS
BEGIN
	UPDATE Manufaturado SET 
	ID_TipoManufaturado = @idtipo , 
	ID_CaracteristicaManufaturado1 = @caracteristica1, 
	ID_CaracteristicaManufaturado2 = @caracteristica2, 
	Nome = @nome, 
	ID_UnidadeMedida = @unidademedida,
	Peso = @peso, 
	Preco = @preco, 
	Descricao = @descricao 
	WHERE ID_Manufaturado = @codigo;
END;
/*
GO
DECLARE	@nome VARCHAR(150), @descricao VARCHAR(250), @codigo NUMERIC(18,0)
	SET @nome = 'teste' SET @descricao = 'desc', @codigo = 5,
EXECUTE spAlteraManufaturado	@nome, @descricao, @codigo
*/

--Excluir Manufaturado
GO
DROP PROCEDURE spExcluiManufaturado;
GO
CREATE PROCEDURE spExcluiManufaturado
	@codigo NUMERIC(18,0)
AS
BEGIN
	DELETE FROM Manufaturado WHERE ID_Manufaturado = @codigo;
END;

--Procurar por Manufaturado
GO
DROP PROCEDURE spProcuraManufaturado;
GO
CREATE PROCEDURE spProcuraManufaturado
	@valor VARCHAR(150)
AS
BEGIN
	SELECT Manufaturado.ID_Manufaturado, TipoManufaturado.Nome, CaracteristicaManufaturado1.Nome, CaracteristicaManufaturado2.Nome, Manufaturado.Nome, Manufaturado.Peso, UnidadeMedida.Nome Unidade, Manufaturado.Preco, Manufaturado.Descricao FROM Manufaturado
                INNER JOIN TipoManufaturado ON TipoManufaturado.ID_TipoManufaturado = Manufaturado.ID_TipoManufaturado
                INNER JOIN UnidadeMedida ON UnidadeMedida.ID_UnidadeMedida = Manufaturado.ID_UnidadeMedida
                INNER JOIN CaracteristicaManufaturado1 ON CaracteristicaManufaturado1.ID_CaracteristicaManufaturado1 = Manufaturado.ID_CaracteristicaManufaturado1
                INNER JOIN CaracteristicaManufaturado2 ON CaracteristicaManufaturado2.ID_CaracteristicaManufaturado2 = Manufaturado.ID_CaracteristicaManufaturado2
                WHERE Manufaturado.Nome LIKE '%'+@valor+'%'
END;

--Usar a combo box
GO
DROP PROCEDURE spProcuraManufaturadoModelo;
GO
CREATE PROCEDURE spProcuraManufaturadoModelo
	@IDTipoManufaturado NUMERIC(18, 0),
	@IDCaracteristicaManufaturado1 NUMERIC(18, 0), 
	@IDCaracteristicaManufaturado2 NUMERIC(18, 0)
AS
BEGIN
	SELECT Manufaturado.Nome, Manufaturado.ID_Manufaturado, TipoManufaturado.Nome, TipoManufaturado.ID_TipoManufaturado FROM Manufaturado 
                INNER JOIN TipoManufaturado ON TipoManufaturado.ID_TipoManufaturado = Manufaturado.ID_TipoManufaturado 
                INNER JOIN UnidadeMedida ON UnidadeMedida.ID_UnidadeMedida = Manufaturado.ID_UnidadeMedida
                INNER JOIN CaracteristicaManufaturado1 ON CaracteristicaManufaturado1.ID_CaracteristicaManufaturado1 = Manufaturado.ID_CaracteristicaManufaturado1
                INNER JOIN CaracteristicaManufaturado2 ON CaracteristicaManufaturado2.ID_CaracteristicaManufaturado2 = Manufaturado.ID_CaracteristicaManufaturado2
                WHERE Manufaturado.ID_TipoManufaturado = @IDTipoManufaturado 
                AND Manufaturado.ID_CaracteristicaManufaturado1 = @IDCaracteristicaManufaturado1
                AND Manufaturado.ID_CaracteristicaManufaturado2 = @IDCaracteristicaManufaturado2
END;

--Procurar por ID Manufaturado
GO
DROP PROCEDURE spProcuraIDManufaturado;
GO
CREATE PROCEDURE spProcuraIDManufaturado
	@codigo NUMERIC(18,0)
AS
BEGIN
	SELECT * FROM Manufaturado WHERE ID_Manufaturado = @codigo
END;
/*
GO
DECLARE
	@valor VARCHAR(150)
	SET @valor = 't'
	EXECUTE spProcuraManufaturado	@valor
*/
--Procura por Manufaturado existente

GO
DROP PROCEDURE spVerificaManufaturadoExistente;
GO
CREATE PROCEDURE spVerificaManufaturadoExistente
	@nome VARCHAR(150)
AS
BEGIN
	SELECT * FROM Manufaturado WHERE Nome = @nome
END;








------------------------
--STORE PROCEDURE TipoManufaturado
------------------------
--Inserir TipoManufaturado
GO
DROP PROCEDURE spInserirTipoManufaturado;
GO
CREATE PROCEDURE spInserirTipoManufaturado
	@nome VARCHAR(150),
	@descricao VARCHAR(250)
AS
BEGIN
	INSERT INTO TipoManufaturado(Nome, Descricao) 
	VALUES (@nome,@descricao); SELECT @@IDENTITY;
	
END;
/*
GO
DECLARE	@nome VARCHAR(150), @descricao VARCHAR(250)
	SET @nome = 'teste' SET @descricao = 'desc'
EXECUTE spInserirTipoManufaturado	@nome, @descricao
*/

--Alterar TipoManufaturado
GO
DROP PROCEDURE spAlteraTipoManufaturado;
GO
CREATE PROCEDURE spAlteraTipoManufaturado
	@nome VARCHAR(150),
	@descricao VARCHAR(250),
	@codigo NUMERIC(18,0)
AS
BEGIN
	UPDATE TipoManufaturado 
	SET 
		Nome = @nome, 
		Descricao = @descricao 
	WHERE ID_TipoManufaturado = @codigo;
END;
/*
GO
DECLARE	@nome VARCHAR(150), @descricao VARCHAR(250), @codigo NUMERIC(18,0)
	SET @nome = 'teste' SET @descricao = 'desc', @codigo = 5,
EXECUTE spAlteraTipoManufaturado	@nome, @descricao, @codigo
*/

--Excluir TipoManufaturado
GO
DROP PROCEDURE spExcluiTipoManufaturado;
GO
CREATE PROCEDURE spExcluiTipoManufaturado
	@codigo NUMERIC(18,0)
AS
BEGIN
	DELETE FROM TipoManufaturado WHERE ID_TipoManufaturado = @codigo;
END;

--Procurar por TipoManufaturado
GO
DROP PROCEDURE spProcuraTipoManufaturado;
GO
CREATE PROCEDURE spProcuraTipoManufaturado
	@valor VARCHAR(150)
AS
BEGIN
	SELECT * FROM TipoManufaturado WHERE Nome LIKE '%'+@valor+'%'
END;

--Procurar por ID TipoManufaturado
GO
DROP PROCEDURE spProcuraIDTipoManufaturado;
GO
CREATE PROCEDURE spProcuraIDTipoManufaturado
	@codigo NUMERIC(18,0)
AS
BEGIN
	SELECT * FROM TipoManufaturado WHERE ID_TipoManufaturado = @codigo
END;
/*
GO
DECLARE
	@valor VARCHAR(150)
	SET @valor = 't'
	EXECUTE spProcuraTipoManufaturado	@valor
*/
--Procura por TipoManufaturado existente

GO
DROP PROCEDURE spVerificaTipoManufaturadoExistente;
GO
CREATE PROCEDURE spVerificaTipoManufaturadoExistente
	@nome VARCHAR(150)
AS
BEGIN
	SELECT * FROM TipoManufaturado WHERE Nome = @nome
END;



------------------------
--STORE PROCEDURE Orcamento
------------------------
--Inserir Orcamento
GO
DROP PROCEDURE spInserirOrcamento;
GO
CREATE PROCEDURE spInserirOrcamento
	@nome VARCHAR(150)
AS
BEGIN
	INSERT INTO Orcamento(Nome) 
	VALUES (@nome); SELECT @@IDENTITY;
	
END;
/*
GO
DECLARE	@nome VARCHAR(150), @descricao VARCHAR(250)
	SET @nome = 'teste' SET @descricao = 'desc'
EXECUTE spInserirOrcamento	@nome, @descricao
*/

--Alterar Orcamento
GO
DROP PROCEDURE spAlteraOrcamento;
GO
CREATE PROCEDURE spAlteraOrcamento
	@nome VARCHAR(150),
	@codigo NUMERIC(18,0)
AS
BEGIN
	UPDATE Orcamento 
	SET 
		Nome = @nome
	WHERE ID_Orcamento = @codigo;
END;
/*
GO
DECLARE	@nome VARCHAR(150), @descricao VARCHAR(250), @codigo NUMERIC(18,0)
	SET @nome = 'teste' SET @descricao = 'desc', @codigo = 5,
EXECUTE spAlteraOrcamento	@nome, @descricao, @codigo
*/

--Excluir Orcamento
GO
DROP PROCEDURE spExcluiOrcamento;
GO
CREATE PROCEDURE spExcluiOrcamento
	@codigo NUMERIC(18,0)
AS
BEGIN
	DELETE FROM Orcamento WHERE ID_Orcamento = @codigo;
END;

--Procurar por Orcamento
GO
DROP PROCEDURE spProcuraOrcamento;
GO
CREATE PROCEDURE spProcuraOrcamento
	@valor VARCHAR(150)
AS
BEGIN
	SELECT * FROM Orcamento WHERE Nome LIKE '%'+@valor+'%'
END;

--Procurar por ID Orcamento
GO
DROP PROCEDURE spProcuraIDOrcamento;
GO
CREATE PROCEDURE spProcuraIDOrcamento
	@codigo NUMERIC(18,0)
AS
BEGIN
	SELECT * FROM Orcamento WHERE ID_Orcamento = @codigo
END;
/*
GO
DECLARE
	@valor VARCHAR(150)
	SET @valor = 't'
	EXECUTE spProcuraOrcamento	@valor
*/
--Procura por Orcamento existente

GO
DROP PROCEDURE spVerificaOrcamentoExistente;
GO
CREATE PROCEDURE spVerificaOrcamentoExistente
	@nome VARCHAR(150)
AS
BEGIN
	SELECT * FROM Orcamento WHERE Nome = @nome
END;



------------------------
--STORE PROCEDURE Pedido
------------------------
--Inserir Pedido
GO
DROP PROCEDURE spInserirPedido;
GO
CREATE PROCEDURE spInserirPedido
	@cliente NUMERIC(18,0),
	@manufaturado NUMERIC(18,0),
	@orcamento NUMERIC(18,0),
	@quantidade INT,
	@desconto NUMERIC(18,2),
	@dataenvio DATETIME,
	@descricao VARCHAR (255)
AS
BEGIN
	INSERT INTO Pedido(ID_Cliente,ID_Manufaturado,ID_Orcamento,Quantidade,Desconto,SYSDATETIME,DataEnvio,Descricao) 
    VALUES (@cliente,@manufaturado,@orcamento,@quantidade,@desconto,GETDATE(),@dataenvio,@descricao); SELECT @@IDENTITY; 
	
END;
/*
GO
DECLARE	@nome VARCHAR(150), @descricao VARCHAR(250)
	SET @nome = 'teste' SET @descricao = 'desc'
EXECUTE spInserirPedido	@nome, @descricao
*/

--Alterar Pedido
GO
DROP PROCEDURE spAlteraPedido;
GO
CREATE PROCEDURE spAlteraPedido
	@cliente NUMERIC(18,0),
	@manufaturado NUMERIC(18,0),
	@orcamento NUMERIC(18,0),
	@quantidade INT,
	@desconto NUMERIC(18,2),
	@dataenvio DATETIME,
	@descricao VARCHAR (255),
	@codigo NUMERIC(18,0)
AS
BEGIN
	UPDATE Pedido SET 
        ID_Cliente = @cliente, 
        ID_Manufaturado = @manufaturado, 
        ID_Orcamento = @orcamento , 
        Quantidade = @quantidade , 
        Desconto = @desconto , 
        DataEnvio = @dataenvio , 
        Descricao = @descricao 
    WHERE ID_Pedido = @codigo;
END;
/*
GO
DECLARE	@nome VARCHAR(150), @descricao VARCHAR(250), @codigo NUMERIC(18,0)
	SET @nome = 'teste' SET @descricao = 'desc', @codigo = 5,
EXECUTE spAlteraPedido	@nome, @descricao, @codigo
*/

--Excluir Pedido
GO
DROP PROCEDURE spExcluiPedido;
GO
CREATE PROCEDURE spExcluiPedido
	@codigo NUMERIC(18,0)
AS
BEGIN
	DELETE FROM Pedido WHERE ID_Pedido = @codigo;
END;

--Procurar por Pedido
GO
DROP PROCEDURE spProcuraPedido;
GO
CREATE PROCEDURE spProcuraPedido
	@valor VARCHAR(150)
AS
BEGIN
	SELECT Pedido.ID_Pedido, Cliente.Nome, TipoManufaturado.Nome Tipo, CaracteristicaManufaturado1.Nome, CaracteristicaManufaturado2.Nome, Manufaturado.Nome Manufaturado, Manufaturado.Peso Unidade, UnidadeMedida.Nome UnMedida, Orcamento.Nome Orcamento, Pedido.Quantidade QTD, Pedido.Desconto, Pedido.DataEnvio, Pedido.Descricao FROM Pedido 
                INNER JOIN Cliente cliente ON cliente.ID_Cliente = Pedido.ID_Cliente 
                INNER JOIN Manufaturado ON Manufaturado.ID_Manufaturado = Pedido.ID_Manufaturado 
                INNER JOIN TipoManufaturado ON TipoManufaturado.ID_TipoManufaturado = Manufaturado.ID_TipoManufaturado 
                INNER JOIN CaracteristicaManufaturado1 ON CaracteristicaManufaturado1.ID_CaracteristicaManufaturado1 = Manufaturado.ID_CaracteristicaManufaturado1 
                INNER JOIN CaracteristicaManufaturado2 ON CaracteristicaManufaturado2.ID_CaracteristicaManufaturado2 = Manufaturado.ID_CaracteristicaManufaturado2 
                INNER JOIN UnidadeMedida ON UnidadeMedida.ID_UnidadeMedida = Manufaturado.ID_UnidadeMedida 
                INNER JOIN Orcamento ON Orcamento.ID_Orcamento = Pedido.ID_Orcamento 
                WHERE Pedido.ID_Manufaturado LIKE '%'+@valor+'%'
END;	

--Procurar por Pedido combo box
GO
DROP PROCEDURE spProcuraPedidoOrcamento;
GO
CREATE PROCEDURE spProcuraPedidoOrcamento
	@valor VARCHAR(150)
AS
BEGIN
	SELECT Pedido.ID_Pedido, Cliente.Nome, Pedido.Quantidade QTD, TipoManufaturado.Nome Tipo, CaracteristicaManufaturado1.Nome, CaracteristicaManufaturado2.Nome, Manufaturado.Nome Manufaturado, Pedido.Desconto, Manufaturado.Peso Unidade, UnidadeMedida.Nome UnMedida, Pedido.DataEnvio, Pedido.Descricao FROM Pedido 
                INNER JOIN Cliente cliente ON cliente.ID_Cliente = Pedido.ID_Cliente 
                INNER JOIN Manufaturado ON Manufaturado.ID_Manufaturado = Pedido.ID_Manufaturado 
                INNER JOIN TipoManufaturado ON TipoManufaturado.ID_TipoManufaturado = Manufaturado.ID_TipoManufaturado 
                INNER JOIN CaracteristicaManufaturado1 ON CaracteristicaManufaturado1.ID_CaracteristicaManufaturado1 = Manufaturado.ID_CaracteristicaManufaturado1 
                INNER JOIN CaracteristicaManufaturado2 ON CaracteristicaManufaturado2.ID_CaracteristicaManufaturado2 = Manufaturado.ID_CaracteristicaManufaturado2 
                INNER JOIN UnidadeMedida ON UnidadeMedida.ID_UnidadeMedida = Manufaturado.ID_UnidadeMedida 
                INNER JOIN Orcamento ON Orcamento.ID_Orcamento = Pedido.ID_Orcamento 
                WHERE Pedido.ID_Orcamento = '%'+@valor+'%'
END;	


--Procurar por ID Pedido
GO
DROP PROCEDURE spProcuraIDPedido;
GO
CREATE PROCEDURE spProcuraIDPedido
	@codigo NUMERIC(18,0)
AS
BEGIN
	SELECT * FROM Pedido 
           INNER JOIN Manufaturado ON Manufaturado.ID_Manufaturado = Pedido.ID_Manufaturado 
           INNER JOIN Cliente cliente ON cliente.ID_Cliente = Pedido.ID_Cliente 
           INNER JOIN TipoManufaturado ON TipoManufaturado.ID_TipoManufaturado = Manufaturado.ID_TipoManufaturado 
           INNER JOIN CaracteristicaManufaturado1 ON CaracteristicaManufaturado1.ID_CaracteristicaManufaturado1 = Manufaturado.ID_CaracteristicaManufaturado1 
           INNER JOIN CaracteristicaManufaturado2 ON CaracteristicaManufaturado2.ID_CaracteristicaManufaturado2 = Manufaturado.ID_CaracteristicaManufaturado2 
           WHERE ID_Pedido = @codigo;
END;
/*
GO
DECLARE
	@valor VARCHAR(150)
	SET @valor = 't'
	EXECUTE spProcuraPedido	@valor
*/
--Procura por Pedido existente

GO
DROP PROCEDURE spVerificaPedidoExistente;
GO
CREATE PROCEDURE spVerificaPedidoExistente
	@nome VARCHAR(150)
AS
BEGIN
	SELECT * FROM Pedido WHERE Pedido.Descricao = @nome
END;


------------------------
--STORE PROCEDURE UnidadeMedida
------------------------
--Inserir UnidadeMedida
GO
DROP PROCEDURE spInserirUnidadeMedida;
GO
CREATE PROCEDURE spInserirUnidadeMedida
	@nome VARCHAR(150)
AS
BEGIN
	INSERT INTO UnidadeMedida(Nome) 
	VALUES (@nome); SELECT @@IDENTITY;
	
END;
/*
GO
DECLARE	@nome VARCHAR(150), @descricao VARCHAR(250)
	SET @nome = 'teste' SET @descricao = 'desc'
EXECUTE spInserirUnidadeMedida	@nome, @descricao
*/

--Alterar UnidadeMedida
GO
DROP PROCEDURE spAlteraUnidadeMedida;
GO
CREATE PROCEDURE spAlteraUnidadeMedida
	@nome VARCHAR(150),
	@codigo NUMERIC(18,0)
AS
BEGIN
	UPDATE UnidadeMedida 
	SET 
		Nome = @nome
	WHERE ID_UnidadeMedida = @codigo;
END;
/*
GO
DECLARE	@nome VARCHAR(150), @descricao VARCHAR(250), @codigo NUMERIC(18,0)
	SET @nome = 'teste' SET @descricao = 'desc', @codigo = 5,
EXECUTE spAlteraUnidadeMedida	@nome, @descricao, @codigo
*/

--Excluir UnidadeMedida
GO
DROP PROCEDURE spExcluiUnidadeMedida;
GO
CREATE PROCEDURE spExcluiUnidadeMedida
	@codigo NUMERIC(18,0)
AS
BEGIN
	DELETE FROM UnidadeMedida WHERE ID_UnidadeMedida = @codigo;
END;

--Procurar por UnidadeMedida
GO
DROP PROCEDURE spProcuraUnidadeMedida;
GO
CREATE PROCEDURE spProcuraUnidadeMedida
	@valor VARCHAR(150)
AS
BEGIN
	SELECT * FROM UnidadeMedida WHERE Nome LIKE '%'+@valor+'%'
END;

--Procurar por ID UnidadeMedida
GO
DROP PROCEDURE spProcuraIDUnidadeMedida;
GO
CREATE PROCEDURE spProcuraIDUnidadeMedida
	@codigo NUMERIC(18,0)
AS
BEGIN
	SELECT * FROM UnidadeMedida WHERE ID_UnidadeMedida = @codigo
END;
/*
GO
DECLARE
	@valor VARCHAR(150)
	SET @valor = 't'
	EXECUTE spProcuraUnidadeMedida	@valor
*/
--Procura por UnidadeMedida existente

GO
DROP PROCEDURE spVerificaUnidadeMedidaExistente;
GO
CREATE PROCEDURE spVerificaUnidadeMedidaExistente
	@nome VARCHAR(150)
AS
BEGIN
	SELECT * FROM UnidadeMedida WHERE Nome = @nome
END;
------------------------
--STORE PROCEDURE Saida Pedido
------------------------

--Inserir UnidadeMedida
GO
DROP PROCEDURE spInserirSaidaPedido;
GO
CREATE PROCEDURE spInserirSaidaPedido
	@idpedido NUMERIC(18, 0), 
	@qtdentregue INT, 
	@pago NUMERIC(18, 2),
	@descricao VARCHAR(255)
AS
BEGIN
	INSERT INTO SaidaPedido(ID_Pedido,QuantidadeEntregue ,Pago ,SYSDATETIME, Descricao) 
	VALUES (@idpedido, @qtdentregue, @pago, GETDATE(), @descricao); SELECT @@IDENTITY;

END;
/*
GO
DECLARE	@nome VARCHAR(150), @descricao VARCHAR(250)
	SET @nome = 'teste' SET @descricao = 'desc'
EXECUTE spInserirUnidadeMedida	@nome, @descricao
*/

--Alterar SaidaPedido
GO
DROP PROCEDURE spAlteraSaidaPedido;
GO
CREATE PROCEDURE spAlteraSaidaPedido
	@idpedido NUMERIC(18,0),
	@qtdentregue NUMERIC(18,0),
	@pago INT,
	@descricao VARCHAR(255),
	@codigo NUMERIC(18, 0)
AS
BEGIN
	UPDATE SaidaPedido 
	SET 
		ID_Pedido = @idpedido , 
		QuantidadeEntregue = @qtdentregue , 
		Pago = @pago , 
		SYSDATETIME = GETDATE(), 
		Descricao = @descricao 
	WHERE ID_SaidaManufaturado = @codigo;
END;
/*
GO
DECLARE	@nome VARCHAR(150), @descricao VARCHAR(250), @codigo NUMERIC(18,0)
	SET @nome = 'teste' SET @descricao = 'desc', @codigo = 5,
EXECUTE spAlteraSaidaPedido	@nome, @descricao, @codigo
*/

--Excluir SaidaPedido
GO
DROP PROCEDURE spExcluiSaidaPedido;
GO
CREATE PROCEDURE spExcluiSaidaPedido
	@codigo NUMERIC(18,0)
AS
BEGIN
	DELETE FROM SaidaPedido WHERE ID_SaidaManufaturado = @codigo;
END;

--Procurar por SaidaPedido
GO
DROP PROCEDURE spProcuraSaidaPedido;
GO
CREATE PROCEDURE spProcuraSaidaPedido
	@valor VARCHAR(150)
AS
BEGIN
	SELECT 
		ID_SaidaManufaturado,
		SaidaPedido.ID_Pedido, 
		Cliente.Nome, 
		Cliente.Celular ,
		TipoManufaturado.Nome, 
		CaracteristicaManufaturado1.Nome, 
		CaracteristicaManufaturado2.Nome,
		Manufaturado.Nome, 
		Pedido.Quantidade QuantidadePedida, 
		SaidaPedido.QuantidadeEntregue, 
		SaidaPedido.Pago, 
		SaidaPedido.SYSDATETIME, 
		SaidaPedido.Descricao 
	FROM SaidaPedido
	INNER JOIN Pedido ON Pedido.ID_Pedido = SaidaPedido.ID_Pedido
    INNER JOIN Orcamento ON Orcamento.ID_Orcamento = Pedido.ID_Orcamento
    INNER JOIN Manufaturado ON Manufaturado.ID_Manufaturado = Pedido.ID_Manufaturado
    INNER JOIN TipoManufaturado ON TipoManufaturado.ID_TipoManufaturado = Manufaturado.ID_TipoManufaturado
	INNER JOIN CaracteristicaManufaturado1 ON CaracteristicaManufaturado1.ID_CaracteristicaManufaturado1 = Manufaturado.ID_CaracteristicaManufaturado1
	INNER JOIN CaracteristicaManufaturado2 ON CaracteristicaManufaturado2.ID_CaracteristicaManufaturado2 = Manufaturado.ID_CaracteristicaManufaturado2
	INNER JOIN Cliente ON Cliente.ID_Cliente = Pedido.ID_Cliente
	WHERE Cliente.Nome LIKE '%'+@valor+'%'
END;

--Procurar por ID SaidaPedido
GO
DROP PROCEDURE spProcuraIDSaidaPedido;
GO
CREATE PROCEDURE spProcuraIDSaidaPedido
	@codigo NUMERIC(18,0)
AS
BEGIN
	SELECT * FROM SaidaPedido
    INNER JOIN Pedido ON Pedido.ID_Pedido = SaidaPedido.ID_Pedido 
    INNER JOIN Manufaturado ON Manufaturado.ID_Manufaturado = Pedido.ID_Manufaturado 
    INNER JOIN TipoManufaturado ON TipoManufaturado.ID_TipoManufaturado = Manufaturado.ID_TipoManufaturado 
    INNER JOIN CaracteristicaManufaturado1 ON CaracteristicaManufaturado1.ID_CaracteristicaManufaturado1 = Manufaturado.ID_CaracteristicaManufaturado1 
    INNER JOIN CaracteristicaManufaturado2 ON CaracteristicaManufaturado2.ID_CaracteristicaManufaturado2 = Manufaturado.ID_CaracteristicaManufaturado2 
    INNER JOIN Cliente ON Cliente.ID_Cliente = Pedido.ID_Cliente 
    WHERE ID_SaidaManufaturado =  @codigo
END;
/*
GO
DECLARE
	@valor VARCHAR(150)
	SET @valor = 't'
	EXECUTE spProcuraSaidaPedido	@valor
*/
--Procura por SaidaPedido existente
/*
GO
DROP PROCEDURE spVerificaSaidaPedidoExistente;
GO
CREATE PROCEDURE spVerificaSaidaPedidoExistente
	@nome VARCHAR(150)
AS
BEGIN
	SELECT * FROM SaidaPedido WHERE Nome = @nome
END;
*/
------------------------
--STORE PROCEDURE Relatorios de Ganhos
------------------------
--Relatorios de ganhos
GO
DROP PROCEDURE spRelatorioGanhos;
GO
CREATE PROCEDURE spRelatorioGanhos
AS
BEGIN
	SELECT 
		TipoManufaturado.Nome Tipo, 
		CaracteristicaManufaturado1.Nome, 
		CaracteristicaManufaturado2.Nome, 
		Manufaturado.Nome Manufaturado, 
		SUM(Pedido.Quantidade) QTD, 
		SUM(Pedido.Quantidade * Manufaturado.Preco) Ganho_total 
	FROM Pedido
    INNER JOIN Manufaturado ON Manufaturado.ID_Manufaturado = Pedido.ID_Manufaturado
    INNER JOIN TipoManufaturado ON TipoManufaturado.ID_TipoManufaturado = Manufaturado.ID_TipoManufaturado
    INNER JOIN CaracteristicaManufaturado1 ON CaracteristicaManufaturado1.ID_CaracteristicaManufaturado1 = Manufaturado.ID_CaracteristicaManufaturado1
    INNER JOIN CaracteristicaManufaturado2 ON CaracteristicaManufaturado2.ID_CaracteristicaManufaturado2 = Manufaturado.ID_CaracteristicaManufaturado2
    GROUP BY TipoManufaturado.Nome, CaracteristicaManufaturado1.Nome, CaracteristicaManufaturado2.Nome, Manufaturado.Nome
END;
	

--Relatorios de ganho
GO
DROP PROCEDURE spRelatorioGanhosCliente;
GO
CREATE PROCEDURE spRelatorioGanhosCliente
AS
BEGIN
	SELECT 
		Cliente.ID_Cliente, 
		Cliente.Nome, 
		TipoManufaturado.Nome Tipo, 
		CaracteristicaManufaturado1.Nome, 
		CaracteristicaManufaturado2.Nome, 
		Manufaturado.Nome Manufaturado, 
		SUM( Pedido.Quantidade) QTD 
	FROM Pedido
	INNER JOIN Cliente cliente ON cliente.ID_Cliente = Pedido.ID_Cliente
	INNER JOIN Manufaturado ON Manufaturado.ID_Manufaturado = Pedido.ID_Manufaturado
	INNER JOIN TipoManufaturado ON TipoManufaturado.ID_TipoManufaturado = Manufaturado.ID_TipoManufaturado
	INNER JOIN CaracteristicaManufaturado1 ON CaracteristicaManufaturado1.ID_CaracteristicaManufaturado1 = Manufaturado.ID_CaracteristicaManufaturado1
	INNER JOIN CaracteristicaManufaturado2 ON CaracteristicaManufaturado2.ID_CaracteristicaManufaturado2 = Manufaturado.ID_CaracteristicaManufaturado2
	INNER JOIN UnidadeMedida ON UnidadeMedida.ID_UnidadeMedida = Manufaturado.ID_UnidadeMedida
	INNER JOIN Orcamento ON Orcamento.ID_Orcamento = Pedido.ID_Orcamento
	GROUP BY Cliente.ID_Cliente, Cliente.Nome, TipoManufaturado.Nome, CaracteristicaManufaturado1.Nome, CaracteristicaManufaturado2.Nome, Manufaturado.Nome
END;

--Relatorios de ganho por data
GO
DROP PROCEDURE spRelatorioGanhosData;
GO
CREATE PROCEDURE spRelatorioGanhosData
AS
BEGIN
	SELECT Cliente.Nome,CAST(Orcamento.DataReg as DATE) Data, COUNT(Orcamento.DataReg) QTD FROM Pedido
	INNER JOIN Cliente cliente ON cliente.ID_Cliente = Pedido.ID_Cliente
	INNER JOIN Orcamento ON Orcamento.ID_Orcamento = Pedido.ID_Orcamento 
	GROUP BY Cliente.Nome, Orcamento.DataReg
END;
------------------------
--STORE PROCEDURE Gastos
------------------------
--Relatorios de gasto
GO
DROP PROCEDURE spRelatorioGasto;
GO
CREATE PROCEDURE spRelatorioGasto
AS
BEGIN
	SELECT 
		Custo.ID_Custo, 
		Fabricante.Nome, 
		Custo.Nome, 
		Custo.Quantidade,
		Custo.Unidade,
		UnidadeMedida.Nome, 
		Custo.Preco PrecoUnitario, 
		(Custo.Preco*Custo.Quantidade) AS Total, 
		CAST(Custo.DataCompra AS DATE) DataRegistro 
	FROM Custo
    INNER JOIN Fabricante ON Fabricante.ID_Fabricante = Custo.ID_Fabricante
    INNER JOIN UnidadeMedida ON UnidadeMedida.ID_UnidadeMedida = Custo.ID_UnidadeMedida
END;

--Relatorios de gasto Produtos 
GO
DROP PROCEDURE spRelatorioGastoProdutos;
GO
CREATE PROCEDURE spRelatorioGastoProdutos	
AS
BEGIN
	SELECT 
		Fabricante.Nome, 
		Custo.Nome, 
		SUM(Custo.Quantidade) QTD,
		Custo.Unidade, 
		UnidadeMedida.Nome,
		(SUM(Custo.Preco)*SUM(Custo.Quantidade))AS total 
	FROM Custo
	INNER JOIN Fabricante ON Fabricante.ID_Fabricante = Custo.ID_Fabricante
	INNER JOIN UnidadeMedida ON UnidadeMedida.ID_UnidadeMedida = Custo.ID_UnidadeMedida
	GROUP BY Fabricante.Nome, Custo.Nome, Custo.Unidade, UnidadeMedida.Nome
END;


--Relatorios de gasto Data 
GO
DROP PROCEDURE spRelatorioGastoData;
GO
CREATE PROCEDURE spRelatorioGastoData	
AS
BEGIN
	SELECT 
		Fabricante.Nome, 
		Custo.Nome, 
		SUM(Custo.Quantidade) QTD,
		Custo.Unidade, 
		UnidadeMedida.Nome,
		CAST(Custo.DataCompra AS DATE) DataRegistro 
	FROM Custo
	INNER JOIN Fabricante ON Fabricante.ID_Fabricante = Custo.ID_Fabricante
	INNER JOIN UnidadeMedida ON UnidadeMedida.ID_UnidadeMedida = Custo.ID_UnidadeMedida
	GROUP BY Fabricante.Nome, Custo.Nome, Custo.Unidade, UnidadeMedida.Nome, DataCompra
END;

------------------------
--STORE PROCEDURE Relatorios de venda
------------------------
--Relatorios venda 
GO
DROP PROCEDURE spRelatorioVenda;
GO
CREATE PROCEDURE spRelatorioVenda	
AS
BEGIN
	SELECT 
		pedido.ID_Orcamento, 
		Orcamento.Nome,
		SUM(Pedido.Desconto) DescontoTotal, 
		SUM( Manufaturado.Preco*Pedido.Quantidade)-SUM(Pedido.Desconto) TotalPedido, 
		SUM(SaidaPedido.Pago) TotalPago, 
		SUM( Manufaturado.Preco*Pedido.Quantidade)-SUM(Pedido.Desconto)-SUM(SaidaPedido.Pago) DiferencaTotal 
	FROM pedido 
	INNER JOIN Orcamento ON Orcamento.ID_Orcamento = Pedido.ID_Orcamento 
	INNER JOIN Manufaturado ON Manufaturado.ID_Manufaturado = Pedido.ID_Manufaturado 
	INNER JOIN SaidaPedido ON SaidaPedido.ID_Pedido = Pedido.ID_Pedido 
	GROUP BY pedido.ID_Orcamento, Orcamento.Nome
END;



--Relatorios venda Faturado
GO
DROP PROCEDURE spRelatorioVendaFaturado;
GO
CREATE PROCEDURE spRelatorioVendaFaturado	
AS
BEGIN
	SELECT 
		pedido.ID_Orcamento, 
		Orcamento.Nome,TipoManufaturado.Nome, 
		CaracteristicaManufaturado1.Nome,
		CaracteristicaManufaturado2.Nome,
		Manufaturado.Nome , 
		Pedido.Quantidade qtdPedido, 
		SUM(QuantidadeEntregue) qtdEntregue, 
		SUM(Pedido.Quantidade - QuantidadeEntregue) faltaFabricar 
	FROM saidapedido 
	INNER JOIN Pedido ON Pedido.ID_Pedido = SaidaPedido.ID_Pedido 
	INNER JOIN Orcamento ON Orcamento.ID_Orcamento = Pedido.ID_Orcamento 
	INNER JOIN Manufaturado ON Manufaturado.ID_Manufaturado = Pedido.ID_Manufaturado 
	INNER JOIN TipoManufaturado ON TipoManufaturado.ID_TipoManufaturado = Manufaturado.ID_TipoManufaturado 
	INNER JOIN CaracteristicaManufaturado1 ON Manufaturado.ID_CaracteristicaManufaturado1 = CaracteristicaManufaturado1.ID_CaracteristicaManufaturado1 
	INNER JOIN CaracteristicaManufaturado2 ON Manufaturado.ID_CaracteristicaManufaturado2 = CaracteristicaManufaturado2.ID_CaracteristicaManufaturado2 
	GROUP BY pedido.ID_Orcamento, Orcamento.Nome,TipoManufaturado.Nome, CaracteristicaManufaturado1.Nome,CaracteristicaManufaturado2.Nome,Manufaturado.Nome, Pedido.Quantidade
END;

--Relatorios venda fabricar
GO
DROP PROCEDURE spRelatorioVendaFabricar;
GO
CREATE PROCEDURE spRelatorioVendaFabricar	
AS
BEGIN
	SELECT TipoManufaturado.Nome, CaracteristicaManufaturado1.Nome,CaracteristicaManufaturado2.Nome,Manufaturado.Nome, SUM(Pedido.Quantidade - QuantidadeEntregue) Fabricar from saidapedido INNER JOIN Pedido ON Pedido.ID_Pedido = SaidaPedido.ID_Pedido INNER JOIN Orcamento ON Orcamento.ID_Orcamento = Pedido.ID_Orcamento INNER JOIN Manufaturado ON Manufaturado.ID_Manufaturado = Pedido.ID_Manufaturado INNER JOIN TipoManufaturado ON TipoManufaturado.ID_TipoManufaturado = Manufaturado.ID_TipoManufaturado INNER JOIN CaracteristicaManufaturado1 ON Manufaturado.ID_CaracteristicaManufaturado1 = CaracteristicaManufaturado1.ID_CaracteristicaManufaturado1 INNER JOIN CaracteristicaManufaturado2 ON Manufaturado.ID_CaracteristicaManufaturado2 = CaracteristicaManufaturado2.ID_CaracteristicaManufaturado2 GROUP BY TipoManufaturado.Nome, CaracteristicaManufaturado1.Nome,CaracteristicaManufaturado2.Nome,Manufaturado.Nome HAVING (SUM(Pedido.Quantidade - QuantidadeEntregue)>0) 
END;

EXEC spProcuraIDSaidaPedido 10