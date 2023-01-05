using UserLog.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;
using UserLog.Models;
using System.Xml.Linq;

namespace UserLog.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        

        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        Products products = new Products();
        Collection<Products> productsRegs = new Collection<Products>();


        [HttpGet(Name = "ProductsController")]
        public IEnumerable<Products> Get()
        {
            return Enumerable.Range(1, 5000).Select(index => new Products
            {
                /*Id = UsersRegs[index].Id,
                Name = UsersRegs[index].Name,
                Contrasenia = UsersRegs[index].Contrasenia,*/
                Id = 20,
                Name = "Fd",
                Price = "Fd",
                Category = "Fd",
            })
            .ToArray();
        }

  
        [HttpPost(Name = "PostController")]
        public IEnumerable<Products> Post([FromBody] Products product)
        {
            return Enumerable.Range(0, 1).Select(index => new Products
            {
                /*Id = UsersRegs[index].Id,
                Name = UsersRegs[index].Name,
                Contrasenia = UsersRegs[index].Contrasenia,*/
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Category = product.Category,
            })
            .ToArray();
        }

        [HttpDelete(Name = "DeleteController")]
        public IEnumerable<Products> Delete([FromBody] Products product)
        {
            return Enumerable.Range(0, 1).Select(index => new Products
            {
                /*Id = UsersRegs[index].Id,
                Name = UsersRegs[index].Name,
                Contrasenia = UsersRegs[index].Contrasenia,*/
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Category = "DELETE"+product.Category,
            })
            .ToArray();
        }

        [HttpPut(Name = "PutController")]
        public IEnumerable<Products> Put([FromBody] Products product)
        {
            return Enumerable.Range(0, 1).Select(index => new Products
            {
                /*Id = UsersRegs[index].Id,
                Name = UsersRegs[index].Name,
                Contrasenia = UsersRegs[index].Contrasenia,*/
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Category = "Put" + product.Category,
            })
            .ToArray();
        }

    }
}
