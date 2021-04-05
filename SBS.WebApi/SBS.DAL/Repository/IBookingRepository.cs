using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBS.Models;

namespace SBS.DAL.Repository
{
    public interface IBookingRepository
    {
        string registerBooking(BookingVM model);
        Boolean updateBooking(BookingVM model);
        Boolean deleteBooking(int ID);
        BookingVM getBookingByID(String ID);
        List<BookingVM> getAllBooking();
    }
}
