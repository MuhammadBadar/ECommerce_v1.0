using QST.ECommerce.Domain.Catalogue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QST.ECommerce.Application
{
    // What to Do ?
    public interface IDepartmentRepository
    {
        int AddDepartment(Department dept);
        //int UpdateDapartment(Department dept);
        //int DeleteDepartment(int deptId);
        //Department GetDepartmentById(int deptId); 
        List<Department> GetAllDepartments();
    }
}
