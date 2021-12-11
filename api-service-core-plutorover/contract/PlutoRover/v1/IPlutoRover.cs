using Api.Contracts.Core.PlutoRover.Common;
using System.Threading.Tasks;

namespace Api.Contracts.Core.PlutoRover.PlutoRover.v1
{
    public interface IPlutoRover
    {
        Task<ItemResult<string>> GetAsync(int roverId);
        Task<ItemResult<string>> ExecuteComandsAsync(int roverId, PlutoRoverRequest request);
    }
}
