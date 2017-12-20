DROP TABLE SaidaPedido
DROP TABLE Pedido
DROP TABLE Orcamento
DROP TABLE Manufaturado
DROP TABLE TipoManufaturado
DROP TABLE CaracteristicaManufaturado1
DROP TABLE CaracteristicaManufaturado2
DROP TABLE Custo
DROP TABLE UnidadeMedida
DROP TABLE Fabricante
DROP TABLE Cliente
DROP TABLE Bairro
DROP TABLE Cidade

CREATE TABLE Cidade(
    ID_Cidade NUMERIC(18,0) NOT NULL IDENTITY,
    Nome VARCHAR(50) NOT NULL,
    Descricao VARCHAR(225),

    CONSTRAINT PKID_Cidade PRIMARY KEY (ID_Cidade)
)
CREATE TABLE Bairro(
    ID_Bairro NUMERIC(18,0) NOT NULL IDENTITY,
    Nome VARCHAR(150) NOT NULL,
    Descricao VARCHAR(255),

    CONSTRAINT PKID_Bairro PRIMARY KEY(ID_Bairro),
)
CREATE TABLE Cliente(
    ID_Cliente NUMERIC(18,0) NOT NULL IDENTITY,
    Nome VARCHAR(50) NOT NULL,
    Telefone NUMERIC(18,0) NOT NULL,
    Celular NUMERIC(18,0),
    ID_Cidade NUMERIC(18,0),
    ID_Bairro NUMERIC(18,0),
    SYSDATETIME DATETIME,

    CONSTRAINT PKID_Cliente PRIMARY KEY (ID_Cliente),
    CONSTRAINT FKID_Cidade FOREIGN KEY (ID_Cidade) REFERENCES Cidade(ID_Cidade),
    CONSTRAINT FKID_Bairro FOREIGN KEY (ID_Bairro) REFERENCES Bairro(ID_Bairro),
)
CREATE TABLE Fabricante(
    ID_Fabricante NUMERIC(18,0) NOT NULL IDENTITY,
    Nome VARCHAR(150) NOT NULL,
    Descricao VARCHAR(255),

    CONSTRAINT PKID_Fabricante PRIMARY KEY(ID_Fabricante)
)
CREATE TABLE UnidadeMedida(
    ID_UnidadeMedida NUMERIC(18,0) NOT NULL IDENTITY,
    Nome VARCHAR(50) NOT NULL,

    CONSTRAINT PKID_UnidadeMedida PRIMARY KEY (ID_UnidadeMedida)
)
CREATE TABLE Custo(
    ID_Custo NUMERIC(18,0) NOT NULL IDENTITY,
    ID_Fabricante NUMERIC(18,0) NOT NULL,
    Nome VARCHAR(50) NOT NULL,
    Preco NUMERIC(18,2) NOT NULL,
    Quantidade INT NOT NULL,
    Unidade NUMERIC(18,2),
    ID_UnidadeMedida NUMERIC(18,0),
    Descricao VARCHAR(255),
    DataCompra DATETIME,

    CONSTRAINT PKID_Custo PRIMARY KEY (ID_Custo),
    CONSTRAINT FKID_Fabricante FOREIGN KEY (ID_Fabricante) REFERENCES Fabricante(ID_Fabricante),
    CONSTRAINT FKID_UnidadeMedida FOREIGN KEY (ID_UnidadeMedida) REFERENCES UnidadeMedida(ID_UnidadeMedida)
)
CREATE TABLE CaracteristicaManufaturado1( 
    ID_CaracteristicaManufaturado1 NUMERIC(18,0) NOT NULL IDENTITY,
    Nome VARCHAR(50) NOT NULL,
    Descricao VARCHAR(255),

    CONSTRAINT PKID_CaracteristicaManufaturado1 PRIMARY KEY (ID_CaracteristicaManufaturado1)
)
CREATE TABLE CaracteristicaManufaturado2( 
    ID_CaracteristicaManufaturado2 NUMERIC(18,0) NOT NULL IDENTITY,
    Nome VARCHAR(50) NOT NULL,
    Descricao VARCHAR(255),

    CONSTRAINT PKID_CaracteristicaManufaturado2 PRIMARY KEY (ID_CaracteristicaManufaturado2)
)
CREATE TABLE TipoManufaturado( 
    ID_TipoManufaturado NUMERIC(18,0) NOT NULL IDENTITY,
    Nome VARCHAR(50) NOT NULL,
    Descricao VARCHAR(255),

    CONSTRAINT PKID_TipoManufaturado PRIMARY KEY (ID_TipoManufaturado)
)
CREATE TABLE Manufaturado(
    ID_Manufaturado NUMERIC(18,0) NOT NULL IDENTITY,
    ID_TipoManufaturado NUMERIC(18,0) NOT NULL,
    ID_CaracteristicaManufaturado1 NUMERIC(18,0),
    ID_CaracteristicaManufaturado2 NUMERIC(18,0),
    Nome VARCHAR(50) NOT NULL,
    ID_UnidadeMedida NUMERIC(18,0) NOT NULL,
    Peso NUMERIC(18,2) NOT NULL,
    Preco NUMERIC(18,2) NOT NULL,
    Descricao VARCHAR(255),

    CONSTRAINT PKID_Manufaturado PRIMARY KEY (ID_Manufaturado),
    CONSTRAINT FKID_TipoManufaturado FOREIGN KEY (ID_TipoManufaturado) REFERENCES TipoManufaturado(ID_TipoManufaturado),
    CONSTRAINT FKID_UnidadeMedida1 FOREIGN KEY (ID_UnidadeMedida) REFERENCES UnidadeMedida(ID_UnidadeMedida),
    CONSTRAINT FKID_CaracteristicaManufaturado1 FOREIGN KEY (ID_CaracteristicaManufaturado1) REFERENCES CaracteristicaManufaturado1(ID_CaracteristicaManufaturado1),
    CONSTRAINT FKID_CaracteristicaManufaturado2 FOREIGN KEY (ID_CaracteristicaManufaturado2) REFERENCES CaracteristicaManufaturado2(ID_CaracteristicaManufaturado2)
)
CREATE TABLE Orcamento(
    ID_Orcamento NUMERIC(18,0) NOT NULL IDENTITY,
    Nome VARCHAR(100) NOT NULL,
    DataReg DATETIME,

    CONSTRAINT PKID_Orcamento PRIMARY KEY (ID_Orcamento)
)
CREATE TABLE Pedido(
    ID_Pedido NUMERIC(18,0) NOT NULL IDENTITY,
    ID_Cliente NUMERIC(18,0) NOT NULL,
    ID_Manufaturado NUMERIC(18,0) NOT NULL,
    ID_Orcamento NUMERIC(18,0) NOT NULL,
    Quantidade INT NOT NULL,
	Desconto NUMERIC(18,2),
    SYSDATETIME DATETIME,
    DataEnvio DATETIME,
    Descricao VARCHAR(255),

    CONSTRAINT PKID_Pedido PRIMARY KEY (ID_Pedido),
    CONSTRAINT FKID_Cliente FOREIGN KEY (ID_Cliente) REFERENCES Cliente(ID_Cliente),
    CONSTRAINT FKID_Orcamento FOREIGN KEY (ID_Orcamento) REFERENCES Orcamento(ID_Orcamento),
    CONSTRAINT FKID_Manufaturado FOREIGN KEY (ID_Manufaturado) REFERENCES Manufaturado(ID_Manufaturado),
)
CREATE TABLE SaidaPedido(
    ID_SaidaManufaturado NUMERIC(18,0) NOT NULL IDENTITY,
    ID_Pedido NUMERIC(18,0) NOT NULL,
    QuantidadeEntregue INT NOT NULL,
    Pago NUMERIC(18,2) NOT NULL,
    SYSDATETIME DATETIME,
    Descricao VARCHAR(255),

    CONSTRAINT PKID_SaidaManufaturado PRIMARY KEY (ID_SaidaManufaturado),
    CONSTRAINT FKID_Pedido FOREIGN KEY (ID_Pedido) REFERENCES Pedido(ID_Pedido),
)

INSERT INTO Cidade(Nome,Descricao)
VALUES  ('Sorocaba','Terra rasgada'),
        ('São Roque',''),
        ('Tatui','')
INSERT INTO Bairro(Nome,Descricao)
VALUES  ('Santa Rosalia',''),
        ('Centro',''),
        ('Aparecida','')
INSERT INTO Cliente(Nome,Telefone,Celular,ID_Cidade,ID_Bairro)
VALUES  ('Edson','1532335488','15981084456',1,1),
        ('Cecilia','1532335488','15981084456',1,1)
INSERT INTO Fabricante(Nome,Descricao)
VALUES  ('Nestle','Produtos alimenticios'),
        ('MARAJOARA','Produtos alimenticios')

INSERT INTO UnidadeMedida(Nome)
VALUES  ('KG'),
        ('METRO'),
        ('UNIDADE'),
        ('CAIXA')
INSERT INTO Custo(ID_Fabricante,Nome,Preco,Quantidade,Unidade,ID_UnidadeMedida,Descricao,DataCompra)
VALUES  ('1','Chocolate','50','1','1',1,'', GETDATE())
INSERT INTO TipoManufaturado(Nome, Descricao)
VALUES  ('OVO PASCOA','OVO DE PASCOA'),
        ('BARRA','Barra de chocolate'),
        ('BISCOITO','Biscoito')
INSERT INTO CaracteristicaManufaturado1(Nome, Descricao)
VALUES  ('AO LEITE','Chocolate ao leite'),
        ('BRANCO','Chocolate branco'),
        ('MEIO AMARGO','chocolate meio amargo'),
        ('DIET','Chocolate diet')
		INSERT INTO CaracteristicaManufaturado2(Nome, Descricao)
VALUES  ('PRESTIGIO','Coco'),
        ('CROCANTE','Caramelo'),
        ('FLOCOS DE ARROZ','Uso de floco de arroz'),
        ('TRUFA DE CHOCOLATE','uso de trufa de chocolate')
INSERT INTO Manufaturado(ID_TipoManufaturado,Nome,ID_CaracteristicaManufaturado1,ID_CaracteristicaManufaturado2,ID_UnidadeMedida,Peso,Preco,Descricao)
VALUES  (1,'Ao Leite Prestigio 1kg',1,1,1,'1','50','feito de coco'),
        (1,'Ao Leite Prestigio 500g',1,1,1,'0.5','50','feito de coco'),
        (1,'Ao Leite Prestigio 250g',1,1,1,'0.25','50','feito de coco'),
        (1,'Ao Leite Prestigio 100g',1,1,1,'0.1','50','feito de coco')
INSERT INTO Orcamento(Nome, DataReg)
VALUES  ('Edson Yamamoto',GETDATE()),
        ('Cecilia Yamamoto',GETDATE()),
        ('Jose',GETDATE()),
        ('Ta',GETDATE())
INSERT INTO Pedido(ID_Cliente,ID_Manufaturado,ID_TipoManufaturado,ID_CaracteristicaManufaturado1,ID_CaracteristicaManufaturado2,ID_Orcamento,Quantidade,Desconto,DataEnvio,Descricao)
VALUES  (1,1,1,1,1,1,1,'0','','')

INSERT INTO Entregue(ID_Pedido,ID_Custo)
VALUES  (1,1)

/*
Todos os pedidos
*/
SELECT cliente.Nome, cliente.Telefone, cliente.Celular, Manufaturado.Nome, Manufaturado.Peso, Pedido.Quantidade FROM Pedido
INNER JOIN Cliente cliente ON cliente.ID_Cliente = Pedido.ID_Cliente
INNER JOIN Manufaturado ON Manufaturado.ID_Manufaturado = Pedido.ID_Manufaturado
INNER JOIN TipoManufaturado ON TipoManufaturado.ID_TipoManufaturado = Manufaturado.ID_TipoManufaturado

/*
Todas as despesas
*/
SELECT Fabricante.Nome, Custo.Nome, Custo.Quantidade, Custo.Preco FROM Entregue
INNER JOIN Custo ON Custo.ID_Custo = Entregue.ID_Custo
INNER JOIN Fabricante ON Fabricante.ID_Fabricante = Custo.ID_Fabricante

/*
Soma total de ganhos
*/
SELECT Manufaturado.Nome, Manufaturado.Peso, SUM(Pedido.Quantidade) qtdTOTAL, SUM(Manufaturado.Preco) Total FROM Entregue
INNER JOIN Pedido  ON Pedido.ID_Pedido = Entregue.ID_Pedido
INNER JOIN Manufaturado  ON Manufaturado.ID_Manufaturado = Pedido.ID_Manufaturado
GROUP BY Manufaturado.Nome, Manufaturado.Peso

/*
Soma total de despesas
*/
SELECT Fabricante.Nome, Custo.nome, SUM (Custo.Quantidade) TotalQTD, SUM(Custo.Preco)TOTALgasto FROM Entregue
INNER JOIN Custo ON Custo.ID_Custo = Entregue.ID_Custo
INNER JOIN Fabricante ON Fabricante.ID_Fabricante = Custo.ID_Fabricante
GROUP BY Fabricante.Nome, Custo.Nome
