using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_MEET.BO
{
    public class Utilisateur
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Photo { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Contact { get; set; }
        public string Profession { get; set; }
        public string Localisation { get; set; }
        public string Sexe { get; set; }
        public List<Client> Clients { get; set; }
        public Utilisateur()
        {
            Clients = new List<Client>();
        }

        public Utilisateur(string email, string password, string photo, string nom, string prenom, int contact, string profession, string localisation, string sexe) : this()
        {
            Email = email;
            Password = password;
            Photo = photo;
            Nom = nom;
            Prenom = prenom;
            Contact = contact;
            Profession = profession;
            Localisation = localisation;
            Sexe = sexe;
        }
        public Utilisateur(Utilisateur u) : this(u?.Email, u?.Password, u.Photo, u?.Nom, u?.Prenom, u?.Contact ?? 34567, u?.Profession, u?.Localisation, u?.Sexe)
        {

        }

        public override bool Equals(object obj)
        {
            return obj is Utilisateur user &&
                   Email == user.Email;
        }

        public override int GetHashCode()
        {
            return -506688385 + EqualityComparer<string>.Default.GetHashCode(Email);
        }
        public void AddClient(Client client)
        {
            Clients.Add(client);
        }
        public void DeleteClient(Client client)
        {
            Clients.Remove(client);
        }
        
        public List<Client> GetClient()
        {
            var list = new List<Client>();
            foreach (var c in Clients)
                list.Add(new Client(c));
            return list;
        }
    }
}
