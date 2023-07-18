namespace TGolf.Model
{

    // Lớp đại diện cho bảng BagNo
    public class BagNo
    {
        public int BagNoId { get; set; }
        public int BookingId { get; set; }
        public int CaddyId { get; set; }

        // Quan hệ nhiều-1 với bảng Booking
        public Booking? Booking { get; set; }

        // Quan hệ nhiều-1 với bảng Caddy
        public Caddy? Caddy { get; set; }
    }
}
