
using SW.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SW.DBServices.Interfaces
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
        /// Get Person by the Id
        /// </summary>
        /// <param name="id">The Id of the user in the database</param>
        /// <returns></returns>
        Task<Person> GetPersonById(string id);

        /// <summary>
        /// Get Person by the Id
        /// </summary>
        /// <param name="id">The Id of the user in the database</param>
        /// <returns></returns>
        Task<List<Person>> FilterPeopleByFullName(string fullName);

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

