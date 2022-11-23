namespace Exam_WindowsForms.Model;

public abstract class Question
{
    public long Id { get; set; }
    public char index { get; }
    public string Enonce { get; set; }

}