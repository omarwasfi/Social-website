using SW.UI.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SW.UI.Data.Interfaces
{
    public interface IPersonDataService
    {

        /// <summary>
        /// Get Person by the userName
        /// </summary>
        /// <param name="userName">User name is same as email here</param>
        /// <returns></returns>
        Task<Person> GetPerson(string userName);

        /// <summary>
        /// Update Person Data
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        void UpdatePerson(Person person);

        /// <summary>
        /// Get all people From the database
        /// </summary>
        /// <returns></returns>
        Task<List<Person>> GetPeople();
    }
}
