namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which operation do you want to do?");
            Console.Write("1=Add " + "2=Extract " + "3=Multiply " + "4=Divide " + "5=Power ");
            string operation = Console.ReadLine();
            int realOperation = Convert.ToInt32(operation);

            string firstNumber = "";
            string secondNumber = "";

            Console.Write("Enter your first number: ");
            firstNumber = Console.ReadLine();
            
            Console.Write("Enter your second number: ");
            secondNumber = Console.ReadLine();

            int intFirstNumber = Convert.ToInt32(firstNumber);
            int intSecondNumber = Convert.ToInt32(secondNumber);

            double realFirstNumber = Convert.ToDouble(firstNumber);
            double realSecondNumber = Convert.ToDouble(secondNumber);

            if (realOperation == 1)
            {
                Console.WriteLine(realFirstNumber + realSecondNumber);
            }
            else if (realOperation == 2)
            {
                Console.WriteLine(realFirstNumber - realSecondNumber);
            }
            else if (realOperation == 3)
            {
                Console.WriteLine(realFirstNumber * realSecondNumber);
            }
            else if (realOperation == 4)
            {
                Console.WriteLine(realFirstNumber / realSecondNumber);
            }
            else if (realOperation == 5)
            {
                Console.WriteLine(Power(intFirstNumber, intSecondNumber));           
            }
            else
            {
                Console.WriteLine("Invalid number! Please restart the program!");
            }

            Console.WriteLine("Thank you for using 'CalculatorOnur'!. You can restart the program for more calculations!");
            Console.ReadLine();
        }

        static int Power(int baseNumber, int powerNumber )
        {
            int result = 1;

            for (int i = 0; i < powerNumber; i++)
                result = result * baseNumber;

            return result;
        }

    }

}