public partial class Solution
{
    public static int[,] SumOfMatrix(int[,] matrix1, int[,] matrix2)
    {
        int[,] matrix3 = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                matrix3[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return matrix3;
    }

    public static int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
    {
        if (matrix1.GetLength(1) != matrix2.GetLength(0)) return new int[,] { };
        int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

        for (int i = 0; i < resultMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                int[] Row = row(matrix1, i);
                int[] Column = column(matrix2, j);
                resultMatrix[i, j] = Num(Row, Column);
            }
        }
        return resultMatrix;
    }
    private static int[] row(int[,] matrix, int num)
    {
        int[] Rows = new int[matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            Rows[i] = matrix[num, i];
        }
        return Rows;
    }
    private static int[] column(int[,] matrix, int num)
    {
        int[] Columns = new int[matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Columns[i] = matrix[i, num];
        }
        return Columns;
    }
    private static int Num(int[] row, int[] col)
    {
        int num = 0;
        for (int i = 0; i < row.Length; i++)
        {
            num += row[i] * col[i];
        }
        return num;
    }

    public static int Trace(int[,] matrix)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1)) return -1;
        int sum = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, i];
        }

        return sum;
    }
    public static int[,] HandoverMatrix(int[,] matrix)
    {
        int[,] resultMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                resultMatrix[j, i] = matrix[i, j];
            }
        }
        return resultMatrix;
    }
    public static bool IsSymmetry(int[,] matrix)
    {
        bool isSymmetry = true;
        int val = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = val; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] != matrix[j, i]) return false;
            }
            val++;
        }
        return isSymmetry;
    }
    public static int[,] Cero(int[,] matrix)
    {
        List<(int, int)> CoordinateCeros = new List<(int, int)>();

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0) CoordinateCeros.Add((i, j));
            }
        }

        for (int i = 0; i < CoordinateCeros.Count; i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[CoordinateCeros[i].Item1, j] = 0;
            }
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                matrix[j, CoordinateCeros[i].Item2] = 0;
            }
        }
        return matrix;
    }

    public static int[] Spiral(int[,] matrix)
    {
        if (matrix.GetLength(0) * matrix.GetLength(1) < 0) return new int[] { };

        int[] arr = new int[matrix.GetLength(0) * matrix.GetLength(1)];

       bool[,] mask = new bool[matrix.GetLength(0), matrix.GetLength(1)];

        (int, int)[] direction = { (0, 1), (1, 0), (0, -1), (-1, 0) };

        int x = 0, y = 0;
        int pos = 0;
        arr[0]=matrix[0,0];
        mask[0,0]=true;
        for (int i = 1; i < arr.Length; i++)
        {
            x += direction[pos].Item1;
            y += direction[pos].Item2;
           if(x>=matrix.GetLength(0))
           {
            x-=1;
            pos=++pos%4;
            y += direction[pos].Item2;
           }
           if(y>=matrix.GetLength(1))
           {
             y-=1;
             pos=++pos%4;
             x+=direction[pos].Item1;
           } 
           if(y<0)
           {
            y=0;
            pos=++pos%4;
            x+=direction[pos].Item1;
           }
           if(x<0)
           {
            x=0;
            pos=++pos%4;
            y+=direction[pos].Item2;
           }
            if (mask[x, y])
            {
                pos=++pos%4;
                x += direction[pos].Item1;
                y += direction[pos].Item2;
            }
            mask[x,y]=true;
            arr[i] = matrix[x, y];
        }
        return arr;
    }
}