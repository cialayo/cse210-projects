public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        string writingInformation = $"{base.GetSummary()}\n{_title} by {base._studentName}";
        return writingInformation;
    }
}
