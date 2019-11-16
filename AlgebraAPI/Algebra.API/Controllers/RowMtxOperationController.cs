using Algebra.Application.DTOs;
using Algebra.Application.Matrixes;
using Microsoft.AspNetCore.Mvc;

namespace Algebra.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RowMtxOperationController : ControllerBase
    {
        private readonly IMtxRowOperationServices mtxRowOperationServices;

        public RowMtxOperationController(IMtxRowOperationServices mtxRowOperationServices)
        {
            this.mtxRowOperationServices = mtxRowOperationServices;
        }
        [HttpGet]
        public MatrixRowOperation Get()
        {
            return mtxRowOperationServices.OperateRows();
        }
    }
}