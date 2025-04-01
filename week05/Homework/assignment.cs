public class assignment{
    protected private string _studentName;
    protected private string _topic;

    public assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return ($"The student name is {_studentName} and the topic is {_topic}");
    }
}