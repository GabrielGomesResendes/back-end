Console.WriteLine("Numero da placa");
string placa = Console.ReadLine();
string placaFinal = placa.Substring(6);
Console.WriteLine(placaFinal);

if(placaFinal == "1" || placaFinal == "2"){
    Console.WriteLine("segunda");
}
if(placaFinal == "3" || placaFinal == "4"){
    Console.WriteLine("terça");
}
if(placaFinal == "5" || placaFinal == "6"){
    Console.WriteLine("quarta");
}
if(placaFinal == "7" || placaFinal == "8"){
    Console.WriteLine("quinta");
}
if(placaFinal == "9" || placaFinal == "0"){
    Console.WriteLine("sexta");
}
