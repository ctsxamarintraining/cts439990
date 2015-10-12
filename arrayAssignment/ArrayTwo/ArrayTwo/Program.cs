using System;

namespace ArrayTwo
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

			printArrayElements (fourDimensionArray);

			int[] oneDimensionArray = new int[5];
			oneDimensionArray [0] = 1;
			oneDimensionArray [1] = 2;
			oneDimensionArray [2] = 3;
			oneDimensionArray [3] = 4;
			oneDimensionArray [4] = 5;

			printArrayElements (oneDimensionArray);
		

		}

		public static void printArrayElements(Array arrayName){
			foreach (var element in arrayName) {
				Console.WriteLine (element);
			}
		}
	}
}

