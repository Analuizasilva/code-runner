using System;

namespace Calculadora
{
    public class Class1
    {
        #region Calculadora
        public static void ImprimeCalculadora(string valorTela)
        {
            //Tela Calculadora
            string espacos = "";
            for (int i = 0; i < (25 - valorTela.Length); i++) espacos += " ";
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("          " + "" + "                 ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write($"{espacos}{valorTela}");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine(" ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("                           ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");
            // for imprime teclas de numeros
            for (int i = 7; i <= 9; i++)
            {
                ImprimeNumeros(i);
            }
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" + ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("   ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("                           ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");

            for (int i = 4; i <= 6; i++)
            {
                ImprimeNumeros(i);
            }
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" - ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("   ");
            Console.WriteLine("                           ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");

            for (int i = 1; i <= 3; i++)
            {
                ImprimeNumeros(i);
            }
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" * ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("   ");
            Console.WriteLine("                           ");

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
        // funcao imprime teclas de numeros
        private static void ImprimeNumeros(int numero)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write($" {numero} ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");
        }
        // funcao imprime calculadora imprime na tela.
        public static void Calculadora()
        {
            ImprimeCalculadora("0");
            Calcular();
        }

        //funcao efetua os calculos
        public static void Calcular()
        {
            try
            {
                var tela = "";
                Console.WriteLine("Insira um numero");
                var input = Console.ReadLine();
                if (input == "x")
                {
                    System.Environment.Exit(0);
                }
                double num = double.Parse(input);
                tela += $" {num}";
                ImprimeCalculadora(tela);
                Console.WriteLine("Insira um operador ou sinal de = para finlizar( +, -, *, / ou =)");
                string oper = Console.ReadLine();
                tela += $" {oper}";
                ImprimeCalculadora(tela);
                double result = num;
                while (oper != "=")
                {
                    if (oper == "+")
                    {
                        Console.WriteLine("Insira um numero");
                        var num1 = double.Parse(Console.ReadLine());
                        tela += $" {num1}";
                        ImprimeCalculadora(tela);
                        Console.WriteLine("Insira um operador ou sinal de = para finlizar( +, -, *, / ou =)");
                        oper = Console.ReadLine();
                        tela += $" {oper}";
                        ImprimeCalculadora(tela);
                        result += num1;
                    }
                    else if (oper == "-")
                    {
                        Console.WriteLine("Insira um numero");
                        var num1 = double.Parse(Console.ReadLine());
                        tela += $" {num1}";
                        ImprimeCalculadora(tela);
                        Console.WriteLine("Insira um operador ou sinal de = para finlizar( +, -, *, / ou =)");
                        oper = Console.ReadLine(); result -= num1;
                        tela += $" {oper}";
                        ImprimeCalculadora(tela);
                    }
                    else if (oper == "*")
                    {
                        Console.WriteLine("Insira um numero");
                        var num1 = double.Parse(Console.ReadLine());
                        tela += $" {num1}";
                        ImprimeCalculadora(tela);
                        Console.WriteLine("Insira um operador ou sinal de = para finlizar( +, -, *, / ou =)");
                        oper = Console.ReadLine(); result *= num1;
                        tela += $" {oper}";
                        ImprimeCalculadora(tela);
                    }

                    else if (oper == "/")

                    {
                        Console.WriteLine("Insira um numero");
                        var num1 = double.Parse(Console.ReadLine());
                        tela += $" {num1}";
                        ImprimeCalculadora(tela);
                        Console.WriteLine("Insira um operador ou sinal de = para finlizar( +, -, *, / ou =)");
                        oper = Console.ReadLine();
                        result /= num1;
                        tela += $" {oper}";
                        ImprimeCalculadora(tela);
                    }
                    else if (oper == "%")
                    {
                        Console.WriteLine("Insira um numero");
                        var num1 = double.Parse(Console.ReadLine());
                        tela += $" {num1}";
                        ImprimeCalculadora(tela);
                        Console.WriteLine("Insira um operador ou sinal de = para finlizar( +, -, *, / ou =)");
                        oper = Console.ReadLine();
                        result %= num1;
                        tela += $" {oper}";
                        ImprimeCalculadora(tela);
                    }
                }
                tela = $" {result} ";
                if (tela == " ∞ ") tela = "Infinito";
                ImprimeCalculadora(tela);
            }
            catch
            {
                Console.WriteLine(" Não foi possivel efetuar a operação!");
            }
        }


        #endregion
        #region Jogo da velha (Nao fiz)
        public static void JogoDaVelha()
        {
            Console.WriteLine("  ________     ");
            Console.WriteLine(" |        |         ");
            Console.WriteLine(" |        O         ");
            Console.WriteLine(" |       /|     ");
            Console.WriteLine(" |       /     "); //ja tem o resto dos membros ^_^
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


        }
        #endregion
        #region Jogo da Forca (Nao fiz)
        public static void JogoDaForca()
        {

        }
        #endregion 
    }
}


