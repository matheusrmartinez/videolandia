CREATE DATABASE VideoLandiaDB;
GO

USE VideoLandiaDB;
GO

CREATE TABLE GenerosFilmes
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
CodigoItem INT PRIMARY KEY IDENTITY,
CodigoDeBarras varchar(50),
Titulo varchar(40),
CodigoGenero int,
Ano int,
Tipo varchar(10),
Preco decimal(19,6),
DataAdquirida DATE,
Custo decimal (19,6),
CodigoSituacao int,
CodigoArtista int,
FOREIGN KEY (CodigoGenero) REFERENCES GenerosFilmes (CodigoGenero),
FOREIGN KEY (CodigoSituacao) REFERENCES Situacoes (CodigoSituacao),
FOREIGN KEY (CodigoArtista) REFERENCES Artistas (CodigoArtista)
)

CREATE TABLE Locacoes
(
CodigoLocacao INT PRIMARY KEY IDENTITY,
CodigoItem INT,
CodigoFuncionario INT,
CodigoCliente INT,
DataAtual DATE,
DataPrevista DATE,
Valor decimal (19,6),
ValorTotal decimal (19,6),
ValorPago decimal(19,6),
SituacaoPagamento varchar(10)
FOREIGN KEY (CodigoItem) REFERENCES Itens (CodigoItem),
FOREIGN KEY  (CodigoFuncionario) REFERENCES Pessoas (CodigoPessoa),
FOREIGN KEY (CodigoCliente) REFERENCES Pessoas (CodigoPessoa)
)

CREATE TABLE Devolucoes
(
CodigoLocacao INT,
DataEntrega DATE,
ValorAPagar DECIMAL(19,6),
ValorPago DECIMAL (19,6),
FOREIGN KEY (CodigoLocacao) REFERENCES Locacoes (CodigoLocacao)
)

CREATE TABLE FilmesGeneros
(
CodigoItem int,
CodigoGenero int,
FOREIGN KEY (CodigoItem) REFERENCES Itens (CodigoItem),
FOREIGN KEY (CodigoGenero) REFERENCES GenerosFilmes (CodigoGenero) 
)

CREATE TABLE ArtistasFilme
(
CodigoItem int,
CodigoArtista int,
FOREIGN KEY (CodigoItem) REFERENCES Itens (CodigoItem),
FOREIGN KEY (CodigoArtista) REFERENCES Artistas (CodigoArtista)
)

CREATE TABLE PersonagensFilme
(
CodigoArtista int,
CodigoItem int,
NomePersonagem varchar (50) PRIMARY KEY,
FOREIGN KEY (CodigoArtista) REFERENCES Artistas (CodigoArtista),
FOREIGN KEY (CodigoItem) REFERENCES Itens (CodigoItem)
)
