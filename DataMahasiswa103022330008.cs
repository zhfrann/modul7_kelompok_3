using System.Text.Json;

class Address
{
    public String streetAddress { get; set; }
    public String city { get; set; }
    public String state { get; set; }
}

class Course
{
    public String code { get; set; }
    public String name { get; set; }
}

class DataMahasiswa103022330008
{
    public String firstName { get; set; }
    public String lastName { get; set; }
    public String gender { get; set; }
    public int age { get; set; }
    public Address address { get; set; }
    public List<Course> courses { get; set; }

    public static void ReadJSON()
    {
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "jurnal7_1_103022330008.json");
        string jsonString = File.ReadAllText(filePath);
        
        DataMahasiswa103022330008 data = JsonSerializer.Deserialize<DataMahasiswa103022330008>(jsonString);

        Console.WriteLine("First Name: " + data.firstName);
        Console.WriteLine("Last Name: " + data.lastName);
        Console.WriteLine("Gender: " + data.gender);
        Console.WriteLine("Age: " + data.age);
        Console.WriteLine("Street Address: " + data.address.streetAddress);
        Console.WriteLine("City: " + data.address.city);
        Console.WriteLine("State: " + data.address.state);

        Console.WriteLine("Daftar mata kuliah yang diambil:");
        for (int i = 0; i < data.courses.Count; i++)
        {
            Console.WriteLine($"MK {i + 1} {data.courses[i].code} - {data.courses[i].name}");
        }
    }
}
