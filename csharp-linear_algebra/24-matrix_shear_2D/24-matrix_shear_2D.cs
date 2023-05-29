using System;

public class MatrixMath
{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return new double[,] { { -1 } };
        }

        double[,] result = new double[2, 2];
        Array.Copy(matrix, result, matrix.Length);

        if (direction == 'x')
        {
            result[0, 0] += factor * result[0, 1];
            result[1, 0] += factor * result[1, 1];
        }
        else if (direction == 'y')
        {
            result[0, 1] += factor * result[0, 0];
            result[1, 1] += factor * result[1, 0];
        }
        else
        {
            return new double[,] { { -1 } };
        }

        return result;
    }
}