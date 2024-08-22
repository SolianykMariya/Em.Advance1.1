using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        public static double getText(string text)
        {
                Console.WriteLine(text);
                return Convert.ToDouble(Console.ReadLine());
        }

        public static void showError()
        {
           Console.WriteLine("Помилка!!!");
        }

        public static double Result(double number1, double number2, string operation)
        {
            switch (operation)
            {
                case "+": Console.WriteLine(number1+number2);break;
                case "-": Console.WriteLine(number1 - number2);break;
                case "*": Console.WriteLine(number1* number2);break;    
                case "/": Console.WriteLine(number1 / number2);break;
                case "sqrt": Console.WriteLine(Math.Sqrt(number1));break;
                case "^": Console.WriteLine(Math.Pow(number1,number2));break;

            }
            return number1;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            double num1 = getText("Введіть перше число");

            Console.WriteLine("Оберіть одну з вказаних дій та введіть його знак:\n + для додавання\n- для віднімання\n * для множення\n / для ділення\n sqrt для квадратного кореня\n^ для піднесення в степінь");
            string operation = Console.ReadLine();

            if (operation == "+")
            {
               double num2 = getText("Введіть другий доданок");
                Result(num1, num2, "+");
            }
            else if (operation == "-")
            {
                double num2 = getText("Введіть від'ємник");
                Result(num1, num2, "-");
            }
            else if(operation == "*")
            {
              double num2 = getText("Введіть другий множник");
                Result(num1, num2, "*"); 
            }
            else if (operation == "/")
            {
                double num2 = getText("Введіть дільник");
                if (num2 == 0)
                {
                   showError();
                }
                else
                {
                    Result(num1, num2, "/");
                }
            }
            else if (operation == "sqrt")
            {
                if (num1 < 0)
                {
                    showError();
                }
                else
                {
                    Result(num1, 0, "sqrt");
                }
                
            }
            else if (operation == "^")
            {
               double power = getText("Введіть показник степеня, до якого ви хочете піднести число:");
               if (power < 0)
               {
                    showError();
               }
               else
               {
                    Result(num1, power, "^"); 
               }
            }
        }
    }
}
