using System.Collections;

int[] oldWayForArray1 = new int[] { 1, 2, 3, 4 };
int[] oldWayForArray2 = new[] { 1, 2, 3, 4 };
int[] oldWayForArray3 = { 1, 2, 3, 4 };

int[] array = [1, 2, 3, 4];

List<int> myList = [1, 2, 3, 4];


int[] row0 = [1, 2, 3];
int[] row1 = [4, 5, 6];
int[] row2 = [7, 8, 9];
int[][] matrix = [row0, row1, row2];


for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int column = 0; column < matrix[row].Length; column++)
    {
        Console.WriteLine(matrix[row][column].ToString());
    }
}

int[] array1 = [1, 2, 3];
int[] array2 = [4, 5, 6];
int[] array3 = [7, 8, 9];
int[] largeArray = [.. array1, .. array2, .. array3];

foreach (var item in largeArray)
{
    Console.WriteLine(item.ToString());
}

int[] largeArray2 = [.. array1, 20, .. array2, .. array3];

foreach (var item in largeArray2)
{
    Console.WriteLine(item.ToString());
}
