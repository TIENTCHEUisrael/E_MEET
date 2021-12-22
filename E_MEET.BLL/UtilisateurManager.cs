using E_MEET.BO;
using E_MEET.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_MEET.BLL
{
    public class UtilisateurManager
    {
        private UtilisateurRepository Userrepository;
        private ClientRepository Clientrepository;
        public UtilisateurManager()
        {
            Userrepository = new UtilisateurRepository();
            Clientrepository = new ClientRepository();
        }
        /// <summary>
        /// Edit the User
        /// </summary>
        /// <param name="oldUser"></param>
        /// <param name="newUser"></param>
        public void EditUser(Utilisateur oldUser, Utilisateur newUser)
        {
            Userrepository.Set(oldUser, newUser);
        }
        /// <summary>
        /// Add the User
        /// </summary>
        /// <param name="user"></param>
        public void AddUser(Utilisateur user)
        {
            Userrepository.Add(user);
        }
        /// <summary>
        /// Delete the user
        /// </summary>
        /// <param name="user"></param>
        public void DeleteUSer(Utilisateur user)
        {
            Userrepository.Set(user, user);

        }
        /// <summary>
        /// The authentification of User
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Utilisateur Authenticate(string email, string password)
        {
            var users = Userrepository.FindByEmail(email);
            foreach (var u in users)
                if (u.Email == email && u.Password == password)
                    return u;
            return null;
        }
        /// <summary>
        /// Get all the User
        /// </summary>
        /// <returns></returns>
        public List<Utilisateur> GetAllUSer()
        {
            return Userrepository.GetAll();
        }
        /// <summary>
        /// Get all the CLient
        /// </summary>
        /// <returns></returns>
        public List<Client> GetAllClient()
        {
            return Clientrepository.GetAll();
        }
        /// <summary>
        /// Add in the User the Client 
        /// </summary>
        /// <param name="user"></param>
        /// <param name="clt"></param>
        public void AddUserClient(Utilisateur user, Client clt)
        {
            if (Userrepository.Check(user) < 0)
                throw new KeyNotFoundException($"{nameof(Utilisateur)} not found");
            user.AddClient(clt);
            Userrepository.Set(user, user);
        }
        /// <summary>
        /// Remove in User the Client checked
        /// </summary>
        /// <param name="user"></param>
        /// <param name="clt"></param>
        public void RemoveUserClient(Utilisateur user, Client clt)
        {
            if (Userrepository.Check(user) < 0)
                throw new KeyNotFoundException($"{nameof(Utilisateur)} not found");
            user.DeleteClient(clt);
            Userrepository.Set(user, user);
        }
    }
}
