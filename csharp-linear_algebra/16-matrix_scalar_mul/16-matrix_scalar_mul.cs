using System;

public class MatrixMath
{
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if (matrix.Length == 0 || (matrix.GetLength(0) != 2 && matrix.GetLength(0) != 3) 
            || (matrix.GetLength(1) != 2 && matrix.GetLength(1) != 3))
        {
            return new double[,] { { -1 } };
        }

        double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                result[i, j] = matrix[i, j] * scalar;
            }
        }
        return result;
    }
}