public class mathassignment : assignment
{
    private string _textBookSection;
    private string _problem;

    public mathassignment(string studentName, string topic, string textBookSection, string problem) : base(studentName, topic)
    {
        _textBookSection = textBookSection;
        _problem = problem;
    }

    public string GetHomeWorkList()
    {
        return $"Section is {_textBookSection} and problem is {_problem}"; 
    }
}