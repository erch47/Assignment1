namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool calculatorOn = true;
            
            while (calculatorOn)
            {
                Console.Clear();


                PrintMenu();
                int input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Enter first number: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        string add = string.Format("{0} + {1} = {2}", num1, num2, Calc.Addition(num1, num2));
                        Console.WriteLine(add);
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Enter first number: "); ;
                        double num3 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        double num4 = Convert.ToDouble(Console.ReadLine());
                        string subtract = string.Format("{0} - {1} = {2}", num3, num4, Calc.Subtraction(num3, num4));
                        Console.WriteLine(subtract);
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Enter first number: ");
                        double num5 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        double num6 = Convert.ToDouble(Console.ReadLine());
                        string multiply = string.Format("{0} * {1} = {2}", num5, num6, Calc.Multiplication(num5, num6));
                        Console.WriteLine(multiply);
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.Write("Enter first number: ");
                        double num7 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        double num8 = Convert.ToDouble(Console.ReadLine());
                        if (num8 == 0)
                        {
                            Console.WriteLine("Can't divide by zero");
                            Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
                        }
                        else
                        {
                            string divide = string.Format("{0} / {1} = {2}", num7, num8, Calc.Division(num7, num8));
                            Console.WriteLine(divide);
                            Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
                        }
                        
                        break;
                    case 9:
                        calculatorOn = false;
                        break;

                }
            }
        }

        static void PrintMenu()
        {
            string menu = @"-----------------Calculator-----------------
Enter the selection you want to do

Press 1 for addition
Press 2 for subtraction
Press 3 for multiplication
Press 4 for division

Press 9 to exit";
            Console.WriteLine(menu);
        }


        static double UserInput()
        {
            double num = Convert.ToDouble(Console.ReadLine());
            return num;
        }

    }
}