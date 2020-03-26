CREATE TABLE Clientes( 
	ClienteId int,
	Cpf varchar(14),
	Nome varchar(50),
	Endereco varchar(200),
	Numero varchar(50),
	Complemento varchar(50),
	Bairro varchar(100),
	Cidade varchar(100),
	Estado varchar(2),
	Cep varchar(8),
	TelRes varchar(15),
	TelCel varchar(15),
	DataCadastro datetime default getdate(),
	Ativo bit,
	LatLog varchar(50)
)
