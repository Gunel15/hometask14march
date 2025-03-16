



//class Program
//{
//    static int Faktorial(int num)
//    {
//        int hasil = 1;
//        for (int i = 1; i <= num; i++)
//        {
//            hasil *= i;
//        }
//        return hasil;
//    }

//    static void Main()
//    {
//        int num = 10;
//        int cavab = Faktorial(num);
//        Console.WriteLine(cavab);
//    }
//}




class Program
{
    static string TersChevir(string soz)
    {
        string ters = "";
        for (int i = soz.Length - 1; i >= 0; i--)
            ters += soz[i];

        return (ters);
    }
    static void Main()
    {
        string soz = "Gunel";
        string terssoz = TersChevir(soz);
        Console.WriteLine(terssoz);
    }
}








