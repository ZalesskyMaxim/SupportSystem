using Model.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL.Repository
{
    public class AbstractRepository : IDisposable
    {
        protected DBArtWorkContext dbArtWorkContext;

        public AbstractRepository()
        {
            dbArtWorkContext = new DBArtWorkContext();
        }

        public void Dispose()
        {
            dbArtWorkContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
