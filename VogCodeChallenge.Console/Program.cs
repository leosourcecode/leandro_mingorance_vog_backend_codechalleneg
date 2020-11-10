using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
                //Console.WriteLine(name);
            }

            TESTModule(-1);
            TESTModule(0);
            TESTModule(1);
            TESTModule(2);
            TESTModule(3);
            TESTModule(4);
            TESTModule(5);
            TESTModule(1.0f);
            TESTModule(2.0f);
            TESTModule(3.0f);
            TESTModule("s");
            TESTModule(null);
            TESTModule(10.0d);
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

        public static object TESTModule(object obj)
        {
            if (obj == null) return obj;

            switch (Type.GetTypeCode(obj.GetType()))
            {
                case TypeCode.Int32:
                    if((int)obj >= 1 && (int)obj <= 4) return (int)obj * 2;
                    return (int)obj > 4 ? (int)obj * 3 : throw new ValidationException("The input value of the integer type must be greater than 0!");

                case TypeCode.Single:
                    return (float)obj == 1.0f && (float)obj == 2.0f ? 3.0f : obj;

                case TypeCode.String:
                    return ((string)obj).ToUpper();

                default:
                    return obj;

            }
        }
    }
}
