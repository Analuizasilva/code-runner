using System;

namespace JogoDoGalo
{
    public static class JogoDoGaloSolucao
    {
        public static void JogoDoGalo()
        {
            IniciarJogo();
        }
        public static void ImprimirPosicao(string pos1, string pos2, string pos3, string pos4, string pos5,
            string pos6, string pos7, string pos8, string pos9)
        {
            Console.Clear();
            Console.WriteLine($"_{pos1}_|_{pos2}_|_{pos3}_");
            Console.WriteLine($"_{pos4}_|_{pos5}_|_{pos6}_");
            Console.WriteLine($" {pos7} | {pos8} | {pos9} ");
        }

        public static void IniciarJogo()
        {
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
            var resposta = false;

            ImprimirPosicao(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
            while (end)
            {
                Console.WriteLine("Jogador1 (X) escolha um numero entre 1 e 9?");
                var jog1 = Console.ReadLine();
                switch (jog1)
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
                ImprimirPosicao(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
                resposta = GameOver(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
                if (resposta)
                {
                    Console.WriteLine("Jogador1 ganhou");
                    break;
                }
                Console.WriteLine("Jogador2 (O) escolha um numero entre 1 e 9?");
                var jog2 = Console.ReadLine();
                switch (jog2)
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
                ImprimirPosicao(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
                resposta = GameOver(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
                if (resposta)
                {
                    Console.WriteLine("Jogador2 ganhou");
                    break;
                }
            }       
        }
        public static bool GameOver(string pos1, string pos2, string pos3, string pos4, string pos5,
            string pos6, string pos7, string pos8, string pos9)
        {
            if (pos1 == pos2 && pos1 == pos3)
                return true;

            if (pos1 == pos4 && pos1 == pos7)
                return true;

            if (pos1 == pos5 && pos1 == pos9)
                return true;

            if (pos2 == pos5 && pos2 == pos8)
                return true;

            if (pos3 == pos6 && pos3 == pos9)
                return true;

            if (pos4 == pos5 && pos4 == pos6)
                return true;

            if (pos7 == pos8 && pos7 == pos9)
                return true;
            return false;
        }
    }
}
