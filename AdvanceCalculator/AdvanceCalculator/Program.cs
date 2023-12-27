using System;

class Kalkulator
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Advance calkulator");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exponentiation");
            Console.WriteLine("6. Root");
            Console.WriteLine("7. Logarithm");
            Console.WriteLine("8. Exit");
             
            Console.Write("Select an operation (1-8): ");
            int wybor = Convert.ToInt32(Console.ReadLine());

            double liczba1;
            double liczba2;
            double wynik = 0;


            if (wybor == 5)
            {
                Console.Write("Give the base of the power: ");
                liczba1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the exponent of the power: ");
                liczba2 = Convert.ToDouble(Console.ReadLine());
            }
            else if (wybor == 6)
            {
                Console.Write("Enter the number under the square root: ");
                liczba1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the degree of the element: ");
                liczba2 = Convert.ToDouble(Console.ReadLine());
            }
            else if (wybor == 7)
            {
                Console.Write("Enter the base of the logarithm: ");
                liczba1 = Convert.ToDouble(Console.ReadLine());

                
                Console.Write("Enter the logarithmic number: ");
                liczba2 = Convert.ToDouble(Console.ReadLine());
            }
            else if (wybor == 8)
            {
                Console.WriteLine("End.");
                break;
            }
            else
            {
                Console.Write("Enter the first number: ");
                liczba1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second numberę: ");
                liczba2 = Convert.ToDouble(Console.ReadLine());
            }
            
            

           

            switch (wybor)
            {
                case 1:
                    wynik = Dodawanie(liczba1, liczba2);
                    break;
                case 2:
                    wynik = Odejmowanie(liczba1, liczba2);
                    break;
                case 3:
                    wynik = Mnozenie(liczba1, liczba2);
                    break;
                case 4:
                    wynik = Dzielenie(liczba1, liczba2);
                    break;
                case 5:
                    wynik = Potega(liczba1, liczba2);
                    break;
                case 6:
                    wynik = Pierwiastek(liczba1, liczba2);
                    break;
                case 7:
                    wynik = Log(liczba1, liczba2);
                    break;
                default:
                    Console.WriteLine("Incorrect operation selection.");
                    break;
            }

            Console.WriteLine("Result: " + wynik);
            Console.WriteLine();
        }
    }

    static double Dodawanie(double a, double b)
    {
        return a + b;
    }

    static double Odejmowanie(double a, double b)
    {
        return a - b;
    }

    static double Mnozenie(double a, double b)
    {
        return a * b;
    }

    static double Dzielenie(double a, double b)
    {
        if (b != 0)
            return a / b;
        else
        {
            Console.WriteLine("You cannot divide by zero.");
            return 0;
        }
    }

    static double Potega(double a, double b)
    {
        return Math.Pow(a,b);
    }

    static double Pierwiastek(double a, double b)
    {
        double wynik2 = Math.Pow(a, 1 / b);
        return wynik2;
    }
    
    static double Log(double a, double b)
    {
        
        return Math.Log(b, a);
    }

}