// See https://aka.ms/new-console-template for more information

using static System.Runtime.InteropServices.JavaScript.JSType;

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
    }
}
