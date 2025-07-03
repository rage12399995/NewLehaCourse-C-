class Program
{
    static void Main()
    {
       
        MyString str1 = new MyString();                
        MyString str2 = new MyString("What a wonderful day!");   
        MyString str3 = new MyString(new char[] { 'a', 'b', 'c' }); 
        MyString str4 = new MyString(str2);             

        Console.WriteLine("До реверса:");
        Console.WriteLine(str2.ToString());
  
        str2.Reverse();

        Console.WriteLine("После реверса:");
        Console.WriteLine(str2.ToString());
    }
}