using System.Collections.Generic;

public class Collections
{
    public void LearnAboutList()
    {
        List<string> names = new List<string>{"Ram", "Hari"};
        names.Add("Alina");
        names.Add("Alina");
        names.Add("Alina");
        names.Add("Alina");
    }

    public void LearnAboutDictationary()
    {
        Dictionary<string, string> countryCapitals = new Dictionary<string, string>
        {
            ["Bhutan"]  = "Thimpu",
            ["China"] = "Beijing"
        };
        countryCapitals.Add("Nepal", "Kathmandu");
        countryCapitals.Add("India", "New Delhi");
        countryCapitals.Add("Russia", "Moscow");
    }
}using System;
using System.IO;
namespace FileDirectoryHandling
{
    public class FileIO
    {
        public void LearnFileReading()
        {
            string fileContent = File.ReadAllText(@"F:\Test.txt");
            Console.WriteLine(fileContent);
        }
         public void LearnFileWriting()
        {
            string fileContent = File.ReadAllText(@"F:\Test.txt");
            File.WriteAllText("A.txt", "I am new file just created.");
        }
    }
}