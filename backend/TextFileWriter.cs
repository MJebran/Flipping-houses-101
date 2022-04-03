using System;
using System.IO;
using System.Collections.Generic;

namespace FlippingProperty;

//TODO make it like it gets search result from HouseModel.cs
internal class Program
{


    static void Main(string[] args)//Only one main is to have
    {
        Console.WriteLine("to exit press \"x\"");
        var allLines = File.ReadAllLines("apiCallResult.txt");
        var textReader = new StreamReader("apiCallResult.txt");
        string firstLine = textReader.ReadLine(); //TODO should take the api

        foreach (var item in allLines) 
        {
            Console.WriteLine(item);
        }

        textReader.Close();

        if (firstLine == " ")
        {
            var textWriter = new StreamWriter("apiCallResult.txt");
            textWriter.WriteLine("apiCallResult");
            textWriter.Close();
        }

        while (true)
        {
            var list = new List<string>();
            string input = Console.ReadLine();

            if (input == "x")
            {
                return;
            }

            list.Add(input);
            File.AppendAllLines("apiCallResult.txt", list);
        }
    }
}
