using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace romanos
{
    class Program
    {
        static void Main(string[] args)
        {
            char decidir = 'S';
            while (decidir == 'S' || decidir == 's')
            {
                Console.Clear();
                Console.WriteLine("Digite o primeiro valor");
                romanos MMMCMXCIX = new romanos(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor");
                romanos CM = new romanos(Console.ReadLine());
                Console.WriteLine("digite o operador que deseja fazer");
                char op = char.Parse(Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case '+':
                        Console.Write(MMMCMXCIX.ToString() + " + " + CM.ToString() + " = ");
                        Console.Write(MMMCMXCIX + CM);
                        break;
                    case '*':
                        Console.Write(MMMCMXCIX.ToString() + " * " + CM.ToString() + " = ");
                        Console.Write(MMMCMXCIX * CM);
                        break;
                    case '/':
                        Console.Write(MMMCMXCIX.ToString() + " / " + CM.ToString() + " = ");
                        Console.Write(MMMCMXCIX / CM);
                        break;
                    case '-':
                        Console.Write(MMMCMXCIX.ToString() + " - " + CM.ToString() + " = ");
                        Console.Write(MMMCMXCIX - CM);
                        break;
                    default:
                        Console.WriteLine("operação invalida");
                        break;
                }
                
                Console.WriteLine("\ndigite <S> para mais operações ou <N> para encerrar aplicativo!!!");
                decidir = char.Parse(Console.ReadLine());
            }
            
        }
    }
}