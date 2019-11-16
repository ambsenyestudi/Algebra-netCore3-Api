using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Algebra.Application.Descriptors;
using Algebra.Application.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Algebra.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIDescriptorController : ControllerBase
    {
        private readonly IDescriptorsService descriptorsService;

        public APIDescriptorController(IDescriptorsService descriptorsService)
        {
            this.descriptorsService = descriptorsService;
        }
        [HttpGet]
        public ApiDescriptorDTO GetDescription()
        {
            return descriptorsService.GetDescriptor();
        }
    }
}