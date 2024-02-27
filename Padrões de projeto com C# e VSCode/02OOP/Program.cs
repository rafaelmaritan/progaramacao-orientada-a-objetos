// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Retangulo retangulo = new(20, 30); // STRUCTURE ---> Value Type -- Stack

IRepository repositorio =
new RepositorioFuncionarios(new List<Funcionario>());

var programador = new Programador(id: 1, nome: "Rafa",
sobrenome: "Maritan", idade: 30, altura: 1.78, salario: 2000,
tecnologia: "dotNet");
var analista = new Analista(id: 2, nome: "Denise",
sobrenome: "Lopes", idade: 30, altura: 1.78, salario: 2000);

repositorio.Inserir(programador);
repositorio.Inserir(analista);

foreach (var item in repositorio.ListarTodosOsFuncionarios())
{
    Console.WriteLine(item.Nome);
}

repositorio.Remover(analista.Id);
foreach (var item in repositorio.ListarTodosOsFuncionarios())
{
    Console.WriteLine(item.Nome);
}

Console.WriteLine(programador.Trabalhar());

Console.WriteLine(programador.Andar());


Console.WriteLine(analista.Trabalhar());

Console.WriteLine(analista.Andar());