class OneDimentioal
{
    public int[] Masiv;
    public OneDimentioal(int n)
    {
        Console.WriteLine("Введите количество элементов в массиве");
        int len = int.Parse(Console.ReadLine());
        int[] array = new int[len];
        if (n == 1)
        {
            Random r = new Random();
            for (int i = 0; i < len; i++)
            {
                array[i] = r.Next(-200, 200);
            }
        }
        else
        {

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Введите " + (i + 1) + "-й элемент массива");
                array[i] = int.Parse(Console.ReadLine());
            }

        }
        this.Masiv = array;
    }
    public OneDimentioal(int[] n) //конструктор для задач с удалением
    {
        this.Masiv = n;
    }
    public void WriteArray()
    {
        for (int i = 0; i < Masiv.Length; i++)
        {
            Console.Write(Masiv[i] + " ");
        }
        Console.WriteLine();
    }
    public double AVG()
    {
        int summ = 0;
        for (int i = 0; i < Masiv.Length; i++)
        {
            summ += Masiv[i];
        }
        double avg = (double)summ / (double)Masiv.Length;
        return avg;
    }
    public int[] deleteBig()
    {
        int len = Masiv.Length;
        for (int i = 0; i < len; i++)
        {
            if (Masiv[i] > 100 || Masiv[i] < -100)
            {
                int l = i;
                while (l < len - 1)
                {
                    Masiv[l] = Masiv[l + 1];
                    l += 1;
                }
                len -= 1;
                i -= 1;
            }
        }
        int[] newArr = new int[len];
        for (int i = 0; i < len; i++)
        {
            newArr[i] = Masiv[i];
        }
        return newArr;
    }
    public int[] doUniq()
    {
        int counter = 0;
        int[] uniqs = new int[Masiv.Length];
        for (int i = 0; i < Masiv.Length; i++)
        {
            uniqs[i] = -10000;
        }
        for (int i = 0; i < Masiv.Length; i++)
        {
            bool flag = true;
            for (int j = 0; j < uniqs.Length; j++)
            {
                if (uniqs[j] == Masiv[i])
                {
                    flag = false;
                }
            }
            if (flag)
            {
                uniqs[counter] = Masiv[i];
                counter++;
            }
        }//uniqs - все уникальные значения из arr
        int[] answer = new int[counter];
        for (int i = 0; i < answer.Length; i++)
        {
            answer[i] = uniqs[i];
        }
        return answer;
    }
}