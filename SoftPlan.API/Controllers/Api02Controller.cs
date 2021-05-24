using Microsoft.AspNetCore.Mvc;
using SoftPlan.Application.Interface;
using System;
using System.Threading.Tasks;

namespace SoftPlan.API.Controllers
{
    public class Api02Controller : ControllerBase
    {
        private readonly IJuroBusiness _juroBusiness;

        public Api02Controller(IJuroBusiness juroBusiness)
        {
            _juroBusiness = juroBusiness;
        }

        [Route("api/calculojuros")]
        [HttpGet]
        public async Task<IActionResult> GetCalcularJuro(float vlrInicial, int tempo)
        {
            try
            {
                var result = await _juroBusiness.CalularJuro(vlrInicial, tempo);
                return Ok(Math.Round(result,2));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        [Route("api/showmethecode")]
        public async Task<IActionResult> MostraUrl()
        {
            try
            {
                var result = await _juroBusiness.ObterUrl();
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
