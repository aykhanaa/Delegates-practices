using Delegate_homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_homework.Data
{
    internal class AppDbContext
    {
        public static List<Person> persons;
        public static List<Book> books;

        static AppDbContext()
        {
            persons = new List<Person>
            {
                new Person
                {
                    Id = 1,
                    Name = "Fexriyye",
                    Surname = "Tagizade",
                    Adress = "28 may",
                    Salary = 1111,
                },
                new Person
                {
                   Id = 2,
                    Name = "Esgerxan",
                    Surname = "Bayramov",
                    Adress = "28 may",
                    Salary = 500,
                },
                new Person
                {
                    Id = 1,
                    Name = "Ayxan",
                    Surname = "Agayev",
                    Adress = "Bineqedi",
                    Salary = 345,
                },
                new Person
                {
                    Id = 1,
                    Name = "Behruz",
                    Surname = "Eliyev",
                    Adress = "Kurdexani",
                    Salary = 2500,
                },
            };

            books = new List<Book>
            {
                new Book
                {
                    Id = 1,
                    Name = "Leyli ve Mecnun",
                    Author = "Nizami",
                },

                 new Book
                 {
                     Id = 2,
                     Name = "Kimyagər",
                     Author = "Coelho",
                 },

                  new Book
                  {
                      Id =3,
                      Name = "Sirler xezinesi",
                      Author = "Nizami",
                  },

                   new Book
                   {
                       Id = 4,
                       Name = "Hərb və sülh",
                       Author = "Tolstoy",
                   },

            };

        }
    }
}
