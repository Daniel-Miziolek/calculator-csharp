using System;

class Program
{
    static void Main(string[] args)
    {
        string operation = Console.ReadLine();
        Interpret(operation);
    }

    static void Interpret(string operation)
    {
        string[] lines = operation.Split('\n');

        foreach (string line in lines)
        {
            string[] tokens = line.Split(' ');

            if (tokens[1] == "+")
            {
                double result = Double.Parse(tokens[0]) + Double.Parse(tokens[2]);
                Console.WriteLine(">> " + result);
            }
            else if (tokens[1] == "-")
            {
                double result = Double.Parse(tokens[0]) - Double.Parse(tokens[2]);
                Console.WriteLine(">> " + result);
            }
            else if (tokens[1] == "*")
            {
                double result = Double.Parse(tokens[0]) * Double.Parse(tokens[2]);
                Console.WriteLine(">> " + result);
            }
            else if (tokens[1] == "/")
            {
                double result = Double.Parse(tokens[0]) / Double.Parse(tokens[2]);
                Console.WriteLine(">> " + result);
            }
            else if (tokens[1] == "^")
            {
                double n1 = Double.Parse(tokens[0]);
                double n2 = Double.Parse(tokens[2]);
                double result = (double)Math.Pow(n1, n2);

                Console.WriteLine(">> " + result);
            }
            else if (tokens[1] == "root")
            {
                double n1 = Double.Parse(tokens[0]);
                double n2 = Double.Parse(tokens[2]);
                double result = Math.Pow(n1, 1.0 / n2);
                Console.WriteLine(">> " + result);

            }
            else if (tokens[0] == "|" && tokens[2] == "|")
            {
                double n1 = Double.Parse(tokens[1]);
                double result = (double)Math.Abs(n1);
                Console.WriteLine(">> " + result);
            }        
            else if (tokens[0] == "log_10")
            {
                double n1 = Double.Parse(tokens[1]);
                double result = (double)Math.Log10(n1);
                Console.WriteLine(">> " + result);
            }
            else if (tokens[0] == "log_2")
            {
                double n1 = Double.Parse(tokens[1]);
                double result = (double)Math.Log2(n1);
                Console.WriteLine(">> " + result);
            }
        }
    }


}