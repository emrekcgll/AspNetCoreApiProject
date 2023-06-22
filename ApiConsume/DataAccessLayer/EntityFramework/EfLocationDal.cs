using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfLocationDal : GenericRepository<Location>, ILocationDal
    {
        public EfLocationDal(Context context) : base(context)
        {
        }
    }
}
