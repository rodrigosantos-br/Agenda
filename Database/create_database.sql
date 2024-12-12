-- Criação do banco de dados
CREATE DATABASE Agenda;

-- Seleciona o banco de dados
USE Agenda;

-- Criação da tabela de compromissos
CREATE TABLE [dbo].[compromissos] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Titulo]    VARCHAR (50)  NOT NULL,
    [DataHora]  DATETIME      NOT NULL,
    [Descricao] VARCHAR (200) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
