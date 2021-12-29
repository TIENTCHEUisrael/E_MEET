using E_MEET.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_MEET.DAL
{
    public class RdvRepository:BaseRepository<RendezVous>
    {
        public RdvRepository() : base()
        {

        }
        public List<RendezVous> FindByIdentifiant(string identification)
        {
            List<RendezVous> list = new List<RendezVous>();
            foreach (var data in Datas)
            {
                if (data.Id.Contains(identification))
                    list.Add(data);

            }
            return new List<RendezVous>(list);
        }
    }
}
