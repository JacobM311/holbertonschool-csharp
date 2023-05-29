using System;

class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        if (vector.Length < 2 || vector.Length > 3)
        {
            return -1;
        }

        double sumOfSquares = 0;
        for (int i = 0; i < vector.Length; i++)
        {
            sumOfSquares += Math.Pow(vector[i], 2);
        }

        double magnitude = Math.Sqrt(sumOfSquares);

        return Math.Round(magnitude, 2);
    }
}