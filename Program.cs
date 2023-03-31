// See https://aka.ms/new-console-template for more information
Console.WriteLine("---Imitando a Dory---");

Console.Write("Escreva uma Frase: ");
string frase = Console.ReadLine()!;

string baleies = frase 
.Replace("a", "aaa")
.Replace("A", "AAA")
.Replace("e", "eee")
.Replace("E", "EEE")
.Replace("i", "iii")
.Replace("I", "III")
.Replace("o", "ooo")
.Replace("O", "OOO")
.Replace("u", "uuu")
.Replace("U", "UUU");

Console.WriteLine($"\nEm baleies: {baleies}");