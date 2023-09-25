
Console.WriteLine("Nome do aluno");
string NomeAluno = Console.ReadLine();

Console.WriteLine($"Digite a nota1");
int notu = int.Parse (Console.ReadLine());
Console.WriteLine($"Digite a nota2");
int notd = int.Parse(Console.ReadLine());
Console.WriteLine($"Digite a nota3");
int nott = int.Parse(Console.ReadLine());

int media = (notu + notd + nott) /3;

string resposta = (media >=7) ? $" a nota é {media}, o aluno {NomeAluno} foi aprovado" : $" a nota é {media}, o aluno {NomeAluno} foi reprovado";
Console.WriteLine(resposta);