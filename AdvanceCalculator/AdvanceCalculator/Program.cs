using System;

{
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
                    int result = Int32.Parse(tokens[0]) + Int32.Parse(tokens[2]);
                    Console.WriteLine("Result: " + result);
                }
                else if (tokens[1] == "-")
                {
                    int result = Int32.Parse(tokens[0]) - Int32.Parse(tokens[2]);
                    Console.WriteLine("Result: " + result);
                }
                else if (tokens[1] == "*")
                {
                    int result = Int32.Parse(tokens[0]) * Int32.Parse(tokens[2]);
                    Console.WriteLine("Result: " + result);
                }
                else if (tokens[1] == "/")
                {
                    int result = Int32.Parse(tokens[0]) / Int32.Parse(tokens[2]);
                    Console.WriteLine("Result: " + result);
                }
                else if (tokens[1] == "^")
                {
                    int n1 = Int32.Parse(tokens[0]);
                    int n2 = Int32.Parse(tokens[2]);
                    int result = (int)Math.Pow(n1, n2);

                    Console.WriteLine("Result: " + result);
                }
                else if (tokens[1] == "sqrt")
                {
                    int n = Int32.Parse(tokens[0]);
                    int result = sqrt(n);
                    Console.WriteLine("Result: " + result);
                }
                else if (tokens[0] == "|" && tokens[2] == "|")
                {
                    int n1 = Int32.Parse(tokens[1]);                  
                    int result = (int)Math.Abs(n1);
                    Console.WriteLine("Result: " + result);
                }
                // To repair ;)
                //else if (tokens[0] == "log_")
                //{
                //    int n1 = Int32.Parse(tokens[1]);
                //    int n2 = Int32.Parse(tokens[2]);
                //    int result = (int)Math.Log(n1, n2);
                //    Console.WriteLine("Result: " + result);
                //}
                
            }
        }

        static int sqrt(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                int factorial = 1;
                for (int i = 2; i <= n; i++)
                {
                    factorial *= i;
                }
                return factorial;
            }
        }
    }
}
