using System.ComponentModel.DataAnnotations.Schema;

namespace TGolf.Model
{
    // Lớp đại diện cho bảng Order
    public class Order
    {
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public int BookingId { get; set; }
        public int Quantity { get; set; }

        // Quan hệ nhiều-1 với bảng ProShopItem
        [NotMapped]
        public ProShopItem? ProShopItem { get; set; }


        // Quan hệ nhiều-1 với bảng Booking
        public Booking? Booking { get; set; }
    }
}
