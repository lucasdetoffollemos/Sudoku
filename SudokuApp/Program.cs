using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuApp
{
    class Program
    {
        static void Main(string[] args)
        {


            int[,] sudoku = new int[9, 9];
            int[] linha = new int[9];
            int[] coluna = new int[9];
            int[] bloco1 = new int[9];
            int[] bloco2 = new int[9];
            int[] bloco3 = new int[9];
            int[] bloco4 = new int[9];
            int[] bloco5 = new int[9];
            int[] bloco6 = new int[9];
            int[] bloco7 = new int[9];
            int[] bloco8 = new int[9];
            int[] bloco9 = new int[9];

            string sudokuStr =   @"1 3 2 5 7 9 4 6 8
                                   4 9 8 2 6 1 3 7 5
                                   7 5 6 3 8 4 2 1 9
                                   6 4 3 1 5 8 7 9 2
                                   5 2 1 7 9 3 8 4 6
                                   9 8 7 4 2 6 5 3 1
                                   2 1 4 9 3 5 6 8 7
                                   3 6 5 8 1 7 9 2 4
                                   8 7 9 6 4 2 1 5 3";
            
            Console.WriteLine("Esse sudoku é verdadeiro? ");
            Console.ReadLine();
            Console.Clear();
            

            //convertendo a string e adicionando-a dentro da matriz
            using (StringReader sudokuReader = new StringReader(sudokuStr))
            {
                string linhaSudoku = "";

                for (int x = 0; x < 9; x++)
                {
                    linhaSudoku = sudokuReader.ReadLine();

                    string[] valores = linhaSudoku.Trim().Split();

                    for (int y = 0; y < 9; y++)
                    {
                        sudoku[x, y] = Convert.ToInt32(valores[y]);
                    }
                }
            }
            
            //lendo as linhas
            //pegar as linhas e colocar em um array
            bool linhaTrue = false;
            for (int x = 0; x < 9; x++)
            {
                int auxLinhas = 0;
                for (int y = 0; y < 9; y++)
                {
                    linha[auxLinhas] = sudoku[x, y];
                    auxLinhas++;
                    
                }

                linhaTrue = verificaLinha(linha);
            }

           //Console.WriteLine(linhaTrue);

            //lendo as colunas
            //pegar as colunas e colocar em um array
            bool colunaTrue = false;
            for (int x = 0; x < 9; x++)
            {
                int auxColunas = 0;
                for (int y = 0; y < 9; y++)
                {
                    coluna[auxColunas] = sudoku[y, x];
                    auxColunas++;

                }
                colunaTrue = verificaLinha(coluna);
            }

            //Console.WriteLine(colunaTrue);


            bool bloco1True = false;
            int auxBloco1 = 0;
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    bloco1[auxBloco1] = sudoku[x, y];
                    auxBloco1++;
                }
            }
            bloco1True = verificaBloco(bloco1);
            

            bool bloco2True = false;
            int auxBloco2 = 0;
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    bloco2[auxBloco2] = sudoku[x, y+3];
                    auxBloco2++;
                }
            }
            bloco2True = verificaBloco(bloco2);
            

            bool bloco3True = false;
            int auxBloco3 = 0;
            for(int x =0;x< 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    bloco3[auxBloco3] = sudoku[x, y + 6];
                    auxBloco3++;
                }
            }
            bloco3True = verificaBloco(bloco3);

            bool bloco4True = false;
            int auxBloco4 = 0;
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    bloco4[auxBloco4] = sudoku[x + 3, y];
                    auxBloco4++;
                }
            }
            bloco4True = verificaBloco(bloco4);

            bool bloco5True = false;
            int auxBloco5 = 0;
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    bloco5[auxBloco5] = sudoku[x + 3, y + 3];
                    auxBloco5++;
                }
            }
            bloco5True = verificaBloco(bloco5);

            bool bloco6True = false;
            int auxBloco6 = 0;
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    bloco6[auxBloco6] = sudoku[x + 3, y + 6];
                    auxBloco6++;
                }
            }
            bloco6True = verificaBloco(bloco6);

            bool bloco7True = false;
            int auxBloco7 = 0;
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    bloco7[auxBloco7] = sudoku[x + 6, y];
                    auxBloco7++;
                }
            }
            bloco7True = verificaBloco(bloco7);

            bool bloco8True = false;
            int auxBloco8 = 0;
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    bloco8[auxBloco8] = sudoku[x + 6, y + 3];
                    auxBloco8++;
                }
            }
            bloco8True = verificaBloco(bloco8);

            bool bloco9True = false;
            int auxBloco9 = 0;
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    bloco9[auxBloco9] = sudoku[x + 6, y + 6];
                    auxBloco9++;
                }
            }
            bloco9True = verificaBloco(bloco9);

            
            if(linhaTrue && colunaTrue && bloco1True && bloco2True && bloco3True && bloco4True && bloco5True && bloco6True && bloco7True  && bloco8True && bloco9True)
            {
                Console.WriteLine("SIM");
            }
            else
            {
                Console.WriteLine("NÃO");
            }

        }

        public static bool  verificaLinha(int[] linha)
        {
            int soma = 0;
            for (int x = 0; x < 9; x++)
            {
                soma = soma + linha[x];
            }

            if(soma == 45)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool verificaColuna(int[] coluna)
        {
            int soma = 0;
            for (int y = 0;y < 9; y++)
            {
                soma = soma + coluna[y];
            }

            if (soma == 45)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool verificaBloco(int[] bloco)
        {
            int soma = 0;
            for (int y = 0; y < 9; y++)
            {
                soma = soma + bloco[y];
            }

            if (soma == 45)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
