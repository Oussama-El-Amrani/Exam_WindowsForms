namespace Exam_WindowsForms.Model;

public class Exam
{
    public long Id { get; set; }
    public string Nom { get; set; }
    public DateTime DateDebut { get; set; }
    public int Duree { get; set; }
    public List<QuestionChoixMultiple> QuestionChoixMultiples;
    public List<QuestionOuverte> QuestionOuverte;
}