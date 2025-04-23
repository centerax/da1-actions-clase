namespace Dominio;

public class Calculadora
{
    //para evitar "magic numbers"
    private const int ValorPorDefecto = 0;
    private const int CadenaConValorUnico = 1;
    
    public int Sumar(string unaCadena)
    {
        if (EsSoloUnNumero(unaCadena))
        {
            return ConvertirStringAInt(unaCadena);
        }
        
        return ValorPorDefecto;
    }

    private static int ConvertirStringAInt(string unaCadena)
    {
        return int.Parse(unaCadena);
    }

    private static bool EsSoloUnNumero(string unaCadena)
    {
        return unaCadena.Length == CadenaConValorUnico;
    }
}