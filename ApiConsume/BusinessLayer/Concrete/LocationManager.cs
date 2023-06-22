using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class LocationManager : ILocationService
    {
        private readonly ILocationDal _locationDal;

        public LocationManager(ILocationDal locationDal)
        {
            _locationDal = locationDal;
        }

        public void TCreate(Location t)
        {
            _locationDal.Create(t);
        }

        public void TDelete(Location t)
        {
            _locationDal.Delete(t);
        }

        public Location TGetById(int id)
        {
            return _locationDal.GetById(id);
        }

        public List<Location> TGetList()
        {
            return _locationDal.GetList();
        }

        public void TUpdate(Location t)
        {
            _locationDal.Update(t);
        }
    }
}
