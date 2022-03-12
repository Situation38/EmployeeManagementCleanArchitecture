using Employee.Application.Reponses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Application.Commandes
{

    //Nous ajoutons la commande "CreateEmployeeCommand"
    //Cette classe enverra une commande
    //à l'infrastructure pour créer un nouvel enregistrement
    //Cela va donc implémenter la bibliothèque IRequest et MediatR
    
    public class CreateEmployeeCommand: IRequest < EmployeeResponse > {
    public string FirstName {
        get;
        set;
    }

    public string LastName {
        get;
        set;
    }
    public DateTime DateOfBirth {
        get;
        set;
    }
    public string PhoneNumber {
        get;
        set;
    }
    public string Email {
        get;
        set;
    }
       
}




}
