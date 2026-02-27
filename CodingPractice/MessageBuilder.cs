public class MessageBuilder
{
    private string _message;

    public MessageBuilder AddText(string text)
    {
        _message += text;
        return this;
    }

    public MessageBuilder AddSpace()
    {
        _message += " ";
        return this;
    }

    public MessageBuilder AddNewLine()
    {
        _message += "\n"; 
        return this;
    }

    public string Build()
    {
        return _message;
    }
}