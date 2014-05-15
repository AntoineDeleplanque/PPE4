using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace DigiCode
{
    class SalleService
    {
        public static IEnumerable<SalleEntity> LoadSalle()
        {
            using (DbModelContainer ctx = new DbModelContainer())
            {
                return ctx.SalleEntityJeu.ToList();
                /*List<Salle> SalleList = new List<Salle>();
                foreach (SalleEntity salleEntity in SalleEntityList)
                {
                    SalleList.Add(salleEntity as Salle);
                }
                return SalleList;*/
            }
        }
    }
}
