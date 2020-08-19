using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator1
    {


        /*add numbers*/
        public int Add(int number1 ,int number2)
        {
            if (number1 < 0 && number2 > 0 && number1 < number2)
            {
                return (number2 + number1);
            }
            else if (number1 < 0 & number2 > 0 && number1 > number2)
            {
                return (number1 + number2);
            }
            else if (number1 > 0 && number2 < 0 && number1 > number2)
            {
                return (number1 + number2);
            }
            else if (number1 > 0 && number2 < 0 && number1 < number2)
            {
                return (number1 - number2);
            }
            
            else
            {
                return (number1 + number2);
            }
        }
       

        /*multiply numbers */
       public int Mult(int number1, int number2)
        {

            return (number1 * number2); 

        }
        /*subtracts numbers*/
        public int Sub(int number1, int number2)
        {
            if (number1 > 0 && number2 < 0 && number1 < number2)
            {
                return (number1 + number2);
            }
            else if (number1 < 0 && number2 > 0 && number1 < number2)
            {
                return (number1 - number2);

            }
            else if (number1 < 0 && number2 < 0 && number1 > number2)
            {
                return (number1 - number2);
            }
            else if (number1 < 0 && number2 < 0 && number1 < number2)
            {
                return (number1-number2);
            }
            else
            {
                return (number1 - number2);
            }
         }
        /*Divide numbers*/
        public float Div(float number1,float number2)
        {
            return (number1 / number2);

        }

        /*Square*/
        public int Sq(int number)
        {
            return (number * number);
        }
    }
   class Program
    {
        static void Main(string[] args)
        {
            Calculator1 x = new Calculator1();

            int i=1 ;

            do
            {

                int number1 = Convert.ToInt32(Console.ReadLine());
                string calculate = Console.ReadLine();
                

                if (calculate == "^")
                    Console.WriteLine(x.Sq(number1));

                else
                {
                    
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    
                    if (calculate == "+")
                        Console.WriteLine(x.Add(number1, number2));
                    else if (calculate == "*")
                        Console.WriteLine(x.Mult(number1, number2));
                    else if (calculate == "-")
                        Console.WriteLine(x.Sub(number1, number2));
                    else if (calculate == "/")
                        Console.WriteLine(x.Div(number1, number2));

                }

                i++;

            }
            while (i < 50);

            Console.ReadKey();
            
        }
    }
}
