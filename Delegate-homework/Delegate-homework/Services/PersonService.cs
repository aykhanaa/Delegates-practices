using Delegate_homework.Data;
using Delegate_homework.Models;
using Delegate_homework.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_homework.Services
{
    internal class PersonService:IPersonService
    {
        public List<Person> CheckSalary(Predicate<Person> predicate)
        {
            List<Person> checksalary = new List<Person>();
            foreach (var item in AppDbContext.persons)
            {
                if (predicate(item))
                {
                    checksalary.Add(item);
                }
            }
            return checksalary;
        }

        public List<Person> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
