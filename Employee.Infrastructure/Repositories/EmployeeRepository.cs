using Employee.Core.Repositories;
using Employee.Infrastructure.Data;
using Employee.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Infrastructure.Repositories
{
    //Pour une opération personnalisée spécifique à une entité, nous allons créer
    //une autre classe EmployeeRepository  dans le dossier Repositories
    //Nous allons implémenter Repository et IEmployeeRepository
    //qui auront également accès au code générique et personnalisé
    public class EmployeeRepository : Repository<Employee.Core.Entities.Employee>, IEmployeeRepository
    {
        public EmployeeRepository(EmployeeContext employeeContext) : base(employeeContext) { }
        public async Task<IEnumerable<Core.Entities.Employee>> GetEmployeeByLastName(string lastname)
        {
            return await _employeeContext.Employees.Where(m => m.LastName == lastname).ToListAsync();
        }
    }
}
