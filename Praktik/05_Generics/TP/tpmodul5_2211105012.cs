class HaloGeneric {
    public void SapaUser<T>(T user) {
        Console.WriteLine($"Halo user {user}");
    }
}

class DataGeneric<T> {
    public T Data { get; set; }

    public DataGeneric(T data) {
        Data = data;
    }

    public void PrintData() {
        Console.WriteLine($"Data yang tersimpan adalah: {Data}");
    }
}

class tpmodul5_2211104012
{
    static void Main() {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Praktikan");

        // Menyimpan NIM dalam DataGeneric dan mencetaknya
        DataGeneric<string> nimData = new DataGeneric<string>("2211104012");
        nimData.PrintData();
    }
}