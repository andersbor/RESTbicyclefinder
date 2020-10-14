namespace bicyclefinder.Models
{
    public class Bicycle
    {
        public int Id { get; set; }
        public string FrameNumber { get; set; }
        public string KindOfBicycle { get; set; }
        public string Brand { get; set; }
        public string Colors { get; set; }
        public string Place { get; set; }
        public string Date { get; set; }
        public int UserId { get; set; }

        public string MissingFound { get; set; }

        public string FirebaseUserId { get; set; }

        public override string ToString()
        {
            return Brand + " " + Place;
        }
    }
}
