using System;
using System.IO;
using Newtonsoft.Json;

namespace TP07
{
    class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    class DataMahasiswa2211104012
    {
        public Nama nama { get; set; }
        public string nim { get; set; }
        public string fakultas { get; set; }

        public static void ReadJSON()
        {
            try
            {
                // Ambil path file JSON di dalam folder proyek
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "tp7_1_2211104012.json");

                // Cek apakah file ada
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("Error: File JSON tidak ditemukan!");
                    return;
                }

                // Baca file JSON
                string jsonData = File.ReadAllText(filePath);

                // Deserialisasi JSON ke objek
                DataMahasiswa2211104012 mahasiswa = JsonConvert.DeserializeObject<DataMahasiswa2211104012>(jsonData);

                // Print hasil deserialisasi
                Console.WriteLine($"Nama: {mahasiswa.nama.depan} {mahasiswa.nama.belakang}");
                Console.WriteLine($"NIM: {mahasiswa.nim}");
                Console.WriteLine($"Fakultas: {mahasiswa.fakultas}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi kesalahan saat membaca JSON: " + ex.Message);
            }
        }
    }
}
