namespace FundamentosCSharp;
public class ContadorString
{
    public int ContarCaracteres(string input)
    {
        return input.Count(c => !char.IsWhiteSpace(c));
    }
}
