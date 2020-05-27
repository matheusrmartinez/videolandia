CREATE DATABASE VideoLandiaDB;
GO

USE VideoLandiaDB;
GO

CREATE TABLE Generos
(
CodigoGenero int PRIMARY KEY IDENTITY,
Nome varchar(50)
)

CREATE TABLE Artistas
(
CodigoArtista int PRIMARY KEY IDENTITY,
Nome varchar(100),
DataNascimento DATE,
Pais varchar(50),
CaminhoFoto varchar(200)
)


CREATE TABLE Situacoes
(
CodigoSituacao int PRIMARY KEY IDENTITY,
NomeCliente varchar(100),
DataRetirada DATE,
DataPrevista DATE,
Telefone varchar(15),
Celular varchar(15)
)

CREATE TABLE Pessoas
(
CodigoPessoa int PRIMARY KEY IDENTITY,
Funcionario char(1),
Nome varchar(100),
DataNascimento DATE,
Sexo char(1),
EstadoCivil varchar(30),
RG varchar(20),
CPF varchar(20),
Endereco varchar(200),
Cidade varchar(50),
CEP varchar(10),
Estado varchar(2),
Telefone varchar(15),
Celular varchar(15),
Email varchar(30),
SituacaoPagamentos varchar(10)
)

CREATE TABLE Itens
(
CodigoItem INT IDENTITY,
CodigoDeBarras varchar(50) PRIMARY KEY,
Titulo varchar(40),
CodigoGenero int,
Ano int,
Tipo varchar(10),
Preco decimal(19,6),
DataAdquirida DATE,
Custo decimal (19,6),
CodigoSituacao int,
CodigoArtista int,
FOREIGN KEY (CodigoGenero) REFERENCES Generos (CodigoGenero),
FOREIGN KEY (CodigoSituacao) REFERENCES Situacoes (CodigoSituacao),
FOREIGN KEY (CodigoArtista) REFERENCES Artistas (CodigoArtista)
)

CREATE TABLE Locacoes
(
CodigoLocacao INT PRIMARY KEY IDENTITY,
CodigoFuncionario INT,
CodigoCliente INT,
DataAtual DATE,
DataPrevista DATE,
Valor decimal (19,6),
ValorTotal decimal (19,6),
ValorPago decimal(19,6),
SituacaoPagamento varchar(10)
FOREIGN KEY  (CodigoFuncionario) REFERENCES Pessoas (CodigoPessoa),
FOREIGN KEY (CodigoCliente) REFERENCES Pessoas (CodigoPessoa)
)

CREATE TABLE Devolucoes
(
CodigoDevolucao INT PRIMARY KEY IDENTITY,
CodigoLocacao INT,
DataEntrega DATE,
ValorAPagar DECIMAL(19,6),
ValorPago DECIMAL (19,6),
FOREIGN KEY (CodigoLocacao) REFERENCES Locacoes (CodigoLocacao),
)

CREATE TABLE ItensDevolucao 
(
CodigoDevolucao int,
CodigoDeBarras varchar(50),
Titulo varchar(50),
Preco decimal (19,6),
FOREIGN KEY (CodigoDevolucao) REFERENCES Devolucoes (CodigoDevolucao)
)

CREATE TABLE ArtistasFilme
(
CodigoDeBarras varchar(50),
CodigoArtista int,
FOREIGN KEY (CodigoDeBarras) REFERENCES Itens (CodigoDeBarras),
FOREIGN KEY (CodigoArtista) REFERENCES Artistas (CodigoArtista)
)

CREATE TABLE GenerosFilmes
(
CodigoGenero int,
NomeGenero varchar(50),
CodigoItem int,
CodigoDeBarras varchar(50),
Titulo varchar(50),
FOREIGN KEY (CodigoGenero) REFERENCES Generos (CodigoGenero),
FOREIGN KEY (CodigoDeBarras) REFERENCES Itens (CodigoDeBarras),
)

CREATE TABLE PersonagensFilme
(
CodigoArtista int,
CodigoDeBarras varchar(50),
NomePersonagem varchar (50) PRIMARY KEY,
NomeArtista varchar(100),
Titulo varchar(40),
FOREIGN KEY (CodigoArtista) REFERENCES Artistas (CodigoArtista),
FOREIGN KEY (CodigoDeBarras) REFERENCES Itens (CodigoDeBarras)
)

CREATE TABLE ItensLocacao
(
CodigoLocacao int,
CodigoItem int,
CodigoDeBarras varchar(50),
Titulo varchar(40),
Preco decimal(19,6),
FOREIGN KEY (CodigoLocacao) REFERENCES Locacoes (CodigoLocacao)
)

