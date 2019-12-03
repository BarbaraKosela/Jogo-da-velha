using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorEMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Início");

            string[,] campos;
            campos = new string[3, 3];

            // X X O
            // X O O
            // O X X

            campos[0, 0] = "X";
            campos[0, 1] = "X";
            campos[0, 2] = "X";

            campos[1, 0] = "X";
            campos[1, 1] = "O";
            campos[1, 2] = "O";

            campos[2, 0] = "O";
            campos[2, 1] = "X";
            campos[2, 2] = "X";


            bool houveVencedorNaHorizontal = ProcurarHorizontal(campos);
            bool houveVencedorNaVertical = ProcurarVertical(campos);
            bool houveVencedorDiagonal = ProcurarDiagonal(campos);

            if (houveVencedorNaHorizontal == true)
                Console.WriteLine("Houve vencedor na horizontal");
            else if (houveVencedorNaVertical == true)
                Console.WriteLine("Houve vencedor na vertical");
            else if (houveVencedorDiagonal == true)
                Console.WriteLine("Houve vencedor na diagonal");
            else
                Console.WriteLine("Não houve vencedor");

            Console.WriteLine("Fim");
            Console.ReadLine();
        }
        static bool ProcurarHorizontal(string[,] vetor)
        {
            string resultadoX = "";
            string resultadoO = "";
            for (int horiz = 0; horiz < 3; horiz++)
            {
                for (int outroHoriz = 0; outroHoriz < 3; outroHoriz++)
                {
                    var linhaHorizontal = vetor[horiz, outroHoriz];
                    if (linhaHorizontal == "X")
                    {
                        resultadoX = linhaHorizontal + resultadoX;
                        if (resultadoX == "XXX")
                        {
                            Console.WriteLine($"Linha Horizontal: {resultadoX}");
                            return true;
                        }
                    }
                    else if (linhaHorizontal == "O")
                    {
                        resultadoO = linhaHorizontal + resultadoO;
                        if (resultadoO == "OOO")
                        {
                            Console.WriteLine($"Linha Horizontal: {resultadoO}");
                            return true;
                        }
                    }
                }
                resultadoX = "";
                resultadoO = "";
            }
            return false;
        }
        static bool ProcurarVertical(string[,] vetor)
        {
            string resultadoX = "";
            string resultadoO = "";
            for (int vert = 0; vert < 3; vert++)
            {
                for (int outroVert = 0; outroVert < 3; outroVert++)
                {
                    var linhaVertical = vetor[outroVert, vert];
                    if (linhaVertical == "X")
                    {
                        resultadoX = linhaVertical + resultadoX;
                        if (resultadoX == "XXX")
                        {
                            Console.WriteLine($"Linha Vertical: {resultadoX}");
                            return true;
                        }
                    }
                    else if (linhaVertical == "O")
                    {
                        resultadoO = linhaVertical + resultadoO;
                        if (resultadoO == "OOO")
                        {
                            Console.WriteLine($"Linha Vertical: {resultadoO}");
                            return true;
                        }
                    }
                }
                resultadoX = "";
                resultadoO = "";
            }
            return false;
        }
        static bool ProcurarDiagonal(string[,] vetor)
        {
            return false;
        }
    }
}
