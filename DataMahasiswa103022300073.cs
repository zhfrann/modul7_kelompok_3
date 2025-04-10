using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

class DataMahasiswa103022300073
{
    public String firstName { get; set; }
    public String lastName { get; set; }
    public String gender { get; set; }
    public int age { get; set; }
    public Address address { get; set; }
    public List<Course> courses { get; set; }


    public static void ReadJson()
    {

        string jsonString = File.ReadAllText("./jurnal7_1_103022300073.json");
        DataMahasiswa103022300073 data = JsonSerializer.Deserialize<DataMahasiswa103022300073>(jsonString);
        Console.WriteLine("First Name: " + data.firstName);
        Console.WriteLine("Last Name: " + data.lastName);
        Console.WriteLine("Gender: "+data.gender);
        Console.WriteLine("Age: " + data.age);
        Console.WriteLine("Street Address: " + data.address.streetAddress+ " city: "+ data.address.city + " state: "+ data.address.state);
        Console.WriteLine("Courses: ");
        for (int i = 0; i < data.courses.Count; i++)
        {
            Console.WriteLine("Course Code: " + data.courses[i].code + " Course Name: " + data.courses[i].name);
        }

    }
}

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
