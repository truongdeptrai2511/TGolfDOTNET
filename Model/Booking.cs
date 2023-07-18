namespace TGolf.Model
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int MemberId { get; set; }
        public DateTime BookingDate { get; set; }
        public TimeSpan CheckInTime { get; set; }
        public TimeSpan CheckOutTime { get; set; }

        // Quan hệ nhiều-1 với bảng Member
        public Member? Member { get; set; }
    }
}
