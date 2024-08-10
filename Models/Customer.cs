namespace CustomersCRUD.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateOnly DateOfBirth { get; set; }

        public string Address { get; set; }  

        public double Credit { get; set; }
        




    }
}
