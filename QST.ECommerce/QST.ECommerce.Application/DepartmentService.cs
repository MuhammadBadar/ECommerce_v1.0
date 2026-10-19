using QST.ECommerce.Domain.Catalogue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QST.ECommerce.Application
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        
        // Construction Injection
        public DepartmentService(IDepartmentRepository deptRepo) 
        {
            _departmentRepository = deptRepo;
        }

        public int SaveDepartment(Department department)
        {
            int result = _departmentRepository.AddDepartment(department);
            return result;
            //throw new NotImplementedException();
        }

        public List<Department> GetAll()
        {
            var list = _departmentRepository.GetAllDepartments();
            return list;
            //throw new NotImplementedException();
        }

        
    }
}
