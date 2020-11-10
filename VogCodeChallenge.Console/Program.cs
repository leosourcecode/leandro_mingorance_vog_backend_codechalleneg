using System;
using System.Collections.Generic;
using System.Reflection;

namespace VogCodeChallenge.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(QuestionClass);
            FieldInfo info = type.GetField("NamesList", BindingFlags.NonPublic | BindingFlags.Static);
            object namesList = info.GetValue(null);

            foreach (var name in (List<string>)namesList)
            {
                Console.WriteLine(name);
            }
        }

        public static class QuestionClass
        {
            static List<string> NamesList = new List<string>()
            {
                "Jimmy",
                "Jeffrey",
                "John",
            };
        }
    }
}
