namespace TGolf.Model
{
    // Lớp đại diện cho bảng Rental
    public class Rental
    {
        public int RentalId { get; set; }
        public int FacilityId { get; set; }
        public int BookingId { get; set; }
        public DateTime RentalDate { get; set; }

        // Quan hệ nhiều-1 với bảng Facility
        public Facility? Facility { get; set; }

        // Quan hệ nhiều-1 với bảng Booking
        public Booking? Booking { get; set; }
    }
}
