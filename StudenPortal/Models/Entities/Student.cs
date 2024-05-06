namespace StudenPortal.Models.Entities
{
    public class Student
    {
        public Guid Id  { get; set; }
        public String Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool Subscribed { get; set; }
    }
}
