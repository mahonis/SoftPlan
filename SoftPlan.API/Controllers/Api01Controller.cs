using Microsoft.AspNetCore.Mvc;
using SoftPlan.Application.Interface;
using System;
using System.Threading.Tasks;

namespace SoftPlan.API.Controllers
{
    public class Api01Controller : ControllerBase
    {
        private readonly IJuroBusiness _juroBusiness;
        public Api01Controller(IJuroBusiness juroBusiness)
        {
            _juroBusiness = juroBusiness;
        }

        [Route("api/taxaJuros")]
        [HttpGet]
        public async Task<IActionResult> ObterTaxa()
        {
            try
            {
                var juro = await _juroBusiness.ObterJuro();
                var result = juro.ToString().Replace('.', ',');
                return Ok(result);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
