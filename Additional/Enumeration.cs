using System;
using System.Linq;

namespace Training
{
    internal static class Enumeration
    {
        public static bool IsEnumerationContains(string str, Type T)
        {
            string[] items = Enum.GetNames(T);

            foreach (var item in items)
            {
                if (str.Contains(item))
                {
                    return true;
                }
            }

            return false;
        }

        public static void PrintAllNames(Type T)
        {
            var values = Enum.GetValues(T);
            int i = 0;

            foreach (var name in Enum.GetNames(T))
            {
                Console.WriteLine($"{(int)values.GetValue(i++)}. {name}");
            }
        }

        public static int Max(Type T)
        {
            return Enum.GetValues(T).Cast<int>().Max();
        }

        public static int Min(Type T)
        {
            return Enum.GetValues(T).Cast<int>().Min();
        }

        public static int GetValueByName(Type T, string name)
        {
            var values = Enum.GetValues(T);
            int i = 0;

            foreach (var _name in Enum.GetNames(T))
            {
                if (_name == name)
                    return (int)values.GetValue(i);

                i++;
            }

            throw new Exception();
        }
    }
}
