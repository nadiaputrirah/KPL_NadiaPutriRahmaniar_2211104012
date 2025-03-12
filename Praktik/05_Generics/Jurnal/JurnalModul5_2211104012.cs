using System;

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

class JurnalModul5_2211104012
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
    }
}