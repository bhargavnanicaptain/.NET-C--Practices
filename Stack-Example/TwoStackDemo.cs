using System;
using System.Collections.Generic;
class TwoStackDemo
{
    static void Main()
    {
        Stack<int> resultStack = new Stack<int>();
        Stack<string> expressionStack = new Stack<string>();
        while (true)
        {
            Console.Write("Enter Expression (or) type 'undo' ");
            string input = Console.ReadLine();
            if (input.ToLower() == "undo")
            {
                if (resultStack.Count > 0 && expressionStack.Count > 0)
                {
                    Console.WriteLine($"Undo: Removed '{expressionStack.Pop()}' with result {resultStack.Pop()}");
                }
                else
                {
                    Console.WriteLine("Nothing to Undo");
                }
                continue;
            }
            string[] parts = input.Split(' ');
            if (parts.Length == 3)
            {
                int num1 = int.Parse(parts[0]);
                string op = parts[1];
                int num2 = int.Parse(parts[2]);
                int result = 0;
                switch (op)
                {
                    case "+": result = num1 + num2; break;
                    case "-": result = num1 - num2; break;
                    case "*": result = num1 * num2; break;
                    case "/": result = num2 != 0 ? num1 / num2 : 0; break;
                    default: Console.WriteLine("Invalid Operator"); continue;
                }
                resultStack.Push(result);
                expressionStack.Push(input);
                Console.WriteLine($"Result: {result}");
            }
            else
            {
                Console.WriteLine("Please enter a valid expression like '5 + 3'");
            }
        }
    }
}