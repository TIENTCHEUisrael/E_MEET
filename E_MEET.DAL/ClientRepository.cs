using E_MEET.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_MEET.DAL
{
    public class ClientRepository:BaseRepository<Client>
    {
        public ClientRepository() : base()
        {
        }
        public List<Client> FindByEmail(string mail)
        {
            List<Client> list = new List<Client>();
            foreach (var data in Datas)
            {
                if (data.Email.ToLower().Contains(mail.ToLower()))
                    list.Add(data);

            }
            return new List<Client>(list);
        }
        public List<Client> FindByNom(string nom)
        {
            List<Client> list = new List<Client>();
            foreach (var data in Datas)
            {
                if (data.Nom.ToLower().Contains(nom.ToLower()))
                    list.Add(data);
            }
            return new List<Client>(list);
        }
    }
}
