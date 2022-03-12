using Employee.Application.Commandes;
using Employee.Application.Reponses;
using Employee.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Employee.Application.Handlers
{
    //Nous allons créer un gestionnaire pour CreateEmployeeCommand
    public class CreateEmployeeHandler : IRequestHandler<CreateEmployeeCommand, EmployeeResponse>
    {
        private readonly IEmployeeRepository _employeeRepo;
        public CreateEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepo = employeeRepository;
        }
        public async Task<EmployeeResponse> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employeeEntitiy = EmployeeMapper.Mapper.Map<Employee.Core.Entities.Employee>(request);
            if (employeeEntitiy is null)
            {
                throw new ApplicationException("Issue with mapper");
            }

            //Nous avons mappé l'entité Employee avec l'objet de requête.
            var newEmployee = await _employeeRepo.AddAsync(employeeEntitiy);

            //Ajout de l'employe EmployeeEntity à la base de données
            var employeeResponse = EmployeeMapper.Mapper.Map<EmployeeResponse>(newEmployee);

            //mappage vers MovieResponse pour récupérer EmployeeId à partir de l'objet
            //puis retour de la réponse.
            return employeeResponse;
        }
    }
}
