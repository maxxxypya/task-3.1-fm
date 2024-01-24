class Twodimentioal
{
    public int[,] Masiv;
    public Twodimentioal(int[,] a)
    {
        Masiv = a;
    }
    public Twodimentioal(int n)
    {
        Console.WriteLine("Введите количество строк в массиве");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов в массиве");
        int b = int.Parse(Console.ReadLine());
        Masiv = new int[a, b];
        if (n == 1)
        {
            Random r = new Random();
            for (int i = 0; i < Masiv.GetLength(0); i++)
            {
                for (int j = 0; j < Masiv.GetLength(1); j++)
                {
                    Masiv[i, j] = r.Next(-200, 200);
                }
            }
        }
        else
        {
            int count = 1;
            for (int i = 0; i < Masiv.GetLength(0); i++)
            {
                for (int j = 0; j < Masiv.GetLength(1); j++)
                {
                    Console.WriteLine("Введите " + count + "-й элемент массива");
                    Masiv[i, j] = int.Parse(Console.ReadLine());
                    count++;
                }
            }
        }
    }
    public void WriteArray()
    {
        for (int i = 0; i < Masiv.GetLength(0); i++)
        {
            for (int j = 0; j < Masiv.GetLength(1); j++)
            {
                Console.Write(Masiv[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

}