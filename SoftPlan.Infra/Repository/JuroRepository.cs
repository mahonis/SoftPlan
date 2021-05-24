using SoftPlan.Core.Interface.Repository;
using System.Threading.Tasks;

namespace SoftPlan.Infra.Repository
{
    public class JuroRepository : IJuroRepository
    {
        public Task<float> ObterJuro()
        {
            var vlrTaxa = (float)0.01;
            return Task.FromResult(vlrTaxa);
        }

        public Task<string> ObterUrl()
        {
            var url = @"https://github.com/mahonis/SoftPlan";
            return Task.FromResult(url);
        }
    }
}
