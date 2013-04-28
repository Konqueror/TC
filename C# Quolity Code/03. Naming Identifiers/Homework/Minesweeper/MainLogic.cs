using System;
using System.Collections.Generic;
using System.Linq;

namespace Minesweeper
{
	public class MainLogic
	{
		static void Main(string[] аргументи)
		{
            const int MaxMines = 35;
			string command = string.Empty;
			char[,] gameField = CreateGameField();
			char[,] minesPositions = PlaceMines();
			int pointCounter = 0;
			bool isMine = false;
			List<Score> topPlayerList = new List<Score>(6);
			int cow = 0;
			int col = 0;
            bool newGame = true;
			bool finishedGame  = false;

			do
			{
				if (newGame)
				{
                    Console.WriteLine("Let's play Minesweeper. Try to find all cells without mines." +
					" Commands: 'top' shows Top Players list, 'restart' starts new game, 'exit' exits the game!");
					PrintGameField(gameField);
					newGame = false;
				}

				Console.Write("Please enter a row and col: ");
				command = Console.ReadLine().Trim();
                
                if (command.Length >= 3)
				{
                    if (int.TryParse(command[0].ToString(), out cow) &&
                    int.TryParse(command[2].ToString(), out col) &&
					cow <= gameField.GetLength(0) && col <= gameField.GetLength(1))
					{
                        command = "turn";
					}
				}

                switch (command)
				{
					case "top":
                        Chart(topPlayerList);
						break;

					case "restart":
						gameField = CreateGameField();
                        minesPositions = PlaceMines();
						PrintGameField(gameField);
						isMine = false;
						newGame = false;
						break;

					case "exit":
						Console.WriteLine("Bye Bye!");
						break;

					case "turn":
                        if (minesPositions[cow, col] != '*')
						{
                            if (minesPositions[cow, col] == '-')
							{
                                tisinahod(gameField, minesPositions, cow, col);
								pointCounter++;
							}

							if (MaxMines == pointCounter)
							{
                                finishedGame = true;
							}
							else
							{
								PrintGameField(gameField);
							}
						}
						else
						{
							isMine = true;
						}
						break;
					
                    default:
                        Console.WriteLine("\nUnknown command\n");
						break;
				}
				
                if (isMine)
				{
                    PrintGameField(minesPositions);
					Console.Write("\nHrrrrrr! You died with {0} points. " + "Please enter your nichname: ", pointCounter);
					string nickname = Console.ReadLine();
					
                    Score currentPlayer = new Score(nickname, pointCounter);
					
                    if (topPlayerList.Count < 5)
					{
						topPlayerList.Add(currentPlayer);
					}
					else
					{
						for (int i = 0; i < topPlayerList.Count; i++)
						{
							if (topPlayerList[i].Points < currentPlayer.Points)
							{
								topPlayerList.Insert(i, currentPlayer);
								topPlayerList.RemoveAt(topPlayerList.Count - 1);
								break;
							}
						}
					}
                    topPlayerList.Sort((Score firstPlayer, Score secondPlayer) => secondPlayer.Name.CompareTo(firstPlayer.Name));
                    topPlayerList.Sort((Score firstPlayer, Score secondPlayer) => secondPlayer.Points.CompareTo(firstPlayer.Points));
                    Chart(topPlayerList);

					gameField = CreateGameField();
                    minesPositions = PlaceMines();
					pointCounter = 0;
					isMine = false;
					newGame = true;
				}

                if (finishedGame)
				{
                    Console.WriteLine("\nYOU WON!!!\n You have opened all {0} fields.", MaxMines);
                    PrintGameField(minesPositions);
					Console.WriteLine("Please enter your Nickname: ");
					string name = Console.ReadLine();
					Score points = new Score(name, pointCounter);
					topPlayerList.Add(points);
                    Chart(topPlayerList);
					gameField = CreateGameField();
                    minesPositions = PlaceMines();
					pointCounter = 0;
                    finishedGame = false;
					newGame = true;
				}
			}

            while (command != "exit");
			Console.WriteLine("Made in Bulgaria");
			Console.Read();
		}

		private static void Chart(List<Score> playerPoints)
		{
            Console.WriteLine("\nPoints:");
			if (playerPoints.Count > 0)
			{
				for (int i = 0; i < playerPoints.Count; i++)
				{
					Console.WriteLine("{0}. {1} --> {2} Fields opened",
						i + 1, playerPoints[i].Name, playerPoints[i].Points);
				}
				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("Empty Chart!\n");
			}
		}

        private static void tisinahod(char[,] field,
            char[,] bombs, int row, int col)
		{
            char bombsCount = GetSurroundingMines(bombs, row, col);
            bombs[row, col] = bombsCount;
            field[row, col] = bombsCount;
		}

		private static void PrintGameField(char[,] board)
		{
            int boardHeight = board.GetLength(0);
            int boardWidth = board.GetLength(1);
			Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
			Console.WriteLine("   ---------------------");
            
            for (int row = 0; row < boardHeight; row++)
			{
				Console.Write("{0} | ", row);
                for (int col = 0; col < boardWidth; col++)
				{
					Console.Write(string.Format("{0} ", board[row, col]));
				}
				Console.Write("|");
				Console.WriteLine();
			}
			Console.WriteLine("   ---------------------\n");
		}

		private static char[,] CreateGameField()
		{
			int boardRows = 5;
			int boardColumns = 10;
			char[,] board = new char[boardRows, boardColumns];
			
            for (int row = 0; row < boardRows; row++)
			{
				for (int col = 0; col < boardColumns; col++)
				{
					board[row, col] = '?';
				}
			}

			return board;
		}

		private static char[,] PlaceMines()
		{
            int fieldRows = 5;
            int fieldCols = 10;
            char[,] gameField = new char[fieldRows, fieldCols];

            for (int row = 0; row < fieldRows; row++)
			{
                for (int col = 0; col < fieldCols; col++)
				{
					gameField[row, col] = '-';
				}
			}

			List<int> bombsMap = new List<int>();
            
            while (bombsMap.Count < 15)
			{
				Random random = new Random();
				int randomInt = random.Next(50);

                if (!bombsMap.Contains(randomInt))
				{
                    bombsMap.Add(randomInt);
				}
			}

            foreach (int bombLocation in bombsMap)
			{
                int col = (bombLocation / fieldCols);
                int rol = (bombLocation % fieldCols);
                
                if (rol == 0 && bombLocation != 0)
				{
					col--;
                    rol = fieldCols;
				}
				else
				{
					rol++;
				}

				gameField[col, rol - 1] = '*';
			}

			return gameField;
		}

        private static char GetSurroundingMines(char[,] minesField, int currentRow, int currentCol)
		{
			int minesCount = 0;
			int fieldRows = minesField.GetLength(0);
			int fieldCols = minesField.GetLength(1);

			if (currentRow - 1 >= 0)
			{
				if (minesField[currentRow - 1, currentCol] == '*')
				{
                    minesCount++; 
				}
			}

			if (currentRow + 1 < fieldRows)
			{
				if (minesField[currentRow + 1, currentCol] == '*')
				{
                    minesCount++; 
				}
			}

			if (currentCol - 1 >= 0)
			{
				if (minesField[currentRow, currentCol - 1] == '*')
				{
                    minesCount++;
				}
			}

			if (currentCol + 1 < fieldCols)
			{
				if (minesField[currentRow, currentCol + 1] == '*')
				{
                    minesCount++;
				}
			}

			if ((currentRow - 1 >= 0) && (currentCol - 1 >= 0))
			{
				if (minesField[currentRow - 1, currentCol - 1] == '*')
				{
                    minesCount++; 
				}
			}

			if ((currentRow - 1 >= 0) && (currentCol + 1 < fieldCols))
			{
				if (minesField[currentRow - 1, currentCol + 1] == '*')
				{
                    minesCount++; 
				}
			}

			if ((currentRow + 1 < fieldRows) && (currentCol - 1 >= 0))
			{
				if (minesField[currentRow + 1, currentCol - 1] == '*')
				{
                    minesCount++; 
				}
			}

			if ((currentRow + 1 < fieldRows) && (currentCol + 1 < fieldCols))
			{
				if (minesField[currentRow + 1, currentCol + 1] == '*')
				{
                    minesCount++; 
				}
			}
            return char.Parse(minesCount.ToString());
		}
	}
}
