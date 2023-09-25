
class Animal 
{
    public string cor { get; set; }

    public void EmitirSom()
    {
        Console.WriteLine("Animal emitindo som");
    }
}

class Cachorro : Animal
{

}

class Gato : Animal
{
    
}

class Program
{
    static void Main()
    {
        Animal animalGenerico = new Animal();
        animalGenerico.EmitirSom();
        Cachorro meuCachorro = new Cachorro();
        meuCachorro.cor = "caramelo";
        meuCachorro.EmitirSom();
    }
}
