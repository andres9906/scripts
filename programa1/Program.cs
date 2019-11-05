using System;
using System.Text.RegularExpressions;

namespace scripts
{
    class Program
    {
        static void Main(string[] args)
        {
            //string pattern ="[A-Z]:\\((\w|\W)[^\\]+(\S((\w|\W)[^\\])+)*\\)*"
            int i = 0;
            while(i == 0){
                string pattern = @"(-)?\d.\d";
                Regex rgx = new Regex(pattern);

                Console.Write("Ingresar dirección: \n");
                string input = Console.ReadLine();
                Console.WriteLine(rgx.IsMatch(input));
                Console.WriteLine("Desea seguir verificando direcciones? 0: Sí    1: No");
                
                i = Convert.ToInt32(Console.ReadLine());
            }
            
            //string input;
            //Console.Write("Ingresar número decimal");
            //input = Console.ReadLine();
            //Console.WriteLine(input);
        }
    }
}
