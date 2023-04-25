using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class RoomManager : IRoomService
    {
        private readonly IRoomDal _roomDal;
        public void Delete(Room t)
        {
            throw new NotImplementedException();
        }

        public Room GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Room> GetList()
        {
            throw new NotImplementedException();
        }

        public void Insert(Room t)
        {
            throw new NotImplementedException();
        }

        public void Update(Room t)
        {
            throw new NotImplementedException();
        }
    }
}
