using System;

namespace Calculadora
{
    public class CalculadoraSolucao
    {
        #region Designer Calculadora
        public static void PrintCalculator(string valorscreen)
        {      
            // for imprime numeros na screen    
            string espacos = "";
            for (int i = 0; i < (25 - valorscreen.Length); i++) espacos += " ";
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("          " + "" + "                 ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write($"{espacos}{valorscreen}");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine(" ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("                           ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");

            // for imprime teclas "7, 8, 9" 
            for (int i = 7; i <= 9; i++)
            {
                ImprimeNumeros(i);
            }
            // imprime tecla  "+"
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" + ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("   ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("                           ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");

            // imprime teclas "4, 5, 6" 
            for (int i = 4; i <= 6; i++)
            {
                ImprimeNumeros(i);
            }

            // imprime tecla  "-"
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" - ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("   ");
            Console.WriteLine("                           ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");

            // imprime teclas  "1, 2, 3" 
            for (int i = 1; i <= 3; i++)
            {
                ImprimeNumeros(i);
            }

            // imprime tecla  "*"
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" * ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("   ");
            Console.WriteLine("                           ");

            // imprime teclas  "0, , , =, /"
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" 0 ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" , ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" = ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" / ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("   ");
            Console.WriteLine("                           ");

            // imprime teclas "X, %, on/off" 
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" X ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" % ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" on /off ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("   ");
            Console.WriteLine("                           ");
            Console.ResetColor();
        }
        #endregion

        #region Imprimir
        // funcao que imprime na screen da calculadora.
        private static void ImprimeNumeros(int numero)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write($" {numero} ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");
        }
        
        public static void Calculator()
        {
            PrintCalculator("0");
            Calculate();
        }
        #endregion 

        #region Logica para efetuar operacoes
        public static void Calculate()
        {
            try
            {
                // Solicita numeros e operadores
                var screen = "";
                Console.WriteLine("Insira um numero");
                var input = Console.ReadLine();
                if (input == "x")
                {
                    System.Environment.Exit(0);
                }
                double num = double.Parse(input);
                screen += $" {num}";
                PrintCalculator(screen);
                Console.WriteLine("Insira um operador ou sinal de = para finlizar( +, -, *, / ou =)");
                string oper = Console.ReadLine();
                screen += $" {oper}";
                PrintCalculator(screen);
                double result = num;

                // Logica para efetuar calculos 
                while (oper != "=")
                {
                    if (oper == "+")
                    {
                        Console.WriteLine("Insira um numero");
                        var num1 = double.Parse(Console.ReadLine());
                        screen += $" {num1}";
                        PrintCalculator(screen);
                        Console.WriteLine("Insira um operador ou sinal de = para finlizar( +, -, *, / ou =)");
                        oper = Console.ReadLine();
                        screen += $" {oper}";
                        PrintCalculator(screen);
                        result += num1;
                    }
                    else if (oper == "-")
                    {
                        Console.WriteLine("Insira um numero");
                        var num1 = double.Parse(Console.ReadLine());
                        screen += $" {num1}";
                        PrintCalculator(screen);
                        Console.WriteLine("Insira um operador ou sinal de = para finlizar( +, -, *, / ou =)");
                        oper = Console.ReadLine(); result -= num1;
                        screen += $" {oper}";
                        PrintCalculator(screen);
                    }
                    else if (oper == "*")
                    {
                        Console.WriteLine("Insira um numero");
                        var num1 = double.Parse(Console.ReadLine());
                        screen += $" {num1}";
                        PrintCalculator(screen);
                        Console.WriteLine("Insira um operador ou sinal de = para finlizar( +, -, *, / ou =)");
                        oper = Console.ReadLine(); result *= num1;
                        screen += $" {oper}";
                        PrintCalculator(screen);
                    }
                    else if (oper == "/")
                    {
                        Console.WriteLine("Insira um numero");
                        var num1 = double.Parse(Console.ReadLine());
                        screen += $" {num1}";
                        PrintCalculator(screen);
                        Console.WriteLine("Insira um operador ou sinal de = para finlizar( +, -, *, / ou =)");
                        oper = Console.ReadLine();
                        result /= num1;
                        screen += $" {oper}";
                        PrintCalculator(screen);
                    }
                    else if (oper == "%")
                    {
                        Console.WriteLine("Insira um numero");
                        var num1 = double.Parse(Console.ReadLine());
                        screen += $" {num1}";
                        PrintCalculator(screen);
                        Console.WriteLine("Insira um operador ou sinal de = para finlizar( +, -, *, / ou =)");
                        oper = Console.ReadLine();
                        result %= num1;
                        screen += $" {oper}";
                        PrintCalculator(screen);
                    }
                }
                #endregion

        #region Logica para caso um numero seja dividido por zero
                screen = $" {result} ";
                if (screen == " ∞ ") screen = "Infinito";
                PrintCalculator(screen);
            }
            #endregion

        #region catch da excessao caso seja digitado uma letra 
            catch
            {
                Console.WriteLine(" Não foi possivel efetuar a operação com letras!");
            }
        }
    }
    #endregion 
}


