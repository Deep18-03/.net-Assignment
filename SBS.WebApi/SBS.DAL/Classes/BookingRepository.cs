using SBS.DAL.Repository;
using SBS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBS.DAL.Classes
{
    public class BookingRepository : IBookingRepository
    {
        private readonly Database.ServiceBookingSystemEntities _dbcontext;
        public BookingRepository()
        {
            _dbcontext = new Database.ServiceBookingSystemEntities();
        }
        public bool deleteBooking(int Id)
        {
            try
            {
                var entity = _dbcontext.AppointBookings.Find(Id);
                if (entity.Status != null)
                {
                    var entities = _dbcontext.Entry(entity);
                    entities.State = EntityState.Deleted;
                    _dbcontext.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                // return false;
            }
            return false;
        }

        public List<BookingVM> getAllBooking()
        {
            var entities = _dbcontext.AppointBookings.ToList();
            List<BookingVM> bookinglist = new List<BookingVM>();
            if (entities != null)
            {
                foreach (var item in entities)
                {
                    BookingVM booking = new BookingVM();
                    booking.Id = item.Id;
                    booking.VehicleId = item.VehicleId;
                    //customer.Locality = item.Locality;
                    booking.MechanicId = (int)item.MechanicId;
                    booking.ServiceId = item.ServiceId;
                    booking.StartDateTime = item.StartTime;
                    booking.EndDateTime = item.EndTime;
                    booking.BookedBy = item.BookedBy;
                    booking.Status = item.Status;
                    bookinglist.Add(booking);
                }
            }
            return bookinglist;
        }

        public BookingVM getBookingByID(string ID)
        {
            throw new NotImplementedException();
        }

        public string registerBooking(BookingVM model)
        {
            if (model != null)
            {
                Database.AppointBooking entity = new Database.AppointBooking();
                entity.Id = model.Id;
                entity.VehicleId = model.VehicleId;
                //entity.lo = model.Locality;
                entity.MechanicId = model.MechanicId;
                entity.ServiceId = model.ServiceId;
                entity.StartTime = (DateTime)model.StartDateTime;
                entity.EndTime = (DateTime)model.EndDateTime;
                entity.BookedBy = (int)model.BookedBy;
                entity.Status = model.Status;

                _dbcontext.AppointBookings.Add(entity);
                _dbcontext.SaveChanges();
                return "";
            }
            else
                return "Not added";
        }

        public bool updateBooking(BookingVM model)
        {
            throw new NotImplementedException();
        }

       
    }
}
