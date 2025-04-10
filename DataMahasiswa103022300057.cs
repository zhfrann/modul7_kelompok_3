using System.Text.Json;

class DataMahasiswa103022300057
    {
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public Address address { get; set; }
    public Courses[] courses { get; set; }

    public class Address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }

    public class Courses
    {
        public string code { get; set; }
        public string name { get; set; }
    }
    public static void ReadJSON(string fileName)
    {
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
        string jsonString = File.ReadAllText(filePath); DataMahasiswa103022300057 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa103022300057>(jsonString);
        Console.WriteLine($"Nama {mahasiswa.firstName} {mahasiswa.lastName} dengan jenis kelamin {mahasiswa.gender} umur {mahasiswa.age}");
        Console.WriteLine($"Alamat di {mahasiswa.address.streetAddress}, {mahasiswa.address.city}, {mahasiswa.address.state}");
        Console.WriteLine("Mata Kuliah yang diambil:");
        Console.WriteLine("--------------------------------------------------");
        foreach (var course in mahasiswa.courses)
        {
            Console.WriteLine($"Kode: {course.code}, Nama: {course.name}");
        }
    }
}
