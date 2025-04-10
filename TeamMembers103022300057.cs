using System.Text.Json;

class TeamMembers103022300057
{
    public Members[] members { get; set; }
    public class Members
    {
        public string firstName;
        public string lastName;
        public string gender;
        public int age;
        public string nim;
    }

    public static void ReadJSON(string fileName)
    {
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
        string jsonString = File.ReadAllText(filePath);

        TeamMembers103022300057 Data = JsonSerializer.Deserialize<TeamMembers103022300057>(jsonString);

        Console.WriteLine("Team Members:");
        Console.WriteLine("====================================");
        foreach (var member in Data.members)
        {
            Console.WriteLine($"{member.nim} {member.firstName} {member.lastName} ({member.age} {member.gender})");
        }

    }
}
