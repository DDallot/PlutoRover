using System.Threading.Tasks;

namespace Api.Services.Core.PlutoRover.Dal.PlutoRover
{
    public class PlutoRoverDal : IPlutoRoverDal
    {
        public Task<Rover> GetRoverAsync(int roverId)
        {
            // Fake Data
            return Task.FromResult(new Rover()
            {
                Id = 23,
                X = 0,
                Y = 0,
                Heading = 0
            });
        }
    }
}
