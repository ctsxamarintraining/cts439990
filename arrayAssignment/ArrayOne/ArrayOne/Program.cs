using System;

namespace ArrayOne
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[, , ,] fourDimensionArray = new string[2, 2, 2, 2];
			fourDimensionArray [0, 0, 0, 0] = "A";
			fourDimensionArray [0, 0, 0, 1] = "B";
			fourDimensionArray [0, 0, 1, 0] = "C";
			fourDimensionArray [0, 0, 1, 1] = "D";
			fourDimensionArray [0, 1, 0, 0] = "E";
			fourDimensionArray [0, 1, 0, 1] = "F";
			fourDimensionArray [0, 1, 1, 0] = "G";
			fourDimensionArray [0, 1, 1, 1] = "H";
			fourDimensionArray [1, 0, 0, 0] = "I";
			fourDimensionArray [1, 0, 0, 1] = "J";
			fourDimensionArray [1, 0, 1, 0] = "K";
			fourDimensionArray [1, 0, 1, 1] = "L";
			fourDimensionArray [1, 1, 0, 0] = "M";
			fourDimensionArray [1, 1, 0, 1] = "N";
			fourDimensionArray [1, 1, 1, 0] = "O";
			fourDimensionArray [1, 1, 1, 1] = "P";

			//Iteration
			for (int i = 0; i < fourDimensionArray.GetLength(3); i++)
			{
				for (int j = 0; j < fourDimensionArray.GetLength(2); j++)
				{
					for (int k = 0; k < fourDimensionArray.GetLength(1); k++)
					{
						for(int l=0; l< fourDimensionArray.GetLength(0); l++)
						{

							Console.WriteLine(fourDimensionArray[i, j, k, l]);

						}

					}

				}
			}



		}
	}
}
