namespace Exam_WindowsForms.Model;

public class Etudiant
{
    public long EtudiantId { get; set; }
    public string NomComplet { get; set; }
    public string Cne { get; set; }
    public string Email { get; set; }
    public Dictionary<Exam,double> ExamsNote { get; set; }
}