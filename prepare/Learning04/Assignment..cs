public class Assignment
{
    protected string _name = " ";
    protected string _topic = " ";

    public string GetName()
    {
        return _name;
    }


    public void SetName(string name)
    {
        _name = name;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public void SetTopic(string topic)
    {
        _topic = topic;
    }


    public string GetSummary()
    {
        return $"{_name} - {_topic}";
    }
}