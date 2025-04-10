using System.Text.Json;

class GlossDef
{
    public String para { get; set; }
    public List<String> GlossSeeAlso { get; set; }
}

class GlossEntry
{
    public String ID { get; set; }
    public String SortAs { get; set; }
    public String GlossTerm { get; set; }
    public String Acronym { get; set; }
    public String Abbrev { get; set; }
    public GlossDef GlossDef { get; set; }
    public String GlossSee { get; set; }
}

class GlossList
{
    public GlossEntry GlossEntry { get; set; }
}

class GlossDiv
{
    public String title { get; set; }
    public GlossList GlossList { get; set; }
}

class Glossary
{
    public String title { get; set; }
    public GlossDiv GlossDiv { get; set; }
}

class GlossaryItem103022330008
{
    public Glossary glossary { get; set; }

    public static void ReadJSON()
    {
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "jurnal7_3_103022330008.json");
        string jsonString = File.ReadAllText(filePath);

        GlossaryItem103022330008 data = JsonSerializer.Deserialize<GlossaryItem103022330008>(jsonString);

        GlossEntry glossEntry = data.glossary.GlossDiv.GlossList.GlossEntry;
        Console.WriteLine("Glossary Entry: ");

        Console.WriteLine($"ID: {glossEntry.ID}");
        Console.WriteLine($"SortAs: {glossEntry.SortAs}");
        Console.WriteLine($"GlossTerm: {glossEntry.GlossTerm}");
        Console.WriteLine($"Acronym: {glossEntry.Acronym}");
        Console.WriteLine($"Abbrev: {glossEntry.Abbrev}");

        Console.WriteLine($"GlossDef.para: {glossEntry.GlossDef.para}");
        Console.Write("GlossDef.GlossSeeAlso: ");
        foreach (var item in glossEntry.GlossDef.GlossSeeAlso)
        {
            Console.Write($"{item}, ");
        }

        Console.WriteLine($"GlossSee: {glossEntry.GlossSee}");
    }
}