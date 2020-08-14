using System;

namespace life
{
	class MainClass
	{
		static void Main (string[] args)
		{
			int Width = 10;
			int Height = 10;
			bool[,] cells = new bool[Width, Height];
			int[,] randomLife = new int[10, 10] {{1, 0, 0, 1, 1, 1, 1, 0, 0, 1}, {0, 0, 0, 1, 1, 0, 1, 0, 0, 1},{0, 0, 0, 1, 0, 1, 1, 0, 0, 1}, {1, 0, 0, 1, 0, 0, 1, 0, 0, 1}, {0, 1, 0, 1, 0, 1, 1, 0, 0, 1}, {1, 1, 0, 1, 0, 1, 1, 0, 0, 1}, {0, 0, 1, 0, 1, 0, 1, 0, 0, 1}, {1, 0, 0, 1, 1, 0, 1, 0, 0, 1}, {1, 0, 0, 1, 0, 1, 1, 0, 0, 1}, {1, 0, 0, 1, 0, 1, 0, 0, 0, 1}};

			for (int i = 0; i < Width; i++){
				for (int i1 = 0; i1 < Height; i1++){
					//Random randomLife = new Random ();
					//int newCell = randomLife.Next (0, 2);
					int newCell = randomLife [i, i1];

					if (newCell == 1) {
						cells [i, i1] = true;
					}
					else {
						cells [i, i1] = false;
					}
				}
			}
			bool[,] mainCells = new bool[Width, Height];
			mainCells = cells;

			while (true) {
				Repaint (mainCells, Width, Height);
				for (int sx = 0; sx < Width; sx++) {
					for (int sy = 0; sy < Height; sy++) {
						cells[sx, sy] = Neigbors (mainCells, sx, sy, Width, Height);
					}
				}
				mainCells = cells;
			}
		}
		public static void Repaint(bool[,] cells, int width, int height)
		{
			for (int x = 0; x < width; x++) {
				for (int y = 0; y < height; y++) {
					if (cells [x, y] == true) {
						Console.Write ('0');
					} else {
						Console.Write (" ");
					}
				}
				Console.Write ('\n');
			}
			Console.WriteLine ("");
			Console.WriteLine ("");
			Console.WriteLine ("");
			Console.WriteLine ("");
			Console.WriteLine ("");
			Console.WriteLine ("");
			Console.WriteLine ("");
			Console.WriteLine ("");
			Console.WriteLine ("");
			Console.WriteLine ("");
			Console.WriteLine ("");
			Console.WriteLine ("");
			Console.WriteLine ("");
			Console.WriteLine ("");
			Console.WriteLine ("");
			Console.ReadKey ();
		}
		public static bool Neigbors (bool[,] cells, int startX, int startY, int w, int h)
		{
			int neig = 0;

 			for (int x = startX - 1; x < startX + 2; x++) {
				for (int y = startY - 1; y < startY + 2; y++) {

					if (x >= 0 && x < w && y >= 0 && y < h) {
						if (cells [x, y] == true) {
							if (x != startX || y != startY) {
								neig++;
							}
						}
					}
				}
			}
			bool dsn = DoSoN (cells [startX, startY], neig);
			return dsn;
		}
		public static bool DoSoN (bool cellHp, int cellNeighbors) // Die or Sex or None
		{
			if (cellNeighbors == 3) {
				return true;
			} else if (cellNeighbors > 3) {
				return false;
			} else if (cellNeighbors < 2) {
				return false;
			} else {
				return cellHp;
			}
		}
	}
}
