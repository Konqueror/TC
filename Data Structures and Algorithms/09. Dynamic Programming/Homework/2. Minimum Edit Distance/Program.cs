using System;

static class LevenshteinDistance
{
    public static decimal Compute(string firstString, string secondString)
    {
        const decimal CostDelete = 0.9M;
        const decimal CostInsert = 0.8M;
        const decimal CostReplace = 1M;

        int n = firstString.Length;
        int m = secondString.Length;
        decimal[,] matrix = new decimal[n + 1, m + 1];

        if (n == 0)
        {
            return m;
        }

        if (m == 0)
        {
            return n;
        }

        for (int row = 0; row <= n; row++)
        {
            matrix[row, 0] = row * CostDelete;
        }

        for (int col = 0; col <= m; col++)
        {
            matrix[0, col] = col * CostInsert;
        }

        for (int row = 1; row <= n; row++)
        {
            for (int col = 1; col <= m; col++)
            {
                decimal cost;
                if (secondString[col - 1] == firstString[row - 1])
                {
                    cost = 0;
                }
                else
                {
                    cost = CostReplace;
                }

                decimal delete = matrix[row - 1, col] + CostDelete;
                decimal replace = matrix[row - 1, col - 1] + cost;
                decimal insert = matrix[row, col - 1] + CostInsert;


                matrix[row, col] = Math.Min(Math.Min(delete, insert), replace);
            }
        }

        return matrix[n, m];
    }

    static void Main()
    {
        Console.WriteLine(Compute("developer", "enveloped"));
    }
}
