using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Json.Net;
using System.IO;


namespace TestSeri
{
    class Program
    {
        static void Main(string[] args)
        {
            Etudiant Hicham= new Etudiant("Hicham");
            Etudiant Khad= new Etudiant("Khadija");
            Etudiant moh = new Etudiant("Mohamed");
            Etudiant Hiba = new Etudiant("Hiba");
            Etudiant Imane= new Etudiant("Imane");
            Etudiant Hamid= new Etudiant("Amine");
            Etudiant Mehd= new Etudiant("Mehdi");
            Hicham.add_amie(Mehd);
            Hicham.add_amie(moh);
            Hicham.add_amie(Hiba);
            Hicham.add_amie(Khad);
            Hicham.add_amie(Imane);
            Hicham.add_amie(Hamid); 
            File.WriteAllText("Hicham.json", JsonNet.Serialize(Hicham));
            Etudiant copie = JsonNet.Deserialize<Etudiant>(File.ReadAllText("Hicham.json"));
            Console.ReadLine();
        }
    }
}
