using Delegate_homework.Services;
using Delegate_homework.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_homework.Controllers
{
    internal class PersonController
    {
        private readonly IPersonService _personService;

        public PersonController()
        {
            _personService = new PersonService();
        }
            public void CheckSalary()
            {
                var response = _personService.CheckSalary(m => m.Salary > 1000);
                foreach (var item in response)
                {
                    Console.WriteLine(item.Name + "-" + item.Adress + "-" + item.Salary);
                }
            } 

    }
}
