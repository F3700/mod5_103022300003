// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
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

public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDate;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDate = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        this.storedData.Add(data);
        this.inputDate.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data " + i+1 + " berisi: " + storedData[i] + " yang disimpan pada waktu" + inputDate[i]);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        SimpleDataBase<double> sdb = new SimpleDataBase<double>();

        Console.WriteLine("Masukan 1: ");
        double aa = double.Parse(Console.ReadLine());
        sdb.AddNewData(aa);
        Console.WriteLine("Masukan 2: ");
        double bb = double.Parse(Console.ReadLine());
        sdb.AddNewData(bb);
        Console.WriteLine("Masukan 3: ");
        double cc = double.Parse(Console.ReadLine());
        sdb.AddNewData(cc);

        sdb.PrintAllData();

        Console.WriteLine("Angka 1: ");
        double aa1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Angka 2: ");
        double bb1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Angka 3: ");
        double cc1 = double.Parse(Console.ReadLine());

        PemrosesData prosesData = new PemrosesData();
        double hasil = prosesData.DapatkanNilaiTerbesar(aa1, bb1, cc1);
        Console.WriteLine("Nilai Terbesar adalah : " + hasil);
    }
}
