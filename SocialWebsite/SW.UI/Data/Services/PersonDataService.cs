using Microsoft.EntityFrameworkCore;
using SW.UI.Areas.Identity.Data;
using SW.UI.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SW.UI.Data.Services
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
