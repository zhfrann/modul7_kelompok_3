using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;


class GlossaryItem103022300073
{

	public Glossary Glossary { get; set; }

    public static void ReadJson()
    {
        string jsonString = File.ReadAllText("./jurnal7_3_103022300073.json");
        GlossaryItem103022300073 data = JsonSerializer.Deserialize<GlossaryItem103022300073>(jsonString);
        glosEntry entry = data.Glossary.GlossDiv.GlossList.GlossEntry;
        Console.WriteLine("\nGlossary Item:");
        Console.WriteLine("ID: " + data.Glossary.GlossDiv.GlossList.GlossEntry.ID);
        Console.WriteLine("Sort As: " + data.Glossary.GlossDiv.GlossList.GlossEntry.SortAs);
        Console.WriteLine("Gloss Term: " + data.Glossary.GlossDiv.GlossList.GlossEntry.GlossTerm);
        Console.WriteLine("Acronym: " + data.Glossary.GlossDiv.GlossList.GlossEntry.Acronym);
        Console.WriteLine("Abbrev: " + data.Glossary.GlossDiv.GlossList.GlossEntry.Abbrev);
        Console.WriteLine("Gloss Def: " + data.Glossary.GlossDiv.GlossList.GlossEntry.GlossDef.para);
        for (int i = 0; i < data.Glossary.GlossDiv.GlossList.GlossEntry.GlossDef.GlossSeeAlso.Count(); i++)
        {
            Console.WriteLine("Gloss See Also: " + data.Glossary.GlossDiv.GlossList.GlossEntry.GlossDef.GlossSeeAlso[i]);
        }
        Console.WriteLine("Gloss See: " + data.Glossary.GlossDiv.GlossList.GlossEntry.GlossSee);
    }
}

class Glossary
{
    public string title { get; set; }
    public GlossDiv GlossDiv { get; set; }
}

class GlossDiv
{
    public string title { get; set; }
    public GlossList GlossList { get; set; }
}

class GlossList
{
    public glosEntry GlossEntry { get; set; }
}
class glosEntry
{
    public string ID { get; set; }
    public string SortAs { get; set; }
    public string GlossTerm { get; set; }
    public string Acronym { get; set; }
    public string Abbrev { get; set; }
    public GlossDef GlossDef { get; set; }
    public string GlossSee { get; set; }
}

class GlossDef
{
    public string para { get; set; }
    public List<string> GlossSeeAlso { get; set; }
}