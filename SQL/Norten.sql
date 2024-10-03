Create database Norten

use Norten		
go

--CRIANDO TABELA DE Usuario
create table Func_Usuario_RH(
	idLogin INT IDENTITY PRIMARY KEY,
	RH_Login VARCHAR(50) NOT NULL,
	RH_senha VARCHAR(20) NOT NULL
)

CREATE TABLE Funcionarios (
    ID_Func INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Func_CPF CHAR(11) NOT NULL UNIQUE,
    Func_NomeCompleto NVARCHAR(100),
    Func_DataNascimento DATE,
    Func_Genero NVARCHAR(20),
    Func_EstadoCivil NVARCHAR(20),
    Func_Identificacao NVARCHAR(20),
    Func_Endereco NVARCHAR(255),
    Func_TelefoneCelular NVARCHAR(15),
    Func_Email NVARCHAR(100),
    Func_Cargo NVARCHAR(50),
    Func_Departamento NVARCHAR(50),
    Func_DataAdmissao DATE,
    Func_Salario DECIMAL(10, 2),
    Func_CarteiraTrabalho NVARCHAR(20),
    Func_Foto VARBINARY(MAX),
	Func_Senha VARCHAR(255) NOT NULL,
	idLogin INT NULL
);


select * from Funcionarios

ALTER TABLE Funcionarios
ADD CONSTRAINT FK_Funcionarios_Usuario
FOREIGN KEY (idLogin) REFERENCES Func_Usuario_RH(idLogin);

-- Insere um novo registro na tabela Func_Usuario_RH
INSERT INTO Func_Usuario_RH (RH_Login, RH_senha)
VALUES ('Gui', '123');

-- Insere um novo registro na tabela Funcionarios
INSERT INTO Funcionarios (Func_CPF, Func_NomeCompleto, Func_DataNascimento, Func_Genero, Func_EstadoCivil, Func_Identificacao, Func_Endereco, Func_TelefoneCelular, Func_Email, Func_Cargo, Func_Departamento, Func_DataAdmissao, Func_Salario, Func_CarteiraTrabalho, Func_Foto, Func_Senha, idLogin)
VALUES ('51627074813', 'Guilherme Carvalho', '2002-04-03', 'M', 'C', 'RG 123456789-0', 'Rua da Paz, 123', '(11) 98765-4321', 'guilhermecarvalho381@email.com', 'Desenvolvedor de software', 'Tecnologia da informação', '2023-10-11', 5000.00, '12345678901', NULL, '123', 1);

SELECT * FROM FolhaDePagamento 

CREATE TABLE FolhaDePagamento (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Conta NVARCHAR(100),
    SalarioBase DECIMAL(10, 2),
    AdicionalNoturno DECIMAL(10, 2), 
    AdiantamentoQuinzenal DECIMAL(18,2) DEFAULT 0.00,
    PlanoDeSaude DECIMAL(18,2) DEFAULT 50.00,
    INSS DECIMAL(18,2) DEFAULT 0.00,
    ValeRefeicao DECIMAL(18,2) DEFAULT 1200.00,
    ValeTransporte DECIMAL(18,2) DEFAULT 1000.00,
    FGTS DECIMAL(18,2),
    DecimoTerceiro DECIMAL(18,2) DEFAULT 0.00,
    Ferias DECIMAL(18,2) DEFAULT 0.00,
    ID_Func INT,
    FOREIGN KEY (ID_Func) REFERENCES Funcionarios(ID_Func),
);


