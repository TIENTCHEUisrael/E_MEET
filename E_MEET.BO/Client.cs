using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_MEET.BO
{
    public class Client
    {
        public string Email { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Photo { get; set; }
        public int Age { get; set; }
        public int Contact { get; set; }
        public string Sexe { get; set; }
        public string Localisation { get; set; }
        public List<RendezVous> RendezVous { get; set; }
        public Client()
        {
            RendezVous = new List<RendezVous>();
        }
        /// <summary>
        /// Constructeur a 8 elements
        /// </summary>
        /// <param name="email"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="photo"></param>
        /// <param name="age"></param>
        /// <param name="contact"></param>
        /// <param name="sexe"></param>
        /// <param name="localisation"></param>
        public Client(string email, string nom, string prenom, string photo, int age, int contact, string sexe, string localisation) : this()
        {
            Email = email;
            Nom = nom;
            Prenom = prenom;
            Photo = photo;
            Age = age;
            Contact = contact;
            Sexe = sexe;
            Localisation = localisation;
        }
        /// <summary>
        /// Contrcuteur qui prend en parametre un user
        /// </summary>
        /// <param name="p"></param>
        public Client(Client p) : this(p?.Email, p?.Nom, p?.Prenom, p.Photo, p?.Age ?? 00, p?.Contact ?? 345678, p?.Sexe, p?.Localisation)
        {
        }
        /// <summary>
        /// Methode equal redefini
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is Client client &&
                   Email == client.Email;
        }
        /// <summary>
        /// Le geshascode redefini
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return -506688385 + EqualityComparer<string>.Default.GetHashCode(Email);
        }
        /// <summary>
        /// Ajout RendezVous
        /// </summary>
        /// <param name="rdv"></param>
        public void AddRdv(RendezVous rdv)
        {
            RendezVous.Add(rdv);
        }
        /// <summary>
        /// Supprimer rendezVous
        /// </summary>
        /// <param name="rdv"></param>
        public void DeleteRDv(RendezVous rdv)
        {
            RendezVous.Remove(rdv);
        }
        /// <summary>
        /// Liste de RendezVous
        /// </summary>
        /// <returns></returns>
        public List<RendezVous> GetRDv()
        {
            var list = new List<RendezVous>();
            foreach (var c in RendezVous)
                list.Add(new RendezVous(c));
            return list;
        }
    }
}
