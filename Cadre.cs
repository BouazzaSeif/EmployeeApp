

namespace EmployeeApp
{
    public class Cadre : Employe
    {
        
        public int Indice { get; set; }

        public Cadre(int matricule, string nom, string prenom, DateTime dateNaissance, int indice) : base(matricule, nom, prenom, dateNaissance)
        {
            Indice = indice;
        }

        public override string ToString() => $"Cadre - {base.ToString()}, Indice: {Indice}";

        public override double Salaire
        {
            get
            {
                switch (Indice)
                {
                    case 1:
                        return 1300;
                    case 2:
                        return 1500;
                    case 3:
                        return 1700;
                    case 4:
                        return 2000;
                    default:
                        return 0;
                }
            }
        }
    }
}
