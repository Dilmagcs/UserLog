using UserLog.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;
 
using UserLog.Datos;

namespace UserLog.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {

        public Collection<Users> users;
        UserSql userSql= new UserSql();
        private readonly ILogger<UsersController> _logger;

        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }

        Users user = new Users();
        Collection<Users> UsersRegs = new Collection<Users>();


        [HttpGet(Name = "UsersController")]
        public IEnumerable<Users> Geat()
        {
            return Enumerable.Range(1, 5).Select(index => new Users
            {
                /*Id = UsersRegs[index].Id,
                Name = UsersRegs[index].Name,
                Contrasenia = UsersRegs[index].Contrasenia,*/
                Id = 40,
                Name = "Fd",
                Contrasenia = "Fd",
            })
            .ToArray();
        }
 

        [HttpPost(Name = "UsersGetIdController")]
        public IEnumerable<Users> GetU([FromBody] Users user)
        {
            Users users = userSql.ConsultarId(user.Id);
            return Enumerable.Range(0, 1).Select(index => new Users
            {         
                Id = users.Id,
                Name = users.Name,
                Contrasenia = users.Contrasenia

            })
           .ToArray();
        }
    }
}
