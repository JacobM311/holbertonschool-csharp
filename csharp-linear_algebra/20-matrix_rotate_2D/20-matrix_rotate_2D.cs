using System;

public class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return new double[,] { { -1 } };
        }

        double[,] result = new double[2, 2];
        double cos = Math.Cos(angle);
        double sin = Math.Sin(angle);

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                double x = matrix[i, j];
                double y = matrix[j, i];

                result[i, j] = x * cos - y * sin;
                result[j, i] = x * sin + y * cos;
            }
        }

        return result;
    }
}