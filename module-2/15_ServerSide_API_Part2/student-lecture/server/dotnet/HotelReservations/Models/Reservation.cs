using System;
using System.ComponentModel.DataAnnotations;

namespace HotelReservations.Models
{
    public class Reservation
    {
        public int? Id { get; set; }
        [Required]
        public int HotelID { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string CheckinDate { get; set; }
        [Required]
        public string CheckoutDate { get; set; }
        [Required]
        public int Guests { get; set; }

        public Reservation(int? id, int hotelId, string fullName, string checkinDate, string checkoutDate, int guests)
        {
            Id = id ?? new Random().Next(100, int.MaxValue);
            HotelID = hotelId;
            FullName = fullName;
            CheckinDate = checkinDate;
            CheckoutDate = checkoutDate;
            Guests = guests;
        }
    }
}
