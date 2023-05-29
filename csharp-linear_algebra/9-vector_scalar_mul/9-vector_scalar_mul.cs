using System;

public class VectorMath
{
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length < 2 || vector.Length > 3)
        {
            return new double[] { -1 };
        }

        double[] sumVector = new double[vector.Length];
        for (int i = 0; i < vector.Length; i++)
        {
            sumVector[i] = vector[i] * scalar;
        }

        return sumVector;
    }
}