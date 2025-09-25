namespace apf_mhalac.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public string Surname { get; set; } 
        public string Email { get; set; } 
        public int Age { get; set; }
        public string City { get; set; } 
        public int PhoneNumber { get; set; }

        public List<string> TodoList { get; set; }
    }
}
