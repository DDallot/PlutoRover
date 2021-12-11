using System.Threading.Tasks;

namespace Api.Services.Core.PlutoRover.Dal.PlutoRover
{
    public interface IPlutoRoverDal
    {
        Task<Rover> GetRoverAsync(int roverId);
    }
}
