namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\tДобро пожаловать в Калькулятор");
            Console.WriteLine("\nВ этом калькуляторе есть такие команды: " +
                "\nСложение(+)" +
                "\nВычитание(-)" +
                "\nУмножение(*)" +
                "\nДеление(/)" +
                "\nВозведение в степень(^)" +
                "\nСравнить два числа(<>)" +
                "\nЧтобы выйти из программы(N)");
                
            Console.WriteLine("\nВведите команду из скобочек");
            string exit = Console.ReadLine();

            while (exit != "N") 
            {
    
                switch (exit) 
                {
                    case "+":
                        Console.WriteLine("Введите две переменных:");
                        Console.Write("-> a = ");
                        string first = Console.ReadLine();
                        Console.Write("-> b = ");
                        string two = Console.ReadLine();

                        if (CheckingValues(first, two) == true)
                        {
                            double a = Convert.ToDouble(first);
                            double b = Convert.ToDouble(two);
                            if (b < 0)
                            {
                                Console.WriteLine($"Результат: {a} + ({b}) = {Addition(a, b)}");
                            }
                            else 
                            {
                                Console.WriteLine($"Результат: {a} + {b} = {Addition(a, b)}");
                            }
                                
                        }
                        else 
                        {
                            Console.WriteLine("Ошибка: Неправильный тип данных!");
                        }

                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("\nСложение(+)" + 
                                          "\nВычитание(-)" + 
                                          "\nУмножение(*)" + 
                                          "\nДеление(/)" + 
                                          "\nВозведение в степень(^)" + 
                                          "\nСравнить два числа(<>)" +
                                          "\nЧтобы выйти из программы(N)");

                        Console.WriteLine("\nВведите команду из скобочек");
                        exit = Console.ReadLine();

                        break;
                    case "-":
                        Console.WriteLine("Введите две переменных:");
                        Console.Write("-> a = ");
                        first = Console.ReadLine();
                        Console.Write("-> b = ");
                        two = Console.ReadLine();

                        if (CheckingValues(first, two) == true)
                        {
                            double a = Convert.ToDouble(first);
                            double b = Convert.ToDouble(two);
                            if (b < 0)
                            {
                                Console.WriteLine($"Результат: {a} - ({b}) = {Subtraction(a, b)}");
                            }
                            else
                            {
                                Console.WriteLine($"Результат: {a} - {b} = {Subtraction(a, b)}");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Ошибка: Неправильный тип данных!");
                        }

                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("\nСложение(+)" +
                                          "\nВычитание(-)" +
                                          "\nУмножение(*)" +
                                          "\nДеление(/)" +
                                          "\nВозведение в степень(^)" +
                                          "\nСравнить два числа(<>)" +
                                          "\nЧтобы выйти из программы(N)");
                        Console.WriteLine("\nВведите команду из скобочек");
                        exit = Console.ReadLine();

                        break;
                    case "*":
                        Console.WriteLine("Введите две переменных:");
                        Console.Write("-> a = ");
                        first = Console.ReadLine();
                        Console.Write("-> b = ");
                        two = Console.ReadLine();

                        if (CheckingValues(first, two) == true)
                        {
                            double a = Convert.ToDouble(first);
                            double b = Convert.ToDouble(two);
                            if (b < 0)
                            {
                                Console.WriteLine($"Результат: {a} * ({b}) = {Math.Round(Multiplication(a, b), 3)}");
                            }
                            else
                            {
                                Console.WriteLine($"Результат: {a} * {b} = {Math.Round(Multiplication(a, b), 3)}");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Ошибка: Неправильный тип данных!");
                        }

                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("\nСложение(+)" +
                                          "\nВычитание(-)" +
                                          "\nУмножение(*)" +
                                          "\nДеление(/)" +
                                          "\nВозведение в степень(^)" +
                                          "\nСравнить два числа(<>)" +
                                          "\nЧтобы выйти из программы(N)");
                        Console.WriteLine("\nВведите команду из скобочек");
                        exit = Console.ReadLine();

                        break;
                    case "/":
                        Console.WriteLine("Введите две переменных:");
                        Console.Write("-> a = ");
                        first = Console.ReadLine();
                        Console.Write("-> b = ");
                        two = Console.ReadLine();

                        if (CheckingValues(first, two) == true)
                        {
                            double a = Convert.ToDouble(first);
                            double b = Convert.ToDouble(two);
                            if (b == 0) 
                            {
                                Console.WriteLine("Ошибка: На ноль делить нельзя!");
                            }
                            else if (b < 0)
                            {
                                Console.WriteLine($"Результат: {a} / ({b}) = {Math.Round(Divide(a, b), 3)}");
                            }
                            else
                            {
                                Console.WriteLine($"Результат: {a} / {b} = {Math.Round(Divide(a, b), 3)}");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Ошибка: Неправильный тип данных!");
                        }

                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("\nСложение(+)" +
                                          "\nВычитание(-)" +
                                          "\nУмножение(*)" +
                                          "\nДеление(/)" +
                                          "\nВозведение в степень(^)" +
                                          "\nСравнить два числа(<>)" +
                                          "\nЧтобы выйти из программы(N)");
                        Console.WriteLine("\nВведите команду из скобочек");
                        exit = Console.ReadLine();

                        break;
                    case "^":
                        Console.WriteLine("Введите две переменных:");
                        Console.WriteLine("a - основание степени;\nb - показатель степени");

                        Console.Write("-> a = ");
                        first = Console.ReadLine();
                        Console.Write("-> b = ");
                        two = Console.ReadLine();

                        if (CheckingValues(first, two) == true)
                        {
                            double a = Convert.ToDouble(first);
                            double b = Convert.ToDouble(two);
                            
                            if (b < 0)
                            {
                                Console.WriteLine($"Результат: {a} ^ ({b}) = {Math.Round(Exponentiation(a, b), 3)}");
                            }
                            else
                            {
                                Console.WriteLine($"Результат: {a} ^ {b} = {Math.Round(Exponentiation(a, b), 3)}");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Ошибка: Неправильный тип данных!");
                        }

                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("\nСложение(+)" +
                                          "\nВычитание(-)" +
                                          "\nУмножение(*)" +
                                          "\nДеление(/)" +
                                          "\nВозведение в степень(^)" +
                                          "\nСравнить два числа(<>)" +
                                          "\nЧтобы выйти из программы(N)");
                        Console.WriteLine("\nВведите команду из скобочек");
                        exit = Console.ReadLine();

                        break;
                    case "<>":
                        Console.WriteLine("Введите три переменных:");
                        Console.WriteLine("a - первое число;\nb - второе число;\nc - знак равенства");
                        Console.WriteLine("\tЗнаки равенства\n\t a больше b (>)" + "\n\t a меньше b (<)" + "\n\t a равно b (=)");
                        
                        Console.Write("-> a = ");
                        first = Console.ReadLine();
                        Console.Write("-> b = ");
                        two = Console.ReadLine();
                        Console.Write("-> c = ");
                        string three = Console.ReadLine();

                        if (CheckingValues(first, two) == true)
                        {
                            double a = Convert.ToDouble(first);
                            double b = Convert.ToDouble(two);
                            string c = three;

                            Console.WriteLine($"Результат: {a} {c} {b} = {Comparison(a, b, c)}");

                        }
                        else 
                        {
                            Console.WriteLine("Ошибка: Неправильный тип данных!");
                        }

                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("\nСложение(+)" +
                                          "\nВычитание(-)" +
                                          "\nУмножение(*)" +
                                          "\nДеление(/)" +
                                          "\nВозведение в степень(^)" +
                                          "\nСравнить два числа(<>)" +
                                          "\nЧтобы выйти из программы(N)");
                        Console.WriteLine("\nВведите команду из скобочек");
                        exit = Console.ReadLine();

                        break;
                    default:
                        Console.WriteLine("Ошибка: Несуществующая команда");
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("\nСложение(+)" +
                                          "\nВычитание(-)" +
                                          "\nУмножение(*)" +
                                          "\nДеление(/)" +
                                          "\nВозведение в степень(^)" +
                                          "\nСравнить два числа(<>)" +
                                          "\nЧтобы выйти из программы(N)");
                        Console.WriteLine("\nВведите команду из скобочек");
                        exit = Console.ReadLine();
                        break;
                }
            }
        }

        static bool CheckingValues(string first, string two) 
        {
            bool flag = false;

            double a;
            bool success_a = double.TryParse(first, out a);

            double b;
            bool success_b = double.TryParse(two, out b);

            if (success_a == true && success_b == true) 
            {
                flag = true;
            }

            return flag;
        }


        static double Addition(double a, double b)
        {
            return a + b;
        }

        static double Subtraction(double a, double b) 
        {
            return a - b;
        }

        static double Multiplication(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            return a / b;
            
        }

        static double Exponentiation(double a, double b)
        {
             
            return Math.Pow(a, b);
            
        }

        static string Comparison(double a, double b, string c) 
        {
            string fl = "Ложь";
            if (c == ">")
            {
                if (a > b)
                {
                    fl = "Истина";
                }
                else
                {
                    fl = "Ложь";
                }
            }
            else if (c == "<")
            {
                if (a < b)
                {
                    fl = "Истина";
                }
                else
                {
                    fl = "Ложь";
                }
            }
            else if (c == "=")
            {
                if (a == b)
                {
                    fl = "Истина";
                }
                else
                {
                    fl = "Ложь";
                }
            }
            else 
            {
                fl = "Ошибка: неcуществует такого знака равенства";
            }
            return fl;
        }
    }
}
