using CMDb_Grupp13.Models;
using System.Threading.Tasks;

namespace CMDb_Grupp13.Infrastructure
{
    public interface IApiClient
    {
        Task<SearchDto> GetAsync<SearchDtoT>(string endpoint);

    }
}
