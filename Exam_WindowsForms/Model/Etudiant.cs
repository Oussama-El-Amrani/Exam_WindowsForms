namespace Exam_WindowsForms.Model;

public class Etudiant
{
    public long Id { get; set; }
    public string NomCompet { get; set; }
    public string Cne { get; set; }
    public Dictionary<string,double> ExamsNote { get; set; }
}