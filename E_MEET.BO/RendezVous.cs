using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_MEET.BO
{
    public class RendezVous
    {
        public string HeureDebut { get; set; }
        public string HeureFin { get; set; }
        public int Temps { get; set; }
        public string Choix1 { get; set; }
        public string Choix2 { get; set; }
        public int Choixjour1 { get; set; }
        public int ChoixMois1 { get; set; }
        public string NumeroJour { get; set; }
        public string Choixjour2 { get; set; }
        public int ChoixMois2 { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public int OccurrenceJours { get; set; }
        public string Choix3 { get; set; }
        public string Motif { get; set; }

        public override bool Equals(object obj)
        {
            return obj is RendezVous vous &&
                   Motif == vous.Motif;
        }

        public override int GetHashCode()
        {
            return -1340830888 + EqualityComparer<string>.Default.GetHashCode(Motif);
        }

        public RendezVous(string heureDebut, string heureFin, int temps, string choix1, string choix2, int choixjour1, int choixMois1, string numeroJour, string choixjour2, int choixMois2, DateTime dateDebut, DateTime dateFin, int occurrenceJours, string choix3, string motif)
        {
            HeureDebut = heureDebut;
            HeureFin = heureFin;
            Temps = temps;
            Choix1 = choix1;
            Choix2 = choix2;
            Choixjour1 = choixjour1;
            ChoixMois1 = choixMois1;
            NumeroJour = numeroJour;
            Choixjour2 = choixjour2;
            ChoixMois2 = choixMois2;
            DateDebut = dateDebut;
            DateFin = dateFin;
            OccurrenceJours = occurrenceJours;
            Choix3 = choix3;
            Motif = motif;
        }
        public RendezVous(RendezVous r) : this(r?.HeureDebut, r?.HeureFin, r?.Temps ?? 30, r?.Choix1, r?.Choix2, r?.Choixjour1??1, r?.ChoixMois1 ?? 1, r?.NumeroJour, r?.Choixjour2, r?.ChoixMois2 ?? 1,r.DateDebut,r.DateFin,r?.OccurrenceJours??2,r?.Choix3,r?.Motif)
        {

        }
        public Object CLone()
        {
            return new RendezVous(HeureDebut, HeureFin, Temps, Choix1, Choix2,Choixjour1, ChoixMois1, NumeroJour, Choixjour2, ChoixMois2, DateDebut, DateFin, OccurrenceJours, Choix3, Motif);
        }
    }
}
