namespace Exam_WindowsForms.Model;

public class QuestionOuverte: Question
{
    public Exam Exam { get; set; }
    public string Reponse { get; set; }
}