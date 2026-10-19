using QST.ECommerce.Domain.Catalogue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QST.ECommerce.Application
{
    public interface IDepartmentService
    {
        // Save means 1. Add 2. Update 3. Delete
        int SaveDepartment(Department department);
        List<Department> GetAll();
    }
}
