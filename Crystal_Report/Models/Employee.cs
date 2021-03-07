using System.Collections.Generic;

namespace Crystal_Report.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int PostCode { get; set; }

        public List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee(){Id = 1,Name = "Rahim",Email="R@gmail.com",Address="Dhaka",PostCode = 1216},
                new Employee(){Id = 1,Name = "Karim",Email="K@gmail.com",Address="Faridpur",PostCode = 1223},
                new Employee(){Id = 1,Name = "Jamal",Email="J@gmail.com",Address="Dhaka",PostCode = 1223},
                new Employee(){Id = 1,Name = "Sajid",Email="s@gmail.com",Address="Kolabagan",PostCode = 12132},
                new Employee(){Id = 1,Name = "Polin",Email="p@gmail.com",Address="Dhaka",PostCode = 1212326},
                new Employee(){Id = 1,Name = "Shuvo",Email="s@gmail.com",Address="Dhanmondi",PostCode = 12146},
                new Employee(){Id = 1,Name = "Forid",Email="f@gmail.com",Address="Uttora",PostCode = 122316},
                new Employee(){Id = 1,Name = "Asad",Email="a@gmail.com",Address="Mirpur",PostCode = 122316},
            };
        }
    }
}