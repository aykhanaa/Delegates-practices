using Delegate_homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_homework.Services.Interfaces
{
    internal interface IPersonService
    {
        List<Person> GetAll();
        List<Person> CheckSalary(Predicate<Person> predicate);
    }
}
