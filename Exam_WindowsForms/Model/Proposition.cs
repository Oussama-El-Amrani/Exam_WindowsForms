namespace Exam_WindowsForms.Model;

public class Proposition
{
    public long Id { get; set; }
    public bool Vrai { get; set; }
    public string Contenu { get; set; }
    public int Index { get; set; }
    public Certitude Certitude { get; set; }
}