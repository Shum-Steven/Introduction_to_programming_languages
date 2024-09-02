// Задайте двумерный массив символов (тип char[,]).
// Создать строку из символов этого массива.

void Main()
{
    int row = dataEntery("введите число Строк: ");
    int col = dataEntery("введите число Столбцов: ");
    char[,] matrix = generateArray(row, col);
    firstPrint(matrix);
    char[] strChar = arrayChar(matrix);
    string str = string.Concat(strChar);
    System.Console.WriteLine(str);
}

char[] arrayChar(char[,] matrix)
{
    char[] tempArray = new char[matrix.GetLength(0) * matrix.GetLength(1)];
    int i = 0;
    while(i < tempArray.Length)
    {
        for(int j = 0; j < matrix.GetLength(0); j++)
        {
            for(int q = 0; q < matrix.GetLength(1); q++)
            {
                tempArray[i] = matrix[j,q];
                i++;
            }
        }
    }
    return tempArray;
}

void firstPrint(char[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                System.Console.Write(matrix[i,j] + "\t");
            }
            System.Console.WriteLine();
        }
}

char[,] generateArray(int rowSize, int colSize)
{
    char[,] tempMatrix = new char[rowSize, colSize];
    Random rng = new Random();

    for(int i = 0; i < tempMatrix.GetLength(0); i++)
        {
            for(int j = 0; j < tempMatrix.GetLength(1); j++)
            {
                tempMatrix[i,j] = (char)rng.Next('A', 'Z' + 1);
            }
        }
        return tempMatrix;
}

int dataEntery (string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
Main();