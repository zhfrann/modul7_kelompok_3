namespace modul7_kelompok_3;
using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

public class TeamMember
{
   public string NIM { get; set; }
   public string Nama { get; set; }
   public int Umur { get; set; }
   public string JenisKelamin { get; set; }
}

public class TeamMembers103022300093
{
   public List<TeamMember> TeamMembers { get; set; }

   public static void ReadJSON()
   {
      string jsonString = File.ReadAllText("jurnal7_2_103022300093.json");
      var data = JsonSerializer.Deserialize<TeamMembers103022300093>(jsonString);
      Console.WriteLine("Team Member List");
      foreach (var member in data.TeamMembers)
      {
         Console.WriteLine($"{member.NIM} - {member.Nama} - {member.Umur} - {member.JenisKelamin}");
      }
   }
}