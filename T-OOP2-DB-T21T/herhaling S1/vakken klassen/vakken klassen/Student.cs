using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vakken_klassen
{
    class Student
    {
        public int StudentNummer { get; set; }
        public string Naam { get; set; }
        public string Adress { get; set; }
        public DateTime GeboorteDatum { get; set; }
        public List<Resultaat> Resultaten { get; set; }

        public Student(int studentnummer, string naam, string adress, DateTime geboortedatum)
        {
            StudentNummer = studentnummer;
            Naam = naam;
            Adress = adress;
            GeboorteDatum = geboortedatum;
            Resultaten = new List<Resultaat>();
        }

        public override string ToString()
        {
            return $"{Naam}";
        }

        public Resultaat Behaald(string vakCode)
        {
            foreach (Resultaat resultaat in Resultaten)
            {
                if (resultaat.Vak.VakCode == vakCode)
                {
                    return resultaat;
                }
            }
            return null;
        }

        public void AddResultaat(Resultaat newResultaat)
        {
            Resultaat resultaat = Behaald(newResultaat.Vak.VakCode);
            if (resultaat == null)
            {
                Resultaten.Add(newResultaat);
            }
            else if (resultaat.Cijfer < newResultaat.Cijfer)
            {
                    resultaat.Cijfer = newResultaat.Cijfer;            
            }
        }

        public int Hoger()
        {
            int Hoogste = 0;
            foreach (Resultaat resultaat in Resultaten)
            {
                if (resultaat.Cijfer > Hoogste)
                {
                    Hoogste = resultaat.Cijfer;
                }
            }
            return Hoogste;
        }

        public int SBU()
        {
            int sbu = 0;
            foreach(Resultaat resultaat in Resultaten)
            {
                if (resultaat.Cijfer >= 6)
                {
                    sbu += resultaat.Vak.SBU;
                }
            }
            return sbu;
        }
    }
}
