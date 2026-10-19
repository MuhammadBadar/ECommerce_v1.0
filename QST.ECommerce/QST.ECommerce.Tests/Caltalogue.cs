using QST.ECommerce.Domain.Catalogue;

namespace QST.ECommerce.Tests
{
    public class Caltalogue
    {
        [Fact]
        public void Test_Department()
        {
            List<Department> deptList = new List<Department>();
            List<Category> categories = new List<Category>();
            List<Product> products = new List<Product>();
            

            Department dept = new Department();
            dept.Id = 1;
            dept.Name = "Electronics";
            dept.Description = "Electronic Devices";

            deptList.Add(dept);

            categories.Add(new Category { DepartmentId = 1, Id = 1, Name = "Accessories & Supplies" });
            categories.Add(new Category { DepartmentId = 1, Id = 2, Name = "Camera & Photo" });
            categories.Add(new Category { DepartmentId = 1, Id = 3, Name = "Car & Vehicle Electronics" });

            // products belonging to first department & first category
            products.Add(new Product { Id = 1, DepartmentId = 1, CategoryId = 1, Name = "Bluetooth Tracker Tags for iOS & Android", Price = 9139, Description = "Dual Compatibility with Apple Find My & Google Find Hub - Wireless Locator for Keys, Wallet, Pets, Luggage, 4 Pack" });
            products.Add(new Product { Id = 2, DepartmentId = 1, CategoryId = 1, 
                Name = "Hybrid Active Noise Cancelling Wireless Ear Buds 80 Hrs Playtime Hi-Res Stereo Quality Bluetooth Earbuds with Transparency Mode Headphones Bluetooth Earhooks ANC Earphones for Work Sports Travel\r\n", 
                Price = 9139, 
                Description = "Hybrid Active Noise Cancelling Wireless Ear Buds 80 Hrs Playtime Hi-Res Stereo Quality Bluetooth Earbuds with Transparency Mode Headphones Bluetooth Earhooks ANC Earphones for Work Sports Travel\r\n"
            });


            dept = new Department();
            dept.Id = 2;
            dept.Name = "Computers";
            deptList.Add(dept);

            categories.Add(new Category { DepartmentId = 2, Id = 4, Name = "Computer Accessories & Peripherals" });
            categories.Add(new Category { DepartmentId = 2, Id = 5, Name = "Computer Componenets" });
            categories.Add(new Category { DepartmentId = 2, Id = 6, Name = "Computers & Tablets" });

            
            dept = new Department();
            dept.Id = 3;
            dept.Name = "Smart Home";
            deptList.Add(dept);


        }

        [Fact]
        public void Test_Cateogry()
        {
            List<Category> categories = new List<Category>();

            // Electronics
            categories.Add(new Category { DepartmentId = 1, Id = 1, Name = "Accessories & Supplies" });
            categories.Add(new Category { DepartmentId = 1, Id = 2, Name = "Camera & Photo" });
            categories.Add(new Category { DepartmentId = 1, Id = 3, Name = "Car & Vehicle Electronics" });

            // Computers
            categories.Add(new Category { DepartmentId = 2, Id = 4, Name = "Computer Accessories & Peripherals" });
            categories.Add(new Category { DepartmentId = 2, Id = 5, Name = "Computer Componenets" });
            categories.Add(new Category { DepartmentId = 2, Id = 6, Name = "Computers & Tablets" });
        }
    }
}