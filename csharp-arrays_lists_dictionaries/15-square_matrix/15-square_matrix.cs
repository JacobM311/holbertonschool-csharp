public class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int rows = myMatrix.GetLength(0);
        int columns = myMatrix.GetLength(1);
        int[,] squaredMatrix = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                int value = myMatrix[i, j];
                int squaredValue = value * value;
                squaredMatrix[i, j] = squaredValue;
            }
        }

        return squaredMatrix;
    }
}