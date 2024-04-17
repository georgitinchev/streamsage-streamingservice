namespace EmployeesProject.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Avatar { get; set; }
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public Employee(int id, string firstName, string lastName, string avatar)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Avatar = avatar;
        }

        public Employee()
        {
        }
    }
}
