using EuSouGroot;
Console.WriteLine("Chat com seu amigo Groot");
Console.WriteLine("Diga algo para ele (ou 'tchau' para sair):");

string fala;

do
{
    fala = Console.ReadLine(); 
    if (fala.ToLower() != "tchau") 
    {
        Console.WriteLine(FraseGroot.GerarFrase());
    }
} while (fala.ToLower() != "tchau");

Console.WriteLine("Você se despediu de Groot 😢");