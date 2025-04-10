using System;
using System.Text.Json;
using System.Threading.Tasks;

class TeamMembers103022300073
{
    public List<Member> members { get; set; }

    public static void ReadJson()
    {
        string jsonString = File.ReadAllText("./jurnal7_2_103022300073.json");
        TeamMembers103022300073 data = JsonSerializer.Deserialize<TeamMembers103022300073>(jsonString);
        Console.WriteLine("\n");
        Console.WriteLine("Team Members:");
        for (int i = 0; i< data.members.Count(); i++)
        {
            Console.WriteLine("First Name: " + data.members[i].firstName);
            Console.WriteLine("Last Name: " + data.members[i].lastName);
            Console.WriteLine("Gender: " + data.members[i].gender);
            Console.WriteLine("Age: " + data.members[i].age);
            Console.WriteLine("Nim: " + data.members[i].nim);
            Console.WriteLine("\n");
        }
    }
}

class Member
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public string nim { get; set; }
}
