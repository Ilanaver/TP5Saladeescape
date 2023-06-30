namespace TP5Saladeescape.Models;
static public class Escape
{
    private static string[] incognitasSalas = new string[] {"Denver Nuggets","Harden","James","Moreno"};
    private static  int estadoJuego = 1;

    private static void InicializarJuego()
    {
        estadoJuego = 1;
    }
    public static int GetEstadoJuego()
    {
        return estadoJuego;
    }
    public static bool ResolverSala(int Sala, string Incognita)
    {
        
        if (Sala != estadoJuego){
            return false;
        }
        if (Incognita == incognitasSalas[Sala-1])
        {
            Sala++;
            estadoJuego++;
            return true;
        }
        return false;
    }
}
