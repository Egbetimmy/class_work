namespace Web1.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; } 
        public string Photo { get; set; }
        public int UserID { get; set; }
        public User user { get; set; }
    }
    public class ProfileRequest
    {
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Photo { get; set; }
        public int UserID { get; set; }
    }
}
