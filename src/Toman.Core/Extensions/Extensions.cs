using System;
using System.Linq;

namespace Toman.Extensions;

internal static class Extensions
{

    public static bool IsNullOrEmpty(this string value)
    {
        return string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value);
    }
    
    public static void ThrowIfArgumentIsNull(this object obj, string name = "")
    {
        if (name.IsNullOrEmpty()) name = nameof(obj);

        if (obj is null)
            throw new ArgumentNullException(name);
    }

    public static void ThrowIfReferenceIsNull(this object obj, string name = "")
    {
        if (name.IsNullOrEmpty()) name = nameof(obj);

        if (obj is null)
            throw new NullReferenceException(name);
    }
    
    public static bool IsNumeric(this string str) 
    {
        if (str.IsNullOrEmpty())
            throw new ArgumentNullException(nameof(str));

        return str.All(char.IsDigit);
    }
}