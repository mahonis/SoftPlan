using SoftPlan.Application.Interface;
using SoftPlan.Core.Interface.Repository;
using System;
using System.Threading.Tasks;

namespace SoftPlan.Application.Business
{
    public class JuroBusiness : IJuroBusiness
    {
        private readonly IJuroRepository _juroRepository;

        public JuroBusiness(IJuroRepository juroRepository)
        {
            _juroRepository = juroRepository;
        }

        public async Task<float> ObterJuro()
        {
            var result = await _juroRepository.ObterJuro();
            return result;
        }

        public async Task<float> CalularJuro(float vlr, int tempo)
        {
            var tax = _juroRepository.ObterJuro().Result;
            var result = Math.Pow((double)(vlr * (1 + tax)), tempo);

            return (float)Math.Truncate(100 * result) / 100;
        }

        public async Task<string> ObterUrl()
        {
            var result = await _juroRepository.ObterUrl();
            return result;
        }
    }
}
