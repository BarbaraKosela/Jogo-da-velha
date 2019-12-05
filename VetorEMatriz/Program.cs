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
            Console.WriteLine("Início\n");

            string[,] campos;
            campos = new string[3, 3];

            // O X X
            // X X O
            // O O X

            campos[0, 0] = "O";
            campos[0, 1] = "X";
            campos[0, 2] = "X";

            campos[1, 0] = "X";
            campos[1, 1] = "X";
            campos[1, 2] = "O";

            campos[2, 0] = "O";
            campos[2, 1] = "O";
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

            Console.WriteLine("\nFim");
            Console.ReadLine();
        }
        static bool ProcurarHorizontal(string[,] vetor)
        {
            string resultadoX = "";
            string resultadoO = "";
            int contador = 0;
            foreach (string campos in vetor)
            {
                contador++;
                if (campos == "X")
                {
                    resultadoX = campos + resultadoX;
                    if (resultadoX == "XXX")
                        return true;
                }
                else if (campos == "O")
                {
                    resultadoO = campos + resultadoO;

                    if (resultadoO == "OOO")
                        return true;
                }
                if (contador == 3)
                {
                    resultadoX = "";
                    resultadoO = "";
                    contador = 0;
                }
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
                    string linhaVertical = vetor[outroVert, vert];
                    if (linhaVertical == "X")
                    {
                        resultadoX = linhaVertical + resultadoX;
                        if (resultadoX == "XXX")
                            return true;
                    }
                    else if (linhaVertical == "O")
                    {
                        resultadoO = linhaVertical + resultadoO;
                        if (resultadoO == "OOO")
                            return true;
                    }
                }
                resultadoX = "";
                resultadoO = "";
            }
            return false;
        }
        static bool ProcurarDiagonal(string[,] vetor)
        {
            bool haVencedorDiagonal = false;
            while (!haVencedorDiagonal)
            {
                if (vetor[0, 0] == "X" && vetor[1, 1] == "X" && vetor[2, 2] == "X" ||
                    vetor[0, 0] == "O" && vetor[1, 1] == "O" && vetor[2, 2] == "O")
                    haVencedorDiagonal = true;
                else if (vetor[0, 2] == "X" && vetor[1, 1] == "X" && vetor[2, 0] == "X" ||
                    vetor[0, 2] == "O" && vetor[1, 1] == "O" && vetor[2, 0] == "O")
                    haVencedorDiagonal = true;
                else
                    return false;
            }
            return haVencedorDiagonal;
        }
    }
}
