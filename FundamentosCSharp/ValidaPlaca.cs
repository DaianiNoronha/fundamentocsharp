using System.Text.RegularExpressions;

namespace FundamentosCSharp;
public class ValidaPlaca
{
    public bool IsPlaca(string placa)
    {
        // Expressão regular para verificar o padrão da placa
        string padrao = @"^[a-zA-Z]{3}[0-9]{4}$";
        return Regex.IsMatch(placa, padrao);

    }
}
