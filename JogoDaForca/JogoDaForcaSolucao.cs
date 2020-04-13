using System;

namespace Ficha13
{
    public static class ExtensExtensionMethods
    {
        public static char CharAt(this string @string, int pos) => @string[pos];
    }

    public class JogoDaForca

    {      

        #region JogoDaForca
        

        public static void Inicio()

        {
            string l1 = "*** Jogo da Forca ***";
            string l2 = "\n            ";
            string l3 = "  ========    ";
            string l4 = "  ||          ";
            string l5 = "  ||          ";
            string l6 = "  ||          ";
            string l7 = "  ||          ";
            string l8 = "  ||          ";
            string l9 = "  ||          ";
            string l10 = "TTTTTT   \n  ";


            string l1f = "*** Jogo da Forca ***";
            string l2f = "\n            ";
            string l3f = "  ========    ";
            string l4f = "  ||    |     ";
            string l5f = "  ||    O     ";
            string l6f = "  ||   /|\\   ";
            string l7f = "  ||    |     ";
            string l8f = "  ||     \\   ";
            string l82f = "  ||   / \\   ";
            string l9f = "  ||          ";
            string l10f = "TTTTTT   \n   ";


       


            var inicio = "A";
            while (inicio != "1")
            {
                Console.WriteLine("Pressione 1 para começar");
                 inicio = Console.ReadLine();
            }
            string recom = "s";

            while (recom == "s")
            {
                recom = "a";

                string espacos = "";
                string palavra = "";
                string palavrafinal = "";
                string palavraapre = "";
                string palavraapretemp = "";
                string letras = "";
                string letrains = "";
                int vidas = 6;
                int count = 0;
                var vida = 6;


                Console.Clear();
                palavra = "";
                string pl1 = "banana";
                string pl2 = "cavalo";
                string pl3 = "galinha";
                string pl4 = "gato";

                var selectWord = RandomWord(pl1, pl2, pl3, pl4);

                palavra = selectWord;
                palavrafinal = palavra;

                int tampalavra = palavra.Length;

                for (var i = 0; i < tampalavra; i++)
                {
                    espacos += "-";
                }

                Console.WriteLine(l1);
                Console.WriteLine(l2);
                Console.WriteLine(l3);
                Console.WriteLine(l4);
                Console.WriteLine(l5);
                Console.WriteLine(l6);
                Console.WriteLine(l7);
                Console.WriteLine(l8);
                Console.WriteLine(l9);
                Console.WriteLine(l10);
                Console.WriteLine("Palavra -> " + espacos);




                while (palavraapre != palavra)
                {
                    for (var i = 0; i < 1; i++)
                    {


                        Console.WriteLine("Letras utilizadas-> " + letras);
                        Console.WriteLine("Vidas-> " + vida);
                        Console.WriteLine("Insira uma letra");
                        letrains = Console.ReadLine();
                        letras += letrains;
                        Console.Clear();
                    }

                    if (vidas == 6)
                    {
                        if (vida == 6 & palavra.Contains(letrains))
                        {
                            Console.Clear();
                            Console.WriteLine(l1);
                            Console.WriteLine(l2);
                            Console.WriteLine(l3);
                            Console.WriteLine(l4);
                            Console.WriteLine(l5);
                            Console.WriteLine(l6);
                            Console.WriteLine(l7);
                            Console.WriteLine(l8);
                            Console.WriteLine(l9);
                            Console.WriteLine(l10);

                        }
                        else if (vida == 6 & !palavra.Contains(letrains))
                        {
                            Console.WriteLine(l1);
                            Console.WriteLine(l2);
                            Console.WriteLine(l3);
                            Console.WriteLine(l4f);
                            Console.WriteLine(l5);
                            Console.WriteLine(l6);
                            Console.WriteLine(l7);
                            Console.WriteLine(l8);
                            Console.WriteLine(l9);
                            Console.WriteLine(l10);

                            vida--;
                        }
                        else if (vida == 5 & palavra.Contains(letrains))
                        {
                            Console.WriteLine(l1);
                            Console.WriteLine(l2);
                            Console.WriteLine(l3);
                            Console.WriteLine(l4f);
                            Console.WriteLine(l5);
                            Console.WriteLine(l6);
                            Console.WriteLine(l7);
                            Console.WriteLine(l8);
                            Console.WriteLine(l9);
                            Console.WriteLine(l10);


                        }
                        else if (vida == 5 & !palavra.Contains(letrains))
                        {
                            Console.WriteLine(l1);
                            Console.WriteLine(l2);
                            Console.WriteLine(l3);
                            Console.WriteLine(l4f);
                            Console.WriteLine(l5f);
                            Console.WriteLine(l6);
                            Console.WriteLine(l7);
                            Console.WriteLine(l8);
                            Console.WriteLine(l9);
                            Console.WriteLine(l10);

                            vida--;
                        }
                        else if (vida == 4 & palavra.Contains(letrains))
                        {
                            Console.WriteLine(l1);
                            Console.WriteLine(l2);
                            Console.WriteLine(l3);
                            Console.WriteLine(l4f);
                            Console.WriteLine(l5f);
                            Console.WriteLine(l6);
                            Console.WriteLine(l7);
                            Console.WriteLine(l8);
                            Console.WriteLine(l9);
                            Console.WriteLine(l10);


                        }
                        else if (vida == 4 & !palavra.Contains(letrains))
                        {
                            Console.WriteLine(l1);
                            Console.WriteLine(l2);
                            Console.WriteLine(l3);
                            Console.WriteLine(l4f);
                            Console.WriteLine(l5f);
                            Console.WriteLine(l6f);
                            Console.WriteLine(l7);
                            Console.WriteLine(l8);
                            Console.WriteLine(l9);
                            Console.WriteLine(l10);

                            vida--;
                        }
                        else if (vida == 3 & palavra.Contains(letrains))
                        {
                            Console.WriteLine(l1);
                            Console.WriteLine(l2);
                            Console.WriteLine(l3);
                            Console.WriteLine(l4f);
                            Console.WriteLine(l5f);
                            Console.WriteLine(l6f);
                            Console.WriteLine(l7);
                            Console.WriteLine(l8);
                            Console.WriteLine(l9);
                            Console.WriteLine(l10);


                        }
                        else if (vida == 3 & !palavra.Contains(letrains))
                        {
                            Console.WriteLine(l1);
                            Console.WriteLine(l2);
                            Console.WriteLine(l3);
                            Console.WriteLine(l4f);
                            Console.WriteLine(l5f);
                            Console.WriteLine(l6f);
                            Console.WriteLine(l7f);
                            Console.WriteLine(l8);
                            Console.WriteLine(l9);
                            Console.WriteLine(l10);

                            vida--;
                        }
                        else if (vida == 2 & palavra.Contains(letrains))
                        {
                            Console.WriteLine(l1);
                            Console.WriteLine(l2);
                            Console.WriteLine(l3);
                            Console.WriteLine(l4f);
                            Console.WriteLine(l5f);
                            Console.WriteLine(l6f);
                            Console.WriteLine(l7f);
                            Console.WriteLine(l8);
                            Console.WriteLine(l9);
                            Console.WriteLine(l10);


                        }
                        else if (vida == 2 & !palavra.Contains(letrains))
                        {
                            Console.WriteLine(l1);
                            Console.WriteLine(l2);
                            Console.WriteLine(l3);
                            Console.WriteLine(l4f);
                            Console.WriteLine(l5f);
                            Console.WriteLine(l6f);
                            Console.WriteLine(l7f);
                            Console.WriteLine(l8f);
                            Console.WriteLine(l9);
                            Console.WriteLine(l10);

                            vida--;
                        }
                        else if (vida == 1 & palavra.Contains(letrains))
                        {
                            Console.WriteLine(l1);
                            Console.WriteLine(l2);
                            Console.WriteLine(l3);
                            Console.WriteLine(l4f);
                            Console.WriteLine(l5f);
                            Console.WriteLine(l6f);
                            Console.WriteLine(l7f);
                            Console.WriteLine(l8f);
                            Console.WriteLine(l9);
                            Console.WriteLine(l10);


                        }
                        else if (vida == 1 & !palavra.Contains(letrains))
                        {
                            Console.WriteLine(l1);
                            Console.WriteLine(l2);
                            Console.WriteLine(l3);
                            Console.WriteLine(l4f);
                            Console.WriteLine(l5f);
                            Console.WriteLine(l6f);
                            Console.WriteLine(l7f);
                            Console.WriteLine(l82f);
                            Console.WriteLine(l9);
                            Console.WriteLine(l10);

                            vida--;
                        }
                        else
                        {
                            Console.WriteLine("..............................................");
                            Console.WriteLine("..............................................");
                            Console.WriteLine("..............................................");
                            Console.WriteLine("..................Perdeu!!!...................");
                            Console.WriteLine("..............................................");
                            Console.WriteLine("..............................................");
                            Console.WriteLine("..............................................");
                            break;
                        }


                        for (var i = 0; i < espacos.Length; i++)
                        {

                            if (letrains.CharAt(0) == palavra.CharAt(i))
                            {
                                palavraapretemp += letrains;

                            }
                            else if (palavrafinal.CharAt(i) == "@".CharAt(0))
                            {
                                palavraapretemp += palavraapre.CharAt(i);

                            }
                            else
                            {
                                palavraapretemp += "-";

                            }

                        }
                        palavrafinal = palavrafinal.Replace(letrains, "@");
                        palavraapre = palavraapretemp;
                        palavraapretemp = "";


                        Console.WriteLine("Palavra-> " + palavraapre);

                    }

                }
                Console.WriteLine("..............................................");
                Console.WriteLine("..............................................");
                Console.WriteLine("..............................................");
                Console.WriteLine("..................GANHOU!!!...................");
                Console.WriteLine("..............................................");
                Console.WriteLine("..............................................");
                Console.WriteLine("..............................................");

                while( recom!= "n" && recom != "s")
                {
                    Console.WriteLine("Recomeçar? s para recomeçar, n para parar");
                    recom = Console.ReadLine();
                }
               
            }         
        }


        public static string RandomWord(string p1, string p2, string p3, string p4)
        {
            var result = (new Random()).Next(4) + 1;
            if (result == 1) return p1;
            else if (result == 2) return p2;
            else if (result == 3) return p3;
            else return p4;
        }    
    }
    #endregion
}