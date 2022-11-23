namespace Exam_WindowsForms.Model;

public class Professeur
{
    public long Id { get; set; }
    public string NomCompet { get; set; }
    public string Email { get; set; }
    public List<Exam> Exam { get; set; }
}