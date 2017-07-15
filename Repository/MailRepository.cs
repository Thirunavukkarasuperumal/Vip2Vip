using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class MailRepository
    {
        AlbanyMedCtrEntities entities = new AlbanyMedCtrEntities();

        public List<periopContent> GetAllPeriopContent()
        {
            return entities.periopContents.ToList();
        }
    }
}
