using System;
using Week10.GenericInterface;

public class GenericCalculator<T> : ICalculator<T>, MyInterface
{
    public T Add(T num1, T num2)
    {
        dynamic operand1 = num1;
        dynamic operand2 = num2;
        return operand1 + operand2;
    }

    public void PrintMe(T num1)
    {
        dynamic variable = num1;
        int x = (int)variable * 1;
        Console.WriteLine(x);
    }

    public T Subtract(T num1, T num2)
    {
        dynamic operand1 = num1;
        dynamic operand2 = num2;
        return operand1 - operand2;
    }

    public T Multiply(T num1, T num2)
    {
        dynamic operand1 = num1;
        dynamic operand2 = num2;
        return operand1 * operand2;
    }

    public T Divide(T num1, T num2)
    {
        dynamic operand1 = num1;
        dynamic operand2 = num2;

        if (operand2 == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        return operand1 / operand2;
    }
}
