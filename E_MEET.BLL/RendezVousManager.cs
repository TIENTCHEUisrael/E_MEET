using E_MEET.BO;
using E_MEET.DAL;
using System.Collections.Generic;

namespace E_MEET.BLL
{
    public class RendezVousManager
    {
        private RdvRepository Rdvrepository;
        /// <summary>
        /// 
        /// </summary>
        public RendezVousManager()
        {
            Rdvrepository = new RdvRepository();
        }
        /// <summary>
        /// Edit the RendezVous
        /// </summary>
        /// <param name="oldrdv"></param>
        /// <param name="newrdv"></param>
        public void EditRdv(RendezVous oldrdv, RendezVous newrdv)
        {
            Rdvrepository.Set(oldrdv, newrdv);
        }
        /// <summary>
        /// Add the Appointment
        /// </summary>
        /// <param name="rdv"></param>
        public void AddRdv(RendezVous rdv)
        {
            Rdvrepository.Add(rdv);
        }
        /// <summary>
        /// Delete Appointment
        /// </summary>
        /// <param name="rdv"></param>
        public void DeleteRdv(RendezVous rdv)
        {
            Rdvrepository.Set(rdv, rdv);
        }
        /// <summary>
        /// List of Appointment
        /// </summary>
        /// <returns></returns>
        public List<RendezVous> GetAllrdv()
        {
            return Rdvrepository.GetAll();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public RendezVous AuthenticateRdv(string id)
        {
            var rdv = Rdvrepository.FindByIdentifiant(id);
            foreach (var r in rdv)
                if (r.Id == id)
                    return r;
            return null;
        }
    }
}
