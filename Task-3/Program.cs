﻿using System;
using System.IO;
using Task_3;

bool valid = true;
while (valid)
{
    Console.WriteLine("To get the definition input word here:");
    string userInput = Console.ReadLine()?.ToUpper();
    var dict = new StringsDictionary();
    foreach (var element in File.ReadAllLines(@"D:\C#\Task-2\Task-3\dictionary.txt.txt"))
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
    Console.WriteLine(dict.Get(userInput));
    Console.WriteLine("Exit[Yes/No]?");
    string end2 = Console.ReadLine()?.ToUpper();
    if (end2 == "YES")
    {
        valid = false;
    }
}


            
            
        
    
