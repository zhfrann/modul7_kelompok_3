using System.Text.Json;

namespace modul7_kelompok_3;

public class DataMahasiswa103022300093
{
    public string NIM { get; set; }
    public string Nama { get; set; }
    public int Umur { get; set; }

    public static void ReadJSON()
    {
        var json = File.ReadAllText(@"jurnal7_1_103022300093.json");
        var data = JsonSerializer.Deserialize<DataMahasiswa103022300093>(json);
        Console.WriteLine($"NIM: {data.NIM}, Nama: {data.Nama}, Umur: {data.Umur}");
    }
}
