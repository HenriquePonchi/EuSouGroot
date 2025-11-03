namespace EuSouGroot;

public static class FraseGroot
{
    private static Random rnd = new Random();

    private static string[] frases =
    {
        "Eu sou Groot.","EU SOU GROOT!!!","Eu SoU GrOoT","Eu sou Groot...","Eu sou Groot ?"
    };
    public static string GerarFrase()
    {
        int indice = rnd.Next(frases.Length);
        return frases[indice];
    }
}
