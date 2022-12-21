using System.Globalization;
using System.Collections.Generic;



List<string> list = new List<string>();

list.Add("1");
list.Add("2");
list.Add("3");
list.Add("4");
list.Add("5");
list.Add("6");
list.Add("7");

list.Insert(2, "Olá, Mundo");

foreach(string x in list){
    Console.WriteLine(x);
}
Console.WriteLine(list.Count);
