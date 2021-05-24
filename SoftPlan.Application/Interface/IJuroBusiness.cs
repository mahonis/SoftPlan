using System.Threading.Tasks;

namespace SoftPlan.Application.Interface
{
    public interface IJuroBusiness
    {
        Task<float> ObterJuro();
        Task<float> CalularJuro(float vlr, int tempo);
        Task<string> ObterUrl();
    }
}
