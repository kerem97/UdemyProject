﻿using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IBooking2Dal : IGenericDal<Booking2>
    {
        int GetBookingCount();
        List<Booking2> Last6Bookings();
    }
}
