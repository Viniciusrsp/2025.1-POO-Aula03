using Aula_03;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Televisao tvSala = new Televisao(55);
Console.WriteLine($"O tamnho da tv é: {tvSala.Tamanho}");

Console.WriteLine($"O volume da tv é: {tvSala.Volume}");
tvSala.AumentarVolume();
Console.WriteLine($"O volume da tv é: {tvSala.Volume}");

//Modo mudo
tvSala.AlterarModoMudo();
//Aumentar 1 no volume
tvSala.AumentarVolume();
//Mostra se almentou o volume
Console.WriteLine($"O volume da tv é: {tvSala.Volume}");