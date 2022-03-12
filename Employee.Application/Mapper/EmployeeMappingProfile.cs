using AutoMapper;
using Employee.Application.Commandes;
using Employee.Application.Reponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Application.Mapper
{
    //Creation d'un profil de mappage
    public class EmployeeMappingProfile : Profile
    {
        public EmployeeMappingProfile()
        {
            CreateMap<Employee.Core.Entities.Employee, EmployeeResponse>().ReverseMap();
            CreateMap<Employee.Core.Entities.Employee, CreateEmployeeCommand>().ReverseMap();
        }
    }
}
