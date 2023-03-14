using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char leftParenthesis = '(';
            char rightBracket = ')';
            int maxAllowedDepthOfBrackets = 3;
            bool stringlsCorrect = true;
            string text;

            Console.WriteLine(" Введите строку для проверки ");
            text= Console.ReadLine();

            int[] bracketsPosition = new int[text.Length];
            int bracketsPositionsCounter = -1;

            for ( int i = 0; i<text.Length && stringlsCorrect; i++ )
            {
                if (text[i] == leftParenthesis)
                {
                    bracketsPositionsCounter++;
                    bracketsPosition[bracketsPositionsCounter] = i;
                }
               
                if (bracketsPositionsCounter == maxAllowedDepthOfBrackets) 
                {
                    Console.WriteLine(" Строка неккоретна, глубина больше заданной ");
                    stringlsCorrect= false;
                }

                if (text[i] == rightBracket)
                {
                   
                    if (bracketsPositionsCounter < 0)
                    {
                        Console.WriteLine(" Строка неккоретна, последовательность скобок нарушена ");
                        stringlsCorrect = false;
                    }
                    else
                    {
                        bracketsPositionsCounter--;
                    }
                }

                if ( bracketsPositionsCounter > 0 )
                {
                    stringlsCorrect = false;
                }

                if ( stringlsCorrect ) 
                {
                    Console.WriteLine(" Строка корректна ");
                }
                else
                {
                    Console.WriteLine(" Строка неккоретна ");
                }

                Console.WriteLine(" Строка " + text);
            }
        }
    }
}
