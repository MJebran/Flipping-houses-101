// using System;
// using System.IO;
// using System.Collections.Generic;

// using System.Text.Json;

// namespace FlippingProperty;

// //TODO make it like it gets search result from HouseModel.cs


// public class TextToFileWritere
// {
//     ///////
//     public static List<HouseModel> HouseModels { get; set; }
//     public static void LoudHouse()
//     {
//         if (File.Exists(""))// pass the json file path
//         {
//             var json = File.ReadAllText("houseModels.json");// pass the json file path
            
//         }

//     }
//     // var json = JsonSerializer.Serialize(houseModels);
//     // File.WriteAllText("houseModels.json", json);
//     //     var newListOfHouseModels = JsonSerializer.Deserialize<List<HouseModel>>(json);

//     ////////


//     // public static void TextToFileWritereMethod(HouseModel ApiCallResult)
//     // {

//     //     //Console.WriteLine("to exit press \"x\"");
//     //     var allLines = File.ReadAllLines("apiCallResult.txt");
//     //     //var textReader = new StreamReader("apiCallResult.txt");
//     //     var textWriter = new StreamWriter("apiCallResult.txt");
//     //     //textWriter; //TODO should take the api

//     //     foreach (var item in ApiCallResult.metadata)
//     //     {

//     //         textWriter.WriteLine(item);
//     //     }
//     //     foreach (var item in ApiCallResult.address)
//     //     {

//     //         textWriter.WriteLine(item);
//     //     }
//     //     foreach (var item in ApiCallResult.parcel)
//     //     {

//     //         textWriter.WriteLine(item);
//     //     }
//     //     foreach (var item in ApiCallResult.structure)
//     //     {

//     //         textWriter.WriteLine(item);
//     //     }
//     //     foreach (var item in ApiCallResult.owner)
//     //     {

//     //         textWriter.WriteLine(item);
//     //     }
//     //     foreach (var item in ApiCallResult.deed)
//     //     {

//     //         textWriter.WriteLine(item);
//     //     }

//     //     //
//     //     textWriter.Close();

//         ///

//         // if (firstLine == " ")
//         // {
//         //     //var textWriter = new StreamWriter("apiCallResult.txt");
//         //     textWriter.WriteLine("apiCallResult");
//         //     textWriter.Close();
//         // }

//         // while (true)
//         // {
//         //     var list = new List<string>();
//         //     string input = textWriter();

//         //     if (input == "x")
//         //     {
//         //         return;
//         //     }

//         //     list.Add(input);
//         //     File.AppendAllLines("apiCallResult.txt", list);
//         // }
//     }
// }

