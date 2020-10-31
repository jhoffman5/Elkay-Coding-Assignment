using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Elkay_Coding_Assignment.Data;
using Elkay_Coding_Assignment.Models;

namespace Elkay_Coding_Assignment.Data
{
    public static class DBInitializer
    {
        public static void Initialize(PeopleContext context)
        {
            context.Database.EnsureCreated();
            if(context.People.Any())
            {
                return;
            }

            var people = new Person[]
            {
                new Person{FirstName="Joshua", LastName="Hoffman", Address1="1327 Eastwood Drive", City="Aurora", State="Illinois", Country="USA", Phone="331-643-7234"}
            };

            context.People.AddRange(people);
            context.SaveChanges();
        }
    }
}
