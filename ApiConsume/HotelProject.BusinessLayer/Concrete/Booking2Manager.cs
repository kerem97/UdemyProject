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
    public class Booking2Manager : IBooking2Service
    {
        private readonly IBooking2Dal _booking2Dal;

        public Booking2Manager(IBooking2Dal booking2Dal)
        {
            _booking2Dal = booking2Dal;
        }

        public void TDelete(Booking2 t)
        {
            _booking2Dal.Delete(t);
        }

        public int TGetBookingCount()
        {
            return _booking2Dal.GetBookingCount();
        }

        public Booking2 TGetByID(int id)
        {
            return _booking2Dal.GetByID(id);
        }

        public List<Booking2> TGetList()
        {
            return _booking2Dal.GetList();
        }

        public void TInsert(Booking2 t)
        {
            _booking2Dal.Insert(t);
        }

        public List<Booking2> TLast6Bookings()
        {
            return _booking2Dal.Last6Bookings();
        }

        public void TUpdate(Booking2 t)
        {
            _booking2Dal.Update(t);
        }
    }
}
