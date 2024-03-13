using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_homework.Models
{
    internal class Person:BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Adress { get; set; }
        public int Salary {  get; set; }


    }
}
