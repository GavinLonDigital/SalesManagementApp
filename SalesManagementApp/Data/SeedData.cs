using Microsoft.EntityFrameworkCore;
using SalesManagementApp.Entities;

namespace SalesManagementApp.Data
{
    public static class SeedData
    {
        public static void AddEmployeeData(ModelBuilder modelBuilder)
        {
            //Add Employee Job Titles
            modelBuilder.Entity<EmployeeJobTitle>().HasData(new EmployeeJobTitle
            {
                EmployeeJobTitleId = 1,
                Name = "SM",
                Description = "Sales Manager"

            });
            modelBuilder.Entity<EmployeeJobTitle>().HasData(new EmployeeJobTitle
            {
                EmployeeJobTitleId = 2,
                Name = "TL",
                Description = "Team Leader"

            });
            modelBuilder.Entity<EmployeeJobTitle>().HasData(new EmployeeJobTitle
            {
                EmployeeJobTitleId = 3,
                Name = "SR",
                Description = "Sales Rep"

            });
            //Add Employees
            //Sales Manager
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 1,
                FirstName = "Bob",
                LastName = "Jones",
                Email = "bob.jones@oexl.com",
                Gender = "Male",
                DateOfBirth = DateTime.Parse("10 Feb 1974"),
                ReportToEmpId = null,
                ImagePath = "/Images/Profile/BobJones.jpg",
                EmployeeJobTitleId = 1

            });
            //Team Leaders
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 2,
                FirstName = "Jenny",
                LastName = "Marks",
                Email = "jenny.marks@oexl.com",
                Gender = "Female",
                DateOfBirth = DateTime.Parse("06 May 1976"),
                ReportToEmpId = 1,
                ImagePath = "/Images/Profile/JennyMarks.jpg",
                EmployeeJobTitleId = 2

            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 3,
                FirstName = "Henry",
                LastName = "Andrews",
                Email = "henry.andrews@oexl.com",
                Gender = "Male",
                DateOfBirth = DateTime.Parse("06 May 1981"),
                ReportToEmpId = 1,
                ImagePath = "/Images/Profile/HenryAndrews.jpg",
                EmployeeJobTitleId = 2

            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 4,
                FirstName = "John",
                LastName = "Jameson",
                Email = "john.jameson@oexl.com",
                Gender = "Male",
                DateOfBirth = DateTime.Parse("17 Apr 1984"),
                ReportToEmpId = 1,
                ImagePath = "/Images/Profile/JohnJameson.jpg",
                EmployeeJobTitleId = 2

            });
            //Sales Reps
            //Sales Team for Team Leader Name: Jenny, Id: 2
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 5,
                FirstName = "Noah",
                LastName = "Robinson",
                Email = "noah.robinson@oexl.com",
                Gender = "Male",
                DateOfBirth = DateTime.Parse("12 Feb 1993"),
                ReportToEmpId = 2,
                ImagePath = "/Images/Profile/NoahRobinson.jpg",
                EmployeeJobTitleId = 3

            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 6,
                FirstName = "Elijah",
                LastName = "Hamilton",
                Email = "elijah.hamilton@oexl.com",
                Gender = "Male",
                DateOfBirth = DateTime.Parse("17 Jun 1993"),
                ReportToEmpId = 2,
                ImagePath = "/Images/Profile/ElijahHamilton.jpg",
                EmployeeJobTitleId = 3

            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 7,
                FirstName = "Jamie",
                LastName = "Fisher",
                Email = "jamie.fisher@oexl.com",
                Gender = "Male",
                DateOfBirth = DateTime.Parse("13 Jul 1992"),
                ReportToEmpId = 2,
                ImagePath = "/Images/Profile/JamieFisher.jpg",
                EmployeeJobTitleId = 3

            });
            //Sales Team for Team Leader Name: Henry, Id: 3

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 8,
                FirstName = "Olivia",
                LastName = "Mills",
                Email = "olivia.mills@oexl.com",
                Gender = "Female",
                DateOfBirth = DateTime.Parse("17 Apr 1990"),
                ReportToEmpId = 3,
                ImagePath = "/Images/Profile/OliviaMills.jpg",
                EmployeeJobTitleId = 3

            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 9,
                FirstName = "Benjamin",
                LastName = "Lucas",
                Email = "benjamin.lucas@oexl.com",
                Gender = "Male",
                DateOfBirth = DateTime.Parse("12 Feb 1993"),
                ReportToEmpId = 3,
                ImagePath = "/Images/Profile/BenjaminLucas.jpg",
                EmployeeJobTitleId = 3

            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 10,
                FirstName = "Sarah",
                LastName = "Henderson",
                Email = "sarah.henderson@oexl.com",
                Gender = "Female",
                DateOfBirth = DateTime.Parse("12 Aug 1993"),
                ReportToEmpId = 3,
                ImagePath = "/Images/Profile/SarahHenderson.jpg",
                EmployeeJobTitleId = 3

            });
            //Sales Team for Team Leader Name: John, Id: 4          
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 11,
                FirstName = "Emma",
                LastName = "Lee",
                Email = "emma.lee@oexl.com",
                Gender = "Female",
                DateOfBirth = DateTime.Parse("12 Nov 1995"),
                ReportToEmpId = 4,
                ImagePath = "/Images/Profile/EmmaLee.jpg",
                EmployeeJobTitleId = 3

            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 12,
                FirstName = "Ava",
                LastName = "Williams",
                Email = "ava.williams@oexl.com",
                Gender = "Female",
                DateOfBirth = DateTime.Parse("12 May 1998"),
                ReportToEmpId = 4,
                ImagePath = "/Images/Profile/AvaWilliams.jpg",
                EmployeeJobTitleId = 3

            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 13,
                FirstName = "Angela",
                LastName = "Moore",
                Email = "angela.moore@oexl.com",
                Gender = "Female",
                DateOfBirth = DateTime.Parse("06 Jul 1994"),
                ReportToEmpId = 4,
                ImagePath = "/Images/Profile/AngelaMoore.jpg",
                EmployeeJobTitleId = 3

            });
        }

        public static void AddProductData(ModelBuilder modelBuilder)
        {
            //Add Categories - Road Bikes - Mountain Bikes - Camping - Hiking - Boots
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 1,
                Name = "Mountain Bikes"

            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 2,
                Name = "Road Bikes"

            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 3,
                Name = "Camping"

            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 4,
                Name = "Hiking"

            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 5,
                Name = "Boots"

            });
            //Products
            //Category Mountain Bikes
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Mountain Bike 1",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImagePath = "/Images/products/MountainBike1.jpg",
                Price = 200,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Mountain Bike 2",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImagePath = "/Images/products/MountainBike2.jpg",
                Price = 210,
                CategoryId = 1

            });
            //Category Road Bikes
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Road Bike 1",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImagePath = "/Images/products/RoadBike1.jpg",
                Price = 240,
                CategoryId = 2

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Road Bike 2",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImagePath = "/Images/products/RoadBike2.jpg",
                Price = 250,
                CategoryId = 2

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Road Bike 3",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImagePath = "/Images/products/RoadBike3.jpg",
                Price = 252,
                CategoryId = 2

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Road Bike 4",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImagePath = "/Images/products/RoadBike4.jpg",
                Price = 230,
                CategoryId = 2

            });
            //Camping
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Tent 1",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImagePath = "/Images/products/Tent1.jpg",
                Price = 230,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Tent 2",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImagePath = "/Images/products/Tent2.jpg",
                Price = 230,
                CategoryId = 3

            });
            //Category Camping - Mattresses
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Air Mattress 1",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImagePath = "/Images/products/Mattress1.jpg",
                Price = 11,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Air Mattress 2",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImagePath = "/Images/products/Mattress2.jpg",
                Price = 40,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Air Mattress 3",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImagePath = "/Images/products/Mattress3.jpg",
                Price = 54,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "Air Mattress 4",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImagePath = "/Images/products/Mattress4.jpg",
                Price = 15,
                CategoryId = 3

            });

            //Hiking
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 13,
                Name = "Pack 1",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImagePath = "/Images/products/Pack1.jpg",
                Price = 24,
                CategoryId = 4

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 14,
                Name = "Pack 2",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImagePath = "/Images/products/Pack2.jpg",
                Price = 30,
                CategoryId = 4

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 15,
                Name = "Pack 3",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImagePath = "/Images/products/Pack3.jpg",
                Price = 35,
                CategoryId = 4

            });
            //Category Boots
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 16,
                Name = "Boot 1",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImagePath = "/Images/products/Boot1.jpg",
                Price = 20,
                CategoryId = 5

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 17,
                Name = "Boot 2",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImagePath = "/Images/products/Boot2.jpg",
                Price = 38,
                CategoryId = 5

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 18,
                Name = "Boot 3",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImagePath = "/Images/products/Boot3.jpg",
                Price = 35,
                CategoryId = 5

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 19,
                Name = "Boot 4",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImagePath = "/Images/products/Boot4.jpg",
                Price = 31,
                CategoryId = 5

            });
        }

        public static void AddClientData(ModelBuilder modelBuilder)
        {
            //Add Retail Outlet Data
            modelBuilder.Entity<RetailOutlet>().HasData(new RetailOutlet
            {
                Id = 1,
                Name = "Texas Outdoor Store",
                Location = "TX"
            });
            modelBuilder.Entity<RetailOutlet>().HasData(new RetailOutlet
            {
                Id = 2,
                Name = "California Outdoor Store",
                Location = "CA"
            });
            modelBuilder.Entity<RetailOutlet>().HasData(new RetailOutlet
            {
                Id = 3,
                Name = "New York Outdoor Store",
                Location = "NY"
            });
            modelBuilder.Entity<RetailOutlet>().HasData(new RetailOutlet
            {
                Id = 4,
                Name = " Washington Outdoor Store",
                Location = "WA"
            });

            //Add Client data
            modelBuilder.Entity<Client>().HasData(new Client
            {
                Id = 1,
                FirstName = "James",
                LastName = "Tailor",
                JobTitle = "Buyer",
                PhoneNumber = "000000000",
                Email = "james.tailor@company.com",
                RetailOutletId = 1
            });
            modelBuilder.Entity<Client>().HasData(new Client
            {
                Id = 2,
                FirstName = "Jill",
                LastName = "Hutton",
                JobTitle = "Buyer",
                PhoneNumber = "000000000",
                Email = "jill.hutton@company.com",
                RetailOutletId = 2
            });
            modelBuilder.Entity<Client>().HasData(new Client
            {
                Id = 3,
                FirstName = "Craig",
                LastName = "Rice",
                JobTitle = "Buyer",
                PhoneNumber = "000000000",
                Email = "craig.rice@company.com",
                RetailOutletId = 3
            });
            modelBuilder.Entity<Client>().HasData(new Client
            {
                Id = 4,
                FirstName = "Amy",
                LastName = "Smith",
                JobTitle = "Buyer",
                PhoneNumber = "000000000",
                Email = "amy.smith@company.com",
                RetailOutletId = 4
            });
        }
    }
}
