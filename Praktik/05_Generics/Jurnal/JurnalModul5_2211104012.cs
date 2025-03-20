using System;
using System.Collections.Generic;

class Penjumlahan
{
    public T JumlahTigaAngka<T>(T a, T b, T c) where T : struct, IConvertible
    {
        dynamic num1 = a;
        dynamic num2 = b;
        dynamic num3 = c;
        return (T)(num1 + num2 + num3);
    }
}

class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.UtcNow);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpan pada waktu UTC: {inputDates[i]}");
        }
    }
}

class Program
{
    static void Main()
    {
        Penjumlahan penjumlahan = new Penjumlahan();

        // NIM: 2211104012 → Input angka: 12, 40, 12 (Tipe data float)
        float angka1 = 12.0f;
        float angka2 = 40.0f;
        float angka3 = 12.0f;

        var hasil = penjumlahan.JumlahTigaAngka(angka1, angka2, angka3);
        Console.WriteLine("Hasil penjumlahan: " + hasil);

        // Implementasi SimpleDataBase
        SimpleDataBase<float> database = new SimpleDataBase<float>();
        database.AddNewData(angka1);
        database.AddNewData(angka2);
        database.AddNewData(angka3);

        database.PrintAllData();
    }
}
