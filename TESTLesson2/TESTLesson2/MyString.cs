public class MyString
{
    public char[] _chars;  
    public MyString()
    {
        _chars = new char[0];
    }  
    public MyString(string str)
    {
        _chars = str.ToCharArray();
    }   
    public MyString(char[] chars)
    {
        _chars = new char[chars.Length];
        Array.Copy(chars, _chars, chars.Length);
    }  
    public MyString(MyString other)
    {
        _chars = new char[other.Length];
        Array.Copy(other._chars, _chars, other.Length);
    }    
    public int Length => _chars.Length;   
    public void Reverse()
    {
        Array.Reverse(_chars);
    }   
    public override string ToString()
    {
        return new string(_chars);
    }   
    public char this[int index]
    {
        get => _chars[index];
        set => _chars[index] = value;
    }
}

