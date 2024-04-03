using System;
using System.Text.RegularExpressions;

namespace ValidaçãoPlaca
{
    class Program
    {
        static void Main(string[] args)
        {
           string placa = "ABC-1234"; // Placa a ser validada

            // Expressão regular para validar o formato da placa (três letras seguidas de quatro números)
           // string pattern = @"^[A-Z]{3}\d{4}$";
            string pattern = @"^[a-z]{3}[a-zA-Z0-9]{4}$";

            //string pattern = Regex.Replace(@"[^a-zA-Z0-9]".ToString())

            // Verifica se a placa corresponde ao padrão
            //var placa = Console.ReadLine();
            // bool isValidPlaca = Regex.IsMatch(placa, pattern);

            //Console.WriteLine(placa.Insert(3, "-").ToUpper());

            if (Regex.IsMatch(pattern, @"^[a-z]{3}[a-zA-Z0-9]{4}$", RegexOptions.IgnoreCase))
            {
                Console.ReadLine();
                Console.WriteLine(placa.Insert(3, "-").ToUpper());
            }
            else
            {
                Console.WriteLine("Placa inválida!");
            }
        }
    }
}
