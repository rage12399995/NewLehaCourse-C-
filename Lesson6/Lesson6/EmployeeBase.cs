public abstract class EmployeeBase
{
    private string name;
    private string position;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Position
    {
        get { return position; }
        set { position = value; }
    }

    protected EmployeeBase(string name, string position)
    {
        this.name = name;
        this.position = position;
    }

    public abstract string GetDetails();
}