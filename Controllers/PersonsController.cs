using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using my_vue_starter.Interfaces;
using my_vue_starter.Models;

namespace my_vue_starter.Controllers
{

     [Route("api/[controller]")]
    public class PersonsController : Controller
    {
        private readonly IPersons _persons;

        public PersonsController(IPersons persons)
        {
            this._persons = persons;
        }
        public async Task<IEnumerable<Persons>> GetPerson(int Id)
        {
            return await this._persons.GetPersons(Id);


        }
    }
}
