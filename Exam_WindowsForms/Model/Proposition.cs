namespace Exam_WindowsForms.Model;

public class Proposition
{
    public long PropositionId { get; set; }
    public bool Vrai { get; set; }
    public string Contenu { get; set; }
    public QuestionChoixMultiple QCM { get; set; }
    public Certitude Certitude { get; set; }
}