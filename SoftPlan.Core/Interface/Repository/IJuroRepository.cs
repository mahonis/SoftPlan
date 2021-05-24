using System.Threading.Tasks;

namespace SoftPlan.Core.Interface.Repository
{
    public interface IJuroRepository
    {
        Task<float> ObterJuro();
        Task<string> ObterUrl();
    }
}
