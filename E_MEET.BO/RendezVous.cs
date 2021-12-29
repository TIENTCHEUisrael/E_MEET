using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_MEET.BO
{
    public class RendezVous
    {
        public string Id { get; set; }
        public string ClientsNom { get; set; }
        public string HeureDebut { get; set; }
        public string HeureFin { get; set; }
        public int Temps { get; set; }
        public string ChoixPeriodicite1 { get; set; }
        public string ChoixPeriodicite2 { get; set; }
        public string ChoixDeFin { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string Motif { get; set; }

        public RendezVous()
        {

        }
        public RendezVous(string clientNom,string heureDebut, string heureFin, int temps, string choixPeriodicite1, string choixPeriodicite2, string choixDeFin, DateTime dateDebut, DateTime dateFin, string motif,string id)
        {
            ClientsNom = clientNom;
            HeureDebut = heureDebut;
            HeureFin = heureFin;
            Temps = temps;
            ChoixPeriodicite1 = choixPeriodicite1;
            ChoixPeriodicite2 = choixPeriodicite2;
            ChoixDeFin = choixDeFin;
            DateDebut = dateDebut;
            DateFin = dateFin;
            Motif = motif;
            Id = id;
        }
        public RendezVous(RendezVous r):this(r?.ClientsNom,r?.HeureDebut,r?.HeureFin,r?.Temps??30,r?.ChoixPeriodicite1,r?.ChoixPeriodicite2,r?.ChoixDeFin,r.DateDebut,r.DateFin,r?.Motif,r?.Id)
        {

        }
        public Object CLone()
        {
            return new RendezVous(ClientsNom,HeureDebut, HeureFin, Temps, ChoixPeriodicite1, ChoixPeriodicite2, ChoixDeFin, DateDebut, DateFin, Motif,Id);
        }
        public override bool Equals(object obj)
        {
            return obj is RendezVous vous &&
                   Motif == vous.Motif;
        }
        public override int GetHashCode()
        {
            return -1340830888 + EqualityComparer<string>.Default.GetHashCode(Motif);
        }          
       
    }
}
