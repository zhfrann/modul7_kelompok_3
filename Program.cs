// See https://aka.ms/new-console-template for more information
using System;
using modul7_kelompok_3;

class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa103022300093.ReadJSON();
        TeamMembers103022300093.ReadJSON();
        GlossaryItem103022300093.ReadJSON();
      
        DataMahasiswa103022300057.ReadJSON("jurnal7_1_103022300057.json");
        TeamMembers103022300057.ReadJSON("jurnal7_2_103022300057.json");
        GlossaryItem103022300057.ReadJSON("jurnal7_3_103022300057.json");
    }
}