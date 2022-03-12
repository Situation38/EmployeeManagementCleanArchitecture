using Employee.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.Repositories
{

    // On crée une autre interface héritant de IRepository
    // qui aura une méthode personnalisée spécifique à une entité dans
    // le dossier " Repositories.

    public interface IEmployeeRepository : IRepository<Employee.Core.Entities.Employee>
    {
        //custom operations here
        Task<IEnumerable<Employee.Core.Entities.Employee>> GetEmployeeByLastName(string lastname);
    }
}
