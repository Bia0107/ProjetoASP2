create database dbEmprestimo;
use dbEmprestimo;

create table tbUsuario(
CodUsu int primary key auto_increment,
NomeUsu varchar(50)
);

create table tbLivro(
CodLivro int primary key auto_increment,
NomeLivro varchar(50),
ImagemLivro varchar(225)
);

create table tbEmpretimo(
CodEmp int primary key auto_increment,
dataEmp varchar (20),
dataDev varchar (20),
codUSu int references tbUsuario(codUsu)
);

create table tbintensEmp(
codItem int primary key auto_increment,
codEmp int references tbEmprestimo(codEmp),
codLivro int references tbLivro(codLivro)
);

select * from tbintensEmp;

insert into tbUsuario values (default, 'Bia'),(default,'Garcia');
