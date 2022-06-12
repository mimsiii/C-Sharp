using System;

namespace Tic_tac_toe_Exam
{
    class Tic_tac_toe_Class
    {
        public char[] array = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        int WinLoseDraw = 0;
        int player = 1;
        int choice;

        public void Run()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Player 1 = 'X' / Player 2 = 'O'");
                Board();

                if (player % 2 == 0)
                {
                    Console.WriteLine("Player 2 turn");
                }
                else
                {
                    Console.WriteLine("Player 1 turn");
                }

                Console.WriteLine("Enter on which tile to play on: ");
                choice = int.Parse(Console.ReadLine());

                if (array[choice] != 'X' && array[choice] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        array[choice] = 'O';
                        player--;
                    }
                    else
                    {
                        array[choice] = 'X';
                        player++;
                    }
                }
                else
                {
                    Console.WriteLine("Tile is already marked.Press enter to try again!");
                    Console.ReadKey();
                }
                Console.Clear();
                Board();
                WinLoseDraw = CheckWin();

            } while (WinLoseDraw != 1 && WinLoseDraw != -1);

            if (WinLoseDraw == 1)
            {
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("Draw");
            }
        }

        private void Board()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |", array[1], array[2], array[3]);
            Console.WriteLine("|_____|_____|_____|");
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |", array[4], array[5], array[6]);
            Console.WriteLine("|_____|_____|_____|");
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |", array[7], array[8], array[9]);
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("-------------------");
        }

        private int CheckWin()
        {
            if (array[1] == array[2] && array[2] == array[3] ||
                array[4] == array[5] && array[5] == array[6] ||
                array[7] == array[8] && array[8] == array[9])
            {
                return 1;
            }
            else if (array[1] == array[4] && array[4] == array[7] ||
                    array[2] == array[5] && array[5] == array[8] ||
                    array[3] == array[6] && array[6] == array[9])
            {
                return 1;
            }
            else if (array[1] == array[5] && array[5] == array[9] ||
                     array[3] == array[5] && array[5] == array[7])
            {
                return 1;
            }
            else if (array[1] != '1' && array[2] != '2' && array[3] != '3' &&
                     array[4] != '4' && array[5] != '5' && array[6] != '6' &&
                     array[7] != '7' && array[8] != '8' && array[9] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
