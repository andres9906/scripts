using System;
using System.Text.RegularExpressions;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sww = 0;
            while(sww == 0){
                String dec;
                Console.WriteLine("Ingrese el numero de decimales");
                dec = Console.ReadLine();
                Console.WriteLine("Ingrese el numero decimal");
                String num = Console.ReadLine();

                // using the method
                String aux = "";
                for (int i = 0; i < System.Convert.ToInt32(dec); i++)
                {
                    aux = "0" + aux;
                }
                String erDecimales = @"(-)?\d+.(\d{"+dec+"}(?<!" + aux + "))";
                Match match = Regex.Match(num,erDecimales);
                if (match.Success)
                {   
                    if(match.Value.Equals(num)){
                        Console.WriteLine("Valido");
                    }else{
                        Console.WriteLine("No valido");
                    }
                }
                else { 
                    Console.WriteLine("No valido"); 
                }

                Console.WriteLine("Desea seguir verificando número decimales? 0: Sí    1: No");
                sww = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}