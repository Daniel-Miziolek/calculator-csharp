using System;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main(string[] args)
    {
        string operation = Console.ReadLine();
        Interpret(operation);

    }

    static void Interpret(string operation)
    {
        

        List<string> lines = new List<string>(operation.Split('\n'));



        foreach (string line in lines)
        {

            List<string> tokens = new List<string>(line.Split(' '));

            double a;
            double b;

            if (tokens[0] == "pi")
            {
                tokens[0] = "3,14";
            }            
            if (tokens[1] == "pi")
            {
                tokens[1] = "3,14";
            }
            if (tokens[2] == "pi")
            {
                tokens[2] = "3,14";
            }



            if (tokens[1] == "+")
            {
                a = double.Parse(tokens[0]);
                b = double.Parse(tokens[2]);
                double result = a + b;
                Console.WriteLine(">> " + result);
            }
            else if (tokens[1] == "-")
            {
                a = double.Parse(tokens[0]);
                b = double.Parse(tokens[2]);
                double result = a - b;
                Console.WriteLine(">> " + result);
            }
            else if (tokens[1] == "*")
            {
                a = double.Parse(tokens[0]);
                b = double.Parse(tokens[2]);
                double result = a * b;
                Console.WriteLine(">> " + result);
            }
            else if (tokens[1] == "/")
            {
                a = double.Parse(tokens[0]);
                b = double.Parse(tokens[2]);
                double result = a / b;
                Console.WriteLine(">> " + result);
            }
            else if (tokens[1] == "^")
            {
                a = double.Parse(tokens[0]);
                b = double.Parse(tokens[2]);
                
                double result = (double)Math.Pow(a, b);

                Console.WriteLine(">> " + result);
            }
            else if (tokens[1] == "root")
            {
                a = double.Parse(tokens[0]);
                b = double.Parse(tokens[2]);
                double result = Math.Pow(a, 1.0 / b);
                Console.WriteLine(">> " + result);

            }
            else if (tokens[0] == "|" && tokens[2] == "|")
            {
                a = double.Parse(tokens[1]);
                double result = (double)Math.Abs(a);
                Console.WriteLine(">> " + result);
            }
            else if (tokens[0] == "log_10")
            {
                a = double.Parse(tokens[1]);
                double result = (double)Math.Log10(a);
                Console.WriteLine(">> " + result);
            }
            else if (tokens[0] == "log_2")
            {
                a = double.Parse(tokens[1]);
                double result = (double)Math.Log2(a);
                Console.WriteLine(">> " + result);
            }

        }
    }

    


}