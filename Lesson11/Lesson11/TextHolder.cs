using Lesson11;

internal class TextHolder
{
    private string _text;

    
    public string Text
    {
        get => _text;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new EmptyStringException("Ошибка: Пустая строка недопустима!");
            }
            _text = value;
        }
    }

        
    public TextHolder(string text)
    {
        Text = text; 
    }
}

