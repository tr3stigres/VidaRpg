class Program
{
    public static void Main()
    {

        VidaRpg personajePrincipal = new VidaRpg("Ada", 100, 25);
        Console.WriteLine(personajePrincipal);
        personajePrincipal.RecibirDanyo(30);
        Console.WriteLine(personajePrincipal);
        personajePrincipal.Curar(200);
        Console.WriteLine(personajePrincipal);
        personajePrincipal.RecibirDanyo(500);
        Console.WriteLine(personajePrincipal);

        VidaRpg personajeSecundario = new VidaRpg("", 0, -1);
        Console.WriteLine(personajeSecundario);
    }
}

