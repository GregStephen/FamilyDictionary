using System;
using System.Collections.Generic;

namespace FamilyDictionaryExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("sister", new Dictionary<string, string>() { { "name", "Bri" }, { "age", "36" } });
            myFamily.Add("brother", new Dictionary<string, string>() { { "name", "Thomas" }, { "age", "35" } });
            myFamily.Add("father", new Dictionary<string, string>() { { "name", "Tom" }, { "age", "64" } });
            myFamily.Add("mother", new Dictionary<string, string>() { { "name", "Susan" }, { "age", "unknown!" } });
            myFamily.Add("wife", new Dictionary<string, string>() { { "name", "Whitney" }, { "age", "28" } });

            foreach(var (familyMember, info) in myFamily)
            {
                var name = "";
                var age = "";
                foreach(var (key, value) in info)
                {
                    if(key == "name")
                    {
                        name = value;
                    }
                    else
                    {
                        age = value;
                    }
                }
                Console.WriteLine($"{name} is my {familyMember} and is {age} years old");
            }

        }
    }
}
