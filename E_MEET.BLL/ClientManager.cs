using E_MEET.BO;
using E_MEET.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_MEET.BLL
{
    public class ClientManager
    {
        private RdvRepository Rdvrepository;
        private ClientRepository Clientrepository;

        public ClientManager()
        {
            Rdvrepository = new RdvRepository();
            Clientrepository = new ClientRepository();
        }
        /// <summary>
        /// Adit the client
        /// </summary>
        /// <param name="oldclt"></param>
        /// <param name="newclt"></param>
        public void EditClient(Client oldclt, Client newclt)
        {
            Clientrepository.Set(oldclt, newclt);
        }
        /// <summary>
        /// Authentification du client
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public Client AuthenticateClt(string email)
        {
            var clt = Clientrepository.FindByEmail(email);
            foreach (var c in clt)
                if (c.Email == email)
                    return c;
            return null;
        }

        /// <summary>
        /// Add the client
        /// </summary>
        /// <param name="user"></param>
        public void AddClient(Client user)
        {
            Clientrepository.Add(user);
        }
        /// <summary>
        /// Delete the Client
        /// </summary>
        /// <param name="user"></param>
        public void DeleteClient(Client user)
        {
            Clientrepository.Set(user, user);

        }
        /// <summary>
        /// Get all Client
        /// </summary>
        /// <returns></returns>
        public List<Client> GetAllClient()
        {
            return Clientrepository.GetAll();
        }
        /// <summary>
        /// Get all Appointment
        /// </summary>
        /// <returns></returns>
        public List<RendezVous> GetAllRdv()
        {
            return Rdvrepository.GetAll();
        }
        /// <summary>
        /// Add in Client the Appointment
        /// </summary>
        /// <param name="clt"></param>
        /// <param name="rdv"></param>
        public void AddClientRdv(Client clt, RendezVous rdv)
        {            
            if (Clientrepository.Check(clt) < 0)
                throw new KeyNotFoundException($"{nameof(Client)} not found");
            clt.AddRdv(rdv);
            Clientrepository.Set(clt, clt);
        }
        /// <summary>
        /// Remove in client the appointment
        /// </summary>
        /// <param name="clt"></param>
        /// <param name="rdv"></param>
        public void RemoveClientRdv(Client clt, RendezVous rdv)
        {
            if (Clientrepository.Check(clt) < 0)
                throw new KeyNotFoundException($"{nameof(Client)} not found");
            clt.DeleteRDv(rdv);
            Clientrepository.Set(clt, clt);
        }
    }
}
