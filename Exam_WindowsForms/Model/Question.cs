namespace Exam_WindowsForms.Model;

public abstract class Question
{
    public long QuestionId { get; set; }
    public string Enonce { get; set; }
    public int nombrePoint { get; set; }
    
}