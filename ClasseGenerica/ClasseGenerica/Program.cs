using ClasseGenerica;

int qtdAhoys;

MeuArray<int> arrayDeInteiros = new MeuArray<int>();
MeuArray<string> arrayDeStrings = new MeuArray<string>();

Console.WriteLine("Quantos ahoys deseja?");
qtdAhoys = int.Parse(Console.ReadLine());

arrayDeInteiros.AdicionarElementoArray(qtdAhoys);
arrayDeStrings.AdicionarElementoArray("Ahoy");

Console.WriteLine($"{arrayDeInteiros[0]}" + $" {(arrayDeInteiros[0] > 1 ? arrayDeStrings[0] + "s" : arrayDeStrings[0] )} para ti");