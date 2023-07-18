namespace TGolf.Model
{
    // Lớp đại diện cho bảng Member
    public class Member
    {
        public int MemberId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public decimal Fee { get; set; }
    }

}
