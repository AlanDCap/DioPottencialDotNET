using DesafioPOO.Models;

Console.WriteLine("Escolha uma marca de aparelho:" +
    "\n 1 - Nokia" +
    "\n 2 - Iphone");
int opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
        Nokia n1 = new Nokia(555123456, "2280", 1234567890, 4);

        n1.Ligar();
        n1.ReceberLigacao();
        n1.InstalarAplicativo("ZapZap");
        break;

    case 2:
        Iphone ip1 = new Iphone(777321654, "Iphone 11", 0987654321, 8);

        ip1.Ligar();
        ip1.ReceberLigacao();
        ip1.InstalarAplicativo("Photoshop Adobe Illustrator top");
        break;

    default:
        Console.WriteLine("Opção inválida");
        break;
}