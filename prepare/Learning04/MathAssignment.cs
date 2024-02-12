public class MathAssignment: Assignment 
{
    private string _textBookSection = " ";
    private string _problems = " ";

        public string GetTextBookSection()
    {
        return _textBookSection;
    }


    public void SetTextBookSection(string textbooksection)
    {
        _textBookSection = textbooksection;
    }

    public string GetProblems()
    {
        return _problems;
    }


    public void SetProblems(string problems)
    {
        _problems = problems;
    }

    public string GetHomeWorkList()
    {
        return $"{_name} - {_topic} \nSection {_textBookSection} Problems {_problems}";
    }
}