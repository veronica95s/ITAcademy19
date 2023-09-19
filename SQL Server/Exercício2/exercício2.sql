--Grupo: Anacarolina Moura, Anacarolina Xavier, Carolina Kowaluk, Cristine Lacerda, 
--Eduarda Loureiro, Laura Skorupski e Veronica Andrade


--Tabela Médicos

create table Medicos 
(
	-- NOT NULL indica que esse campo não pode ser vazio ou nulo
	crm char(9) NOT NULL,
	nome varchar(50) NOT NULL,
	especialidade varchar(30) NOT NULL,
	-- Cria uma chave primária da coluna crm. Cada valor de crn deve ser unico.
	-- PK_MEDICOS é o nome da chave primaria
	constraint PK_MEDICOS primary key (crm)
);

--Tabela Pacientes

create table Pacientes 
(
	cpf char(14) not null,
	nome varchar(50) not null,
	sexo varchar(2),
	-- Devine cpf como chave primária
	constraint PK_PACIENTES primary key (cpf),
	-- Verifica se os valores na coluna sexo são válidos
	constraint CK_SEXO check (sexo in ('M', 'F', 'NB'))
);

--Tabela MédicosPacientes

create table MedicosPacientes
(
	crmMedico char(9) not null,
	cpfPaciente char(14) not null,
	-- Define uma chave estrangeira na coluna crmMedico
	-- Estabelece uma relação entre as tabelas MedicosPacientes e Medicos
	-- A coluna crmMedico faz referencia a coluna crm na tabela Medicos
	-- Apenas um valor válido de crm da tabela Medicos pode entrar em crmMedico
	constraint FK_MEDICOS foreign key (crmMedico) references Medicos(crm),
	-- Define uma chave estrangeira na coluna cpfPaciente
	-- Estabelece uma relação entre as tabelas MedicosPacientes e Pacientes
	-- A coluna cpfPaciente faz referencia a coluna cpf na tabela Pacientes
	-- Apenas um valor válido de cpf da tabela Pacientes pode entrar em cpfPaciente
	constraint FK_PACIENTES foreign key (cpfPaciente) references Pacientes(cpf),
	-- Define uma chave primária composta com as colunas crmMedico e cpfPaciente
	constraint PK_MEDICOS_PACIENTES primary key (crmMedico, cpfPaciente)
);


--Médicos

insert into Medicos (crm, nome, especialidade)
values ('123456/RS', 'João Lima', 'Cardiologia');

insert into Medicos (crm, nome, especialidade)
values ('573496/RS', 'Márcia Cardoso', 'Ortopedia');

insert into Medicos(crm, nome, especialidade)
values ('456123/RS', 'José Leôncio', 'Cardiologia');

insert into Medicos (crm, nome, especialidade)
values ('789234/RS', 'Filomena da Silva', 'Neurologia');

insert into Medicos (crm, nome, especialidade)
values ('453678/RS', 'Joventino Leôncio', 'Psiquiatria');


--Pacientes 

insert into Pacientes (cpf, nome, sexo)
values ('123.456.789-10', 'José Almeida', 'M');

insert into Pacientes (cpf, nome, sexo)
values ('321.110.789-06', 'Carla Souza', 'F');

INSERT INTO PACIENTES (CPF, NOME, SEXO)
VALUES ('563.899.000-20', 'Maria Marta', 'F');

INSERT INTO PACIENTES (CPF, NOME, SEXO)
VALUES ('000.110.220-99', 'Maria Clara', 'F');

INSERT INTO PACIENTES (CPF, NOME, SEXO)
VALUES ('999.258.963-74', 'José Pedro', 'M');



--Médicos e Pacientes

insert into MedicosPacientes(crmMedico, cpfPaciente)
values ('123456/RS','123.456.789-10');

insert into MedicosPacientes(crmMedico, cpfPaciente)
values ('573496/RS','321.110.789-06');

insert into MedicosPacientes (crmMedico, cpfPaciente)
values ('456123/RS', '563.899.000-20');

insert into MedicosPacientes(crmMedico, cpfPaciente) 
values('573496/RS', '000.110.220-99');

insert into MedicosPacientes(crmMedico, cpfPaciente)
values ('789234/RS', '563.899.000-20');


--Tabela HistóricoConsultas

create table HistoricoConsultas
(
	-- identity(1,1) os valores vão ser gerados automaticamente em sequencia
	idConsulta numeric identity(1,1),
	crmMedico char(9) not null,
	cpfPaciente char(14) not null,
	dataConsulta date not null,
	-- Define idConsulta como chave primária
	constraint PK_CONSULTA primary key (idConsulta),
	-- Define uma chave estrangeira crmMedico
	-- Estabelece uma relação entre as tabelas HistoricoConsultas e Medicos
	-- A coluna crmMedico faz referencia a coluna crm na tabela Medicos
	-- Apenas um valor válido de crm da tabela Medicos pode entrar em crmMedico
	constraint FK_MEDICOS_CONSULTA foreign key (crmMedico) references Medicos(crm),
	-- Define uma chave estrangeira na coluna cpfPaciente
	-- Estabelece uma relação entre as tabelas HistoricoConsultas e Pacientes
	-- A coluna cpfPaciente faz referencia a coluna cpf na tabela Pacientes
	-- Apenas um valor válido de cpf da tabela Pacientes pode entrar em cpfPaciente
	constraint FK_PACIENTES_CONSULTA foreign key (cpfPaciente) references Pacientes(cpf)
);

--Consultas

insert into HistoricoConsultas (crmMedico, cpfPaciente, dataConsulta)
values ('123456/RS', '563.899.000-20', convert (date, '24/08/2023',103));

insert into HistoricoConsultas (crmMedico, cpfPaciente, dataConsulta)
values ('456123/RS', '563.899.000-20', convert(date, '06/02/2023',103));

insert into HistoricoConsultas (crmMedico, cpfPaciente, dataConsulta)
values ('456123/RS', '563.899.000-20', convert(date, '20/08/2023',103));

insert into HistoricoConsultas (crmMedico, cpfPaciente, dataConsulta)
values ('573496/RS', '321.110.789-06', convert(date, '21/08/2023',103));

insert into HistoricoConsultas (crmMedico, cpfPaciente, dataConsulta)
values('789234/RS', '999.258.963-74', convert(date, '22/07/2023',103));