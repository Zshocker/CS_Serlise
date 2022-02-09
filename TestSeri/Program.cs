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
            Etudiant Khad= new Etudiant("etu1");
            Etudiant moh = new Etudiant("etu2");
            Etudiant Hi = new Etudiant("etu3");
            Hicham.add_amie(moh);
            Hicham.add_amie(Hi);
            Hicham.add_amie(Khad);
            string tr = JsonNet.Serialize(Hicham);
            Console.WriteLine(tr);
            File.WriteAllText("Hicham.json",tr);
            Etudiant copie = JsonNet.Deserialize<Etudiant>(File.ReadAllText("Hicham.json"));
            Console.ReadLine();
        }
    }
}
