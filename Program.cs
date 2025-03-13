



class Program
{
    static int Faktorial(int num)
    {
        int hasil = 1;
        for (int i = 1; i <= num; i++)
        {
            hasil *= i;
        }
        return hasil;
    }

    static void Main()
    {
        int num = 10;
        int cavab = Faktorial(num);
        Console.WriteLine(cavab);
    }
}





