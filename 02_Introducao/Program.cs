//apenas declarei uma variavel do tipo inteira e sem valor
//int num1;
// declarando uma variavel do tipo inteiro e atribuindo valor 5
//int num2 + 5;
// declarando variavel string
//string nomeAluno = "Paulo";
// variavel do tipo logico (true ou false)
//bool resultado = true;
// variavel do tipo double valor com varias casas decimais 
//double coordenada = 1.803645628;
// variavel do tipo decimal - utilizada para valores
//decimal valor = 1.80m;
int idade = 16;
string meuNome = "Gabriel";

Console.WriteLine($"meu nome é {meuNome} e tenho {idade} anos");
Console.WriteLine("");
Console.WriteLine("em qual cidade voce nasceu?");
string nomeCidade = Console.ReadLine();
Console.WriteLine($"voce nasceu em {nomeCidade}");