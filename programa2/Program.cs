using System;
using System.Text.RegularExpressions;

namespace programa2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i == 0){
                Console.Write("Ingresar número a verificar: \n");
                string input = Console.ReadLine();
                Console.Write("Ingresar número decimales a verificar: \n");
                string decimales = Console.ReadLine();

                string pattern = @"(-)?\d.\d";
                Regex rgx = new Regex(pattern);
                
                Console.WriteLine(rgx.IsMatch(input));
                Console.WriteLine("Desea seguir verificando direcciones? 0: Sí    1: No");
                i = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
