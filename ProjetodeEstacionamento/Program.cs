using DesafioFundamentos.Models;

Estacionamento es = new Estacionamento();
bool exibirMenu = true;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Registrar entrada");
    Console.WriteLine("2 - Registrar saída");
    Console.WriteLine("3 - Listar veículos estacionados");
    Console.WriteLine("4 - Ajustar preço por hora");
    Console.WriteLine("5 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            es.AjustarPreco();
            break;

        case "5":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadKey();
}

Console.WriteLine("O programa se encerrou");
