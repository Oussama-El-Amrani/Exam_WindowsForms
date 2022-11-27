namespace Exam_WindowsForms.Model;

public class QuestionChoixMultiple: Question
{
    public Exam Exam { get; set; }
    public List<Proposition> propositions { get; set; }

}