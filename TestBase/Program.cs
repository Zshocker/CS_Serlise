using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Etudiant etudiant = new Etudiant("Hicham", "R1332045");
            etudiant.Save_ToBase(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Etdiant;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
