public class Person
{


public string Name { get; set; }

public int Age { get; set; }

public override string ToString()
{
return $"Name: {Name}, Age: {Age}";
}

public override bool Equals(object? obj)
{
if (obj == null)
{
    return false;
}

if (ReferenceEquals(this, obj))
{
    return true;
}

if (obj is Person other)
{
    return other.Name == Name && other.Age == Age;
}

return false;
}

public static bool operator ==(Person a, Person b)
{
if (a.Name == b.Name && a.Age == b.Age)
{
    return true;
}

return false;
}

public static bool operator !=(Person a, Person b)
{
if (a.Name != b.Name || a.Age != b.Age)
{
    return true;
}

return false;
}
public override int GetHashCode()
{
unchecked
{
    int hash = 17;
    hash = hash * 23 + (Name?.GetHashCode() ?? 0);
    hash = hash * 23 + Age.GetHashCode();
    return hash;
}
}


public static bool operator <(Person a, Person b)
{
if (a is null || b is null)
    return false;

int nameComparison = string.Compare(a.Name, b.Name, StringComparison.Ordinal);
if (nameComparison < 0)
    return true;
if (nameComparison > 0)
    return false;

return a.Age < b.Age;
}


public static bool operator >(Person a, Person b)
{
if (a is null || b is null)
    return false;

int nameComparison = string.Compare(a.Name, b.Name, StringComparison.Ordinal);
if (nameComparison > 0)
    return true;
if (nameComparison < 0)
    return false;

return a.Age > b.Age;
}
}


