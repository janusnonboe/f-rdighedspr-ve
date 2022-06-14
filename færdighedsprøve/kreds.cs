using System;
using System.Collections.Generic;
using System.Text;

namespace færdighedsprøve
{
    public class Kreds
    {
        public string ID { get; set; }
        public string Navn { get; set; }
        public string Adresse { get; set; }
        public int AntalDeltager { get; set; }
        //public Kreds()
       public Kreds(string ID, string Navn, string Adresse, int AntalDeltagere)
        {
            this.ID = ID;
            this.Navn = Navn;
            this.Adresse = Adresse;
            this.AntalDeltager = AntalDeltagere;
        }
        public override string ToString() { return $"Kreds ID {ID}.  adressen {Adresse}  kreds {Navn} antaldeltagere {AntalDeltager}"; }
        
       
   
    }

     //   public static Dictionary<int, string> mydictionary = new Dictionary<int, string>();
   // { 1, "Roskilde" }
    //{ 2, "Osted"}
    //{ 3, "Århus" }
    

 

}
