using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example.API.Services;
using ExampleApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Example.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : Controller<Role>
    {
        public RolesController(IService<Role> service) : base(service)
        {
        }
    }
}
