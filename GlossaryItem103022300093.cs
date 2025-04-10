using System;
using System.IO;
using System.Text.Json;

public class Glossary
{
    public GlossEntry GlossEntry { get; set; }
}

public class GlossaryItem103022300093
{
    public static void ReadJSON()
    {
        string json = File.ReadAllText("jurnal7_3_103022300093.json");
        var root = JsonSerializer.Deserialize<Dictionary<string, Glossary>>(json);
        var entry = root["glossary"].GlossEntry;

        Console.WriteLine("GlossEntry:");
        Console.WriteLine($"ID: {entry.ID}");
        Console.WriteLine($"SortAs: {entry.SortAs}");
        Console.WriteLine($"GlossTerm: {entry.GlossTerm}");
        Console.WriteLine($"Acronym: {entry.Acronym}");
        Console.WriteLine($"Abbrev: {entry.Abbrev}");
        Console.WriteLine($"GlossDef: {entry.GlossDef.Para}");
        Console.WriteLine($"GlossSee: {entry.GlossSee}");
    }
}

public class GlossEntry
{
    public string ID { get; set; }
    public string SortAs { get; set; }
    public string GlossTerm { get; set; }
    public string Acronym { get; set; }
    public string Abbrev { get; set; }
    public GlossDef GlossDef { get; set; }
    public string GlossSee { get; set; }
}

public class GlossDef
{
    public string Para { get; set; }
    public List<string> GlossSeeAlso { get; set; }
}