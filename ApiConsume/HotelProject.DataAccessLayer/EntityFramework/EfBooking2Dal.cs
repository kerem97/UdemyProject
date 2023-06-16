using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfBooking2Dal : GenericRepository<Booking2>, IBooking2Dal
    {
        public EfBooking2Dal(Context context) : base(context)
        {

        }

        public int GetBookingCount()
        {
            var context = new Context();
            var value = context.Bookings2.Count();
            return value;
        }

        public List<Booking2> Last6Bookings()
        {
            var context = new Context();
            var values = context.Bookings2.OrderByDescending(x => x.Booking2ID).Take(6).ToList();
            return values;
        }
    }
}
