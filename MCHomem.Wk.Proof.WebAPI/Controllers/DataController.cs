using MCHomem.Wk.Proof.WebAPI.Models;
using MCHomem.Wk.Proof.WebAPI.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MCHomem.Wk.Proof.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        [HttpGet]
        [Route("/api/[controller]/v1/diff")]
        public String GetDiff()
        {
            return new DataRepository().ReadAndCompare();
        }

        [HttpPost]
        [Route("/api/[controller]/v1/diff/left")]
        public void PostLeft([FromBody] Data data)
        {
            new DataRepository().Write(data, Source.Left);
        }

        [HttpPost]
        [Route("/api/[controller]/v1/diff/right")]
        public void PostRight([FromBody] Data data)
        {
            new DataRepository().Write(data, Source.Right);
        }
    }
}
