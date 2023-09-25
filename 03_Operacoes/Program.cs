Console.WriteLine("digite o valor de x");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("digite o valor de y");
int y = int.Parse(Console.ReadLine());
// Exenplos de operadores aritméticos
int soma = x + y;
int subtracao = x - y;
int multiplicacao = x * y;
int divisao = x / y;
int resto = x % y;
int restoDiv = x % 2;
int restodivv = y % 2;


// Console para exibir na tela as variaveis em cada linha 
//Soma: 15
Console.WriteLine($"soma:{soma}");
//Subtracao:15
Console.WriteLine($"subtracao:{subtracao}");
//Multiplicacao:15
Console.WriteLine($"multiplicacao:{multiplicacao}");
//Divisao:15
Console.WriteLine($"divisao:{divisao}");
//Resto:15
Console.WriteLine($"resto:{resto}");

if(restoDiv == 0)
{
    Console.WriteLine($"o numero {x} é par");
}
else
{
    Console.WriteLine($"o numero {x} é impar");
}
if(restodivv == 0)
{
    Console.WriteLine($"o numero {y} é par");
}
else
{
    Console.WriteLine($"o numero {y} é impar");
}

//Operador ternario
//condicao ? se verdade : senao
string resultado = (restodivv == 0) ? $"o numero {y} é par" : $"o numero {y} é impar";
 Console.WriteLine(resultado);

 int diaSemana = 3;
 //Aprendendo o Switch case 
 switch (diaSemana)
 {
    case 1:
         Console.WriteLine("hoje é domingo!");
         break;
    case 2:
        Console.WriteLine("hoje é segunda!");
        break;
    case 3:
        Console.WriteLine("hoje é terça!");
        break;
    case 4:
        Console.WriteLine("hoje é quarta!");
        break;
    case 5:
        Console.WriteLine("hoje é quinta!");
        break;
    case 6:
        Console.WriteLine("hoje é sexta!");
        break;
    case 7:
        Console.WriteLine("hoje é sabado!");
        break;
    default:
        Console.WriteLine("dia ivalido");
        break;

 }