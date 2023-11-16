/* There are at least seven logic errors in this code and many bad design choices. 
    Feel free to comment or directly edit your changes but do not merge your branch with main! */ 

using System;

// Calculator, CalculatorLogic, CalculatorUtility should be one class to increase cohesion.
class Calculator
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator");

        try
        {
            Console.Write("Enter the first number: ");
            int num1 = Console.ReadLine(); // Won't compile

            Console.Write("Enter the second number: ");
            int num2 = Console.ReadLine(); //

            Console.WriteLine("Select operation (+, -, *, /): ");
            char operation = Console.ReadLine()[0]; // Won't compile

            CalculatorLogic calculatorLogic = new CalculatorLogic();
            // No constructor for calculatorLogic

            int result = calculatorLogic.PerformCalculation(num1, num2); // perform calculation is non-static, won't compile

            Console.WriteLine($"Result: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}"); // 
        }
    }
}

class CalculatorLogic
{
    // Could make use of polymorphism
    public int PerformCalculation(int num1, int num2, char operation)
    {
        int result = 0;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                // *
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero");
                    // Could throw exceptions instead
                }
                break;
            default:
                // * 
                Console.WriteLine("Error: Invalid operation selected.");
                //
                break;
        }

        return result;
    }
}

class CalculatorUtility
{
    // * 
    public string ConvertToBinary(int decimalNumber)
    {
        return Convert.ToString(decimalNumber, 10);
    }
}
