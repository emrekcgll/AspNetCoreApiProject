namespace EntityLayer.Entities
{
    public class Comment
    {
        public int CommentID { get; set; }
        public int Rate { get; set; }
        public DateTime Date { get; set; }

        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public int HotelID { get; set; }
        public Hotel Hotel { get; set; }
    }
}
