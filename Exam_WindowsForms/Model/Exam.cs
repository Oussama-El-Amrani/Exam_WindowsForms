namespace Exam_WindowsForms.Model;

public class Exam
{
    public long ExamId { get; set; }
    public string Nom { get; set; }
    
    public DateTime DateDebut { get; set; }
    
    public int Duree { get; set; }
    //
    public Professeur Professeur;
    // Relation many-to-many avec la classe etudiant
    public List<Etudiant> Etudiants { get; set; }
    //
    public List<QuestionChoixMultiple> QuestionChoixMultiples;
    //
    public List<QuestionOuverte> QuestionOuvertes { get; set; }

}