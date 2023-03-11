using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    public class Boss : Employe
    {
       
        public static double ChiffreAffaires { get; set; }
        public double Pourcentage { get; set; }

        public Boss(int matricule, string nom, string prenom, DateTime dateNaissance, double pourcentage) : base(matricule, nom, prenom, dateNaissance)
        {
            Pourcentage = pourcentage;
        }
        public override string ToString() =>  $"Boss - {base.ToString()}, Pourcentage: {Pourcentage}";
        

        public override double Salaire
        {
            get
            {
                return ChiffreAffaires * Pourcentage / 100;
            }
        }
    }
}
