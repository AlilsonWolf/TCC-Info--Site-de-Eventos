CREATE DATABASE EventHub;
go

USE EventHub;

CREATE TABLE Eventos (
    ID INT PRIMARY KEY IDENTITY,
    Titulo NVARCHAR(255),
    Descricao NVARCHAR(MAX),
    DataEvento DATE,
    Localizacao NVARCHAR(255),
    LinkVideo NVARCHAR(255)
);

CREATE TABLE Artistas (
    ID INT PRIMARY KEY IDENTITY,
    Nome NVARCHAR(255),
    GeneroMusical NVARCHAR(255),
    CanalYouTube NVARCHAR(255)
);

CREATE TABLE CronogramaEvento (
    ID INT PRIMARY KEY IDENTITY,
    DataEvento DATE,
    NomeArtista NVARCHAR(255),
    DescricaoArtista NVARCHAR(MAX)
);
ALTER TABLE CronogramaEvento
ADD EventoID INT,
    FOREIGN KEY (EventoID) REFERENCES Eventos(ID);

ALTER TABLE CronogramaEvento
ADD ArtistaID INT,
    FOREIGN KEY (ArtistaID) REFERENCES Artistas(ID);
