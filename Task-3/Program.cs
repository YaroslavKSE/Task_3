using System;
using System.IO;
using Task_3;

bool valid = true;
var dict = new StringsDictionary();

foreach (var element in File.ReadAllLines(@"C:\C#\Task_3\dictionary.txt.txt"))
{
        var letter = element.Split(new[] {";"}, StringSplitOptions.None)[0];
        string definition;
        if (element.Contains("Defn: "))
        {
            definition = element.Split(new[] {"Defn: "}, StringSplitOptions.None)[1];
        }
        else
        {
            definition = element.Split(new[] {"; "}, StringSplitOptions.None)[1];
        }
        dict.Add(letter, definition);
}

while (valid)
{
    Console.WriteLine("To get the definition input word here:");
    string userInput = Console.ReadLine()?.ToUpper();
    Console.WriteLine(dict.Get(userInput));
    Console.WriteLine("Exit[Yes/No]?");
    string end = Console.ReadLine()?.ToUpper();
    if (end == "YES")
    {
        valid = false;
    }
}



            
            
        
    
