public class ListOfScripture
{
    private List<Scripture> _scriptures;


    public ListOfScripture()
    {
        _scriptures = new List<Scripture>();
    }

    
    public void ScriptureAdd(Scripture scripture)
    {
        _scriptures.Add(scripture);
    }

    public List<Scripture> GetScriptures()
    
    {
        return _scriptures;
    }

}