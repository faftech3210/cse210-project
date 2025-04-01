public class writingassignment : assignment
{
    private string _title;

    public writingassignment(string studentName, string topic, string title) 
        : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritinginfo()
    {
        return $"{_title} by {_studentName}";
    }
    
}