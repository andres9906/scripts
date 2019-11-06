using System;
using System.Text.RegularExpressions;

namespace programa2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sww = 0;
            while(sww == 0){        
                String dir;
                Console.WriteLine("Ingrese la direccion dos");
                dir = Console.ReadLine();
                Char aux = '"';
                  String erDos = @"[A-Z]:\\((\w|\W[^/:*?<>"+Char.ToString(aux)+@"])+(\S(\w|\W[^/:*?<>"+Char.ToString(aux)+@"])+)*\\)*(\w|\W[^/:*?<>"+Char.ToString(aux)+@"\\])+(\S(\w|\W[^\\/:*?<>"+Char.ToString(aux)+@"])+)*(.((\w|\W[^/:*?<>"+Char.ToString(aux)+@"\\]))+)?";
            
                Match match = Regex.Match(dir,erDos);
                if (match.Success)
                {
                if(match.Value.Equals(dir)){

                    Console.WriteLine("Valido");
                }else{
                    Console.WriteLine("No valido");
                }
                }
                else { Console.WriteLine("No valido");
                }
                Console.WriteLine("Desea seguir verificando número decimales? 0: Sí    1: No");
                sww = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
