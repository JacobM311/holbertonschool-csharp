using System;

public class MatrixMath
{
    public static double Determinant(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != cols) // Matrix needs to be square
            return -1;
        if (rows < 2 || rows > 3) // We only handle 2x2 or 3x3 matrices
            return -1;

        double determinant = 0;

        if (rows == 2) // 2x2 matrix determinant
        {
            determinant = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }
        else // 3x3 matrix determinant
        {
            determinant += matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]);
            determinant -= matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]);
            determinant += matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
        }
        
        // Round to 2 decimal places
        return Math.Round(determinant, 2);
    }
}