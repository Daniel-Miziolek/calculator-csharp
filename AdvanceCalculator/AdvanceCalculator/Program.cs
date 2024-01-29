using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter an expression:");
            string operation = Console.ReadLine();
            double result = Interpret(operation);
            Console.WriteLine("Result: " + result);
        }
    }

    static double Interpret(string operation)
    {
        List<string> tokens = Tokenize(operation);
        return Evaluate(tokens);
    }

    static List<string> Tokenize(string operation)
    {
        List<string> tokens = new List<string>();
        string[] operators = { "+", "-", "*", "/", "^", "sqrt", "|", "log_10", "log_2" };

        foreach (char character in operation)
        {
            if (char.IsDigit(character) || character == '.' || character == ',')
            {
                if (tokens.Count == 0 || !char.IsDigit(tokens[tokens.Count - 1][0]))
                {
                    tokens.Add(character.ToString());
                }
                else
                {
                    tokens[tokens.Count - 1] += character;
                }
            }
            else if (char.IsLetter(character))
            {
                tokens.Add(character.ToString());
            }
            else if (Array.Exists(operators, op => op.StartsWith(character.ToString())))
            {
                tokens.Add(character.ToString());
            }
            else if (character == '(' || character == ')')
            {
                tokens.Add(character.ToString());
            }
        }

        return tokens;
    }

    static double Evaluate(List<string> tokens)
    {
        int index = 0;
        return ParseExpression(tokens, ref index);
    }

    static double ParseExpression(List<string> tokens, ref int index)
    {
        double left = ParseTerm(tokens, ref index);
        while (index < tokens.Count && (tokens[index] == "+" || tokens[index] == "-"))
        {
            string op = tokens[index++];
            double right = ParseTerm(tokens, ref index);

            if (op == "+")
                left += right;
            else if (op == "-")
                left -= right;
        }
        return left;
    }

    static double ParseTerm(List<string> tokens, ref int index)
    {
        double left = ParseFactor(tokens, ref index);
        while (index < tokens.Count && (tokens[index] == "*" || tokens[index] == "/"))
        {
            string op = tokens[index++];
            double right = ParseFactor(tokens, ref index);

            if (op == "*")
                left *= right;
            else if (op == "/")
                left /= right;
        }
        return left;
    }

    static double ParseFactor(List<string> tokens, ref int index)
    {
        double result = 0.0;

        if (index < tokens.Count)
        {
            string token = tokens[index++];

            if (double.TryParse(token, out result))
            {
                // It's a number
            }
            else if (token == "(")
            {
                result = ParseExpression(tokens, ref index);
                if (index < tokens.Count && tokens[index] == ")")
                {
                    index++; // Consume the closing parenthesis
                }
            }
            else if (token == "pi")
            {
                result = Math.PI;
            }
            else if (token == "|")
            {
                result = Math.Abs(ParseFactor(tokens, ref index));
                if (index < tokens.Count && tokens[index] == "|")
                {
                    index++; // Consume the closing absolute value bars
                }
            }
            else if (token == "log_10")
            {
                double operand = ParseFactor(tokens, ref index);
                result = Math.Log10(operand);
            }
            else if (token == "log_2")
            {
                double operand = ParseFactor(tokens, ref index);
                result = Math.Log2(operand);
            }
        }

        return result;
    }
}
