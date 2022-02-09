using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSeri
{
    class Etudiant
    {
        public string name { get; set; }
        public List<Etudiant> ListAmis { get; set; } 
        public Etudiant(string nam)
        {
            name = nam;
            ListAmis = new List<Etudiant>();
        }
        public Etudiant()
        {
        }
        public void add_amie(Etudiant etudiant)
        {
            ListAmis.Add(etudiant);
        }
    }
}
