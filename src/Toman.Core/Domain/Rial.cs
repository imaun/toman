using System;
using System.Linq;

namespace Toman;

/// <summary>
/// Iranian Rial. The Official currency for Iran (IRR).
/// </summary>
public class Rial : IEquatable<Rial>
{
    
    
    public bool Equals(Rial? other)
    {
        throw new NotImplementedException();
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Rial)obj);
    }

    public override int GetHashCode()
    {
        throw new NotImplementedException();
    }
}