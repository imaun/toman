using System;
using System.ComponentModel.Design;

namespace Toman;

/// <summary>
/// Iranian Rial. The Official currency for Iran (IRR).
/// </summary>
public class Rial : IEquatable<Rial>
{

    /// <summary>
    /// Creates a Rial object that holds a long integer value representing the amount in this currency.
    /// </summary>
    /// <param name="value"></param>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public Rial(long value)
    {
        if (value < 0) 
            throw new ArgumentOutOfRangeException("Cannot instantinate Rial which has negative value.");
        
        Value = value;
    }
    
    /// <summary>
    /// Amount value in Rial currency.
    /// </summary>
    public long Value { get; private set; }


    /// <summary>
    /// Converts the value in Rial to Toman.
    /// </summary>
    /// <returns>The current value in Toman.</returns>
    public long InToman()
    {
        decimal divide = Value / 10;
        return Convert.ToInt64(Math.Floor(divide));
    }
    
    
    public bool Equals(Rial? other)
    {
        if (other is null || other.GetType() != this.GetType())
            return false;

        return this.Value == other.Value;
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
        return Value.GetHashCode();
    }
}