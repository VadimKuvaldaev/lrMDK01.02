using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restourant
{
    public class RestourantService
    {
        private List<Table> tables_ = new List<Table>();
        private List<Booking> bookings_ = new List<Booking>();

        public void AddTable(int number, int seats)
        {
            for (int i = 0; i < tables_.Count; i++)
            {
                if (tables_[i].Number == number)
                {
                    throw new InvalidOperationException($"Столик с номером {number} уже существует");
                }
            }
            tables_.Add(new Table(number, seats));
        }
        public bool RemoveTable(int number)
        {
            for (int i = 0; i < tables_.Count; i++)
            {
                if (tables_[i].Number == number)
                {
                    tables_.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public List<Table> GetAllTables()
        {
            return tables_;
        }
        public List<Booking> GetAllBookings()
        {
            return bookings_;
        }
        public string TryBookTable(string clientName, int guestsCount, DateTime startTime, int durationMinutes)
        {
            if (tables_.Count == 0)
            {
                return "В ресторане нет столиков";
            }
            for (int i = 0; i < tables_.Count; i++)
            {
                Table table = tables_[i];
                if (table.Seats < guestsCount)
                {
                    continue;
                }
                bool isFree = true;
                DateTime endTime = startTime.AddMinutes(durationMinutes);
                for (int j = 0; j < bookings_.Count; j++)
                {
                    Booking b = bookings_[j];
                    if(b.Table == table.Number) 
                    {
                        if ((startTime >= b.BookingDate && startTime < b.EndTime) ||
                           (endTime > b.BookingDate && endTime <= b.EndTime) ||
                           (startTime <= b.BookingDate && endTime >= b.EndTime)) 
                        {
                            isFree = false;
                            break;
                        }
                    }
                }
                if (isFree) 
                {
                    int bookingNumber = bookings_.Count + 1;
                    bookings_.Add(new Booking(bookingNumber, table.Number, clientName, startTime, durationMinutes));

                    if (guestsCount < table.Seats)
                        return "Столик успешно забронирован! :) Предупреждение: количество гостей меньше вместимости столика.";
                    else
                        return "Столик успешно забронирован! :)";
                }
            }
            for (int i = 0; i < tables_.Count; i++)
            {
                if (tables_[i].Seats >= guestsCount)
                    return "Нет свободных столиков на указанное время. :(";
            }
            return $"Нет столика, вмещающего {guestsCount} гостей. :(";
        }
    }   
}
