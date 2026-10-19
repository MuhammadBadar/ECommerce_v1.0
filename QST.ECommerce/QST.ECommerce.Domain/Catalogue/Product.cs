using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QST.ECommerce.Domain.Catalogue
{
    // Entity
    public class Product
    {
        public int Id { get; set; }
        //public int DepartmentId { get; set; }
        //public int CategoryId { get; set; }
        //public string ProductCode { get; set; }
        public string ProductName { get; set; }
        //public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        //public List<string> ImageURLs { get; set; }

        //public string Department { get; set; }
        //public string Category { get; set; }
    }
}
