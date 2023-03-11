
namespace EmployeeApp
{
    public abstract class Employe
    {
        public int Matricule { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }

        public Employe(int matricule, string nom, string prenom, DateTime dateNaissance)
        {
            Matricule = matricule;
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
        }

        public override string ToString()
        {
            return $"Matricule: {Matricule}, Nom: {Nom}, Prénom: {Prenom}, Date de naissance: {DateNaissance.ToShortDateString()}";
        }

        public abstract double Salaire { get; }
    }

}
