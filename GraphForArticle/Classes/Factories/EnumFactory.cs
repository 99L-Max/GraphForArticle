using System;
using System.Linq;

namespace GraphForArticle
{
    static class EnumFactory
    {
        public static string[] GetEnumStrings<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>().Select(value => value.ToString()).ToArray();
        }
    }
}
