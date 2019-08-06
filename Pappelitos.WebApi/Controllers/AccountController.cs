using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pappelitos.Domain;

namespace Pappelitos.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IAccountLogic accountLogic;

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return accountLogic.GetAllAccount();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return accountLogic.GetById(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Account toAdd)
        {
            accountLogic.AddAccount(toAdd);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put([FromBody] Account toUpdate)
        {
            accountLogic.UpdateAccount(toUpdate);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            accountLogic.DeleteAccount(id);
        }
    }
}
