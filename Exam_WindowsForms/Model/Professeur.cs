namespace Exam_WindowsForms.Model;

public class Professeur
{
    public long ProfesseurId { get; set; }
    public string NomComplet { get; set; }
    public string Email { get; set; }
    public string Cne { get; set; }
    public List<Exam> Exams { get; set; }

    public override string ToString()
    {
        return $"ProfesseurId {ProfesseurId} \n" +
               $"NomComplet {NomComplet} \n" +
               $"Email {Email} \n" +
               $"Cne {Cne} \n" +
               $"Exams {Exams} \n";
    }
}