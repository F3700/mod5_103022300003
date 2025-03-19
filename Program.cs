// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class PemrosesData
{
    public T DapatkanNilaiTerbesar<T>(T a, T b, T c)
    {
        dynamic a1 = a;
        dynamic b1 = b;
        dynamic c1 = c;
        dynamic maks = a1;
        if (maks < b1)
        {
            maks = b1;
        }
        if (maks < c1) {
            maks = c1;
        }
        return maks;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Angka 1: ");
        double aa = double.Parse(Console.ReadLine());
        Console.WriteLine("Angka 2: ");
        double bb = double.Parse(Console.ReadLine());
        Console.WriteLine("Angka 3: ");
        double cc = double.Parse(Console.ReadLine());

        PemrosesData prosesData = new PemrosesData();
        double hasil = prosesData.DapatkanNilaiTerbesar(aa, bb, cc);
        Console.WriteLine("Nilai Terbesar adalah : " + hasil);
    }
}

