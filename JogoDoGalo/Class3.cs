using System;

namespace JogoDoGalo
{
    public class Class3
    {
       
        public static void JogoDoGalo(string valorTamanhoPosicao, string espacos)
        {

            var jogo = "_1_|_2_|_3_\n_4_|_5_|_6_\n 7 | 8 | 9 ";
            Console.WriteLine($"{jogo}{valorTamanhoPosicao}{espacos}");
            string str = Console.ReadLine();
        
            int len = str.Length;
            


        }
        public static void ImprimirPosicao(string valorTamanhoPosicao)
        {
            string espacos = "";
            for (int i = 0; i < (5 - valorTamanhoPosicao.Length); i++) ; espacos += " ";
            Console.Clear();
        }







    }
}
