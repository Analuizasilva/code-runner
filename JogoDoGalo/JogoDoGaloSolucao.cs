using System;

namespace JogoDoGalo
{
    public static class JogoDoGaloSolucao
    {
        public static void JogoDoGalo()
        {
            StartGame();
        }
        public static void PrintPosition(string pos1, string pos2, string pos3, string pos4, string pos5,
            string pos6, string pos7, string pos8, string pos9)
        {
            Console.Clear();
            Console.WriteLine($"_{pos1}_|_{pos2}_|_{pos3}_");
            Console.WriteLine($"_{pos4}_|_{pos5}_|_{pos6}_");
            Console.WriteLine($" {pos7} | {pos8} | {pos9} ");
        }

        public static void StartGame()
        {
            var count = 0;
            var end = true;
            string pos1 = "1";
            string pos2 = "2";
            string pos3 = "3";
            string pos4 = "4";
            string pos5 = "5";
            string pos6 = "6";
            string pos7 = "7";
            string pos8 = "8";
            string pos9 = "9";
            var answer = false;

            PrintPosition(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
            while (end)
            {
                bool choice = true;
                Console.WriteLine("Jogador1 (X) escolha um numero entre 1 e 9?");
                var player1 = Console.ReadLine();

                while (choice)
                {
                    if (occupied(player1, pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9))
                    {
                        Console.WriteLine("Por favor escolha um numero entre 1 e 9, diferente do escolhido");
                        player1 = Console.ReadLine();
                    }
                    else break;
                }

                switch (player1)
                {
                    case "1":
                        pos1 = "X";
                        break;

                    case "2":
                        pos2 = "X";
                        break;

                    case "3":
                        pos3 = "X";
                        break;

                    case "4":
                        pos4 = "X";
                        break;

                    case "5":
                        pos5 = "X";
                        break;

                    case "6":
                        pos6 = "X";
                        break;

                    case "7":
                        pos7 = "X";
                        break;

                    case "8":
                        pos8 = "X";
                        break;

                    case "9":
                        pos9 = "X";
                        break;
                }
                PrintPosition(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
                answer = GameOver(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
                if (answer)
                {
                    Console.WriteLine("Jogador1 ganhou \\O/");
                    break;
                }
                Console.WriteLine("Jogador2 (O) escolha um numero entre 1 e 9?");
                var player2 = Console.ReadLine();

                while (choice)
                {
                    if (occupied(player2, pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9))
                    {
                        Console.WriteLine("Por favor escolha um numero entre 1 e 9, diferente do escolhido");
                        player2 = Console.ReadLine();
                    }
                    else break;
                }

                switch (player2)
                {
                    case "1":
                        pos1 = "O";
                        break;

                    case "2":
                        pos2 = "O";
                        break;

                    case "3":
                        pos3 = "O";
                        break;

                    case "4":
                        pos4 = "O";
                        break;

                    case "5":
                        pos5 = "O";
                        break;

                    case "6":
                        pos6 = "O";
                        break;

                    case "7":
                        pos7 = "O";
                        break;

                    case "8":
                        pos8 = "O";
                        break;

                    case "9":
                        pos9 = "O";
                        break;
                }
                PrintPosition(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
                answer = GameOver(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
                if (answer)
                {
                    Console.WriteLine("Jogador2 ganhou \\O/");
                    break;
                }
                count += 2;
                if (count == 8)
                    break;
            }
            if (!answer)
            {
                Console.WriteLine("O jogo deu empate ;( ");
            }
        }

        public static bool GameOver(string pos1, string pos2, string pos3, string pos4, string pos5,
            string pos6, string pos7, string pos8, string pos9)
        {
            if (pos1 == pos2 && pos1 == pos3)
                return true;

            else if (pos1 == pos4 && pos1 == pos7)
                return true;

            else if (pos1 == pos5 && pos1 == pos9)
                return true;

            else if (pos2 == pos5 && pos2 == pos8)
                return true;

            else if (pos3 == pos6 && pos3 == pos9)
                return true;

            else if (pos4 == pos5 && pos4 == pos6)
                return true;

            else if (pos7 == pos8 && pos7 == pos9)
                return true;
            else if (pos7 == pos5 && pos7 == pos3)
                return true;
            return false;
        }

        public static bool occupied(string pos, string pos1, string pos2, string pos3, string pos4, string pos5,
             string pos6, string pos7, string pos8, string pos9)
        {
            switch (pos)
            {
                case "1":
                    return pos1 == "X" || pos1 == "O";

                case "2":
                    return pos2 == "X" || pos2 == "O";

                case "3":
                    return pos3 == "X" || pos3 == "O";

                case "4":
                    return pos4 == "X" || pos4 == "O";

                case "5":
                    return pos5 == "X" || pos5 == "O";

                case "6":
                    return pos6 == "X" || pos6 == "O";

                case "7":
                    return pos7 == "X" || pos7 == "O";

                case "8":
                    return pos8 == "X" || pos8 == "O";

                case "9":
                    return pos9 == "X" || pos9 == "O";
            }
            return true;
        }
    }
}
