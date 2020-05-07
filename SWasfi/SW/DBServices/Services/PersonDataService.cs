
using Microsoft.EntityFrameworkCore;
using SW.Areas.Identity.Data;
using SW.Data;
using SW.DBServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SW.DBServices.Services
{
    public class PersonDataService : IPersonDataService
    {
        private readonly SWContext SWContext;

        public PersonDataService(SWContext swContext)
        {
            this.SWContext = swContext;
        }



        public async Task<Person> GetPerson(string userName)
        {
            return await SWContext.Users.FirstOrDefaultAsync(x => x.UserName == userName);
        }

        public async Task<Person> GetPersonById(string Id)
        {
            return await SWContext.Users.FirstOrDefaultAsync(x => x.Id == Id);
        }

        public void UpdatePerson(Person person)
        {
            SWContext.Users.Update(person);
            SWContext.SaveChanges();
        }

        public async Task<List<Person>> GetPeople()
        {
            return await SWContext.Users.ToListAsync();
        }


    }
}

