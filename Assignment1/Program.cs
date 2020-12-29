using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class TicTacToe
    {
        //Size of the board.
        private const int BOARDSIZE = 3;
        //Board representation.
        private int[,] board = new int[BOARDSIZE, BOARDSIZE] { { 0, 0, 0 }, { 0, 0, 0}, { 0, 0, 0 } };
        //Default turn to player 1.
        private int player_turn = 1;
        //Field that store player's choice.
        private int player_choice;
        //Field to check status of the game.
        private int game_end = 0;
        //Character fields use to label the grids.
        private char grid1 = '1';
        private char grid2 = '2';
        private char grid3 = '3';
        private char grid4 = '4';
        private char grid5 = '5';
        private char grid6 = '6';
        private char grid7 = '7';
        private char grid8 = '8';
        private char grid9 = '9';
        //Boolean field to constrol validation while-loop.
        private bool marked;

        //Method to print the game board.
        public void PrintBoard()
        {
            //Clear console.
            Console.Clear();
            Console.WriteLine("Player 1: X   Player 2: O\n");
            //If-statements to check player's turn.
            if(player_turn % 2 == 1)
            {
                Console.WriteLine("Player 1 Chance.\n");
            }
            else
            {
                Console.WriteLine("Player 2 Chance.\n");
            }
            //Print game board.
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2}", grid1, grid2, grid3);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2}", grid4, grid5, grid6);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2}", grid7, grid8, grid9);
            Console.WriteLine("   |   |  \n ");
        }
        //Method to check status of the game.
        public int check_game()
        {
            if (player_turn % 2 == 1)
            {
                //check horizontal match
                if ((board[0, 0] == 'X' && board[0, 1] == 'X' && board[0, 2] == 'X') ||
                    (board[1, 0] == 'X' && board[1, 1] == 'X' && board[1, 2] == 'X') ||
                    (board[2, 0] == 'X' && board[2, 1] == 'X' && board[2, 2] == 'X'))
                {
                    return 1;
                }
                //check vertical match
                else if ((board[0, 0] == 'X' && board[1, 0] == 'X' && board[2, 0] == 'X') ||
                    (board[0, 1] == 'X' && board[1, 1] == 'X' && board[2, 1] == 'X') ||
                    (board[0, 2] == 'X' && board[1, 2] == 'X' && board[2, 2] == 'X'))
                {
                    return 1;
                }
                //check diagonal match
                else if ((board[0, 0] == 'X' && board[1, 1] == 'X' && board[2, 2] == 'X') ||
                    (board[0, 2] == 'X' && board[1, 1] == 'X' && board[2, 0] == 'X'))
                {
                    return 1;
                }
                //check for draw game
                else if (grid1 != '1' && grid2 != '2' && grid3 != '3' && grid4 != '4' && grid5 != '5' && grid6 != '6'
                    && grid7 != '7' && grid8 != '8' && grid9 != '9')
                {
                    return 3;
                }
            }
            else
            {
                //check horizontal match
                if ((board[0, 0] == 'O' && board[0, 1] == 'O' && board[0, 2] == 'O') ||
                    (board[1, 0] == 'O' && board[1, 1] == 'O' && board[1, 2] == 'O') ||
                    (board[2, 0] == 'O' && board[2, 1] == 'O' && board[2, 2] == 'O'))
                {
                    return 2;
                }
                //check vertical match
                else if ((board[0, 0] == 'O' && board[1, 0] == 'O' && board[2, 0] == 'O') ||
                    (board[0, 1] == 'O' && board[1, 1] == 'O' && board[2, 1] == 'O') ||
                    (board[0, 2] == 'O' && board[1, 2] == 'O' && board[2, 2] == 'O'))
                {
                    return 2;
                }
                //check diagonal match
                else if ((board[0, 0] == 'O' && board[1, 1] == 'O' && board[2, 2] == 'O') ||
                    (board[0, 2] == 'O' && board[1, 1] == 'O' && board[2, 0] == 'O'))
                {
                    return 2;
                }
                //check for draw game
                else if (grid1 != '1' && grid2 != '2' && grid3 != '3' && grid4 != '4' && grid5 != '5' && grid6 != '6'
                    && grid7 != '7' && grid8 != '8' && grid9 != '9')
                {
                    return 3;
                }
            }
            return 0;
        }
        //Method to start the game.
        public void Play()
        {
            while (game_end == 0)
            {
                PrintBoard();
                marked = true;
                if (player_turn % 2 == 1)
                {
                    Console.WriteLine("Enter a number between 1 and 9.");
                    while (!int.TryParse(Console.ReadLine(), out player_choice))
                    {
                        Console.WriteLine("Enter a number between 1 and 9.");
                    }
                    //Validate user input.
                    while (marked)
                    {
                        if (player_choice == 1 && grid1 == '1')
                        {
                            board[0, 0] = 'X';
                            grid1 = 'X';
                            marked = false;
                        }
                        else if (player_choice == 2 && grid2 == '2')
                        {
                            board[0, 1] = 'X';
                            grid2 = 'X';
                            marked = false;
                        }
                        else if (player_choice == 3 && grid3 == '3')
                        {
                            board[0, 2] = 'X';
                            grid3 = 'X';
                            marked = false;
                        }
                        else if (player_choice == 4 && grid4 == '4')
                        {
                            board[1, 0] = 'X';
                            grid4 = 'X';
                            marked = false;
                        }
                        else if (player_choice == 5 && grid5 == '5')
                        {
                            board[1, 1] = 'X';
                            grid5 = 'X';
                            marked = false;
                        }
                        else if (player_choice == 6 && grid6 == '6')
                        {
                            board[1, 2] = 'X';
                            grid6 = 'X';
                            marked = false;
                        }
                        else if (player_choice == 7 && grid7 == '7')
                        {
                            board[2, 0] = 'X';
                            grid7 = 'X';
                            marked = false;
                        }
                        else if (player_choice == 8 && grid8 == '8')
                        {
                            board[2, 1] = 'X';
                            grid8 = 'X';
                            marked = false;
                        }
                        else if (player_choice == 9 && grid9 == '9')
                        {
                            board[2, 2] = 'X';
                            grid9 = 'X';
                            marked = false;
                        }
                        else
                        {
                            if (player_choice > 9 || player_choice < 1)
                            {
                                Console.WriteLine("Enter a number between 1 and 9.");
                                int.TryParse(Console.ReadLine(), out player_choice);
                            }
                            else
                            {
                                Console.WriteLine("The grid number is already taken.");
                                Console.WriteLine("Enter another number between 1 and 9.");
                                int.TryParse(Console.ReadLine(), out player_choice);
                            }
                        }
                    }
                    PrintBoard();
                    game_end = check_game();
                    player_turn++;
                }
                else
                {
                    Console.WriteLine("Enter a number between 1 and 9.");
                    while (!int.TryParse(Console.ReadLine(), out player_choice))
                    {
                        Console.WriteLine("Enter a number between 1 and 9.");
                    }
                    while (marked)
                    {
                        if (player_choice == 1 && grid1 == '1')
                        {
                            board[0, 0] = 'O';
                            grid1 = 'O';
                            marked = false;
                        }
                        else if (player_choice == 2 && grid2 == '2')
                        {
                            board[0, 1] = 'O';
                            grid2 = 'O';
                            marked = false;
                        }
                        else if (player_choice == 3 && grid3 == '3')
                        {
                            board[0, 2] = 'O';
                            grid3 = 'O';
                            marked = false;
                        }
                        else if (player_choice == 4 && grid4 == '4')
                        {
                            board[1, 0] = 'O';
                            grid4 = 'O';
                            marked = false;
                        }
                        else if (player_choice == 5 && grid5 == '5')
                        {
                            board[1, 1] = 'O';
                            grid5 = 'O';
                            marked = false;
                        }
                        else if (player_choice == 6 && grid6 == '6')
                        {
                            board[1, 2] = 'O';
                            grid6 = 'O';
                            marked = false;
                        }
                        else if (player_choice == 7 && grid7 == '7')
                        {
                            board[2, 0] = 'O';
                            grid7 = 'O';
                            marked = false;
                        }
                        else if (player_choice == 8 && grid8 == '8')
                        {
                            board[2, 1] = 'O';
                            grid8 = 'O';
                            marked = false;
                        }
                        else if (player_choice == 9 && grid9 == '9')
                        {
                            board[2, 2] = 'O';
                            grid9 = 'O';
                            marked = false;
                        }
                        else
                        {
                            if (player_choice > 9 || player_choice < 1)
                            {
                                Console.WriteLine("Enter a number between 1 and 9.");
                                int.TryParse(Console.ReadLine(), out player_choice);
                            }
                            else
                            {
                                Console.WriteLine("The grid number is already taken.");
                                Console.WriteLine("Enter another number between 1 and 9.");
                                int.TryParse(Console.ReadLine(), out player_choice);
                            }
                        }
                    }
                    PrintBoard();
                    game_end = check_game();
                    player_turn++;
                }
            }
            if (game_end == 1)
            {
                Console.WriteLine("Player 1 win!\n");
            }
            else if (game_end == 2)
            {
                Console.WriteLine("Player 2 win!\n");
            }
            else if(game_end == 3)
            {
                Console.WriteLine("Draw game!\n");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToe game = new TicTacToe();
            game.Play();
            Console.ReadKey();
        }
    }
}