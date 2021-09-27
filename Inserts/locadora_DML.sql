USE LOCADORA
GO

insert into empresa (nomeEmpresa)
values ('movida'), ('localiza')

insert into cliente (nomeCliente, cpfCliente)
values ('Saulo', '123456789'), ('Lucas', '987654321')

insert into marca (nomeMarca)
values ('hyundai'), ('jeep'), ('fiat')

insert into modelo (nomeModelo, idMarca)
values ('hb20','1'), ('renegade','2'), ('fox','3')

insert into veiculo (placaVeiculo, idModelo, idMarca, idEmpresa)
values ('AAA1111','3','3','2'), ('BBB2222','1','2','1'), ('CCC3333','2','1','1')

insert into aluguel (idVeiculo, dataAluguel, idCliente)
values ('2','2021-08-19 17:30',5), ('3','2021-08-20 18:30',4), ('1','2021-08-21 19:00',5)