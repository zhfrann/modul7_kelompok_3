using System.Text.Json;

class Member
{
    public String firstName { get; set; }
    public String lastName { get; set; }
    public String gender { get; set; }
    public int age { get; set; }
    public String nim { get; set; }
}

class TeamMembers103022330008
{
    public List<Member> members { get; set; }

    public static void ReadJSON()
    {
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "jurnal7_2_103022330008.json");
        string jsonString = File.ReadAllText(filePath);

        TeamMembers103022330008 data = JsonSerializer.Deserialize<TeamMembers103022330008>(jsonString);

        Console.WriteLine("Team member list:");
        foreach (var member in data.members)
        {
            Console.WriteLine($"{member.nim} {member.firstName} {member.lastName} ({member.age})");
        }
    }
}

