class JaggedArrays
{
    private int[][] jaggedArrays;
    private bool userFilled;

    public JaggedArrays(int rows, int cols, bool userFilled = false)
    {
        jaggedArrays = new int[rows][];
        for (int i = 0; i < rows; i++)
        {
            jaggedArrays[i] = new int[cols];
        }

        this.userFilled = userFilled;
        if (!userFilled)
        {
            FillArrayRandom();
        }
        else
        {
            FillByUser();
        }
    }

    public void FillArrayRandom()
    {
        Random random = new Random();
        for (int i = 0; i < jaggedArrays.Length; i++)
        {
            for (int j = 0; j < jaggedArrays[i].Length; j++)
            {
                jaggedArrays[i][j] = random.Next(100);
            }
        }
    }

    public void FillByUser()
    {
        for (int i = 0; i < jaggedArrays.Length; i++)
        {
            Console.WriteLine($"Введите {jaggedArrays[i].Length} элемента для строки {i + 1} через enter:");
            for (int j = 0; j < jaggedArrays[i].Length; j++)
            {
                jaggedArrays[i][j] = int.Parse(Console.ReadLine());
            }
        }
    }

    public void PrintArray()
    {
        Console.WriteLine("Зубчатый массив:");
        for (int i = 0; i < jaggedArrays.Length; i++)
        {
            for (int j = 0; j < jaggedArrays[i].Length; j++)
            {
                Console.Write(jaggedArrays[i][j] + " ");
            }
            Console.WriteLine();
        }
    }

    public double Average()
    {
        int sum = 0;
        int count = 0;
        for (int i = 0; i < jaggedArrays.Length; i++)
        {
            for (int j = 0; j < jaggedArrays[i].Length; j++)
            {
                sum += jaggedArrays[i][j];
                count++;
            }
        }

        return (double)sum / count;
    }

    public double[] Average2()
    {
        double[] averages = new double[jaggedArrays.Length];
        for (int i = 0; i < jaggedArrays.Length; i++)
        {
            int sum = 0;
            int count = 0;
            for (int j = 0; j < jaggedArrays[i].Length; j++)
            {
                sum += jaggedArrays[i][j];
                count++;
            }

            averages[i] = (double)sum / count;
        }

        return averages;
    }

    public void MultiplyEvenElements()
    {
        for (int i = 0; i < jaggedArrays.Length; i++)
        {
            for (int j = 0; j < jaggedArrays[i].Length; j++)
            {
                if (jaggedArrays[i][j] % 2 == 0)
                {
                    jaggedArrays[i][j] = i * j;
                }
            }
        }
    }
}