using E_MEET.BO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_MEET.DAL
{
    public class UtilisateurRepository:BaseRepository<Utilisateur>
    {
        public UtilisateurRepository() : base()
        {
            FileInfo fileinfo = new FileInfo(Path);
            if (!fileinfo.Exists || fileinfo.Length == 0)
            {                
            }
        }
        public List<Utilisateur> FindByPassword(string password)
        {
            List<Utilisateur> list = new List<Utilisateur>();
            foreach (var data in Datas)
            {
                if (data.Password.ToLower().Contains(password.ToLower()))
                    list.Add(data);
            }
            return new List<Utilisateur>(list);
        }

        public List<Utilisateur> FindByName(string name)
        {
            List<Utilisateur> list = new List<Utilisateur>();
            foreach (var data in Datas)
            {
                if (data.Nom.ToLower().Contains(name.ToLower()))
                    list.Add(data);
            }
            return new List<Utilisateur>(list);
        }
        public List<Utilisateur> FindByEmail(string email)
        {
            List<Utilisateur> list = new List<Utilisateur>();
            foreach (var data in Datas)
            {
                if (data.Email.ToLower().Contains(email.ToLower()))
                    list.Add(data);
            }
            return new List<Utilisateur>(list);
        }


        public List<Utilisateur> FindByTOf(string photo)
        {
            List<Utilisateur> list = new List<Utilisateur>();
            foreach (var datas in Datas)
            {
                if (datas.Photo.ToLower().Contains(photo.ToLower()))
                    list.Add(datas);
            }
            return new List<Utilisateur>(list);
        }
    }
}
