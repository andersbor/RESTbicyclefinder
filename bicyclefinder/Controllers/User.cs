namespace bicyclefinder.Controllers
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string FirebaseUserId { get; set; }

        public override string ToString()
        {
            return Name + " " + Phone;
        }
    }
}
